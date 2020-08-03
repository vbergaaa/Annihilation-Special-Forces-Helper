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
			if (bizo != null)
			{
				Parent = (Soul)bizo;
				RefreshSoulTypeList();
			}
		}

		private void RefreshSoulTypeList()
		{
			if (Parent != null)
			{
				TypeComboBox.SelectedValueChanged -= TypeComboBox_SelectionChanged;
				var items = TypeComboBox.Items;
				TypeComboBox.SelectedIndex = (int)Parent.Type;
				TypeComboBox.SelectedValueChanged += TypeComboBox_SelectionChanged;
			}
		}

		public new Soul Parent
		{
			get => fSoul;
			set
			{
				var oldSaveSlot = fSoul?.SaveSlot;
				base.Parent = value;
				fSoul = value;
				if (fSoul != null && oldSaveSlot.HasValue)
				{
					fSoul.SaveSlot = oldSaveSlot.Value;
				}
				UpdatingBindingSource();
				UpdateButtonsReadonly();
			}
		}
		Soul fSoul;

		private void UpdatingBindingSource()
		{
			if (Parent != null)
			{
				this.BindingSource.DataSource = Parent;
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

		List<SoulType> SoulTypeList
		{
			get
			{
				if (fSoulTypeList == null)
				{
					var list = new List<SoulType>
					{
						SoulType.None,
						SoulType.Lowest,
						SoulType.Lower,
						SoulType.Low,
						SoulType.Mid,
						SoulType.High,
						SoulType.Higher,
						SoulType.Highest,
						SoulType.Night,
						SoulType.Tormented,
						SoulType.Demonic,
						SoulType.Titan,
					};
					fSoulTypeList = list;
				}
				return fSoulTypeList;
			}
		}
		List<SoulType> fSoulTypeList;

		#endregion

		#region Event Handlers

		void TypeComboBox_SelectionChanged(object sender, EventArgs e)
		{
			var newType = (SoulType)TypeComboBox.SelectedValue;
			if (Parent == null || newType != Parent.Type)
			{
				Parent = Soul.New(newType);
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
