
namespace CheesecakeCardBuilder.Renderer {
    using System;
    using System.Drawing;
    using System.Drawing.Drawing2D;

    public class FontService {
        public static Font getDefaultFont(){
            return new Font("Segeo Script", 8.25f, FontStyle.Regular);
        }

        public static StringFormat getDefaultFormat() {
            StringFormat defaultFormat = new StringFormat();
            defaultFormat.Alignment = StringAlignment.Center;
            return defaultFormat;
        }

        public static Brush getDefaultBrush() {
            return new SolidBrush(Color.Black);
        }

        public static LinearGradientBrush getGradiantBrush(Font font, int offset, Color color) {
            ColorBlend cb = new ColorBlend();
            cb.Positions = new[] { 0, 5 / 16f, 8 / 16f, 13 / 16f, 1 };
            cb.Colors = new[] { Color.White, Color.White, Color.Gray, Color.White, Color.White };
            LinearGradientBrush linearGradiant = new LinearGradientBrush(new Rectangle(0, offset, 20, (int)font.GetHeight() / 2), Color.White, Color.White, 90f);
            linearGradiant.InterpolationColors = cb;
            return linearGradiant;
        }

        public static LinearGradientBrush getGradiantBrush(Font font, int offset) {
            return getGradiantBrush(font, offset, Color.FromArgb(255, 180,180,180));
        }
    }
}
