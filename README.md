# nuget101 - NuGet intro 

This is a repository for introduction into NuGet and walkthroughs for some common real-world scenarios.

# What is NuGet?
- Package manager, far from ideal, but with no real alternatives
- NuGet folders (lib, content, tools, build)

# What do we want to use it for?
- Extract stable codebase parts to limit the amount of 

# Tutorial 1 - original project, js lib, static content, class to be moved to external reference, build (sign target?)
- move to separate projects
- create nuget packages
- publish nuget packages
- install nuget packages (show filesystem changes)
- update and publish nuget packages
- upgrade nuget packages
- reinstall nuget packages

# Tutorial 2 - nuget package development 
- what is a good candidate for a nuget package?
- what is a poor candidate for a nuget package?
- multiple feeds
- prerelease feed
- commandline upgrade
- symbol feed
- scripts 
- replace nuget ref with project ref (VS extension - NuGet Reference Switcher)
- tag NuGet branch on release
- create a local prerelease feed 
- create nuget on build, pack and publish to prerelease feed
- upgrade packages by hand (?)
- build time impact
- show a problem with a nuget that has too many responsibilities

# Tutorial 3 - DH nuget install? (what to do with DB scripts?) proper SemVer 