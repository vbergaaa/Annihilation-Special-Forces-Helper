using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VUserInterface.Helpers
{
	public static class CaptionProvider
	{
		public static string GetOptimiseLoadoutCaption(string points, string stat)
		{
			return @$"The application will now automatically assign {points} to attempt to maximise the loadout's {stat}.
It will only assign unused {points}, it won't try to refund anything you have already bought on the loadout, so feel free to buy any important perks, gems, or challenge points before hitting 'OK'.
To make this as accurate as possible, please ensure that you have correctly assigned:
- the current unit
- The unit's rank
- the unit's infuse
- The upgrades
- The difficulty
- The souls you intend to use
- The solo bonus
- The unit spec
- Any mods

All of these things will effect which {points} get selected, so having them as accurate as possible is important before hitting 'OK'.";
		}

		public static string GetShouldRestrictCaption(string points, string stat)
		{
			return @$"You are attempting to maximise the loadout's {stat} with 'Remove loadout restrictions' ticked.
This will cause the application to buy {points}s until every {points} is at it's max value. It will take a very long time and the results will not be realistic.
To use this feature, please untick 'Remove loadout restrictions' on the loadout's details tab.";
		}
	}
}
