﻿
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder.Renderer.CardParts.Stat {
    using System;
    using System.Drawing;
    using Config;
    using Unit;

    public class SpdStatRenderer : StatRenderer {
        private static readonly Point DEFAULTPOSITION = new Point(715, 670);
        private UnitCard card;

        public SpdStatRenderer(ProjectConfig config, UnitCard card)
            : base(config, DEFAULTPOSITION) {
            this.card = card;
            this.font = config.statsFont;
            this.brush = FontService.getGradiantBrush(font, 0);
        }

        protected override void update(Graphics graphics) {
            this.toDraw = card.spd;
        }
    }
}
