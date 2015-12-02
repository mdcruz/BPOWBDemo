﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace BPOWBAutomation.Features.OWB
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("CreateMarineParcel", Description="In order to work with parcels\r\nAs a OWB user\r\nI want to be able to create a parce" +
        "l successfully", SourceFile="Features\\OWB\\CreateMarineParcel.feature", SourceLine=0)]
    public partial class CreateMarineParcelFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "CreateMarineParcel.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "CreateMarineParcel", "In order to work with parcels\r\nAs a OWB user\r\nI want to be able to create a parce" +
                    "l successfully", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
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
#line 6
 #line 7
  testRunner.Given("I am logged in to OWB application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
  testRunner.And("I am on the Shipments tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
        }
        
        public virtual void AbilityToCreateAPlannedParcel(string parcelType, string quantity, string transportType, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "OWB"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Ability to create a planned parcel", @__tags);
#line 11
 this.ScenarioSetup(scenarioInfo);
#line 6
 this.FeatureBackground();
#line 12
  testRunner.Given(string.Format("I create New Planned Parcel with {0}", transportType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 13
        testRunner.And(string.Format("I fill in mandatory fields to create planned {0} with {1}", parcelType, quantity), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
  testRunner.When("I create the parcel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 15
  testRunner.Then("the parcel should be created successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Ability to create a planned parcel, Variant 0", new string[] {
                "OWB"}, SourceLine=18)]
        public virtual void AbilityToCreateAPlannedParcel_Variant0()
        {
            this.AbilityToCreateAPlannedParcel("PURCHASE", "100 BBL", "VESSEL", ((string[])(null)));
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Ability to create a planned parcel, Variant 1", new string[] {
                "OWB"}, SourceLine=19)]
        public virtual void AbilityToCreateAPlannedParcel_Variant1()
        {
            this.AbilityToCreateAPlannedParcel("SALE", "100 BBL", "BARGE", ((string[])(null)));
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Ability to create a planned parcel, Variant 2", new string[] {
                "OWB"}, SourceLine=20)]
        public virtual void AbilityToCreateAPlannedParcel_Variant2()
        {
            this.AbilityToCreateAPlannedParcel("SALE", "99.5 BBL", "TANK", ((string[])(null)));
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Ability to create a planned parcel, Variant 3", new string[] {
                "OWB"}, SourceLine=21)]
        public virtual void AbilityToCreateAPlannedParcel_Variant3()
        {
            this.AbilityToCreateAPlannedParcel("SALE", "0.5 BBL", "TRAIN", ((string[])(null)));
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Ability to create a planned parcel, Variant 4", new string[] {
                "OWB"}, SourceLine=22)]
        public virtual void AbilityToCreateAPlannedParcel_Variant4()
        {
            this.AbilityToCreateAPlannedParcel("STK FROM", "100 BBL", "PUMPOVER", ((string[])(null)));
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Ability to create a planned parcel, Variant 5", new string[] {
                "OWB"}, SourceLine=23)]
        public virtual void AbilityToCreateAPlannedParcel_Variant5()
        {
            this.AbilityToCreateAPlannedParcel("STK TO", "100 BBL", "VESSEL", ((string[])(null)));
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion
