﻿
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder.Renderer.CardParts.Unit {
    using System;
    using System.Drawing;
    using Config;
    using CheesecakeCardBuilder.Unit;
    using Text;

    public class UnitTypeRenderer : CardPartRenderer {
        private static readonly Rectangle POSITION = new Rectangle(555, 205, 200, 200);
        private ProjectConfig config;
        private UnitCard card;
        private TextRenderer renderer;
        private BrushChangerByType brushChanger;

        public UnitTypeRenderer(ProjectConfig config, UnitCard card) {
            this.config = config;
            this.card = card;
            Font font = config.nameFont;
            Brush brush = FontService.getGradiantBrush(font, 14);
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            this.renderer = new CardBoxedTextRenderer() { box = POSITION, format = format, font = font, brush =brush };
            this.renderer.addEffect(new OutlineBoxedTextRenderer(font, POSITION, format, new Pen(Color.Gray, 8f)));
            this.renderer.addEffect(new FuzzyBoxedTextRenderer(font, new Rectangle(POSITION.X + 2, POSITION.Y + 2, POSITION.Width, POSITION.Height), format));
            this.brushChanger = FontService.getDefaultGradientBrushChangerByType(font, card);
        }

        public void draw(Graphics graphics) {
            brushChanger.update(renderer);
            renderer.draw(graphics, card.unitType.ToString());
        }
    }
}
