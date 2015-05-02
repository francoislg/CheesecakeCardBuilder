using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder.Unit {
    using Config;
    using System.Drawing.Drawing2D;
    using System.Windows.Forms;
    public class UnitCardRenderer {
        private UnitCard unitCard;
        private Image template;
        private Font topStatsFont;
        private Font statsFont;
        private Font descriptionFont;
        private Font nameFont;
        private Brush hpStatsBrush;
        private Brush brush;
        private Brush statsBrush;
        private Brush bottomStatsBrush;
        private StringFormat format;
        private readonly Rectangle nameSquare = new Rectangle(170, 452, 450, 200);
        private readonly Point hpPosition = new Point(125, 95);
        private readonly Point resPosition = new Point(655, 95);
        private readonly Point atkPosition = new Point(70, 670);
        private readonly Point defPosition = new Point(70, 960);
        private readonly Point spdPosition = new Point(715, 670);
        private readonly Point accPosition = new Point(715, 960);
        private readonly Rectangle descSquare = new Rectangle(165, 560, 450, 520);

        public UnitCardRenderer(UnitCard unitCard, ProjectConfig config) {
            this.unitCard = unitCard;
            this.template = new Bitmap(config.getUnitPath());
            this.topStatsFont = new Font(config.topStatsFont, config.topStatsFontSize, FontStyle.Regular);
            this.statsFont = new Font(config.statsFont, config.statsFontSize, FontStyle.Regular);
            this.descriptionFont = new Font(config.descriptionFont, config.descriptionFontSize, FontStyle.Regular);
            this.nameFont = new Font(config.nameFont, config.nameFontSize, FontStyle.Regular);
            this.brush = new SolidBrush(Color.Black);
            this.hpStatsBrush = new SolidBrush(Color.Green);
            this.statsBrush = createLinearGradiantBrush(0);
            this.bottomStatsBrush = createLinearGradiantBrush(30);
            this.format = new StringFormat();
            this.format.Alignment = StringAlignment.Center;
        }

        private LinearGradientBrush createLinearGradiantBrush(int offset) {
            ColorBlend cb = new ColorBlend();
            cb.Positions = new[] { 0, 5 / 16f, 8 / 16f, 13 / 16f, 1 };
            cb.Colors = new[] { Color.White, Color.White, Color.Gray, Color.White, Color.White };
            LinearGradientBrush linearGradiant = new LinearGradientBrush(new Rectangle(0, offset, 20, (int)statsFont.GetHeight() * 2), Color.White, Color.White, 90f);
            linearGradiant.InterpolationColors = cb;
            return linearGradiant;
        }

        public Image generate() {
            Image image = (Image)template.Clone();
            int currentDescPosition = 0;
            using (Graphics graphics = Graphics.FromImage(image)) {
                graphics.DrawString(unitCard.name, nameFont, brush, nameSquare, format);
                graphics.DrawString(unitCard.hp, statsFont, hpStatsBrush, hpPosition, format);
                graphics.DrawString(unitCard.res, statsFont, brush, resPosition, format);
                graphics.DrawString(unitCard.atk, statsFont, statsBrush, atkPosition, format);
                graphics.DrawString(unitCard.def, statsFont, bottomStatsBrush, defPosition, format);
                graphics.DrawString(unitCard.spd, statsFont, statsBrush, spdPosition, format);
                graphics.DrawString(unitCard.acc, statsFont, bottomStatsBrush, accPosition, format);
                foreach(UnitDescription unitDescription in unitCard.descriptions){
                    String description = unitDescription.description;
                    graphics.DrawString(description, descriptionFont, brush, new Rectangle(descSquare.X, descSquare.Y + currentDescPosition, descSquare.Width, descSquare.Height - currentDescPosition));
                    currentDescPosition += (int)graphics.MeasureString(description, descriptionFont, descSquare.Size, format).Height;
                }
            }
            return image;
        }
    }
}
