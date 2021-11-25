using EnumsNET;
using System;
using System.Diagnostics.CodeAnalysis;
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
			set => Label.TextAlign = value;
		}

		[SuppressMessage("Design", "CA1061:Do not hide base class methods", Justification = "we don't have a use for 'Text' on a VUserControl, and if we name this something else, it'll cause confusion/bugs when consuming it.")]
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

        static string GetSuffixedNumber(string value)
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
