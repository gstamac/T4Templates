@set EnableNuGetPackageRestore=true

@nuget pack T4AddDataMsTests.nuspec

@copy *.nupkg "C:\_Install\#Visual Studio\_NuGet Packages\."

@pause