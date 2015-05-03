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
        private readonly CardPartRenderer atkStat, defStat, spdStat, accStat, hpStat, resStat, nameRenderer, descriptionsRenderer;

        public UnitCardRenderer(UnitCard unitCard, ProjectConfig config) {
            this.unitCard = unitCard;
            this.template = new Bitmap(config.getUnitPath());
            this.atkStat = new AtkStatRenderer(config, unitCard);
            this.defStat = new DefStatRenderer(config, unitCard);
            this.spdStat = new SpdStatRenderer(config, unitCard);
            this.accStat = new AccStatRenderer(config, unitCard);
            this.hpStat = new HPStatRenderer(config, unitCard);
            this.resStat = new ResStatRenderer(config, unitCard);
            this.nameRenderer = new NameRenderer(config, unitCard);
            this.descriptionsRenderer = new DescriptionsRenderer(config, unitCard);
        }

        public Image generate() {
            Image image = (Image)template.Clone();
            using (Graphics graphics = Graphics.FromImage(image)) {
                hpStat.draw(graphics);
                resStat.draw(graphics);
                atkStat.draw(graphics);
                defStat.draw(graphics);
                spdStat.draw(graphics);
                accStat.draw(graphics);
                nameRenderer.draw(graphics);
                descriptionsRenderer.draw(graphics);
            }
            return image;
        }
    }
}
