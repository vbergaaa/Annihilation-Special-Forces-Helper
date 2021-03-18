using EnumsNET;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace VUserInterface.CommonControls
{
	public partial class VLabel : VUserControl
	{
		public VLabel() : base()
		{
			InitializeComponent();
		}

		public ContentAlignment TextAlign
		{
			get => Label.TextAlign;
			set
			{
				Label.TextAlign = value;
			}
		}

		public new object Text
		{
			get => Label.Text;
			set
			{
				Label.Text = value is Enum @enum
					? Enums.AsString(@enum.GetType(), @enum, EnumFormat.Description, EnumFormat.Name)
					: value.ToString();
			}
		}
	}
}
