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
    [NUnit.Framework.DescriptionAttribute("Additional payments")]
    public partial class AdditionalPaymentsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "AdditionalPayments_638-AC01.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Additional payments", "\t\t638-AC01 Non-DAS learner, takes an English qualification that has a planned end" +
                    " date that exceeds the actual end date of the programme aim", ProgrammingLanguage.CSharp, ((string[])(null)));
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
#line 4
#line 7
 testRunner.Given("the current processing period is 14", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "LearnRefNumber",
                        "Ukprn",
                        "ULN"});
            table1.AddRow(new string[] {
                        "learnref7",
                        "10000",
                        "10000"});
#line 10
 testRunner.And("the following learners:", ((string)(null)), table1, "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "LearnRefNumber",
                        "Ukprn",
                        "ULN",
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
                        "learnref7",
                        "10000",
                        "10000",
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
            table2.AddRow(new string[] {
                        "learnref7",
                        "10000",
                        "10000",
                        "2",
                        "",
                        "",
                        "",
                        "471",
                        "16-18 Apprenticeship (From May 2017) Non-Levy Contract (non-procured)",
                        "ZPROG001",
                        "06/08/2017",
                        "06/10/2018",
                        "06/10/2018",
                        "Completed"});
#line 15
 testRunner.And("the following course information:", ((string)(null)), table2, "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "LearnRefNumber",
                        "Ukprn",
                        "PriceEpisodeIdentifier",
                        "EpisodeStartDate",
                        "EpisodeEffectiveTNPStartDate",
                        "TotalNegotiatedPrice"});
            table3.AddRow(new string[] {
                        "learnref7",
                        "10000",
                        "p1",
                        "06/08/2017",
                        "06/08/2017",
                        "15000"});
#line 21
 testRunner.And("the following contract type 2 on programme earnings for periods 1-12 are provided" +
                    " in the latest ILR for the academic year 1718:", ((string)(null)), table3, "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Contract Type 2 On programme payments")]
        [NUnit.Framework.CategoryAttribute("Non-DAS")]
        [NUnit.Framework.CategoryAttribute("minimum_tests")]
        [NUnit.Framework.CategoryAttribute("additional_payments")]
        [NUnit.Framework.CategoryAttribute("completion")]
        [NUnit.Framework.TestCaseAttribute("Learning_1", "1000", null)]
        public virtual void ContractType2OnProgrammePayments(string transaction_Type, string amount, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Non-DAS",
                    "minimum_tests",
                    "additional_payments",
                    "completion"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Contract Type 2 On programme payments", @__tags);
#line 41
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "LearnRefNumber",
                        "Ukprn",
                        "PriceEpisodeIdentifier",
                        "Period",
                        "ULN",
                        "TransactionType",
                        "Amount"});
            table4.AddRow(new string[] {
                        "learnref7",
                        "10000",
                        "p1",
                        "1",
                        "10000",
                        string.Format("{0}", transaction_Type),
                        string.Format("{0}", amount)});
            table4.AddRow(new string[] {
                        "learnref7",
                        "10000",
                        "p1",
                        "2",
                        "10000",
                        string.Format("{0}", transaction_Type),
                        string.Format("{0}", amount)});
            table4.AddRow(new string[] {
                        "learnref7",
                        "10000",
                        "p1",
                        "3",
                        "10000",
                        string.Format("{0}", transaction_Type),
                        string.Format("{0}", amount)});
            table4.AddRow(new string[] {
                        "learnref7",
                        "10000",
                        "p1",
                        "4",
                        "10000",
                        string.Format("{0}", transaction_Type),
                        string.Format("{0}", amount)});
            table4.AddRow(new string[] {
                        "learnref7",
                        "10000",
                        "p1",
                        "5",
                        "10000",
                        string.Format("{0}", transaction_Type),
                        string.Format("{0}", amount)});
            table4.AddRow(new string[] {
                        "learnref7",
                        "10000",
                        "p1",
                        "6",
                        "10000",
                        string.Format("{0}", transaction_Type),
                        string.Format("{0}", amount)});
            table4.AddRow(new string[] {
                        "learnref7",
                        "10000",
                        "p1",
                        "7",
                        "10000",
                        string.Format("{0}", transaction_Type),
                        string.Format("{0}", amount)});
            table4.AddRow(new string[] {
                        "learnref7",
                        "10000",
                        "p1",
                        "8",
                        "10000",
                        string.Format("{0}", transaction_Type),
                        string.Format("{0}", amount)});
            table4.AddRow(new string[] {
                        "learnref7",
                        "10000",
                        "p1",
                        "9",
                        "10000",
                        string.Format("{0}", transaction_Type),
                        string.Format("{0}", amount)});
            table4.AddRow(new string[] {
                        "learnref7",
                        "10000",
                        "p1",
                        "10",
                        "10000",
                        string.Format("{0}", transaction_Type),
                        string.Format("{0}", amount)});
            table4.AddRow(new string[] {
                        "learnref7",
                        "10000",
                        "p1",
                        "11",
                        "10000",
                        string.Format("{0}", transaction_Type),
                        string.Format("{0}", amount)});
            table4.AddRow(new string[] {
                        "learnref7",
                        "10000",
                        "p1",
                        "12",
                        "10000",
                        string.Format("{0}", transaction_Type),
                        string.Format("{0}", amount)});
