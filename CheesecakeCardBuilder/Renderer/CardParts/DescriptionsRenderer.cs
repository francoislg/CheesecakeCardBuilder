
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder.Renderer.CardParts {
    using System;
    using System.Drawing;
    using Config;
    using Unit;

    public class DescriptionsRenderer : CardPartRenderer, IDisposable {
        private static readonly Rectangle INITIALRECTANGLE = new Rectangle(165, 560, 450, 520);
        private ProjectConfig config;
        private UnitCard card;
        private List<DescriptionRenderer> descriptionRenderers = new List<DescriptionRenderer>();

        public DescriptionsRenderer(ProjectConfig config, UnitCard card) {
            this.config = config;
            this.card = card;
        }

        public void update(Graphics graphics) {
            descriptionRenderers.ForEach(renderer => renderer.Dispose());
            descriptionRenderers.Clear();
            int currentDescPosition = 0;
            foreach (UnitDescription unitDescription in card.descriptions) {
                DescriptionRenderer renderer = new DescriptionRenderer(config, unitDescription, new Rectangle(INITIALRECTANGLE.X, INITIALRECTANGLE.Y + currentDescPosition, INITIALRECTANGLE.Width, INITIALRECTANGLE.Height - currentDescPosition));
                descriptionRenderers.Add(renderer);
                currentDescPosition += (int)renderer.getSizeOfDescription(graphics).Height;
            }
        }

        public void draw(Graphics graphics){
            update(graphics);
            descriptionRenderers.ForEach(renderer => renderer.draw(graphics));
        }

        public void Dispose() {
            descriptionRenderers.ForEach(renderer => renderer.Dispose());
        }
    }
}
