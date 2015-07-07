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
    using System.IO;
    using CheesecakeCardBuilder.Structure;

    public class DefaultBackgroundRenderer : CardPartRenderer {
        private readonly Point POSITION = new Point(0, 542);
        private ProjectConfig config;
        private Card card;
        private ImageRenderer background;
        private String lastArt;
        private Image art;

        public DefaultBackgroundRenderer(ProjectConfig config, Card card) {
            this.config = config;
            this.card = card;
            this.lastArt = card.artFile;
            string backgroundFile = config.background1File;
            if (card is StructureCard) {
                backgroundFile = config.background3File;
            }
            updateArt();
            this.background = new ImageRenderer(new Bitmap(config.background3File), POSITION);
        }

        private void updateArt() {
            String fullpath = config.cardsArtPath + "\\" + card.artFile;
            if (!File.Exists(fullpath)) {
                fullpath = config.cardsArtPath + "\\template.png";
            }
            art = new Bitmap(fullpath);
        }

        public void draw(Graphics graphics) {
            if (card.artFile != lastArt) {
                updateArt();
            }
            graphics.DrawImage(art, 0, 0, art.Width, art.Height);
            background.draw(graphics);
        }
    }
}
