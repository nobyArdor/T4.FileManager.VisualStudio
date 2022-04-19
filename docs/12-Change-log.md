# Change log

## 3.0.1
- Moved configs options to separate T4FileManagerOptions class
- Add option TextFileEncoding to set output text file encoding
- Add option LinkGeneratingFilesToTemplatePlaceholder to link generating files to template placeholder in solution
- Add option LinkJsonFileToSolution to link info.json file in solution tree
- Add option EmptyTemplatePlaceHolderExtention to set empty template placeholder file extention
- Add option SetDefaultExtention - switch when need set default .txt extention to main output file
- Add public method CreateResourceFile - to add binary embedded resouce file without cleanup, header block and other code routines and link the file to solution tree

## 3.0.0

- Support for Visual Studio 2022
- **Breaking Changes**
  - Visual Studio has Breaking Changes in EnvDTE-Automation.
  - With this version T4.FileManager.VisualStudio.ttinclude works only in Visual Studio 2022
  - For backward compatibility you can use T4.FileManager.VisualStudio19.ttinclude

## 2.0.0

- Compatibility to T4.TemplateFileManager improved
- Added class **TemplateFileManager** for better backward compatibility
- Header supports the placeholder $filename$ again
- Methods to configure the t4 file manager now follow the builder pattern style
- **Breaking Changes**
  - GetNamespaceForCSharpCode() removed because CreateNewFile knows the namespace already (set by developer)
  - CreateNewFile FileProperties Dictionary removed use class FileProperties instead

## 1.3.0

- Logging generation in output window and main output text file if .EnableLog() called (Feature UT016)

## 1.2.4

- Referencing in .net core projects new with $(TargetDir)

## Breaking Changes compared to TemplateFileManager

- No support for TFS Source Control
- No Parameter template support with sessions
- *.txt4 replaced with *.info.json
- WriteLineToBuildPane replaced with FileManager.Log()
- Disable split files (FileManager.Process) not supported

