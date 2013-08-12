@set EnableNuGetPackageRestore=true

@nuget pack T4ImplementNotifyPropertyChanged.nuspec

@copy *.nupkg "R:\NuGetLibrary\."

@pause