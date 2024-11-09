using CodenamesWeb.Enums;
using System.Drawing;
using System.Globalization;
using System.Text;

namespace CodenamesWeb.Helpers
{
    public class Resources
    {
        public static string TextColor(ColorStyle style)
        {
            switch (style)
            {
                case ColorStyle.Dark: return "var(--white-color)";
                default: return "var(--dark-color)";
            }
        }

        public static string Color(ColorStyle style)
        {
            return $"var({GetVariable(style)})";
        }
        public static string TransparentColor(ColorStyle style, double transparency)
        {
            return $"rgba(var({GetVariable(style)}-t), {transparency.ToString(CultureInfo.InvariantCulture)})";
        }

        private static string GetVariable(ColorStyle style)
        {
            switch (style)
            {
                case ColorStyle.White: return "--white-color";
                case ColorStyle.Red: return "--red-color";
                case ColorStyle.Blue: return "--blue-color";
                case ColorStyle.Green: return "--green-color";
                case ColorStyle.Yellow: return "--yellow-color";
                case ColorStyle.Dark: return "--dark-color";
                default: return "--white-color";
            }
        }
    }

}
