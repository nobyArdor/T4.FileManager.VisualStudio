﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by Reqnroll (https://www.reqnroll.net/).
//      Reqnroll Version:2.0.0.0
//      Reqnroll Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace T4.FileManager.VisualStudio.AcceptanceCriteria.Features
{
    using Reqnroll;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Reqnroll", "2.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("UT006 Generate File with standard header")]
    [NUnit.Framework.CategoryAttribute("db-11")]
    public partial class UT006GenerateFileWithStandardHeaderFeature
    {
        
        private global::Reqnroll.ITestRunner testRunner;
        
        private static string[] featureTags = new string[] {
                "db-11"};
        
#line 1 "UT006-Generate_File_With_Standard_Header.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual async System.Threading.Tasks.Task FeatureSetupAsync()
        {
            testRunner = global::Reqnroll.TestRunnerManager.GetTestRunnerForAssembly(null, NUnit.Framework.TestContext.CurrentContext.WorkerId);
            global::Reqnroll.FeatureInfo featureInfo = new global::Reqnroll.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "UT006 Generate File with standard header", "\tAs a developer\r\n\tI can generate code with the T4.FileManager using a standard he" +
                    "ader", global::Reqnroll.ProgrammingLanguage.CSharp, featureTags);
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
        
        public void ScenarioInitialize(global::Reqnroll.ScenarioInfo scenarioInfo)
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
 await testRunner.GivenAsync("the file manager", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Generate multiple files with standard header")]
        public async System.Threading.Tasks.Task GenerateMultipleFilesWithStandardHeader()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Generate multiple files with standard header", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 9
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
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
 await testRunner.GivenAsync("the script \"TestGlobalHeader.tt\" with the following content", @"<#@ template debug=""false"" hostspecific=""true"" language=""C#"" #>
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
#>", ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 51
 await testRunner.WhenAsync("I run the script", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 52
 await testRunner.ThenAsync("the file \"PersonDtoWithGlobal.g.cs\" starts with header:", "// -------------------------\r\n// databinding - T4\r\n// -------------------------", ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
#line 58
 await testRunner.AndAsync("the file \"PersonDtoWithGlobal.g.cs\" starts with header:", "// -------------------------\r\n// databinding - T4\r\n// -------------------------", ((global::Reqnroll.Table)(null)), "And ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Generate multiple files with filename in standard header (SA1633)")]
        public async System.Threading.Tasks.Task GenerateMultipleFilesWithFilenameInStandardHeaderSA1633()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Generate multiple files with filename in standard header (SA1633)", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 66
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 6
await this.FeatureBackgroundAsync();
#line hidden
#line 67
 await testRunner.GivenAsync("the script \"TestSA1633Header.tt\" with the following content", @"<#@ template debug=""false"" hostspecific=""true"" language=""C#"" #>
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
#>", ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 109
 await testRunner.WhenAsync("I run the script", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 110
 await testRunner.ThenAsync("the file \"PersonDtoWithSA1633.g.cs\" starts with header:", "// <copyright file=\"PersonDtoWithSA1633.g.cs\" company=\"databinding.gmbh\">\r\n//    " +
                        " databinding.gmbh - All rights reserved.\r\n// </copyright>\r\n// <author>Mr. T4</au" +
                        "thor>", ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
#line 117
 await testRunner.AndAsync("the file \"OrderDtoWithSA1633.g.cs\" starts with header:", "// <copyright file=\"OrderDtoWithSA1633.g.cs\" company=\"databinding.gmbh\">\r\n//     " +
                        "databinding.gmbh - All rights reserved.\r\n// </copyright>\r\n// <author>Mr. T4</aut" +
                        "hor>", ((global::Reqnroll.Table)(null)), "And ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Generate multiple files with filename in standard header (SA1633 - Backward compa" +
            "tibility T4.TemplateFileManager)")]
        public async System.Threading.Tasks.Task GenerateMultipleFilesWithFilenameInStandardHeaderSA1633_BackwardCompatibilityT4_TemplateFileManager()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Generate multiple files with filename in standard header (SA1633 - Backward compa" +
                    "tibility T4.TemplateFileManager)", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 126
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 6
await this.FeatureBackgroundAsync();
#line hidden
#line 127
 await testRunner.GivenAsync("the script \"TestSA1633HeaderTFM.tt\" with the following content", @"<#@ template debug=""false"" hostspecific=""true"" language=""C#"" #>
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
#>", ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 169
 await testRunner.WhenAsync("I run the script", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 170
 await testRunner.ThenAsync("the file \"PersonDtoWithSA1633TFM.g.cs\" starts with header:", "// <copyright file=\"PersonDtoWithSA1633TFM.g.cs\" company=\"databinding.gmbh\">\r\n// " +
                        "    databinding.gmbh - All rights reserved.\r\n// </copyright>\r\n// <author>Mr. T4<" +
                        "/author>", ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
#line 177
 await testRunner.AndAsync("the file \"OrderDtoWithSA1633TFM.g.cs\" starts with header:", "// <copyright file=\"OrderDtoWithSA1633TFM.g.cs\" company=\"databinding.gmbh\">\r\n//  " +
                        "   databinding.gmbh - All rights reserved.\r\n// </copyright>\r\n// <author>Mr. T4</" +
                        "author>", ((global::Reqnroll.Table)(null)), "And ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
    }
}
#pragma warning restore
#endregion
