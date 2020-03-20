﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Autofac.Extras.Moq;
using AutoMapper;
using FluentAssertions;
using Moq;
using NUnit.Framework;
using SFA.DAS.Payments.Application.Infrastructure.Logging;
using SFA.DAS.Payments.Model.Core;
using SFA.DAS.Payments.Model.Core.Entities;
using SFA.DAS.Payments.ProviderPayments.Application.Mapping;
using SFA.DAS.Payments.ProviderPayments.Application.Repositories;
using SFA.DAS.Payments.ProviderPayments.Application.Services;
using SFA.DAS.Payments.ProviderPayments.Messages.Internal.Commands;

namespace SFA.DAS.Payments.ProviderPayments.Application.UnitTests.Services
{
    [TestFixture]
    public class CompletionPaymentServiceTests
    {
        private AutoMock mocker;

        private Mock<IProviderPaymentsRepository> providerPaymentsRepository;

        private CompletionPaymentService completionPaymentService;

        private const long Ukprn = 10000;
        private const decimal Amount = 2000.00m;

        [SetUp]
        public void SetUp()
        {
            mocker = AutoMock.GetLoose();

            var payments = new List<PaymentModel>
            {
                new PaymentModel
                {
                    Ukprn = Ukprn,
                    FundingSource = FundingSourceType.CoInvestedEmployer,
                    SfaContributionPercentage = 0.9m,
                    JobId = 1,
                    DeliveryPeriod = 7,
                    CollectionPeriod = new CollectionPeriod
                    {
                        AcademicYear = 1819,
                        Period = 8
                    },
                    IlrSubmissionDateTime = DateTime.UtcNow,
                    ContractType = ContractType.Act1,
                    PriceEpisodeIdentifier = "P-1",
                    LearnerReferenceNumber = "100500",
                    EventId = Guid.NewGuid(),
                    LearningAimFundingLineType = "16-18",
                    LearningAimPathwayCode = 1,
                    LearningAimReference = "1",
                    LearningAimFrameworkCode = 1,
                    TransactionType = TransactionType.Learning,
                    LearnerUln = 1000,
                    LearningAimProgrammeType = 1,
                    LearningAimStandardCode = 1,
                    Amount = Amount
                }
            };

            providerPaymentsRepository = mocker.Mock<IProviderPaymentsRepository>();

            providerPaymentsRepository
                .Setup(o => o.GetMonthEndAct1CompletionPayments(It.IsAny<CollectionPeriod>(),
                                                                It.IsAny<CancellationToken>()))
                .ReturnsAsync(payments)
                .Verifiable();

            var config = new MapperConfiguration(c => c.AddProfile(typeof(ProviderPaymentsProfile)));

            var mapper = new Mapper(config);

            var logger = mocker.Mock<IPaymentLogger>();

            completionPaymentService = new CompletionPaymentService(logger.Object, mapper, providerPaymentsRepository.Object);
        }

        [Test]
        public async Task ShouldCallRepoAndMapper()
        {
            var command = new ProcessMonthEndAct1CompletionPaymentCommand
            {
                CollectionPeriod = new CollectionPeriod
                {
                    Period = 1, AcademicYear = 1920
                }
            };

            var act1CompletionPaymentEvents = await completionPaymentService.GetAct1CompletionPaymentEvents(command);

            act1CompletionPaymentEvents.Count.Should().Be(1);
            act1CompletionPaymentEvents.First().Ukprn.Should().Be(Ukprn);
            act1CompletionPaymentEvents.First().AmountDue.Should().Be(Amount);

            providerPaymentsRepository.Verify(o =>
                                                  o.GetMonthEndAct1CompletionPayments(It.IsAny<CollectionPeriod>(), CancellationToken.None),
                                              Times.Once);
        }
    }
}