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
    [NUnit.Framework.DescriptionAttribute("UT001 Generate Code")]
    [NUnit.Framework.CategoryAttribute("db-6")]
    public partial class UT001GenerateCodeFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = new string[] {
                "db-6"};
        
#line 1 "UT001-Generate_Code.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "UT001 Generate Code", "\tAs a developer\r\n\tI can generate code with the T4.FileManager with each class in " +
                    "its own file", ProgrammingLanguage.CSharp, featureTags);
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
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Generate two files")]
        public void GenerateTwoFiles()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Generate two files", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 10
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
#line 11
 testRunner.Given("the script \"Test.tt\" with the following content", @"<#@ template debug=""false"" hostspecific=""true"" language=""C#"" #>
<#@ assembly name=""System.Core"" #>
<#@ import namespace=""System.Linq"" #>
<#@ import namespace=""System.Text"" #>
<#@ import namespace=""System.Collections.Generic"" #>
<#@ output extension="".txt"" #>

<#@ include file=""$(ProjectDir)\T4.FileManager.VisualStudio.ttinclude"" #>

<#
var files = new string[] { ""PersonDto"", ""OrderDto"" };
var fileManager = T4FileManager.Create(this);

foreach(var itm in files)
{
fileManager.CreateNewFile(itm + "".g.cs"", """","""");
#>
namespace Test
{
public class <#= itm #>
{
}
}
<#
}

fileManager.Generate();
#>", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 42
 testRunner.When("I run the script", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                            "File"});
                table1.AddRow(new string[] {
                            "PersonDto.g.cs"});
                table1.AddRow(new string[] {
                            "OrderDto.g.cs"});
#line 43
 testRunner.Then("the following files are generated:", ((string)(null)), table1, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Generate two files (Backward compatibility T4.TemplateFileManager)")]
        public void GenerateTwoFilesBackwardCompatibilityT4_TemplateFileManager()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Generate two files (Backward compatibility T4.TemplateFileManager)", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 49
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
#line 50
 testRunner.Given("the script \"TestTFM.tt\" with the following content", @"<#@ template debug=""false"" hostspecific=""true"" language=""C#"" #>
<#@ assembly name=""System.Core"" #>
<#@ import namespace=""System.Linq"" #>
<#@ import namespace=""System.Text"" #>
<#@ import namespace=""System.Collections.Generic"" #>
<#@ output extension="".txt"" #>

<#@ include file=""$(ProjectDir)\T4.FileManager.VisualStudio.ttinclude"" #>

<#
var files = new string[] { ""TFMPersonDto"", ""TFMOrderDto"" };
var fileManager = T4FileManager.Create(this);

foreach(var itm in files)
{
fileManager.StartNewFile(itm + "".g.cs"", """","""");
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
#>", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 81
 testRunner.When("I run the script", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                            "File"});
                table2.AddRow(new string[] {
                            "TFMPersonDto.g.cs"});
                table2.AddRow(new string[] {
                            "TFMOrderDto.g.cs"});
#line 82
 testRunner.Then("the following files are generated:", ((string)(null)), table2, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Generate files uses .txt as default file extension when no output extension direc" +
            "tive is set")]
        public void GenerateFilesUses_TxtAsDefaultFileExtensionWhenNoOutputExtensionDirectiveIsSet()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Generate files uses .txt as default file extension when no output extension direc" +
                    "tive is set", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 88
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
#line 89
 testRunner.Given("the script \"TestMissingFileExtension.tt\" with the following content", @"<#@ template debug=""false"" hostspecific=""true"" language=""C#"" #>
<#@ assembly name=""System.Core"" #>
<#@ import namespace=""System.Linq"" #>
<#@ import namespace=""System.Text"" #>
<#@ import namespace=""System.Collections.Generic"" #>

<#@ include file=""$(ProjectDir)\T4.FileManager.VisualStudio.ttinclude"" #>

<#
var files = new string[] { ""PersonTxtDto"", ""OrderTxtDto"" };
var fileManager = T4FileManager.Create(this);

foreach(var itm in files)
{
fileManager.CreateNewFile(itm + "".g.cs"", """","""");
#>
namespace Test
{
public class <#= itm #>
{
}
}
<#
}

fileManager.Generate();
#>", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 119
 testRunner.When("I run the script", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                            "File"});
                table3.AddRow(new string[] {
                            "PersonTxtDto.g.cs"});
                table3.AddRow(new string[] {
                            "OrderTxtDto.g.cs"});
                table3.AddRow(new string[] {
                            "TestMissingFileExtension.txt"});
#line 120
 testRunner.Then("the following files are generated:", ((string)(null)), table3, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Generate files ignores output extension .cs and uses .txt as default to avoid \"er" +
            "ror generation output\" compile errors")]
        public void GenerateFilesIgnoresOutputExtension_CsAndUses_TxtAsDefaultToAvoidErrorGenerationOutputCompileErrors()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Generate files ignores output extension .cs and uses .txt as default to avoid \"er" +
                    "ror generation output\" compile errors", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 127
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
#line 128
 testRunner.Given("the script \"TestCsExtension.tt\" with the following content", @"<#@ template debug=""false"" hostspecific=""true"" language=""C#"" #>
<#@ assembly name=""System.Core"" #>
<#@ import namespace=""System.Linq"" #>
<#@ import namespace=""System.Text"" #>
<#@ import namespace=""System.Collections.Generic"" #>
<#@ output extension="".cs"" #> <# /* **** <====== is ignored **** */ #>

<#@ include file=""$(ProjectDir)\T4.FileManager.VisualStudio.ttinclude"" #>

<#
var files = new string[] { ""PersonCsDto"", ""OrderCsDto"" };
var fileManager = T4FileManager.Create(this);

foreach(var itm in files)
{
fileManager.CreateNewFile(itm + "".g.cs"", """","""");
#>
namespace Test
{
public class <#= itm #>
{
}
}
<#
}

fileManager.Generate();
#>", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 159
 testRunner.When("I run the script", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                            "File"});
                table4.AddRow(new string[] {
                            "PersonCsDto.g.cs"});
                table4.AddRow(new string[] {
                            "OrderCsDto.g.cs"});
                table4.AddRow(new string[] {
                            "TestCsExtension.txt"});
#line 160
 testRunner.Then("the following files are generated:", ((string)(null)), table4, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Generate files with DisableTemplateMainOutputFile enabled prevents generation of " +
            "the t4 main output file (Workaround invalid file extension)")]
        public void GenerateFilesWithDisableTemplateMainOutputFileEnabledPreventsGenerationOfTheT4MainOutputFileWorkaroundInvalidFileExtension()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Generate files with DisableTemplateMainOutputFile enabled prevents generation of " +
                    "the t4 main output file (Workaround invalid file extension)", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 167
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
#line 168
 testRunner.Given("the script \"TestInvalidFileExtension.tt\" with the following content", @"<#@ template debug=""false"" hostspecific=""true"" language=""C#"" #>
<#@ assembly name=""System.Core"" #>
<#@ import namespace=""System.Linq"" #>
<#@ import namespace=""System.Text"" #>
<#@ import namespace=""System.Collections.Generic"" #>
<#@ output extension="".txt"" #>

<#@ include file=""$(ProjectDir)\T4.FileManager.VisualStudio.ttinclude"" #>

<#
var files = new string[] { ""PersonIvDto"", ""OrderIvDto"" };
var fileManager = T4FileManager.Create(this).DisableTemplateMainOutputFile(); // <=== prevent main output file

foreach(var itm in files)
{
fileManager.CreateNewFile(itm + "".g.cs"", """","""");
#>
namespace Test
{
public partial class <#= itm #>
{
}
}
<#
}

fileManager.Generate();
#>", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 199
 testRunner.When("I run the script", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                            "File"});
                table5.AddRow(new string[] {
                            "PersonIvDto.g.cs"});
                table5.AddRow(new string[] {
                            "OrderIvDto.g.cs"});
#line 200
 testRunner.Then("the following files are generated:", ((string)(null)), table5, "Then ");
#line hidden
                TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                            "File"});
                table6.AddRow(new string[] {
                            "TestInvalidFileExtension.txt"});
#line 204
 testRunner.But("the following files are not generated:", ((string)(null)), table6, "But ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Format file content based on editor.config with EnableAutoIndent flag")]
        public void FormatFileContentBasedOnEditor_ConfigWithEnableAutoIndentFlag()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Format file content based on editor.config with EnableAutoIndent flag", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 209
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
#line 210
 testRunner.Given("the script \"TestAutoIndent.tt\" with the following content", @"<#@ template debug=""false"" hostspecific=""true"" language=""C#"" #>
<#@ assembly name=""System.Core"" #>
<#@ import namespace=""System.Linq"" #>
<#@ import namespace=""System.Text"" #>
<#@ import namespace=""System.Collections.Generic"" #>
<#@ output extension="".txt"" #>

<#@ include file=""$(ProjectDir)\T4.FileManager.VisualStudio.ttinclude"" #>

<#
var files = new string[] { ""FileFormat"" };
var fileManager = T4FileManager.Create(this).EnableAutoIndent(); // <=== Enable Format Document

foreach(var itm in files)
{
fileManager.CreateNewFile(itm + "".g.cs"", """","""");
#>
namespace Test
{
public partial class <#= itm #>
      {
                    public int Id {get; set;}
                          public string Name {get; set;}
}
}

<#
}

fileManager.Generate();
#>", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 244
 testRunner.When("I run the script", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 245
     testRunner.Then("the file \"FileFormat.g.cs\" has following format:", "namespace Test\r\n{\r\n    public partial class FileFormat\r\n    {\r\n        public int" +
                        " Id { get; set; }\r\n        public string Name { get; set; }\r\n    }\r\n}", ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Generate file with default encoding")]
        public void GenerateFileWithDefaultEncoding()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Generate file with default encoding", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 257
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
#line 258
testRunner.Given("the script \"TestDefaultEncoding.tt\" with the following content", @"<#@ template debug=""false"" hostspecific=""true"" language=""C#"" #>
<#@ assembly name=""System.Core"" #>
<#@ import namespace=""System.Linq"" #>
<#@ import namespace=""System.Text"" #>
<#@ import namespace=""System.Collections.Generic"" #>
<#@ output extension="".txt"" #>

<#@ include file=""$(ProjectDir)\T4.FileManager.VisualStudio.ttinclude"" #>

<#
var files = new string[] { ""FileDefaultEncoding"" };
var fileManager = T4FileManager.Create(this);
foreach(var itm in files)
{
fileManager.StartNewFile(itm + "".g.cs"", """","""");
#>
namespace Test
{
public partial class <#= itm #>
{
   public int Id {get; set;}
}
}
<#
}
fileManager.Process();
#>", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 288
 testRunner.When("I run the script", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 289
    testRunner.Then("the file \"FileDefaultEncoding.g.cs\" is encoded in \"UTF-8\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Generate file with Unicode encoding")]
        public void GenerateFileWithUnicodeEncoding()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Generate file with Unicode encoding", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 292
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
#line 293
testRunner.Given("the script \"TestUTF16Encoding.tt\" with the following content", @"<#@ template debug=""false"" hostspecific=""true"" language=""C#"" #>
<#@ assembly name=""System.Core"" #>
<#@ import namespace=""System.Linq"" #>
<#@ import namespace=""System.Text"" #>
<#@ import namespace=""System.Collections.Generic"" #>
<#@ output extension="".txt"" #>

<#@ include file=""$(ProjectDir)\T4.FileManager.VisualStudio.ttinclude"" #>

<#
var files = new string[] { ""TestUTF16Encoding"" };
var fileManager = T4FileManager.Create(this).EnableLog().SetOutputFileEncoding(Encoding.Unicode); // <=== Set encoding for output file
foreach(var itm in files)
{
fileManager.StartNewFile(itm + "".g.cs"", """","""");
#>
namespace Test
{
public partial class <#= itm #>
{
   public int Id {get; set;}
}
}
<#
}
fileManager.Process();
#>", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 323
 testRunner.When("I run the script", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 324
    testRunner.Then("the file \"TestUTF16Encoding.g.cs\" is encoded in \"UTF-16\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Generate file with simular UCS-2 encoding")]
        public void GenerateFileWithSimularUCS_2Encoding()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Generate file with simular UCS-2 encoding", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 327
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
#line 328
    testRunner.Given("the script \"TestBigEndianEncoding.tt\" with the following content", @"<#@ template debug=""false"" hostspecific=""true"" language=""C#"" #>
<#@ assembly name=""System.Core"" #>
<#@ import namespace=""System.Linq"" #>
<#@ import namespace=""System.Text"" #>
<#@ import namespace=""System.Collections.Generic"" #>
<#@ output extension="".txt"" #>

<#@ include file=""$(ProjectDir)\T4.FileManager.VisualStudio.ttinclude"" #>

<#
var files = new string[] { ""TesBigEndianEncoding"" };
var fileManager = T4FileManager.Create(this).EnableLog().SetOutputFileEncoding(Encoding.BigEndianUnicode);
foreach(var itm in files)
{
fileManager.StartNewFile(itm + "".g.sql"", """","""");
#>
SELECT 'öäüé' <#=itm#>
<#
}
fileManager.Process();
#>", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 352
 testRunner.When("I run the script", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 353
    testRunner.Then("the file \"TesBigEndianEncoding.g.sql\" is encoded in \"UTF-16BE\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Generate file with System.Xml Namespace (Bug 20)")]
        public void GenerateFileWithSystem_XmlNamespaceBug20()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Generate file with System.Xml Namespace (Bug 20)", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 355
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
#line 356
    testRunner.Given("the script \"TestSystemXml.tt\" with the following content", @"<#@ template debug=""false"" hostspecific=""true"" language=""C#"" #>
<#@ assembly name=""System.Core"" #>
<#@ assembly name=""System.Xml"" #>
<#@ assembly name=""System.Xml.Linq"" #>
<#@ import namespace=""System.Linq"" #>
<#@ import namespace=""System.Text"" #>
<#@ import namespace=""System.Xml"" #>
<#@ import namespace=""System.Xml.Linq"" #>
<#@ import namespace=""System.Collections.Generic"" #>
<#@ output extension="".txt"" #>
<#@ include file=""$(ProjectDir)\T4.FileManager.VisualStudio.ttinclude"" #>

<# var fileManager = T4FileManager.Create(this).EnableAutoIndent(); #>
<#
fileManager.StartNewFile(""text.xml"", """","""");
var doc = new XmlDocument();
doc.LoadXml(""<book>Reading</book>"");
#>
<#=doc.InnerXml#>
<#
fileManager.Process();
#>", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 381
    testRunner.When("I run the script", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                            "File"});
                table7.AddRow(new string[] {
                            "text.xml"});
#line 382
 testRunner.Then("the following files are generated:", ((string)(null)), table7, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
