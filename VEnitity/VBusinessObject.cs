using System;
using System.Collections.Generic;
using System.ComponentModel;
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

		public event PropertyChangedEventHandler PropertyChanged;

		protected void OnPropertyChanged(PropertyChangedEventArgs e)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, e);
			}
		}

		public abstract string BizoName { get; }

		public bool Save()
		{
			return Context.SaveAsXML(this);
		}
	}
}
