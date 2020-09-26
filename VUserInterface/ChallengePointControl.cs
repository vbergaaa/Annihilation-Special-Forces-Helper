using System;
using System.Linq;
using System.Windows.Forms;
using VEntityFramework.Model;

namespace VUserInterface
{
	public partial class ChallengePointControl : UserControl
	{
		public ChallengePointControl()
		{
			InitializeComponent();
		}

		#region ChallengePoint

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

		#endregion

		#region Caption

		public string Caption
		{ 
			get => CurrentLevelIncrementor.Caption;
			set => CurrentLevelIncrementor.Caption = value;
		}

		#endregion

		#region Bindings

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

		#endregion
	}
}
