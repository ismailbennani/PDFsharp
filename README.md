> [!NOTE]
> The purpose of this fork is to create a version of PDFSharp that does not output the XMP metadata when saving the PDF document. This is necessary to allow the developer to provide their own metadata.
> 
> There is already an issue and [a PR](https://github.com/empira/PDFsharp/pull/44) that has been open since Oct. 2023 but it has not been merged yet, the maintainers 'want a clean solution, not a quick hack that solves one issue, but leads to other issues'. The author of the PR has also created a NuGet package with the fix, but it also contains other changes that are not necessary for my use case.
> 
> This fork only fixes the issue with the XMP metadata and does not contain any other changes. I will try my best to keep it up to date with the original repository. The build is available as a [NuGet library](https://www.nuget.org/packages/FacturXDotNet.PDFsharp) 

# PDFsharp & MigraDoc 6

Version **6.2.0 Preview 3**  
Published **2025-02-06**

This is a preview version of the **PDFsharp** project, the main project of PDFsharp & MigraDoc 6 with updates for C# 12 and .NET 6.

PDFsharp: Copyright (c) 2005-2025 empira Software GmbH, Troisdorf (Cologne Area), Germany
MigraDoc: Copyright (c) 2001-2025 empira Software GmbH, Troisdorf (Cologne Area), Germany
Published Open Source under the [MIT License](https://docs.pdfsharp.net/LICENSE.html)

For more information see [docs.pdfsharp.net](https://docs.pdfsharp.net/)

## Read this FIRST

Project documentation can be found on our DOCS site: <https://docs.pdfsharp.net>.

Note: PowerShell 7 is required to execute the PowerShell scripts that come with PDFsharp.

### Download assets first

Assets like bitmaps, fonts, or PDF files are not part of the repository anymore.
You must download them before compiling the solution for the first time.
Use `download-assets.ps1` in the `dev` folder to create `assets` folder required for some unit tests and needed by some projects.

Execute

```ps
.\dev\download-assets.ps1
```

### Build the solution

`dotnet build` should build the solution without any warnings or errors.

* You need the latest .NET SDK version installed
* Please note that you need a git repository with at least one commit in order to build the PDFsharp solution.  
  Without a git repository with at least one commit, you will get an error message from `GitVersion.MsBuild` while building the solution.
  You can set a tag to define a valid version, e.g.: `git tag v6.2.0` to make it build with a specific version number. Without tag, version 0.1.0 will be used.

### Central package management

The solution uses central package management.
Version numbers for all referenced packages are stored in file `Directory.Packages.props` in the `src` folder.
When adding new packages, add the required version here.

## Authors

PDFsharp and MigraDoc was mainly written by the following software developers.
With support of a lot of community developers who found issues and fixed bugs.

### Original PDFsharp developers

Stefan Lange  
Niklas Schneider  
David Stephensen

### Original MigraDoc developers

Klaus Potzesny  
Niklas Schneider  
Stefan Lange

### Current PDFsharp and MigraDoc developers

Stefan Lange  
Thomas Hövel  
Martin Ossendorf  
Andreas Seifert

## Libraries used by PDFsharp

The Core build of PDFsharp uses BigGustave to read PNG images. BigGustave was released into the public domain and does not restrict the MIT license used by PDFsharp.  
Link to project repository: https://github.com/EliotJones/BigGustave