#line 43
 testRunner.And("the following historical contract type 2 on programme payments exist:", ((string)(null)), table4, "And ");
#line 58
 testRunner.When("a TOBY is received", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "LearnRefNumber",
                        "Ukprn",
                        "PriceEpisodeIdentifier",
                        "Period",
                        "ULN",
                        "TransactionType",
                        "Amount"});
            table5.AddRow(new string[] {
                        "learnref7",
                        "10000",
                        "p1",
                        "1",
                        "10000",
                        string.Format("{0}", transaction_Type),
                        string.Format("{0}", amount)});
            table5.AddRow(new string[] {
                        "learnref7",
                        "10000",
                        "p1",
                        "2",
                        "10000",
                        string.Format("{0}", transaction_Type),
                        string.Format("{0}", amount)});
            table5.AddRow(new string[] {
                        "learnref7",
                        "10000",
                        "p1",
                        "3",
                        "10000",
                        string.Format("{0}", transaction_Type),
                        string.Format("{0}", amount)});
            table5.AddRow(new string[] {
                        "learnref7",
                        "10000",
                        "p1",
                        "4",
                        "10000",
                        string.Format("{0}", transaction_Type),
                        string.Format("{0}", amount)});
            table5.AddRow(new string[] {
                        "learnref7",
                        "10000",
                        "p1",
                        "5",
                        "10000",
                        string.Format("{0}", transaction_Type),
                        string.Format("{0}", amount)});
            table5.AddRow(new string[] {
                        "learnref7",
                        "10000",
                        "p1",
                        "6",
                        "10000",
                        string.Format("{0}", transaction_Type),
                        string.Format("{0}", amount)});
            table5.AddRow(new string[] {
                        "learnref7",
                        "10000",
                        "p1",
                        "7",
                        "10000",
                        string.Format("{0}", transaction_Type),
                        string.Format("{0}", amount)});
            table5.AddRow(new string[] {
                        "learnref7",
                        "10000",
                        "p1",
                        "8",
                        "10000",
                        string.Format("{0}", transaction_Type),
                        string.Format("{0}", amount)});
            table5.AddRow(new string[] {
                        "learnref7",
                        "10000",
                        "p1",
                        "9",
                        "10000",
                        string.Format("{0}", transaction_Type),
                        string.Format("{0}", amount)});
            table5.AddRow(new string[] {
                        "learnref7",
                        "10000",
                        "p1",
                        "10",
                        "10000",
                        string.Format("{0}", transaction_Type),
                        string.Format("{0}", amount)});
            table5.AddRow(new string[] {
                        "learnref7",
                        "10000",
                        "p1",
                        "11",
                        "10000",
                        string.Format("{0}", transaction_Type),
                        string.Format("{0}", amount)});
            table5.AddRow(new string[] {
                        "learnref7",
                        "10000",
                        "p1",
                        "12",
                        "10000",
                        string.Format("{0}", transaction_Type),
                        string.Format("{0}", amount)});
#line 60
 testRunner.Then("the payments due component will generate the following contract type 2 payable ea" +
                    "rnings:", ((string)(null)), table5, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Contract Type 2 completion payment")]
        [NUnit.Framework.TestCaseAttribute("Completion_2", "3000", null)]
        public virtual void ContractType2CompletionPayment(string transaction_Type, string amount, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Contract Type 2 completion payment", exampleTags);
#line 79
this.ScenarioSetup(scenarioInfo);
#line 4
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
                        "learnref7",
                        "10000",
                        "p1",
                        "12",
                        "10000",
                        string.Format("{0}", transaction_Type),
                        string.Format("{0}", amount)});
#line 81
 testRunner.And("the following historical contract type 2 completion payment exist:", ((string)(null)), table6, "And ");
#line 85
 testRunner.When("a TOBY is received", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "LearnRefNumber",
                        "Ukprn",
                        "PriceEpisodeIdentifier",
                        "Period",
                        "ULN",
                        "TransactionType",
                        "Amount"});
            table7.AddRow(new string[] {
                        "learnref7",
                        "10000",
                        "p1",
                        "12",
                        "10000",
                        string.Format("{0}", transaction_Type),
                        string.Format("{0}", amount)});
#line 87
 testRunner.Then("the payments due component will generate the following contract type 2 payable ea" +
                    "rnings:", ((string)(null)), table7, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("638-AC01 Non-DAS learner, takes an English qualification that has a planned end d" +
            "ate that exceeds the actual end date of the programme aim")]
        [NUnit.Framework.CategoryAttribute("MathsAndEnglishNonDas")]
        [NUnit.Framework.CategoryAttribute("_Minimum_Acceptance_")]
        public virtual void _638_AC01Non_DASLearnerTakesAnEnglishQualificationThatHasAPlannedEndDateThatExceedsTheActualEndDateOfTheProgrammeAim()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("638-AC01 Non-DAS learner, takes an English qualification that has a planned end d" +
                    "ate that exceeds the actual end date of the programme aim", new string[] {
                        "MathsAndEnglishNonDas",
                        "_Minimum_Acceptance_"});
