
namespace CheesecakeCardBuilder.Renderer {
    using Config;
    using Unit;
    using Renderer.CardParts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Drawing;
    using System.Text;
    using System.Threading.Tasks;
    using System.Drawing.Imaging;
    using System.Drawing.Text;
    using System.Drawing.Drawing2D;
    using System.Windows.Forms;
    using CheesecakeCardBuilder.Renderer.CardParts.Gear;

    public class GearCardRenderer : CardRenderer {
        private GearCard gearCard;
        private Image template;
        private readonly List<CardPartRenderer> renderers = new List<CardPartRenderer>();

        public GearCardRenderer(GearCard card, ProjectConfig config) {
            this.gearCard = card;
            this.template = new Bitmap(config.unitFile);
            GearCardPartRendererFactory cardPartRendererFactory = new GearCardPartRendererFactory(config, gearCard);
            renderers.Add(cardPartRendererFactory.create(PartType.Background));
            renderers.Add(cardPartRendererFactory.create(PartType.Name));
            renderers.Add(cardPartRendererFactory.create(PartType.Description));
            renderers.Add(cardPartRendererFactory.create(GearPartType.Res));
            renderers.Add(cardPartRendererFactory.create(GearPartType.Atk));
            renderers.Add(cardPartRendererFactory.create(GearPartType.Def));
        }

        public async Task<Image> generate() {
            return await Task.Run<Image>(() => drawOnCard(template));
        }

        private Image drawOnCard(Image template) {
            lock (template) {
                Image card = new Bitmap(template.Width, template.Height, template.PixelFormat);
                using (Graphics graphics = Graphics.FromImage(card)) {
                    graphics.TextRenderingHint = TextRenderingHint.AntiAlias;
                    graphics.InterpolationMode = InterpolationMode.High;
                    graphics.CompositingQuality = CompositingQuality.HighQuality;
                    graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    renderers.ForEach(renderer => renderer.draw(graphics));
                    graphics.DrawImage(template, 0, 0, template.Width, template.Height);
                }
                return card;
            }
        }
    }
}
