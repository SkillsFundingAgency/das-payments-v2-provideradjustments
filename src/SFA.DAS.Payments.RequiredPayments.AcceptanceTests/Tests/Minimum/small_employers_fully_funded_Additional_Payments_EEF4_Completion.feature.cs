﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.3.2.0
//      SpecFlow Generator Version:2.3.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SFA.DAS.Payments.RequiredPayments.AcceptanceTests.Tests.Minimum
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.3.2.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Small Employers fully funded additional payments EEF4 completion")]
    public partial class SmallEmployersFullyFundedAdditionalPaymentsEEF4CompletionFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "small_employers_fully_funded_Additional_Payments_EEF4_Completion.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Small Employers fully funded additional payments EEF4 completion", "\t\t AC3- 1 learner aged 19-24, non-DAS, is a care leaver, In paid employment with " +
                    "a small employer at start, is fully funded for on programme and completion payme" +
                    "nts", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 9
#line 11
 testRunner.Given("the current processing period is 12", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "LearnRefNumber",
                        "Ukprn",
                        "ULN"});
            table1.AddRow(new string[] {
                        "learnref10",
                        "10000",
                        "10000"});
#line 13
 testRunner.And("the following learners:", ((string)(null)), table1, "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "AimSeqNumber",
                        "ProgrammeType",
                        "FrameworkCode",
                        "PathwayCode",
                        "StandardCode",
                        "FundingLineType",
                        "LearnAimRef",
                        "LearningStartDate",
                        "LearningPlannedEndDate",
                        "LearningActualEndDate",
                        "CompletionStatus"});
            table2.AddRow(new string[] {
                        "1",
                        "2",
                        "403",
                        "1",
                        "",
                        "16-18 Apprenticeship (From May 2017) Non-Levy Contract (non-procured)",
                        "ZPROG001",
                        "06/08/2017",
                        "08/08/2018",
                        "08/08/2018",
                        "Completed"});
#line 17
 testRunner.And("the following course information:", ((string)(null)), table2, "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Employer",
                        "Employment Status",
                        "Employment Status Applies",
                        "Small Employer"});
            table3.AddRow(new string[] {
                        "employer_2",
                        "in paid employment",
                        "05/08/2017",
                        "SEM1"});
#line 22
 testRunner.And("the employment status in the ILR is:", ((string)(null)), table3, "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "PriceEpisodeIdentifier",
                        "EpisodeStartDate",
                        "EpisodeEffectiveTNPStartDate",
                        "TotalNegotiatedPrice",
                        "Learning_1"});
            table4.AddRow(new string[] {
                        "p1",
                        "06/08/2017",
                        "06/08/2017",
                        "7500",
                        "500"});
#line 30
 testRunner.And("the following contract type 2 on programme earnings for periods 1-11 are provided" +
                    " in the latest ILR for the academic year 1718:", ((string)(null)), table4, "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "PriceEpisodeIdentifier",
                        "EpisodeStartDate",
                        "EpisodeEffectiveTNPStartDate",
                        "TotalNegotiatedPrice",
                        "Learning_1",
                        "Completion_2"});
            table5.AddRow(new string[] {
                        "p1",
                        "06/08/2017",
                        "06/08/2017",
                        "7500",
                        "500",
                        "1500"});
#line 34
 testRunner.And("the following contract type 2 on programme earnings for period 12 are provided in" +
                    " the latest ILR for the academic year 1718:", ((string)(null)), table5, "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Contract EarningType 2 On programme payments")]
        [NUnit.Framework.CategoryAttribute("Non-DAS")]
        [NUnit.Framework.CategoryAttribute("minimum_tests")]
        [NUnit.Framework.CategoryAttribute("small_employers")]
        [NUnit.Framework.CategoryAttribute("completion")]
        [NUnit.Framework.CategoryAttribute("fully_funded")]
        [NUnit.Framework.TestCaseAttribute("Learning_1", "500", null)]
        public virtual void ContractType2OnProgrammePayments(string transaction_Type, string amount, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Non-DAS",
                    "minimum_tests",
                    "small_employers",
                    "completion",
                    "fully_funded"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Contract EarningType 2 On programme payments", @__tags);
#line 47
this.ScenarioSetup(scenarioInfo);
#line 9
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "LearnRefNumber",
                        "Ukprn",
                        "PriceEpisodeIdentifier",
                        "Period",
                        "ULN",
                        "TransactionType",
                        "Amount"});
            table6.AddRow(new string[] {
                        "learnref10",
                        "10000",
                        "p1",
                        "1",
                        "10000",
                        string.Format("{0}", transaction_Type),
                        string.Format("{0}", amount)});
            table6.AddRow(new string[] {
                        "learnref10",
                        "10000",
                        "p1",
                        "2",
                        "10000",
                        string.Format("{0}", transaction_Type),
                        string.Format("{0}", amount)});
            table6.AddRow(new string[] {
                        "learnref10",
                        "10000",
                        "p1",
                        "3",
                        "10000",
                        string.Format("{0}", transaction_Type),
                        string.Format("{0}", amount)});
            table6.AddRow(new string[] {
                        "learnref10",
                        "10000",
                        "p1",
                        "4",
                        "10000",
                        string.Format("{0}", transaction_Type),
                        string.Format("{0}", amount)});
            table6.AddRow(new string[] {
                        "learnref10",
                        "10000",
                        "p1",
                        "5",
                        "10000",
                        string.Format("{0}", transaction_Type),
                        string.Format("{0}", amount)});
            table6.AddRow(new string[] {
                        "learnref10",
                        "10000",
                        "p1",
                        "6",
                        "10000",
                        string.Format("{0}", transaction_Type),
                        string.Format("{0}", amount)});
            table6.AddRow(new string[] {
                        "learnref10",
                        "10000",
                        "p1",
                        "7",
                        "10000",
                        string.Format("{0}", transaction_Type),
                        string.Format("{0}", amount)});
            table6.AddRow(new string[] {
                        "learnref10",
                        "10000",
                        "p1",
                        "8",
                        "10000",
                        string.Format("{0}", transaction_Type),
                        string.Format("{0}", amount)});
            table6.AddRow(new string[] {
                        "learnref10",
                        "10000",
                        "p1",
                        "9",
                        "10000",
                        string.Format("{0}", transaction_Type),
                        string.Format("{0}", amount)});
            table6.AddRow(new string[] {
                        "learnref10",
                        "10000",
                        "p1",
                        "10",
                        "10000",
                        string.Format("{0}", transaction_Type),
                        string.Format("{0}", amount)});
            table6.AddRow(new string[] {
                        "learnref10",
                        "10000",
                        "p1",
                        "11",
                        "10000",
                        string.Format("{0}", transaction_Type),
                        string.Format("{0}", amount)});
