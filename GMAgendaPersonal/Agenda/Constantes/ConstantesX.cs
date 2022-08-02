using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Constantes {

	public static class Colors {

		#region BackGround

		public static readonly Color BG1 = Color.FromArgb(41, 43, 47);

		public static readonly Color BG2 = Color.FromArgb(33, 35, 39);

		public static readonly Color BG3 = Color.FromArgb(28, 29, 33);

		#endregion BackGround

		#region Controls

		public static readonly Color Gray1 = Color.FromArgb(147, 147, 149);

		public static readonly Color Gray2 = Color.FromArgb(58, 60, 64);

		#endregion Controls

		#region Hover

		public static readonly Color Hover1 = Color.FromArgb(51, 52, 56);

		public static readonly Color Hover2 = Color.FromArgb(43, 44, 48);

		public static readonly Color Hover3 = Color.FromArgb(38, 39, 43);

		#endregion Hover

		#region Dynamic Theme Colors

		public static Color PrimaryColor { get; set; }
		public static Color SecondaryColor { get; set; }

		#endregion Dynamic Theme Colors
	}

	public static class Fonts {
		private static readonly string FamilyName = "Maiandra GD";
		private static readonly FontFamily family = new FontFamily(FamilyName);

		public static Font Bold(float size) {
			return new Font(family, size, FontStyle.Bold);
		}

		public static Font Regular(float size) {
			return new Font(family, size, FontStyle.Regular);
		}

		public static Font Italic(float size) {
			return new Font(family, size, FontStyle.Italic);
		}

		public static Font UnderLine(float size) {
			return new Font(family, size, FontStyle.Underline);
		}

		public static readonly Font Title1 = Bold(15.75f);

		public static readonly Font Title2 = Bold(11.25f);

		public static readonly Font SubTitle1 = Bold(10.65f);

		public static readonly Font Text1 = Regular(10.25f);
	}
}