#line 101
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "ULN",
                        "learner type",
                        "aim type",
                        "agreed price",
                        "aim rate",
                        "start date",
                        "planned end date",
                        "actual end date",
                        "completion status"});
            table8.AddRow(new string[] {
                        "learner a",
                        "programme only non-DAS",
                        "programme",
                        "15000",
                        "",
                        "06/08/2017",
                        "08/08/2018",
                        "08/08/2018",
                        "completed"});
            table8.AddRow(new string[] {
                        "learner a",
                        "programme only non-DAS",
                        "maths or english",
                        "",
                        "471",
                        "06/08/2017",
                        "06/10/2018",
                        "06/10/2018",
                        "completed"});
#line 103
 testRunner.When("an ILR file is submitted with the following data:", ((string)(null)), table8, "When ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Type",
                        "08/17",
                        "09/17",
                        "10/17",
                        "...",
                        "05/18",
                        "06/18",
                        "07/18",
                        "08/18",
                        "09/18",
                        "10/18",
                        "11/18"});
            table9.AddRow(new string[] {
                        "Provider Earned Total",
                        "1033.64",
                        "1033.64",
                        "1033.64",
                        "...",
                        "1033.64",
                        "1033.64",
                        "1033.64",
                        "3033.64",
                        "33.64",
                        "0",
                        "0"});
            table9.AddRow(new string[] {
                        "Provider Paid by SFA",
                        "0",
                        "933.64",
                        "933.64",
                        "...",
                        "933.64",
                        "933.64",
                        "933.64",
                        "933.64",
                        "2733.64",
                        "33.64",
                        "0"});
            table9.AddRow(new string[] {
                        "Payment due from Employer",
                        "0",
                        "100",
                        "100",
                        "...",
                        "100",
                        "100",
                        "100",
                        "100",
                        "300",
                        "0",
                        "0"});
            table9.AddRow(new string[] {
                        "Levy account debited",
                        "0",
                        "0",
                        "0",
                        "...",
                        "0",
                        "0",
                        "0",
                        "0",
                        "0",
                        "0",
                        "0"});
            table9.AddRow(new string[] {
                        "SFA Levy employer budget",
                        "0",
                        "0",
                        "0",
                        "...",
                        "0",
                        "0",
                        "0",
                        "0",
                        "0",
                        "0",
                        "0"});
            table9.AddRow(new string[] {
                        "SFA Levy co-funding budget",
                        "0",
                        "0",
                        "0",
                        "...",
                        "0",
                        "0",
                        "0",
                        "0",
                        "0",
                        "0",
                        "0"});
            table9.AddRow(new string[] {
                        "SFA non-Levy co-funding budget",
                        "900",
                        "900",
                        "900",
                        "...",
                        "900",
                        "900",
                        "900",
                        "2700",
                        "0",
                        "0",
                        "0"});
            table9.AddRow(new string[] {
                        "SFA Levy additional payments budget",
                        "0",
                        "0",
                        "0",
                        "...",
                        "0",
                        "0",
                        "0",
                        "0",
                        "0",
                        "0",
                        "0"});
            table9.AddRow(new string[] {
                        "SFA non-Levy additional payments budget",
                        "33.64",
                        "33.64",
                        "33.64",
                        "...",
                        "33.64",
                        "33.64",
                        "33.64",
                        "33.64",
                        "33.64",
                        "0",
                        "0"});
#line 107
 testRunner.Then("the provider earnings and payments break down as follows:", ((string)(null)), table9, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Payment type",
                        "09/17",
                        "10/17",
                        "...",
                        "05/18",
                        "06/18",
                        "07/18",
                        "08/18",
                        "09/18",
                        "10/18",
                        "11/18"});
            table10.AddRow(new string[] {
                        "On-program",
                        "900",
                        "900",
                        "...",
                        "900",
                        "900",
                        "900",
                        "900",
                        "0",
                        "0",
                        "0"});
            table10.AddRow(new string[] {
                        "Completion",
                        "0",
                        "0",
                        "...",
                        "0",
                        "0",
                        "0",
                        "0",
                        "2700",
                        "0",
                        "0"});
            table10.AddRow(new string[] {
                        "Balancing",
                        "0",
                        "0",
                        "...",
                        "0",
                        "0",
                        "0",
                        "0",
                        "0",
                        "0",
                        "0"});
            table10.AddRow(new string[] {
                        "English and maths on programme",
                        "33.64",
                        "33.64",
                        "...",
                        "33.64",
                        "33.64",
                        "33.64",
                        "33.64",
                        "33.64",
                        "33.64",
                        "0"});
            table10.AddRow(new string[] {
                        "English and maths Balancing",
                        "0",
                        "0",
                        "...",
                        "0",
                        "0",
                        "0",
                        "0",
                        "0",
                        "0",
                        "0"});
#line 118
    testRunner.And("the transaction types for the payments are:", ((string)(null)), table10, "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion