
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

    public class UnitCardRenderer {
        private UnitCard unitCard;
        private Image template;
        private readonly List<CardPartRenderer> renderers = new List<CardPartRenderer>();

        public UnitCardRenderer(UnitCard unitCard, ProjectConfig config) {
            this.unitCard = unitCard;
            this.template = new Bitmap(config.unitFile);
            CardPartRendererFactory statRendererFactory = new CardPartRendererFactory(config, unitCard);
            renderers.Add(statRendererFactory.create(PartType.Atk));
            renderers.Add(statRendererFactory.create(PartType.Def));
            renderers.Add(statRendererFactory.create(PartType.Spd));
            renderers.Add(statRendererFactory.create(PartType.Acc));
            renderers.Add(statRendererFactory.create(PartType.Hp));
            renderers.Add(statRendererFactory.create(PartType.Res));
            renderers.Add(statRendererFactory.create(PartType.Name));
            renderers.Add(statRendererFactory.create(PartType.Description));
        }

        public Image generate() {
            Image card = new Bitmap(template);
            using (Graphics graphics = Graphics.FromImage(card)) {
                graphics.TextRenderingHint = TextRenderingHint.AntiAlias;
                graphics.InterpolationMode = InterpolationMode.High;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                renderers.ForEach(renderer => renderer.draw(graphics));
            }
            return card;
        }
    }
}
