using VEntityFramework.Data;
using VEntityFramework.Interfaces;

namespace VUserInterface
{
	public partial class SoulCollectionForm : VForm
	{
		public SoulCollectionForm(BusinessObject bizo) : base(bizo)
		{
			InitializeComponent();
		}

		public ISoulCollectable SoulCollectable
		{
			get => SoulCollectionControl.Souls;
			set => SoulCollectionControl.Souls = value;
		}
	}
}
