# nuget101 - NuGet intro 

This is a repository for introduction into NuGet and walkthroughs for some common real-world scenarios.

# What is NuGet?
- Package manager, far from ideal, but with no real alternatives
- NuGet folders (lib, content, tools, build)

# What do we want to use it for?
- Extract stable codebase parts to limit the amount of 

# Scenario 1
- Step 1 - Initial project 
- Step 2 - Prepare to create packages
- Step 3 - Create packages
- Step 4 - Publish packages, install packages in project
- Step 5 - Update and publish packages
- Step 6 - Debugging - NuGet Reference Switcher, symbols 

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