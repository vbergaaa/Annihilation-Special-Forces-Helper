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
				UpdateButtonsReadonly();
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
				UpdateButtonsReadonly();
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

		void UpdateButtonsReadonly()
		{
			IncrementArmorButton.Enabled = Parent != null && !Parent.IsMax("Armor");
			IncrementVitalsButton.Enabled = Parent != null && !Parent.IsMax("Vitals");
			IncrementAttackButton.Enabled = Parent != null && !Parent.IsMax("Attack");
			IncrementAttackSpeedButton.Enabled = Parent != null && !Parent.IsMax("AttackSpeed");
			IncrementCriticalChanceButton.Enabled = Parent != null && !Parent.IsMax("CriticalChance");
			IncrementCriticalDamageButton.Enabled = Parent != null && !Parent.IsMax("CriticalDamage");
			IncrementKillsButton.Enabled = Parent != null && !Parent.IsMax("Kills");
			IncrementMineralsButton.Enabled = Parent != null && !Parent.IsMax("Minerals");

			DecrementArmorButton.Enabled = Parent != null && !Parent.IsMin("Armor");
			DecrementVitalsButton.Enabled = Parent != null && !Parent.IsMin("Vitals");
			DecrementAttackButton.Enabled = Parent != null && !Parent.IsMin("Attack");
			DecrementAttackSpeedButton.Enabled = Parent != null && !Parent.IsMin("AttackSpeed");
			DecrementCriticalChanceButton.Enabled = Parent != null && !Parent.IsMin("CriticalChance");
			DecrementCriticalDamageButton.Enabled = Parent != null && !Parent.IsMin("CriticalDamage");
			DecrementKillsButton.Enabled = Parent != null && !Parent.IsMin("Kills");
			DecrementMineralsButton.Enabled = Parent != null && !Parent.IsMin("Minerals");
		}

		#region SoulTypeList

		List<KeyValuePair<string, SoulType>> SoulTypeList
		{
			get
			{
				if (fSoulTypeList == null)
				{
					var list = new Dictionary<string, SoulType>();
					list.Add("None", SoulType.None);
					list.Add($"{SoulType.Lowest.GetDescription()} Soul", SoulType.Lowest);
					list.Add($"{SoulType.Lower.GetDescription()} Soul", SoulType.Lower);
					list.Add($"{SoulType.Low.GetDescription()} Soul", SoulType.Low);
					list.Add($"{SoulType.Mid.GetDescription()} Soul", SoulType.Mid);
					list.Add($"{SoulType.High.GetDescription()} Soul", SoulType.High);
					list.Add($"{SoulType.Higher.GetDescription()} Soul", SoulType.Higher);
					list.Add($"{SoulType.Highest.GetDescription()} Soul", SoulType.Highest);
					list.Add($"{SoulType.Night.GetDescription()} Soul", SoulType.Night);
					list.Add($"{SoulType.Tormented.GetDescription()} Soul", SoulType.Tormented);
					list.Add($"{SoulType.Demonic.GetDescription()} Soul", SoulType.Demonic);
					list.Add($"{SoulType.Titan.GetDescription()} Soul", SoulType.Titan);
					list.Add($"Lowest Soul of {SoulType.Bronze.GetDescription()}", SoulType.Bronze);
					list.Add($"Lowest Soul of {SoulType.Mirrors.GetDescription()}", SoulType.Mirrors);
					list.Add($"Lowest Soul of {SoulType.Hunter.GetDescription()}", SoulType.Hunter);
					list.Add($"Lower Soul of {SoulType.Silver.GetDescription()}", SoulType.Silver);
					list.Add($"Lower Soul of {SoulType.Reflection.GetDescription()}", SoulType.Reflection);
					list.Add($"Lower Soul of {SoulType.Veterancy.GetDescription()}", SoulType.Veterancy);
					list.Add($"Low Soul of {SoulType.Urusy.GetDescription()}", SoulType.Urusy);
					list.Add($"Low Soul of {SoulType.Scavenger.GetDescription()}", SoulType.Scavenger);
					list.Add($"Low Soul of {SoulType.Hunger.GetDescription()}", SoulType.Hunger);
					list.Add($"Mid Soul of {SoulType.Luck.GetDescription()}", SoulType.Luck);
					list.Add($"Mid Soul of {SoulType.Greed.GetDescription()}", SoulType.Greed);
					list.Add($"Mid Soul of {SoulType.Sharing.GetDescription()}", SoulType.Sharing);
					list.Add($"High Soul of {SoulType.Convenience.GetDescription()}", SoulType.Convenience);
					list.Add($"High Soul of {SoulType.Promotion.GetDescription()}", SoulType.Promotion);
					list.Add($"High Soul of {SoulType.Status.GetDescription()}", SoulType.Status);
					list.Add($"Higher Soul of {SoulType.Predestination.GetDescription()}", SoulType.Predestination);
					list.Add($"Higher Soul of {SoulType.RapidMutation.GetDescription()}", SoulType.RapidMutation);
					list.Add($"Higher Soul of {SoulType.Sales.GetDescription()}", SoulType.Sales);
					list.Add($"Highest Soul of {SoulType.GlowingDetermination.GetDescription()}", SoulType.GlowingDetermination);
					list.Add($"Highest Soul of {SoulType.WellAmplification.GetDescription()}", SoulType.WellAmplification);
					list.Add($"Highest Soul of {SoulType.AccelleratedAdvancement.GetDescription()}", SoulType.AccelleratedAdvancement);
					list.Add($"Night Soul of {SoulType.GhostForce.GetDescription()}", SoulType.GhostForce);
					list.Add($"Night Soul of {SoulType.Training.GetDescription()}", SoulType.Training);
					list.Add($"Night Soul of {SoulType.PowerWarping.GetDescription()}", SoulType.PowerWarping);
					list.Add($"Tormented Soul of {SoulType.Demolition.GetDescription()}", SoulType.Demolition);
					list.Add($"Tormented Soul of {SoulType.Tanking.GetDescription()}", SoulType.Tanking);
					list.Add($"Tormented Soul of {SoulType.Unchained.GetDescription()}", SoulType.Unchained);
					list.Add($"Demonic Soul of {SoulType.Draining.GetDescription()}", SoulType.Draining);
					list.Add($"Demonic Soul of {SoulType.Alacrity.GetDescription()}", SoulType.Alacrity);
					list.Add($"Demonic Soul of {SoulType.Stats.GetDescription()}", SoulType.Stats);
					list.Add($"Titan Soul of {SoulType.StridingTitan.GetDescription()}", SoulType.StridingTitan);
					list.Add($"Titan Soul of {SoulType.UnboundReflection.GetDescription()}", SoulType.UnboundReflection);
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
				Parent = Soul.New(type);
			}
		}

		void DecrementAttackButton_Click(object sender, EventArgs e)
		{
			if (Parent != null)
			{
				if (Control.ModifierKeys == Keys.Shift)
				{
					Parent.Attack -= 10;
				}
				else
				{
					Parent.Attack -= 1;
				}
			}
			UpdateButtonsReadonly();
		}

		void IncrementAttackButton_Click(object sender, EventArgs e)
		{
			if (Parent != null)
			{
				if (Control.ModifierKeys == Keys.Shift)
				{
					Parent.Attack += 10;
				}
				else
				{
					Parent.Attack += 1;
				}
			}
			UpdateButtonsReadonly();
		}

		void DecrementAttackSpeedButton_Click(object sender, EventArgs e)
		{
			if (Parent != null)
			{
				if (Control.ModifierKeys == Keys.Shift)
				{
					Parent.AttackSpeed -= 10;
				}
				else
				{
					Parent.AttackSpeed -= 1;
				}
			}
			UpdateButtonsReadonly();
		}

		void IncrementAttackSpeedButton_Click(object sender, EventArgs e)
		{
			if (Parent != null)
			{
				if (Control.ModifierKeys == Keys.Shift)
				{
					Parent.AttackSpeed += 10;
				}
				else
				{
					Parent.AttackSpeed += 1;
				}
			}
			UpdateButtonsReadonly();
		}

		void DecrementVitalsButton_Click(object sender, EventArgs e)
		{
			if (Parent != null)
			{
				if (Control.ModifierKeys == Keys.Shift)
				{
					Parent.Vitals -= 10;
				}
				else
				{
					Parent.Vitals -= 1;
				}
			}
			UpdateButtonsReadonly();
		}

		void IncrementVitalsButton_Click(object sender, EventArgs e)
		{
			if (Parent != null)
			{
				if (Control.ModifierKeys == Keys.Shift)
				{
					Parent.Vitals += 10;
				}
				else
				{
					Parent.Vitals += 1;
				}
			}
			UpdateButtonsReadonly();
		}

		void DecrementArmorButton_Click(object sender, EventArgs e)
		{
			if (Parent != null)
			{
				if (Control.ModifierKeys == Keys.Shift)
				{
					Parent.Armor -= 10;
				}
				else
				{
					Parent.Armor -= 1;
				}
			}
			UpdateButtonsReadonly();
		}

		void IncrementArmorButton_Click(object sender, EventArgs e)
		{
			if (Parent != null)
			{
				if (Control.ModifierKeys == Keys.Shift)
				{
					Parent.Armor += 10;
				}
				else
				{
					Parent.Armor += 1;
				}
			}
			UpdateButtonsReadonly();
		}

		void DecrementCriticalChanceButton_Click(object sender, EventArgs e)
		{
			if (Parent != null)
			{
				if (Control.ModifierKeys == Keys.Shift)
				{
					Parent.CriticalChance -= 10;
				}
				else
				{
					Parent.CriticalChance -= 1;
				}
			}
			UpdateButtonsReadonly();
		}

		void IncrementCriticalChanceButton_Click(object sender, EventArgs e)
		{
			if (Parent != null)
			{
				if (Control.ModifierKeys == Keys.Shift)
				{
					Parent.CriticalChance += 10;
				}
				else
				{
					Parent.CriticalChance += 1;
				}
			}
			UpdateButtonsReadonly();
		}

		void DecrementCriticalDamageButton_Click(object sender, EventArgs e)
		{
			if (Parent != null)
			{
				if (Control.ModifierKeys == Keys.Shift)
				{
					Parent.CriticalDamage -= 10;
				}
				else
				{
					Parent.CriticalDamage -= 1;
				}
			}
			UpdateButtonsReadonly();
		}

		void IncrementCriticalDamageButton_Click(object sender, EventArgs e)
		{
			if (Parent != null)
			{
				if (Control.ModifierKeys == Keys.Shift)
				{
					Parent.CriticalDamage += 10;
				}
				else
				{
					Parent.CriticalDamage += 1;
				}
			}
			UpdateButtonsReadonly();
		}

		void DecrementKillsButton_Click(object sender, EventArgs e)
		{
			if (Parent != null)
			{
				if (Control.ModifierKeys == Keys.Shift)
				{
					Parent.Kills -= 1000;
				}
				else
				{
					Parent.Kills -= 100;
				}
			}
			UpdateButtonsReadonly();
		}

		void IncrementKillsButton_Click(object sender, EventArgs e)
		{
			if (Parent != null)
			{
				if (Control.ModifierKeys == Keys.Shift)
				{
					Parent.Kills += 1000;
				}
				else
				{
					Parent.Kills += 100;
				}
			}
			UpdateButtonsReadonly();
		}

		void DecrementMineralsButton_Click(object sender, EventArgs e)
		{
			if (Parent != null)
			{
				if (Control.ModifierKeys == Keys.Shift)
				{
					Parent.Minerals -= 10000;
				}
				else
				{
					Parent.Minerals -= 1000;
				}
			}
			UpdateButtonsReadonly();
		}

		void IncrementMineralsButton_Click(object sender, EventArgs e)
		{
			if (Parent != null)
			{
				if (Control.ModifierKeys == Keys.Shift)
				{
					Parent.Minerals += 10000;
				}
				else
				{
					Parent.Minerals += 1000;
				}
			}
			UpdateButtonsReadonly();
		}

		#endregion
	}
}
