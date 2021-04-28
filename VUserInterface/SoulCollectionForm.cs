using VEntityFramework.Data;
using VEntityFramework.Interfaces;

namespace VUserInterface
{
	public partial class SoulCollectionForm : VForm
	{
		public SoulCollectionForm(VBusinessObject bizo) : base(bizo)
		{
			InitializeComponent();
		}

		public ISoulCollectable SoulCollectable
		{
			get => this.SoulCollectionControl.Souls;
			set => this.SoulCollectionControl.Souls = value;
		}
	}
}
