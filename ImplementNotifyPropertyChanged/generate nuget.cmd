@set EnableNuGetPackageRestore=true

@nuget pack T4ImplementNotifyPropertyChanged.nuspec

@copy *.nupkg "C:\_Install\#Visual Studio\_NuGet Packages\."

@pause