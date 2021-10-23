using VEntityFramework.Model;

namespace VEntityFramework.Interfaces
{
	public interface ISoulCollectable
	{
		void ToggleSoul(SoulType soul);
		bool GetBindingValue(SoulType soul);
		bool GetBindingVisibility(SoulType soul);
		int TotalUniques { get; }
		int PowerSoulsCount { get; }
		string PowerSoulsCountCaption { get; }
	}
}