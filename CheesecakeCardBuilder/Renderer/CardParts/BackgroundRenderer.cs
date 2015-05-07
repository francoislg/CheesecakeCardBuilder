using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder.Renderer.CardParts {
    using Config;
    using Unit;
    using CardParts;
    using System.Drawing;

    public class BackgroundRenderer : CardPartRenderer {
        private readonly Point POSITION = new Point(0, 542);
        private ProjectConfig config;
        private UnitCard card;
        private ByTypeHandler<ImageRenderer> backgrounds;

        public BackgroundRenderer(ProjectConfig config, UnitCard card) {
            this.config = config;
            this.card = card;
            this.backgrounds = new ByTypeHandler<ImageRenderer>(new ImageRenderer(new Bitmap(config.background1File), POSITION));
            this.backgrounds.Add(UnitType.Advanced, new ImageRenderer(new Bitmap(config.background2File), POSITION));
            this.backgrounds.Add(UnitType.Expert, new ImageRenderer(new Bitmap(config.background3File), POSITION));
            this.backgrounds.Add(UnitType.Elite, new ImageRenderer(new Bitmap(config.background4File), POSITION));
            this.backgrounds.Add(UnitType.Master, new ImageRenderer(new Bitmap(config.background5File), POSITION));
        }

        public void draw(Graphics graphics) {
            graphics.DrawImage(card.art, 0, 0, card.art.Width, card.art.Height);
            backgrounds.Get(card.type).draw(graphics);
        }
    }
}
