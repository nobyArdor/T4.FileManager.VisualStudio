﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace T4.FileManager.NetCore.AcceptanceCriteria.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("UT003 Generate File in other project", new string[] {
            "db-8"}, Description="\tAs a developer\r\n\tI can generate code with the T4.FileManager with each class in " +
        "its own file or in different projects", SourceFile="Features\\UT003-Generate_File_In_Other_Project.feature", SourceLine=1)]
    public partial class UT003GenerateFileInOtherProjectFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = new string[] {
                "db-8"};
        
#line 1 "UT003-Generate_File_In_Other_Project.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "UT003 Generate File in other project", "\tAs a developer\r\n\tI can generate code with the T4.FileManager with each class in " +
                    "its own file or in different projects", ProgrammingLanguage.CSharp, new string[] {
                        "db-8"});
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
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Generate files in other .NET project", SourceLine=5)]
        public virtual void GenerateFilesInOther_NETProject()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Generate files in other .NET project", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 6
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 7
 testRunner.Given("the file manager", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 8
 testRunner.And("the script \"TestInOtherProject.tt\" with the following content", @"<#@ template debug=""false"" hostspecific=""true"" language=""C#"" #>
<#@ assembly name=""System.Core"" #>
<#@ import namespace=""System.Linq"" #>
<#@ import namespace=""System.Text"" #>
<#@ import namespace=""System.Collections.Generic"" #>
<#@ output extension="".txt"" #>

<#@ include file=""$(TargetDir)\T4.FileManager.VisualStudio.ttinclude"" #>

<#
var files = new string[] { ""PersonDto"", ""OrderDto"" };
var fileManager = new T4FileManager(this);

foreach(var itm in files)
{
fileManager.StartNewFile(itm + "".g.cs"",""T4.FileManager.NetCore.AcceptanceCriteria.ExampleTestProject"","""");
#>
namespace Test
{
public class <#= itm #>
{
}
}
<#
}

fileManager.Process();
#>", ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 39
 testRunner.And("I select the target project \"T4.FileManager.NetCore.AcceptanceCriteria.ExampleTes" +
                        "tProject\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 40
 testRunner.When("I run the script", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                            "File"});
                table7.AddRow(new string[] {
                            "PersonDto.g.cs"});
                table7.AddRow(new string[] {
                            "OrderDto.g.cs"});
#line 41
 testRunner.Then("the following files are generated:", ((string)(null)), table7, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
