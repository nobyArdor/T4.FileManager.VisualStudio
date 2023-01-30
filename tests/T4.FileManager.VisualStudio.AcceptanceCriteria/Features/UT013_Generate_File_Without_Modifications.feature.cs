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
namespace T4.FileManager.VisualStudio.AcceptanceCriteria.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("UT013 Generate File without modifications")]
    [NUnit.Framework.CategoryAttribute("db-127")]
    public partial class UT013GenerateFileWithoutModificationsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = new string[] {
                "db-127"};
        
#line 1 "UT013_Generate_File_Without_Modifications.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "UT013 Generate File without modifications", "\tAs a developer\r\n\tI can generate code with the T4.FileManager and supress changes" +
                    " if the file exist", ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
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
 testRunner.And("the script \"TestNoDelete.tt\" with the following content", @"<#@ template debug=""false"" hostspecific=""true"" language=""C#"" #>
<#@ assembly name=""System.Core"" #>
<#@ import namespace=""System.Linq"" #>
<#@ import namespace=""System.Text"" #>
<#@ import namespace=""System.Collections.Generic"" #>
<#@ output extension="".txt"" #>

<#@ include file=""$(ProjectDir)\T4.FileManager.VisualStudio.ttinclude"" #>

<#
var fileManager = T4FileManager.Create(this).DisableOverwriteExistingFile();

fileManager.CreateNewFile(""TestNoDelete.g.cs"","""",""TestOverwrite"");	
#>
namespace Test
{
public class TestNoDelete
{
// first run template
}
}
<#
fileManager.Generate();
#>", ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("No files deleted if CanOverwriteExistingFile is set to false")]
        public void NoFilesDeletedIfCanOverwriteExistingFileIsSetToFalse()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("No files deleted if CanOverwriteExistingFile is set to false", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 36
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
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
                TechTalk.SpecFlow.Table table21 = new TechTalk.SpecFlow.Table(new string[] {
                            "File",
                            "Folder"});
                table21.AddRow(new string[] {
                            "TestNoDelete.g.cs",
                            "TestOverwrite"});
#line 38
 testRunner.And("the following files are generated:", ((string)(null)), table21, "And ");
#line hidden
                TechTalk.SpecFlow.Table table22 = new TechTalk.SpecFlow.Table(new string[] {
                            "From",
                            "To"});
                table22.AddRow(new string[] {
                            "fileManager.CreateNewFile(\"TestNoDelete.g.cs\",\"\",\"TestOverwrite\");",
                            "fileManager.CreateNewFile(\"TestNoDelete2.g.cs\",\"\",\"TestOverwrite\");"});
                table22.AddRow(new string[] {
                            "public class TestNoDelete",
                            "public class TestNoDelete2"});
#line 41
 testRunner.And("I change the line", ((string)(null)), table22, "And ");
#line hidden
#line 45
 testRunner.When("I run the script", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table23 = new TechTalk.SpecFlow.Table(new string[] {
                            "File",
                            "Folder"});
                table23.AddRow(new string[] {
                            "TestNoDelete.g.cs",
                            "TestOverwrite"});
                table23.AddRow(new string[] {
                            "TestNoDelete2.g.cs",
                            "TestOverwrite"});
#line 46
 testRunner.Then("the following files are generated:", ((string)(null)), table23, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("No content changes if CanOverwriteExistingFile is set to false")]
        public void NoContentChangesIfCanOverwriteExistingFileIsSetToFalse()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("No content changes if CanOverwriteExistingFile is set to false", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 51
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 6
this.FeatureBackground();
#line hidden
#line 52
 testRunner.Given("I run the script", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table24 = new TechTalk.SpecFlow.Table(new string[] {
                            "File",
                            "Folder"});
                table24.AddRow(new string[] {
                            "TestNoDelete.g.cs",
                            "TestOverwrite"});
#line 53
 testRunner.And("the following files are generated:", ((string)(null)), table24, "And ");
#line hidden
                TechTalk.SpecFlow.Table table25 = new TechTalk.SpecFlow.Table(new string[] {
                            "From",
                            "To"});
                table25.AddRow(new string[] {
                            "// first run template",
                            "// second run template"});
#line 56
 testRunner.And("I change the line", ((string)(null)), table25, "And ");
#line hidden
#line 59
 testRunner.When("I run the script", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table26 = new TechTalk.SpecFlow.Table(new string[] {
                            "File",
                            "Contains",
                            "Folder"});
                table26.AddRow(new string[] {
                            "TestNoDelete.g.cs",
                            "// first run template",
                            "TestOverwrite"});
#line 60
 testRunner.Then("the following files are generated:", ((string)(null)), table26, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
