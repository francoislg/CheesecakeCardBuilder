
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
        private ProjectConfig config;
        private UnitCard card;
        private IconTextRenderer iconTextRenderer;

        public HPStatRenderer(ProjectConfig config, UnitCard card) {
            this.config = config;
            this.card = card;
            Brush defaultBrush = new SolidBrush(Color.FromArgb(255, 99, 255, 99));
            BrushChangerByUnitType brushChanger = new BrushChangerByUnitType(card, defaultBrush);
            brushChanger.Add(UnitType.Master, new SolidBrush(Color.Red));
            this.iconTextRenderer = new IconTextRenderer(CardPosition.HP, card, config.topStatsFont, config.iconHPFile) { 
                brushChanger = brushChanger
            };
            this.iconTextRenderer.renderer.addDefaultEffects();
        }

        public void draw(Graphics graphics) {
            iconTextRenderer.draw(graphics, card.hp);
        }
    }
}
