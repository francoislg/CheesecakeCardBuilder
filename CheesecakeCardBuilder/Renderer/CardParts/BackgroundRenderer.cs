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
        private ImageRenderer background1;
        private ImageRenderer background2;
        private ImageRenderer background3;
        private ImageRenderer background4;
        private ImageRenderer background5;

        public BackgroundRenderer(ProjectConfig config, UnitCard card) {
            this.config = config;
            this.card = card;
            this.background1 = new ImageRenderer(new Bitmap(config.background1File), POSITION);
            this.background2 = new ImageRenderer(new Bitmap(config.background2File), POSITION);
            this.background3 = new ImageRenderer(new Bitmap(config.background3File), POSITION);
            this.background4 = new ImageRenderer(new Bitmap(config.background4File), POSITION);
            this.background5 = new ImageRenderer(new Bitmap(config.background5File), POSITION);
        }

        public void draw(Graphics graphics) {
            switch (card.type) {
                case UnitType.Standard:
                    background1.draw(graphics);
                    break;
                case UnitType.Advanced:
                    background2.draw(graphics);
                    break;
                case UnitType.Expert:
                    background3.draw(graphics);
                    break;
                case UnitType.Master:
                    background5.draw(graphics);
                    break;
                default:
                    throw new NotSupportedException();
            }
        }
    }
}