#line 49
 testRunner.And("the following historical contract type 2 on programme payments exist:", ((string)(null)), table6, "And ");
#line 63
 testRunner.When("a TOBY is received", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "LearnRefNumber",
                        "Ukprn",
                        "PriceEpisodeIdentifier",
                        "Period",
                        "ULN",
                        "TransactionType",
                        "Price"});
            table7.AddRow(new string[] {
                        "learnref10",
                        "10000",
                        "p1",
                        "1",
                        "10000",
                        string.Format("{0}", transaction_Type),
                        string.Format("{0}", amount)});
            table7.AddRow(new string[] {
                        "learnref10",
                        "10000",
                        "p1",
                        "2",
                        "10000",
                        string.Format("{0}", transaction_Type),
                        string.Format("{0}", amount)});
            table7.AddRow(new string[] {
                        "learnref10",
                        "10000",
                        "p1",
                        "3",
                        "10000",
                        string.Format("{0}", transaction_Type),
                        string.Format("{0}", amount)});
            table7.AddRow(new string[] {
                        "learnref10",
                        "10000",
                        "p1",
                        "4",
                        "10000",
                        string.Format("{0}", transaction_Type),
                        string.Format("{0}", amount)});
            table7.AddRow(new string[] {
                        "learnref10",
                        "10000",
                        "p1",
                        "5",
                        "10000",
                        string.Format("{0}", transaction_Type),
                        string.Format("{0}", amount)});
            table7.AddRow(new string[] {
                        "learnref10",
                        "10000",
                        "p1",
                        "6",
                        "10000",
                        string.Format("{0}", transaction_Type),
                        string.Format("{0}", amount)});
            table7.AddRow(new string[] {
                        "learnref10",
                        "10000",
                        "p1",
                        "7",
                        "10000",
                        string.Format("{0}", transaction_Type),
                        string.Format("{0}", amount)});
            table7.AddRow(new string[] {
                        "learnref10",
                        "10000",
                        "p1",
                        "8",
                        "10000",
                        string.Format("{0}", transaction_Type),
                        string.Format("{0}", amount)});
            table7.AddRow(new string[] {
                        "learnref10",
                        "10000",
                        "p1",
                        "9",
                        "10000",
                        string.Format("{0}", transaction_Type),
                        string.Format("{0}", amount)});
            table7.AddRow(new string[] {
                        "learnref10",
                        "10000",
                        "p1",
                        "10",
                        "10000",
                        string.Format("{0}", transaction_Type),
                        string.Format("{0}", amount)});
            table7.AddRow(new string[] {
                        "learnref10",
                        "10000",
                        "p1",
                        "11",
                        "10000",
                        string.Format("{0}", transaction_Type),
                        string.Format("{0}", amount)});
            table7.AddRow(new string[] {
                        "learnref10",
                        "10000",
                        "p1",
                        "12",
                        "10000",
                        string.Format("{0}", transaction_Type),
                        string.Format("{0}", amount)});
#line 65
 testRunner.Then("the payments due component will generate the following contract type 2 payable ea" +
                    "rnings:", ((string)(null)), table7, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Contract Type 2 completion payment")]
        [NUnit.Framework.TestCaseAttribute("Completion_2", "1500", null)]
        public virtual void ContractType2CompletionPayment(string transaction_Type, string amount, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Contract Type 2 completion payment", exampleTags);
#line 84
this.ScenarioSetup(scenarioInfo);
#line 9
this.FeatureBackground();
#line 86
 testRunner.When("a TOBY is received", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "LearnRefNumber",
                        "Ukprn",
                        "PriceEpisodeIdentifier",
                        "Period",
                        "ULN",
                        "TransactionType",
                        "Price"});
            table8.AddRow(new string[] {
                        "learnref10",
                        "10000",
                        "p1",
                        "12",
                        "10000",
                        string.Format("{0}", transaction_Type),
                        string.Format("{0}", amount)});
#line 88
 testRunner.Then("the payments due component will generate the following contract type 2 payable ea" +
                    "rnings:", ((string)(null)), table8, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
