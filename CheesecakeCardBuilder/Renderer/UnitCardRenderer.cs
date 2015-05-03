using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder.Renderer {
    using Config;
    using Unit;
    using Renderer.CardParts;
    using System.Drawing.Drawing2D;
    using System.Windows.Forms;
    public class UnitCardRenderer {
        private UnitCard unitCard;
        private Image template;
        private readonly List<CardPartRenderer> renderers = new List<CardPartRenderer>();

        public UnitCardRenderer(UnitCard unitCard, ProjectConfig config) {
            this.unitCard = unitCard;
            this.template = new Bitmap(config.getUnitPath());
            StatRendererFactory statRendererFactory = new StatRendererFactory(config, unitCard);
            renderers.Add(statRendererFactory.create(StatTypes.Atk));
            renderers.Add(statRendererFactory.create(StatTypes.Def));
            renderers.Add(statRendererFactory.create(StatTypes.Spd));
            renderers.Add(statRendererFactory.create(StatTypes.Acc));
            renderers.Add(statRendererFactory.create(StatTypes.Hp));
            renderers.Add(statRendererFactory.create(StatTypes.Res));
            renderers.Add(statRendererFactory.create(StatTypes.Name));
            renderers.Add(statRendererFactory.create(StatTypes.Description));
        }

        public Image generate() {
            Image image = (Image)template.Clone();
            using (Graphics graphics = Graphics.FromImage(image)) {
                renderers.ForEach(renderer => renderer.draw(graphics));
            }
            return image;
        }
    }
}
