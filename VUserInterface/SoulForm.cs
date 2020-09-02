using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using VBusiness.Souls;
using VEntityFramework.Data;
using VEntityFramework.Model;

namespace VUserInterface
{
	public partial class SoulForm : VForm
	{
		public SoulForm(VBusinessObject bizo) : base(bizo)
		{
			if (bizo != null && !(bizo is Soul))
			{
				throw new InvalidOperationException("Soul form must only accept a soul bizo");
			}
			else
			{
				InitializeComponent();
				InitializeParent(bizo);
			}
		}

		private void InitializeParent(VBusinessObject bizo)
		{
			Parent = (Soul)bizo ?? new EmptySoul();
			RefreshSoulTypeList();
		}

		private void RefreshSoulTypeList()
		{
			if (Parent != null)
			{
				TypeComboBox.SelectedValueChanged -= TypeComboBox_SelectionChanged;
				var items = TypeComboBox.Items;
				TypeComboBox.SelectedIndex = (int)Parent.Type;
				TypeComboBox.SelectedValueChanged += TypeComboBox_SelectionChanged;
				isParentInitialised = true;
			}
		}
		bool isParentInitialised;

		public new Soul Parent
		{
			get => (Soul)base.Parent;
			set
			{
				int oldSaveSlot = GetSaveSlotFromTextBoxSafe();
				base.Parent = value;
				if (base.Parent != null && isParentInitialised)
				{
					((Soul)base.Parent).SaveSlot = oldSaveSlot;
				}
				UpdatingBindingSource();
			}
		}

		private int GetSaveSlotFromTextBoxSafe()
		{
			return int.TryParse(SaveSlotTextBox.Text, out var saveSlot)
				? saveSlot
				: 0;
		}

		private void UpdatingBindingSource()
		{
			if (Parent != null)
			{
				this.BindingSource.DataSource = Parent;
				this.BindingSource.ResetBindings(false);
			}
		}

		#region SoulTypeList

		List<KeyValuePair<string, SoulType>> SoulTypeList
		{
			get
			{
				if (fSoulTypeList == null)
				{
					// TODO - This is disgusting lets change it
					var list = new Dictionary<string, SoulType>
					{
						{ "None", SoulType.None },
						{ $"{SoulType.Lowest.GetDescription()} Soul", SoulType.Lowest },
						{ $"{SoulType.Lower.GetDescription()} Soul", SoulType.Lower },
						{ $"{SoulType.Low.GetDescription()} Soul", SoulType.Low },
						{ $"{SoulType.Mid.GetDescription()} Soul", SoulType.Mid },
						{ $"{SoulType.High.GetDescription()} Soul", SoulType.High },
						{ $"{SoulType.Higher.GetDescription()} Soul", SoulType.Higher },
						{ $"{SoulType.Highest.GetDescription()} Soul", SoulType.Highest },
						{ $"{SoulType.Night.GetDescription()} Soul", SoulType.Night },
						{ $"{SoulType.Tormented.GetDescription()} Soul", SoulType.Tormented },
						{ $"{SoulType.Demonic.GetDescription()} Soul", SoulType.Demonic },
						{ $"{SoulType.Titan.GetDescription()} Soul", SoulType.Titan },
						{ $"Lowest Soul of {SoulType.Bronze.GetDescription()}", SoulType.Bronze },
						{ $"Lowest Soul of {SoulType.Mirrors.GetDescription()}", SoulType.Mirrors },
						{ $"Lowest Soul of {SoulType.Hunter.GetDescription()}", SoulType.Hunter },
						{ $"Lower Soul of {SoulType.Silver.GetDescription()}", SoulType.Silver },
						{ $"Lower Soul of {SoulType.Reflection.GetDescription()}", SoulType.Reflection },
						{ $"Lower Soul of {SoulType.Veterancy.GetDescription()}", SoulType.Veterancy },
						{ $"Low Soul of {SoulType.Urusy.GetDescription()}", SoulType.Urusy },
						{ $"Low Soul of {SoulType.Scavenger.GetDescription()}", SoulType.Scavenger },
						{ $"Low Soul of {SoulType.Hunger.GetDescription()}", SoulType.Hunger },
						{ $"Mid Soul of {SoulType.Luck.GetDescription()}", SoulType.Luck },
						{ $"Mid Soul of {SoulType.Greed.GetDescription()}", SoulType.Greed },
						{ $"Mid Soul of {SoulType.Sharing.GetDescription()}", SoulType.Sharing },
						{ $"High Soul of {SoulType.Convenience.GetDescription()}", SoulType.Convenience },
						{ $"High Soul of {SoulType.Promotion.GetDescription()}", SoulType.Promotion },
						{ $"High Soul of {SoulType.Status.GetDescription()}", SoulType.Status },
						{ $"Higher Soul of {SoulType.Predestination.GetDescription()}", SoulType.Predestination },
						{ $"Higher Soul of {SoulType.RapidMutation.GetDescription()}", SoulType.RapidMutation },
						{ $"Higher Soul of {SoulType.Sales.GetDescription()}", SoulType.Sales },
						{ $"Highest Soul of {SoulType.GlowingDetermination.GetDescription()}", SoulType.GlowingDetermination },
						{ $"Highest Soul of {SoulType.WellAmplification.GetDescription()}", SoulType.WellAmplification },
						{ $"Highest Soul of {SoulType.AccelleratedAdvancement.GetDescription()}", SoulType.AccelleratedAdvancement },
						{ $"Night Soul of {SoulType.GhostForce.GetDescription()}", SoulType.GhostForce },
						{ $"Night Soul of {SoulType.Training.GetDescription()}", SoulType.Training },
						{ $"Night Soul of {SoulType.PowerWarping.GetDescription()}", SoulType.PowerWarping },
						{ $"Tormented Soul of {SoulType.Demolition.GetDescription()}", SoulType.Demolition },
						{ $"Tormented Soul of {SoulType.Tanking.GetDescription()}", SoulType.Tanking },
						{ $"Tormented Soul of {SoulType.Unchained.GetDescription()}", SoulType.Unchained },
						{ $"Demonic Soul of {SoulType.Draining.GetDescription()}", SoulType.Draining },
						{ $"Demonic Soul of {SoulType.Alacrity.GetDescription()}", SoulType.Alacrity },
						{ $"Demonic Soul of {SoulType.Stats.GetDescription()}", SoulType.Stats },
						{ $"Titan Soul of {SoulType.Acceleration.GetDescription()}", SoulType.Acceleration },
						{ $"Titan Soul of {SoulType.StridingTitan.GetDescription()}", SoulType.StridingTitan },
						{ $"Titan Soul of {SoulType.UnboundReflection.GetDescription()}", SoulType.UnboundReflection },
					};
					fSoulTypeList = list.ToList();
				}
				return fSoulTypeList;
			}
		}
		private List<KeyValuePair<string, SoulType>> fSoulTypeList;

		#endregion

		#region Event Handlers

		void TypeComboBox_SelectionChanged(object sender, EventArgs e)
		{
			var value = TypeComboBox.SelectedValue;

			if (value is SoulType type && (Parent == null || Parent.Type != type))
			{
				Parent = Soul.New(type, null);
			}
		}

		#endregion
	}
}
