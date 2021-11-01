# Annihilation-Special-Forces-Helper
This is a program used to assist players who play the SC2 Custom Arcade Game, "Annihilation Special Forces" created by <Cruxis>jessy. 
It is compatible with Windows 10.

You can use this program to plan and create your in game loadouts, limiting them to your available perk points, gems, souls and challenge points. 
  
It estimates the statistics for your loadout, providing:
  - Player statistics, going beyond the in-game stats by including stats for unit specific buffs, such as infusions, essence, and rank.
  - Unit statistics, to give estimations of a particular units attack, armor, health, etc. at any infusion or rank for the current loadout.
  - A Damage and Toughness score, which approximates you units strength considering the current difficulty, and the typical unit composition for that difficulty.

It also contains economy data, such as:
  - Unit cost information for any unit in the game, configured to your current perks and souls. This allows you to compare perks to see the effect on the cost of a particular unit, and allows you to compare costs of different units at different infuses and ranks.
  - Income data, for any room on any difficulty, configured to your current perks and souls.

## Download Instructions
For most users, it's recommended you go to the [latest release page](https://github.com/vbergaaa/Annihilation-Special-Forces-Helper/releases/tag/v1.3.4), and download the release for your operating system type. If your operation system type isn't there, please raise an issue and I'll add it. For those people who know they have .NET Core SDKs installed on their machines, they can instead install the 'light' version to run an installer and avoid having duplicate binaries. Once you download your version, extract it and run the .exe in the location to launch the app

If you find an issue or wish to request a feature, please create a new issue [here](https://github.com/vbergaaa/Annihilation-Special-Forces-Helper/issues), or contact me through the ASF discord, available via the map in SC2.

### Feature roadmap:
- Improve the usability of the stats and income panels, making it clearer what unit/player stats/costs you are looking at at any given time.
- Add further economy calculations, for things such as building recycle, autoref earnings and training centre.
- Adding a helper that suggests different perks or gems to increase stats/economy with best value/cost ratio.
