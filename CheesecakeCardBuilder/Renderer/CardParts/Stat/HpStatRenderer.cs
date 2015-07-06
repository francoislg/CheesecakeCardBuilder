
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder.Renderer.CardParts.Stat {
    using System;
    using System.Drawing;
    using Config;
    using CheesecakeCardBuilder.Unit;

    public class HPStatRenderer : CardPartRenderer {
        private static readonly Point POSITION = new Point(125, 95);
        private static readonly Point ICONPOSITION = new Point(73, 82);
        private ProjectConfig config;
        private UnitCard card;
        private CardTextRenderer renderer;
        private ImageRenderer iconRenderer;
        private BrushChangerByUnitType brushChanger;

        public HPStatRenderer(ProjectConfig config, UnitCard card) {
            this.config = config;
            this.card = card;
            Font font = config.topStatsFont;
            Brush defaultBrush = new SolidBrush(Color.FromArgb(255, 99, 255, 99));
            this.iconRenderer = new ImageRenderer(new Bitmap(config.iconHPFile), ICONPOSITION);
            this.renderer = new CardTextRenderer() { brush = defaultBrush, font = font, position = POSITION };
            this.renderer.addDefaultEffects();
            this.brushChanger = new BrushChangerByUnitType(card, defaultBrush);
            this.brushChanger.Add(UnitType.Master, new SolidBrush(Color.Red));
        }

        public void draw(Graphics graphics) {
            brushChanger.update(renderer);
            iconRenderer.draw(graphics);
            renderer.draw(graphics, card.hp);
        }
    }
}
