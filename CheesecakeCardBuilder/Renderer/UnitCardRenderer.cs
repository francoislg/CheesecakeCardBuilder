
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
    using CheesecakeCardBuilder.Renderer.CardParts.Unit;

    public class UnitCardRenderer : CardRenderer {
        private UnitCard unitCard;
        private Image template;
        private readonly List<CardPartRenderer> renderers = new List<CardPartRenderer>();

        public UnitCardRenderer(UnitCard card, ProjectConfig config) {
            this.unitCard = card;
            this.template = new Bitmap(config.unitFile);
            UnitCardPartRendererFactory statRendererFactory = new UnitCardPartRendererFactory(config, unitCard);
            renderers.Add(statRendererFactory.create(UnitPartType.Background));
            renderers.Add(statRendererFactory.create(UnitPartType.Atk));
            renderers.Add(statRendererFactory.create(UnitPartType.Def));
            renderers.Add(statRendererFactory.create(UnitPartType.Spd));
            renderers.Add(statRendererFactory.create(UnitPartType.Acc));
            renderers.Add(statRendererFactory.create(UnitPartType.Type));
            renderers.Add(statRendererFactory.create(UnitPartType.Hp));
            renderers.Add(statRendererFactory.create(UnitPartType.Res));
            renderers.Add(statRendererFactory.create(PartType.Name));
            renderers.Add(statRendererFactory.create(PartType.Description));
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
