using System.Windows.Forms;
using VEntityFramework.Model;

namespace VUserInterface
{
	public class VBindingSource : BindingSource
	{
		protected override void OnBindingComplete(BindingCompleteEventArgs e)
		{
			if (e.BindingCompleteState != BindingCompleteState.Success)
			{
				Log.ReportError("Failed Binding Event", e.Exception);
			}
			base.OnBindingComplete(e);
		}
	}
}
