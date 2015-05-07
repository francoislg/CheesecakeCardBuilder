
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder.Renderer.CardParts.Stat {
    using System;
    using System.Drawing;
    using Config;
    using Unit;

    public class ResStatRenderer : CardPartRenderer {
        private static readonly Point POSITION = new Point(655, 95);
        private static readonly Point ICONPOSITION = new Point(604, 82);
        private ProjectConfig config;
        private UnitCard card;
        private CardTextRenderer renderer;
        private ImageRenderer iconRenderer;
        private BrushChangerByType brushChanger;

        public ResStatRenderer(ProjectConfig config, UnitCard card) {
            this.config = config;
            this.card = card;
            this.iconRenderer = new ImageRenderer(new Bitmap(config.iconResFile), ICONPOSITION);
            this.renderer = new CardTextRenderer() { brush = new SolidBrush(Color.Black), font = config.topStatsFont, position = POSITION };
            this.renderer.addDefaultEffects();
            this.brushChanger = new BrushChangerByType(card, renderer);
            this.brushChanger.Add(UnitType.Standard, new SolidBrush(Color.Black));
            this.brushChanger.Add(UnitType.Advanced, new SolidBrush(Color.Turquoise));
            this.brushChanger.Add(UnitType.Expert, new SolidBrush(Color.LightGreen));
            this.brushChanger.Add(UnitType.Elite, new SolidBrush(Color.FromArgb(255, 252, 153, 49)));
            this.brushChanger.Add(UnitType.Master, new SolidBrush(Color.FromArgb(255, 154, 51, 254)));
        }

        public void draw(Graphics graphics) {
            brushChanger.update();
            iconRenderer.draw(graphics);
            renderer.draw(graphics, card.res);
        }
    }
}
