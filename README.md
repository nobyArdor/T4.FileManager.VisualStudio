<p align="center">
  <img height="150" src="https://raw.githubusercontent.com/databinding-gmbh/T4.FileManager.VisualStudio/master/src/images/logo-t4-file-manager.png" alt="T4 FileManager"/>
</p>

forked from (https://github.com/databinding-gmbh/T4.FileManager.VisualStudio/)

# T4.FileManager.VisualStudio

[![Build Status](https://dev.azure.com/databinding/Building%20Blocks/_apis/build/status/databinding-gmbh.T4.FileManager.VisualStudio?branchName=master)](https://dev.azure.com/databinding/Building%20Blocks/_build/latest?definitionId=39&branchName=master) [![Nuget](https://img.shields.io/nuget/v/T4.FileManager.VisualStudio)](https://www.nuget.org/packages/T4.FileManager.VisualStudio/) [![Nuget](https://img.shields.io/nuget/dt/T4.FileManager.VisualStudio)](https://www.nuget.org/packages/T4.FileManager.VisualStudio/)

With the T4.FileManager you can define into which files T4 generates your code. You are no longer bound to the default behaviour of T4 that generates all the code of the “example.tt” template into a single “example.cs” file. Now you can split your code into the files you want: 

- Putting each generated data class into a single code file
- Creating a server and a client component based on a common model
- Distribute generated code to multiple projects within a solution
- Set the file properties (like ResXFileCodeGenerator as CustomTool)
- Update previously generated files

 

## Documentation

Our [documentation](https://databinding-gmbh.github.io/T4.FileManager.VisualStudio/) offers all the details you need to know to work with T4.FileManager.



## Getting Started

### Prerequisites

| Program     | Version     | Info | File        |
|-------------|-------------|------|-------------|
| [Visual Studio](https://visualstudio.microsoft.com/vs/) | 2022 |  since Version 3.0 | T4.FileManager.VisualStudio.ttinclude |
| Visual Studio | 2017, 2019 | since Version 3.0 | T4.FileManager.VisualStudio19.ttinclude |

Visual Studio 16.9.x has a bug that prevents you from debugging T4 templates. See [this post](https://improveandrepeat.com/2021/05/how-to-fix-the-t4-debugger-in-visual-studio-16-9-x/) for an explanation on how to fix it.

### Installing

Install the nuget package in your project.

```
Install-Package T4.FileManager.VisualStudio
```

For more information see [documentation](https://databinding-gmbh.github.io/T4.FileManager.VisualStudio/01-Installation/).

## Running

The execution of the generation remains on the original [T4 Text Templates](https://docs.microsoft.com/en-us/visualstudio/modeling/code-generation-and-t4-text-templates?view=vs-2019).

## Testing

There are some user story oriented [SpecFlow tests](https://databinding-gmbh.github.io/T4.FileManager.VisualStudio/T4FileManagerVisualStudio.html) for ensuring that the FileManager is working as expected.
Tests for NET Framework are located in the project **T4.FileManager.VisualStudio.AcceptanceCriteria** and for NET 5+ in **T4.FileManager.NetCore.AcceptanceCriteria**.

## Authors

- René Leupold - *initial work*
- Johnny Graber

## How to Contribute

Pull-requests are welcome! Please follow these rules so that we can integrate your pull-requests without much effort:

* Create an issue and explain the problem with an example
*	Reference the issue in your commits / pull-request
*	Document the new behavior (in the docs folder)
*	Create tests to verify the new behavior
*	[All existing tests must still pass](https://databinding-gmbh.github.io/T4.FileManager.VisualStudio/T4FileManagerVisualStudio.html), including the acceptance tests (in the tests folder)
*	Clean-up the commit history 
    *	No fix commits
    *	Changes that belong together are in the same commit
    *	All commits have a meaningful commit message
* Keep the code maintainable and focused on the problem you try to solve
    *	No feature-flags to turn the main logic on or off
    *	No C# preprocessor directives (like #if DEBUG)
    *	No modification of the author list (on GitHub and in the NuGet package)
    *	No changes on the code style and formatting



## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Built With

- [T4 Text Templates](https://docs.microsoft.com/en-us/visualstudio/modeling/)
- [Json.NET](https://www.newtonsoft.com/json)

## Breaking changes to old TemplateFileManager

See section breaking changes of [Change log](https://databinding-gmbh.github.io/T4.FileManager.VisualStudio/12-Change-log/#breaking-changes-compared-to-templatefilemanager)



Link to old T4.TemplateFileManager: https://github.com/renegadexx/T4.Helper.

## T4 Intellisense Extensions for Visual Studio
- [tangible T4 Editor](https://t4-editor.tangible-engineering.com/T4-Editor-Visual-T4-Editing.html)
- [T4Editor](https://github.com/Tim-Maes/T4Editor)
- [devart T4 Editor](https://www.devart.com/t4-editor/)
- [T4Language](https://github.com/bricelam/T4Language)

## Fork difference
- Moved configs options to separate T4FileManagerOptions class
- Add option TextFileEncoding to set output text file encoding
- Add option LinkGeneratingFilesToTemplatePlaceholder to link generating files to template placeholder in solution
- Add option LinkJsonFileToSolution to link info.json file in solution tree
- Add option EmptyTemplatePlaceHolderExtention to set empty template placeholder file extention
- Add option SetDefaultExtention - switch when need set default .txt extention to main output file
- Add public method CreateResourceFile - to add binary embedded resouce file without cleanup, header block and other code routines and link the file to solution tree