# Annihilation-Special-Forces-Helper
This is a program used to assist players who play the SC2 Custom Arcade Game, "Annihilation Special Forces" created by <Cruxis>jessy

You can use this program to plan and create your in game loadouts, limiting them to your available perk points, gems, souls and challenge points. 
  
It estimates the statistics for your loadout, providing:
  - Player statistics, going beyond the in-game stats by including stats for unit specific buffs, such as infusions, essence, and rank.
  - Unit statistics, to give estimations of a particular units attack, armor, health, etc. at any infusion or rank for the current loadout.
  - A Damage and Toughness score, which approximates you units strength considering the current difficulty, and the typical unit composition for that difficulty.

It also contains economy data, such as:
  - Unit cost information for any unit in the game, configured to your current perks and souls. This allows you to compare perks to see the effect on the cost of a particular unit, and allows you to compare costs of different units at different infuses and ranks.
  - Income data, for any room on any difficulty, configured to your current perks and souls.

## Download Instructions
Download [the most recent release](https://github.com/vbergaaa/Annihilation-Special-Forces-Helper/releases/download/v1.3.1/ASFv1.3.1.zip), extract it, and run the installer Setup.exe. Follow the prompts to complete installation.

This program makes use of Microsoft .NET Core 3 runtime libraries. If you don't already have them on your machine, the installer will download them the first time you run it.

Once you have installed the program, there will be a shortcut on your destop named 'ASF Companion App'. Use this as the main entry point for the app.
The app can also be found as an excutable in 'C:/Program Files (x86)/vbergaaa/ASF Companion App/', or wherever you specified the install.

If you find an issue or wish to request a feature, please create a new issue [here](https://github.com/vbergaaa/Annihilation-Special-Forces-Helper/issues), or contact me through the ASF discord, available via the map in SC2.

### Feature roadmap:
- Add further economy calculations, for things such as building recycle and autoref earnings.
- Add an RP tracking/logging system to keep your profile up to date and allow you to view a history of your games.
- Add unit specific abilities and buffs to try and make unit stats more reflective of reality.
- Adding a helper that suggests different perks or gems to increase stats/economy with best value/cost ratio.
