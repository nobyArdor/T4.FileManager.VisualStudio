﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.5.0.0
//      SpecFlow Generator Version:3.5.0.0
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
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.5.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("UT006 Generate File with standard header", new string[] {
            "db-11"}, Description="\tAs a developer\r\n\tI can generate code with the T4.FileManager using a standard he" +
        "ader", SourceFile="Features\\UT006-Generate_File_With_Standard_Header.feature", SourceLine=1)]
    public partial class UT006GenerateFileWithStandardHeaderFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = new string[] {
                "db-11"};
        
#line 1 "UT006-Generate_File_With_Standard_Header.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "UT006 Generate File with standard header", "\tAs a developer\r\n\tI can generate code with the T4.FileManager using a standard he" +
                    "ader", ProgrammingLanguage.CSharp, new string[] {
                        "db-11"});
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
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Generate multiple files with standard header", SourceLine=8)]
        public virtual void GenerateMultipleFilesWithStandardHeader()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Generate multiple files with standard header", null, tagsOfScenario, argumentsOfScenario);
#line 9
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
#line 10
 testRunner.Given("the script \"TestGlobalHeader.tt\" with the following content", @"<#@ template debug=""false"" hostspecific=""true"" language=""C#"" #>
<#@ assembly name=""System.Core"" #>
<#@ import namespace=""System.Linq"" #>
<#@ import namespace=""System.Text"" #>
<#@ import namespace=""System.Collections.Generic"" #>
<#@ output extension="".txt"" #>

<#@ include file=""$(ProjectDir)\T4.FileManager.VisualStudio.ttinclude"" #>

<#
var fileManager = T4FileManager.Create(this);
fileManager.StartHeader();
#>
// -------------------------
// databinding - T4
// -------------------------
<#
fileManager.FinishHeader();
fileManager.CreateNewFile(""PersonDtoWithGlobal.g.cs"","""","""");	
#>
namespace Test
{
public class PersonDtoWithGlobal
{
}
}
<#
fileManager.CreateNewFile(""OrderDtoWithGlobal.g.cs"","""","""");	
#>
namespace Test
{
public class OrderDtoWithGlobal
{
}
}
<#
fileManager.Generate();
#>", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 51
 testRunner.When("I run the script", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 52
 testRunner.Then("the file \"PersonDtoWithGlobal.g.cs\" starts with header:", "// -------------------------\r\n// databinding - T4\r\n// -------------------------", ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 58
 testRunner.And("the file \"PersonDtoWithGlobal.g.cs\" starts with header:", "// -------------------------\r\n// databinding - T4\r\n// -------------------------", ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Generate multiple files with filename in standard header (SA1633)", SourceLine=65)]
        public virtual void GenerateMultipleFilesWithFilenameInStandardHeaderSA1633()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Generate multiple files with filename in standard header (SA1633)", null, tagsOfScenario, argumentsOfScenario);
#line 66
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
#line 67
 testRunner.Given("the script \"TestSA1633Header.tt\" with the following content", @"<#@ template debug=""false"" hostspecific=""true"" language=""C#"" #>
<#@ assembly name=""System.Core"" #>
<#@ import namespace=""System.Linq"" #>
<#@ import namespace=""System.Text"" #>
<#@ import namespace=""System.Collections.Generic"" #>
<#@ output extension="".txt"" #>

<#@ include file=""$(ProjectDir)\T4.FileManager.VisualStudio.ttinclude"" #>

<#
var fileManager = T4FileManager.Create(this);
fileManager.StartHeader();
#>
// <copyright file=""$filename$"" company=""databinding.gmbh"">
//     databinding.gmbh - All rights reserved.
// </copyright>
// <author>Mr. T4</author>
<#
fileManager.FinishHeader();
fileManager.CreateNewFile(""PersonDtoWithSA1633.g.cs"","""","""");	
#>
namespace Test
{
public class PersonDtoWithHeader
{
}
}
<#
fileManager.CreateNewFile(""OrderDtoWithSA1633.g.cs"","""","""");	
#>
namespace Test
{
public class OrderDtoWithHeader
{
}
}
<#
fileManager.Generate();
#>", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 109
 testRunner.When("I run the script", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 110
 testRunner.Then("the file \"PersonDtoWithSA1633.g.cs\" starts with header:", "// <copyright file=\"PersonDtoWithSA1633.g.cs\" company=\"databinding.gmbh\">\r\n//    " +
                        " databinding.gmbh - All rights reserved.\r\n// </copyright>\r\n// <author>Mr. T4</au" +
                        "thor>", ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 117
 testRunner.And("the file \"OrderDtoWithSA1633.g.cs\" starts with header:", "// <copyright file=\"OrderDtoWithSA1633.g.cs\" company=\"databinding.gmbh\">\r\n//     " +
                        "databinding.gmbh - All rights reserved.\r\n// </copyright>\r\n// <author>Mr. T4</aut" +
                        "hor>", ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Generate multiple files with filename in standard header (SA1633 - Backward compa" +
            "tibility T4.TemplateFileManager)", SourceLine=125)]
        public virtual void GenerateMultipleFilesWithFilenameInStandardHeaderSA1633_BackwardCompatibilityT4_TemplateFileManager()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Generate multiple files with filename in standard header (SA1633 - Backward compa" +
                    "tibility T4.TemplateFileManager)", null, tagsOfScenario, argumentsOfScenario);
#line 126
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
#line 127
 testRunner.Given("the script \"TestSA1633HeaderTFM.tt\" with the following content", @"<#@ template debug=""false"" hostspecific=""true"" language=""C#"" #>
<#@ assembly name=""System.Core"" #>
<#@ import namespace=""System.Linq"" #>
<#@ import namespace=""System.Text"" #>
<#@ import namespace=""System.Collections.Generic"" #>
<#@ output extension="".txt"" #>

<#@ include file=""$(ProjectDir)\T4.FileManager.VisualStudio.ttinclude"" #>

<#
var fileManager = T4FileManager.Create(this);
fileManager.StartHeader();
#>
// <copyright file=""$filename$"" company=""databinding.gmbh"">
//     databinding.gmbh - All rights reserved.
// </copyright>
// <author>Mr. T4</author>
<#
fileManager.EndBlock();
fileManager.CreateNewFile(""PersonDtoWithSA1633TFM.g.cs"","""","""");	
#>
namespace Test
{
public class PersonDtoWithHeader
{
}
}
<#
fileManager.CreateNewFile(""OrderDtoWithSA1633TFM.g.cs"","""","""");	
#>
namespace Test
{
public class OrderDtoWithHeader
{
}
}
<#
fileManager.Process();
#>", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 169
 testRunner.When("I run the script", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 170
 testRunner.Then("the file \"PersonDtoWithSA1633TFM.g.cs\" starts with header:", "// <copyright file=\"PersonDtoWithSA1633TFM.g.cs\" company=\"databinding.gmbh\">\r\n// " +
                        "    databinding.gmbh - All rights reserved.\r\n// </copyright>\r\n// <author>Mr. T4<" +
                        "/author>", ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 177
 testRunner.And("the file \"OrderDtoWithSA1633TFM.g.cs\" starts with header:", "// <copyright file=\"OrderDtoWithSA1633TFM.g.cs\" company=\"databinding.gmbh\">\r\n//  " +
                        "   databinding.gmbh - All rights reserved.\r\n// </copyright>\r\n// <author>Mr. T4</" +
                        "author>", ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
