﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SFA.DAS.Payments.RequiredPayments.AcceptanceTests.Tests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("No Payment - ALL TT1 TT2 and TT3 paid already")]
    public partial class NoPayment_ALLTT1TT2AndTT3PaidAlreadyFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "No Payment - ALL TT1 TT2 and TT3 paid already.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "No Payment - ALL TT1 TT2 and TT3 paid already", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 3
#line 4
 testRunner.Given("the current processing period is 11", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 5
 testRunner.And("the payments are for the current collection year", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 6
 testRunner.And("a learner with LearnRefNumber learnref1 and Uln 10000 undertaking training with t" +
                    "raining provider 10000", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 7
 testRunner.And("the SFA contribution percentage is 90%", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "PriceEpisodeIdentifier",
                        "Delivery Period",
                        "TransactionType",
                        "Amount"});
            table1.AddRow(new string[] {
                        "p1",
                        "1",
                        "Learning (TT1)",
                        "600"});
            table1.AddRow(new string[] {
                        "p1",
                        "2",
                        "Learning (TT1)",
                        "600"});
            table1.AddRow(new string[] {
                        "p1",
                        "3",
                        "Learning (TT1)",
                        "600"});
            table1.AddRow(new string[] {
                        "p1",
                        "4",
                        "Learning (TT1)",
                        "600"});
            table1.AddRow(new string[] {
                        "p1",
                        "5",
                        "Learning (TT1)",
                        "600"});
            table1.AddRow(new string[] {
                        "p1",
                        "6",
                        "Learning (TT1)",
                        "600"});
            table1.AddRow(new string[] {
                        "p1",
                        "7",
                        "Learning (TT1)",
                        "600"});
            table1.AddRow(new string[] {
                        "p1",
                        "8",
                        "Learning (TT1)",
                        "600"});
            table1.AddRow(new string[] {
                        "p1",
                        "9",
                        "Learning (TT1)",
                        "600"});
            table1.AddRow(new string[] {
                        "p1",
                        "10",
                        "Completion (TT2)",
                        "1800"});
            table1.AddRow(new string[] {
                        "p1",
                        "10",
                        "Balancing (TT3)",
                        "1800"});
#line 8
 testRunner.And("the payments due component generates the following contract type 2 payments due:", ((string)(null)), table1, "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "PriceEpisodeIdentifier",
                        "Delivery Period",
                        "TransactionType",
                        "Amount"});
            table2.AddRow(new string[] {
                        "p1",
                        "1",
                        "Learning (TT1)",
                        "600"});
            table2.AddRow(new string[] {
                        "p1",
                        "2",
                        "Learning (TT1)",
                        "600"});
            table2.AddRow(new string[] {
                        "p1",
                        "3",
                        "Learning (TT1)",
                        "600"});
            table2.AddRow(new string[] {
                        "p1",
                        "4",
                        "Learning (TT1)",
                        "600"});
            table2.AddRow(new string[] {
                        "p1",
                        "5",
                        "Learning (TT1)",
                        "600"});
            table2.AddRow(new string[] {
                        "p1",
                        "6",
                        "Learning (TT1)",
                        "600"});
            table2.AddRow(new string[] {
                        "p1",
                        "7",
                        "Learning (TT1)",
                        "600"});
            table2.AddRow(new string[] {
                        "p1",
                        "8",
                        "Learning (TT1)",
                        "600"});
            table2.AddRow(new string[] {
                        "p1",
                        "9",
                        "Learning (TT1)",
                        "600"});
            table2.AddRow(new string[] {
                        "p1",
                        "10",
                        "Completion (TT2)",
                        "1800"});
            table2.AddRow(new string[] {
                        "p1",
                        "10",
                        "Balancing (TT3)",
                        "1800"});
#line 22
 testRunner.And("the following historical contract type 2 payments exist:", ((string)(null)), table2, "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Contract Type 2 no On Programme Learning payments")]
        [NUnit.Framework.CategoryAttribute("Non-DAS")]
        [NUnit.Framework.CategoryAttribute("NoPayment")]
        public virtual void ContractType2NoOnProgrammeLearningPayments()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Contract Type 2 no On Programme Learning payments", null, new string[] {
                        "Non-DAS",
                        "NoPayment"});
#line 39
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 40
 testRunner.When("a payments due event is received", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 41
 testRunner.Then("the required payments component will not generate any contract type 2 Learning (T" +
                    "T1) payable earnings", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Contract Type 2 no On Programme Completion payment")]
        public virtual void ContractType2NoOnProgrammeCompletionPayment()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Contract Type 2 no On Programme Completion payment", null, ((string[])(null)));
#line 43
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 44
 testRunner.When("a payments due event is received", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 45
 testRunner.Then("the required payments component will not generate any contract type 2 Completion " +
                    "(TT2) payable earnings", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Contract Type 2 no On Programme Balancing payment")]
        public virtual void ContractType2NoOnProgrammeBalancingPayment()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Contract Type 2 no On Programme Balancing payment", null, ((string[])(null)));
#line 47
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 48
 testRunner.When("a payments due event is received", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 49
 testRunner.Then("the required payments component will not generate any contract type 2 Balancing (" +
                    "TT3) payable earnings", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion