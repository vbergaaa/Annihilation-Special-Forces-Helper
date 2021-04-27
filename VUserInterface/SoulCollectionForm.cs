using VEntityFramework.Data;
using VEntityFramework.Interfaces;

namespace VUserInterface
{
	public partial class SoulCollectionForm : VForm
	{
		public SoulCollectionForm(VBusinessObject bizo, ISoulCollectable bindingEntity) : base(bizo)
		{
			InitializeComponent();
			this.SoulCollectionControl.Souls = bindingEntity;
		}
	}
}
