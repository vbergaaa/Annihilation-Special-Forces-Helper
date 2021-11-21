using EnumsNET;
using System;
using System.Drawing;
using System.Windows.Forms;
using VEntityFramework;

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
				var text = value is Enum @enum
					? Enums.AsString(@enum.GetType(), @enum, EnumFormat.Description, EnumFormat.Name)
					: UseNumberSuffixes
						? GetSuffixedNumber(value.ToString())
						: value.ToString();
				Label.Text = text + Suffix;
			}
		}

		string GetSuffixedNumber(string value)
		{
			if (!double.TryParse(value, out var number))
			{
				ErrorReporter.ReportDebug(!string.IsNullOrEmpty(value), "Why are we trying to suffix this?");
				return value;
			}
			else
			{
				if (number > 1000000000000)
				{
					number /= 1000000000000;
					return Math.Round(number, 2) + "T";
				}
				if (number > 1000000000)
				{
					number /= 1000000000;
					return Math.Round(number, 2) + "B";
				}
				if (number > 1000000)
				{
					number /= 1000000;
					return Math.Round(number, 2) + "M";
				}
				if (number > 10000)
				{
					number /= 1000;
					return Math.Round(number, 2) + "K";
				}
				return Math.Round(number, 2).ToString();
			}
		}

		public bool UseNumberSuffixes { get; set; }
		public string Suffix { get; set; }
	}
}
