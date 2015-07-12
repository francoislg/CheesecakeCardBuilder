
namespace CheesecakeCardBuilder.Renderer {
    using CheesecakeCardBuilder.Structure;
    using CheesecakeCardBuilder.Unit;
    using Renderer.Text;
    using System;
    using System.Drawing;
    using System.Drawing.Drawing2D;

    public class FontService {
        public static Color lightGreen = Color.FromArgb(255, 154, 254, 155);
        public static Color lightBlue = Color.FromArgb(255, 53, 255, 255);
        public static Color lightGray = Color.FromArgb(255, 180, 180, 180);
        public static Color lightOrange = Color.FromArgb(255, 252, 153, 49);
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
            LinearGradientBrush linearGradient = new LinearGradientBrush(new Rectangle(0, offset, 20, (int)font.GetHeight() / 2), Color.White, Color.White, 90f);
            linearGradient.InterpolationColors = getInterpolationGradientColors(color);
            return linearGradient;
        }

        public static BrushChangerByType getDefaultGradientBrushChangerByType(Font font, Card card) {
            if (card is UnitCard) {
                BrushChangerByUnitType brushChanger = new BrushChangerByUnitType((UnitCard)card);
                brushChanger.Add(UnitType.Standard, FontService.getGradiantBrush(font, 0, lightGray));
                brushChanger.Add(UnitType.Advanced, FontService.getGradiantBrush(font, 0, lightBlue));
                brushChanger.Add(UnitType.Expert, FontService.getGradiantBrush(font, 0, lightGreen));
                brushChanger.Add(UnitType.Elite, FontService.getGradiantBrush(font, 0, lightOrange));
                brushChanger.Add(UnitType.Master, FontService.getGradiantBrush(font, 0, Color.Red));
                return brushChanger;
            } else if(card is StructureCard) {
                return new BrushChangerOneType(FontService.getGradiantBrush(font, 0, lightGreen));
            } else if (card is CasterCard) {
                return new BrushChangerOneType(FontService.getGradiantBrush(font, 0, lightBlue));
            } else if (card is LocationCard) {
                return new BrushChangerOneType(FontService.getGradiantBrush(font, 0, lightGray));
            } else if (card is GearCard) {
                return new BrushChangerOneType(FontService.getGradiantBrush(font, 0, lightGray));
            } else if (card is BlessingCard) {
                return new BrushChangerOneType(FontService.getGradiantBrush(font, 0, Color.Red));
            } else {
                throw new NotSupportedException();
            }
        }

        public static ColorBlend getInterpolationGradientColors(Color color) {
            float factor = 0.5f;
            Color lighterColor = Color.FromArgb(255, lighten(color.R, factor), lighten(color.G, factor), lighten(color.B, factor));
            ColorBlend cb = new ColorBlend();
            cb.Positions = new[] { 0, 3 / 16f, 6 / 16f, 10 / 16f, 1 };
            cb.Colors = new[] { lighterColor, lighterColor, color, lighterColor, lighterColor };
            return cb;
        }

        private static int lighten(float color, float factor) {
            return (int)((255 - color) * factor + color);
        }

        public static LinearGradientBrush getGradiantBrush(Font font, int offset) {
            return getGradiantBrush(font, offset, Color.FromArgb(255, 180, 180, 180));
        }
    }
}
