using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace VEntityFramework.Data
{
	public abstract class VBusinessObject : INotifyPropertyChanged
	{
		public VBusinessObject()
		{
			Context = new VDataContext();
		}

		public VDataContext Context { get; set; }

		public abstract string BizoName { get; }

		public bool Save()
		{
			Context.SaveAsXML(this, GetExistingXMLFileName);
			UpdateExistingXMLName();
			return true;
		}

		public void Delete()
		{
			Context.DeleteXML(this, GetExistingXMLFileName);
		}

		protected virtual void UpdateExistingXMLName() { }

		protected virtual string GetExistingXMLFileName => null;

		#region Events

		#region PropertyChanged

		public event PropertyChangedEventHandler PropertyChanged;

		protected void OnPropertyChanged(PropertyChangedEventArgs e)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, e);
			}
		}

		#endregion

		#region LoadedFromXML

		internal event EventHandler<EventArgs> LoadedFromXML;

		public virtual void OnLoadedFromXML(OnLoadedEventArgs e)
		{
			LoadedFromXML?.Invoke(this, e);
		}

		#endregion

		#endregion
	}
}
