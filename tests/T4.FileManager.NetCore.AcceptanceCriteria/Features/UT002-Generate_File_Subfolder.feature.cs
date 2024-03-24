﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by Reqnroll (https://www.reqnroll.net/).
//      Reqnroll Version:1.0.0.0
//      Reqnroll Generator Version:1.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace T4.FileManager.NetCore.AcceptanceCriteria.Features
{
    using Reqnroll;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Reqnroll", "1.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("UT002 Generate File in subfolder")]
    [NUnit.Framework.CategoryAttribute("db-7")]
    public partial class UT002GenerateFileInSubfolderFeature
    {
        
        private Reqnroll.ITestRunner testRunner;
        
        private static string[] featureTags = new string[] {
                "db-7"};
        
#line 1 "UT002-Generate_File_Subfolder.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual async System.Threading.Tasks.Task FeatureSetupAsync()
        {
            testRunner = Reqnroll.TestRunnerManager.GetTestRunnerForAssembly(null, NUnit.Framework.TestContext.CurrentContext.WorkerId);
            Reqnroll.FeatureInfo featureInfo = new Reqnroll.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "UT002 Generate File in subfolder", "\tAs a developer\r\n\tI can generate code with the T4.FileManager with each class in " +
                    "its own file in a subfolder", ProgrammingLanguage.CSharp, featureTags);
            await testRunner.OnFeatureStartAsync(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual async System.Threading.Tasks.Task FeatureTearDownAsync()
        {
            await testRunner.OnFeatureEndAsync();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public async System.Threading.Tasks.Task TestInitializeAsync()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public async System.Threading.Tasks.Task TestTearDownAsync()
        {
            await testRunner.OnScenarioEndAsync();
        }
        
        public void ScenarioInitialize(Reqnroll.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public async System.Threading.Tasks.Task ScenarioStartAsync()
        {
            await testRunner.OnScenarioStartAsync();
        }
        
        public async System.Threading.Tasks.Task ScenarioCleanupAsync()
        {
            await testRunner.CollectScenarioErrorsAsync();
        }
        
        public virtual async System.Threading.Tasks.Task FeatureBackgroundAsync()
        {
#line 6
#line hidden
#line 7
 await testRunner.GivenAsync("the file manager", ((string)(null)), ((Reqnroll.Table)(null)), "Given ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Generate T4 files in existing subfolder")]
        public async System.Threading.Tasks.Task GenerateT4FilesInExistingSubfolder()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            Reqnroll.ScenarioInfo scenarioInfo = new Reqnroll.ScenarioInfo("Generate T4 files in existing subfolder", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 9
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 6
await this.FeatureBackgroundAsync();
#line hidden
#line 10
 await testRunner.GivenAsync("the script \"TestSubfolder.tt\" with the following content", @"<#@ template debug=""false"" hostspecific=""true"" language=""C#"" #>
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
fileManager.StartNewFile(itm + "".g.cs"","""",""TestSubfolder"");
#>
namespace Test.TestSubFolder
{
public class <#= itm #>
{
}
}
<#
}

fileManager.Process();
#>", ((Reqnroll.Table)(null)), "Given ");
#line hidden
#line 41
 await testRunner.WhenAsync("I run the script", ((string)(null)), ((Reqnroll.Table)(null)), "When ");
#line hidden
                Reqnroll.Table table5 = new Reqnroll.Table(new string[] {
                            "File",
                            "Folder"});
                table5.AddRow(new string[] {
                            "PersonDto.g.cs",
                            "TestSubfolder"});
                table5.AddRow(new string[] {
                            "OrderDto.g.cs",
                            "TestSubfolder"});
#line 42
 await testRunner.ThenAsync("the following files are generated:", ((string)(null)), table5, "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Change output folder in T4 move generated files to new location")]
        public async System.Threading.Tasks.Task ChangeOutputFolderInT4MoveGeneratedFilesToNewLocation()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            Reqnroll.ScenarioInfo scenarioInfo = new Reqnroll.ScenarioInfo("Change output folder in T4 move generated files to new location", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 47
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 6
await this.FeatureBackgroundAsync();
#line hidden
#line 48
 await testRunner.GivenAsync("the script \"TestSubfolderMoving.tt\" with the following content", @"<#@ template debug=""false"" hostspecific=""true"" language=""C#"" #>
<#@ assembly name=""System.Core"" #>
<#@ import namespace=""System.Linq"" #>
<#@ import namespace=""System.Text"" #>
<#@ import namespace=""System.Collections.Generic"" #>
<#@ output extension="".txt"" #>

<#@ include file=""$(TargetDir)\T4.FileManager.VisualStudio.ttinclude"" #>

<#
var files = new string[] { ""PersonMDto"", ""OrderMDto"" };
var fileManager = new T4FileManager(this);

foreach(var itm in files)
{
fileManager.StartNewFile(itm + "".g.cs"","""",""TestSubfolder"");
#>
namespace Test.TestSubFolder
{
public class <#= itm #>
{
}
}
<#
}

fileManager.Process();
#>", ((Reqnroll.Table)(null)), "Given ");
#line hidden
#line 79
 await testRunner.WhenAsync("I run the script", ((string)(null)), ((Reqnroll.Table)(null)), "When ");
#line hidden
                Reqnroll.Table table6 = new Reqnroll.Table(new string[] {
                            "From",
                            "To"});
                table6.AddRow(new string[] {
                            "fileManager.StartNewFile(itm + \".g.cs\",\"\",\"TestSubfolder\");",
                            "fileManager.StartNewFile(itm + \".g.cs\",\"\",\"TestSubfolderNew\");"});
#line 80
 await testRunner.AndAsync("I change the line", ((string)(null)), table6, "And ");
#line hidden
#line 83
 await testRunner.AndAsync("I run the script again", ((string)(null)), ((Reqnroll.Table)(null)), "And ");
#line hidden
                Reqnroll.Table table7 = new Reqnroll.Table(new string[] {
                            "File",
                            "Folder"});
                table7.AddRow(new string[] {
                            "PersonMDto.g.cs",
                            "TestSubfolderNew"});
                table7.AddRow(new string[] {
                            "OrderMDto.g.cs",
                            "TestSubfolderNew"});
#line 84
 await testRunner.ThenAsync("the following files are generated:", ((string)(null)), table7, "Then ");
#line hidden
                Reqnroll.Table table8 = new Reqnroll.Table(new string[] {
                            "File",
                            "Folder"});
                table8.AddRow(new string[] {
                            "PersonMDto.g.cs",
                            "TestSubfolder"});
                table8.AddRow(new string[] {
                            "OrderMDto.g.cs",
                            "TestSubfolder"});
#line 88
 await testRunner.AndAsync("the following files no longer exist:", ((string)(null)), table8, "And ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
    }
}
#pragma warning restore
#endregion
