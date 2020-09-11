using System;
using System.Linq;
using System.Windows.Forms;
using VEntityFramework.Model;

namespace VUserInterface
{
	public partial class ChallengePointControl : GroupBox
	{
		public ChallengePointControl()
		{
			InitializeComponent();
		}

		public VChallengePoint ChallengePoint
		{
			get => fChallengePoint;
			set
			{
				if (fChallengePoint != value)
				{
					fChallengePoint = value;
					UpdateBindingIfDataSourceChanged();
				}
			}
		}
		VChallengePoint fChallengePoint;

		void UpdateBindingIfDataSourceChanged()
		{
			if (ChallengePoint != null && ChallengePoint != this.bindingSource.DataSource)
			{
				this.bindingSource.DataSource = ChallengePoint;
				RefreshBinding(true);
			}
		}

		protected override void OnBindingContextChanged(EventArgs e)
		{
			base.OnBindingContextChanged(e);
			UpdateBindingIfDataSourceChanged();
		}

		protected override void OnParentBindingContextChanged(EventArgs e)
		{
			base.OnParentBindingContextChanged(e);
			UpdateBindingIfDataSourceChanged();
		}

		public void RefreshBinding(bool updateSchema)
		{
			this.bindingSource.ResetBindings(updateSchema);
		}
	}
}
