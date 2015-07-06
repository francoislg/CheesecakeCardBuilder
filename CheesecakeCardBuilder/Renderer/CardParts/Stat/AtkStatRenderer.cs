
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder.Renderer.CardParts.Stat {
    using System;
    using System.Drawing;
    using Config;
    using CheesecakeCardBuilder.Unit;
    using System.Drawing.Drawing2D;

    public class AtkStatRenderer : CardPartRenderer {
        private static readonly Point POSITION = new Point(70, 700);
        private static readonly Point ICONPOSITION = new Point(POSITION.X - 60, POSITION.Y - 135);
        private ProjectConfig config;
        private UnitCard card;
        private CardTextRenderer renderer;
        private ImageRenderer iconRenderer;
        private BrushChangerByUnitType brushChanger;

        public AtkStatRenderer(ProjectConfig config, UnitCard card) {
            this.config = config;
            this.card = card;
            Font font = config.statsFont;
            this.iconRenderer = new ImageRenderer(new Bitmap(config.iconAtkFile), ICONPOSITION);
            this.renderer = new CardTextRenderer() { brush = FontService.getGradiantBrush(config.statsFont, 0), font = font, position = POSITION };
            this.renderer.addDefaultEffects();
            this.brushChanger = FontService.getDefaultGradientBrushChangerByType(font, card);
        }

        public void draw(Graphics graphics) {
            brushChanger.update(renderer);
            iconRenderer.draw(graphics);
            renderer.draw(graphics, card.atk);
        }
    }
}
