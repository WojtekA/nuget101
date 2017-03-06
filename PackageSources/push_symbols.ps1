param(
        [Parameter(
                    Mandatory=$true,
                    Position=0,
                    HelpMessage='Provide a valid path to nupkg file')]
        [string] $w
)

nuget push $w 1742b729-a59f-4aee-98b2-9e0320a2d97d -Source https://www.myget.org/F/feed-wojtek/symbols/api/v2/package