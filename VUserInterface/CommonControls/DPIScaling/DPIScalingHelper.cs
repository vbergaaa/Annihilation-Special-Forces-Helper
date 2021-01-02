using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VUserInterface
{
	public static class DPIScalingHelper
	{
		#region AutoSizeDimensions

		public static SizeF AutoSizeDimensions
		{
			get
			{
				if (!fAutoSizeDimensions.HasValue)
				{
					fAutoSizeDimensions = new SizeF(6, 13);
				}
				return fAutoSizeDimensions.Value;
			}
		}
		static SizeF? fAutoSizeDimensions;

		#endregion

		#region Initialise

		static void InitialiseDpi()
		{
			if (fDpiX == 0)
			{
				using (var form = new Form())
				using (var g = form.CreateGraphics())
				{
					fDpiX = g.DpiX / 96f;
					fDpiY = g.DpiY / 96f;
				}
			}
		}
		static float fDpiX;
		static float fDpiY;

		#endregion

		#region Scaling

		public static int GetScaledX(int x)
		{
			InitialiseDpi();
			return (int)(x * fDpiX);
		}

		public static int GetScaledY(int y)
		{
			InitialiseDpi();
			return (int)(y * fDpiY);
		}

		public static Size GetScaledSize(int x, int y)
		{
			return new Size(GetScaledX(x), GetScaledY(y));
		}

		public static Point GetScaledPoint(int x, int y)
		{
			return new Point(GetScaledX(x), GetScaledY(y));
		}

		#endregion
	}
}