# nuget101 - NuGet intro 

This is a repository for introduction into NuGet and walkthroughs for some common real-world scenarios.

# What is NuGet?
- Package manager, far from ideal, but with no real alternatives
- NuGet folders (lib, content, tools, build)

# What do we want to use it for?
- Extract stable, independent codebase parts to increase modularization
- Deliver some artifacts (js, css, images) in a convenient way 
- Shorten build time 

# Tools 
- Visual Studio
- a proper commandline
- NuGet feed (MyGet.org)

# Scenario 1 - nuget basics
1. Initial project
2. Prepare to create packages
3. Create packages
4. Publish packages, install packages in project
5. Update and publish packages

# Scenario 2 - debugging
6. Debugging - symbols
    - disable 'Just my code'
    - enable 'Enable source server support'
7. Debugging - NuGet Reference Switcher

# TODO 
- Spotting NuGets
    - what is a good candidate for a nuget package? 
- what is a poor candidate for a nuget package?
- NuGet scripting 
- Development setup
    - multiple feeds
    - prerelease feed
    - symbol feed
    - local / remote feeds
    - automate nuget build and publish 
    - tag NuGet branch on release
- Best practices
    - build time impact
