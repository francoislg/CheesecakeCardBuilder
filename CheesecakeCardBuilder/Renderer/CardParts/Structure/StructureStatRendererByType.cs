using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder.Renderer.CardParts.Structure {
    using CheesecakeCardBuilder.Config;
    using CheesecakeCardBuilder.Renderer.Text;
    using CheesecakeCardBuilder.Structure;
    using System.Drawing;
    public class StructureStatRendererByType : CardPartRenderer {
        private static readonly Rectangle POSITION = new Rectangle(545, 205, 220, 200);
        private ProjectConfig config;
        private StructureCard card;
        private TextRenderer renderer;
        private ByTypeHandler<StructureType, CardPartRenderer> rendererByStructureType;
        public StructureStatRendererByType(ProjectConfig config, StructureCard card) {
            this.config = config;
            this.card = card;
            Font font = config.nameFont;
            Brush brush = FontService.getGradiantBrush(font, 14, FontService.lightGreen);
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            this.renderer = new CardBoxedTextRenderer() { box = POSITION, format = format, font = font, brush = brush };
            this.renderer.addEffect(new OutlineBoxedTextRenderer(font, POSITION, format, new Pen(Color.Gray, 8f)));
            this.renderer.addEffect(new FuzzyBoxedTextRenderer(font, new Rectangle(POSITION.X + 2, POSITION.Y + 2, POSITION.Width, POSITION.Height), format));
            rendererByStructureType = new ByTypeHandler<StructureType, CardPartRenderer>();
            rendererByStructureType.Add(StructureType.Production, new ProductionCardPartRenderer(config, card));
            rendererByStructureType.Add(StructureType.Transport, new TransportCardPartRenderer());
            rendererByStructureType.Add(StructureType.Storage, new StorageCardPartRenderer(config, card));
        }

        public void draw(Graphics graphics) {
            renderer.draw(graphics, card.structureType.ToString());
            rendererByStructureType.Get(card.structureType).draw(graphics);
        }
    }
}
