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

    public class BackgroundRenderer : CardPartRenderer {
        private readonly Point POSITION = new Point(0, 542);
        private ProjectConfig config;
        private UnitCard card;
        private ByTypeHandler<ImageRenderer> backgrounds;
        private String lastArt;
        private Image art;

        public BackgroundRenderer(ProjectConfig config, UnitCard card) {
            this.config = config;
            this.card = card;
            this.lastArt = card.artFile;
            updateArt();
            this.backgrounds = new ByTypeHandler<ImageRenderer>(new ImageRenderer(new Bitmap(config.background1File), POSITION));
            this.backgrounds.Add(UnitType.Advanced, new ImageRenderer(new Bitmap(config.background2File), POSITION));
            this.backgrounds.Add(UnitType.Expert, new ImageRenderer(new Bitmap(config.background3File), POSITION));
            this.backgrounds.Add(UnitType.Elite, new ImageRenderer(new Bitmap(config.background4File), POSITION));
            this.backgrounds.Add(UnitType.Master, new ImageRenderer(new Bitmap(config.background5File), POSITION));
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
            backgrounds.Get(card.unitType).draw(graphics);
        }
    }
}
