@set EnableNuGetPackageRestore=true

@nuget pack T4AddDataMsTests.nuspec

@copy *.nupkg "R:\NuGetLibrary\."

@pause