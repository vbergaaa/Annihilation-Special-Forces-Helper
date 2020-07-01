using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace VModel
{
	public abstract class VBusinessObject : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		protected void OnPropertyChanged(PropertyChangedEventArgs e)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, e);
			}
		}
	}
}
