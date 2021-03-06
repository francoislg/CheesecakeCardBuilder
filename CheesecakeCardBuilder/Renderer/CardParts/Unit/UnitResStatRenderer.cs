﻿
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder.Renderer.CardParts.Stat {
    using System;
    using System.Drawing;
    using Config;
    using CheesecakeCardBuilder.Unit;

    public class UnitResStatRenderer : CardPartRenderer {
        private ProjectConfig config;
        private UnitCard card;
        private CardTextRenderer renderer;
        private BrushChangerByUnitType brushChanger;
        private ByTypeHandler<UnitType, ImageRenderer> iconRenderer;

        public UnitResStatRenderer(ProjectConfig config, UnitCard card) {
            this.config = config;
            this.card = card;
            Bitmap referenceBitmap = new Bitmap(config.iconResFile);
            Point POSITION = IconTextRenderer.getPosition(CardPosition.Resources);
            Point ICONPOSITION = IconTextRenderer.getIconPosition(CardPosition.Resources, POSITION, referenceBitmap.Size);
            this.iconRenderer = new ByTypeHandler<UnitType, ImageRenderer>(new ImageRenderer(referenceBitmap, ICONPOSITION));
            this.iconRenderer.Add(UnitType.Advanced, new ImageRenderer(new Bitmap(config.iconRes2File), ICONPOSITION));
            this.iconRenderer.Add(UnitType.Expert, new ImageRenderer(new Bitmap(config.iconGreenResFile), ICONPOSITION));
            this.iconRenderer.Add(UnitType.Elite, new ImageRenderer(new Bitmap(config.iconRes4File), ICONPOSITION));
            this.iconRenderer.Add(UnitType.Master, new ImageRenderer(new Bitmap(config.iconRes5File), ICONPOSITION));
            this.renderer = new CardTextRenderer() { brush = new SolidBrush(Color.Black), font = config.topStatsFont, position = POSITION };
            this.renderer.addDefaultEffects();
            this.brushChanger = new BrushChangerByUnitType(card);
            this.brushChanger.Add(UnitType.Standard, new SolidBrush(Color.Black));
            this.brushChanger.Add(UnitType.Advanced, new SolidBrush(Color.Turquoise));
            this.brushChanger.Add(UnitType.Expert, new SolidBrush(Color.LightGreen));
            this.brushChanger.Add(UnitType.Elite, new SolidBrush(Color.FromArgb(255, 252, 153, 49)));
            this.brushChanger.Add(UnitType.Master, new SolidBrush(Color.FromArgb(255, 154, 51, 254)));
        }

        public void draw(Graphics graphics) {
            brushChanger.update(renderer);
            iconRenderer.Get(card.unitType).draw(graphics);
            renderer.draw(graphics, card.res);
        }
    }
}
