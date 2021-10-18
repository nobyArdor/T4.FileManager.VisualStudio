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
    [TechTalk.SpecRun.FeatureAttribute("UT013 Generate File with overwrite", new string[] {
            "db-127"}, Description="\tAs a developer\r\n\tI can change the behaviour of supress changes to overwrite exis" +
        "ting files", SourceFile="Features\\UT013_Generate_File_With_Overwrite.feature", SourceLine=1)]
    public partial class UT013GenerateFileWithOverwriteFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = new string[] {
                "db-127"};
        
#line 1 "UT013_Generate_File_With_Overwrite.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "UT013 Generate File with overwrite", "\tAs a developer\r\n\tI can change the behaviour of supress changes to overwrite exis" +
                    "ting files", ProgrammingLanguage.CSharp, new string[] {
                        "db-127"});
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
        
        public virtual void FeatureBackground()
        {
#line 6
#line hidden
#line 7
 testRunner.Given("the file manager", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 8
 testRunner.And("the script \"TestDelete.tt\" with the following content", @"<#@ template debug=""false"" hostspecific=""true"" language=""C#"" #>
<#@ assembly name=""System.Core"" #>
<#@ import namespace=""System.Linq"" #>
<#@ import namespace=""System.Text"" #>
<#@ import namespace=""System.Collections.Generic"" #>
<#@ output extension="".txt"" #>

<#@ include file=""$(TargetDir)\T4.FileManager.VisualStudio.ttinclude"" #>

<#
var fileManager = T4FileManager.Create(this).DisableOverwriteExistingFile();

fileManager.StartNewFile(""TestDelete.g.cs"","""",""TestOverwrite"");	
#>
namespace Test
{
public class TestDelete
{
// first run template
}
}
<#
fileManager.Process();
#>", ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Generate files with CanOverwriteExistingFile is set to true, files deleted", SourceLine=35)]
        public virtual void GenerateFilesWithCanOverwriteExistingFileIsSetToTrueFilesDeleted()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Generate files with CanOverwriteExistingFile is set to true, files deleted", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 36
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
#line 6
this.FeatureBackground();
#line hidden
#line 37
 testRunner.Given("I run the script", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table20 = new TechTalk.SpecFlow.Table(new string[] {
                            "File",
                            "Folder"});
                table20.AddRow(new string[] {
                            "TestDelete.g.cs",
                            "TestOverwrite"});
#line 38
 testRunner.And("the following files are generated:", ((string)(null)), table20, "And ");
#line hidden
                TechTalk.SpecFlow.Table table21 = new TechTalk.SpecFlow.Table(new string[] {
                            "From",
                            "To"});
                table21.AddRow(new string[] {
                            "T4FileManager.Create(this).DisableOverwriteExistingFile();",
                            "T4FileManager.Create(this);"});
                table21.AddRow(new string[] {
                            "fileManager.StartNewFile(\"TestDelete.g.cs\",\"\",\"TestOverwrite\");",
                            "fileManager.StartNewFile(\"TestNoDelete3.g.cs\",\"\",\"TestOverwrite\");"});
                table21.AddRow(new string[] {
                            "public class TestDelete",
                            "public class NewTestDeleteModel"});
#line 41
 testRunner.And("I change the line", ((string)(null)), table21, "And ");
#line hidden
#line 46
 testRunner.When("I run the script", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table22 = new TechTalk.SpecFlow.Table(new string[] {
                            "File",
                            "Folder"});
                table22.AddRow(new string[] {
                            "TestNoDelete3.g.cs",
                            "TestOverwrite"});
#line 47
 testRunner.Then("the following files are generated:", ((string)(null)), table22, "Then ");
#line hidden
                TechTalk.SpecFlow.Table table23 = new TechTalk.SpecFlow.Table(new string[] {
                            "File",
                            "Folder"});
                table23.AddRow(new string[] {
                            "TestDelete.g.cs",
                            "TestOverwrite"});
#line 50
 testRunner.And("the following files are cleaned up:", ((string)(null)), table23, "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
