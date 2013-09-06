@set EnableNuGetPackageRestore=true

@nuget pack T4ImplementPropertyChangedCaliburn.nuspec

@copy *.nupkg "R:\NuGetLibrary\."

@pause