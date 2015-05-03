﻿
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder.Renderer.CardParts {
    using System;
    using System.Drawing;
    using Config;
    using Unit;

    public class NameRenderer : DefaultStatRenderer {
        private static readonly Rectangle DEFAULTPOSITION = new Rectangle(170, 452, 450, 200);
        private UnitCard card;

        public NameRenderer(ProjectConfig config, UnitCard card)
            : base(config, DEFAULTPOSITION) {
            this.card = card;
            this.font = new Font(config.nameFont, config.nameFontSize, FontStyle.Regular);
            this.brush = FontService.getGradiantBrush(font, 30);
        }

        protected override void update(Graphics graphics) {
            this.toDraw = card.name;
        }
    }
}
