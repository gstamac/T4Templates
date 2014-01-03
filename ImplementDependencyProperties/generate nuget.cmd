@set EnableNuGetPackageRestore=true

@nuget pack T4ImplementDependencyProperties.nuspec

@copy *.nupkg "R:\NuGetLibrary\."

@pause