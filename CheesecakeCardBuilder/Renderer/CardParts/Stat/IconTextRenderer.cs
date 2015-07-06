using CheesecakeCardBuilder.Config;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesecakeCardBuilder.Renderer.CardParts.Stat {
    public enum CardPosition {
        TopLeft, TopRight, BottomLeft, BottomRight, HP, Resources
    }

    public class IconTextRenderer {
        private static readonly Point BOTTOMLEFT = new Point(70, 975);
        private static readonly Point TOPLEFT = new Point(70, 700);
        private static readonly Point BOTTOMRIGHT = new Point(715, 975);
        private static readonly Point TOPRIGHT = new Point(715, 700);
        private static readonly Point HPPOSITION = new Point(125, 95);
        private static readonly Point HPICONPOSITION = new Point(73, 82);
        private static readonly Point RESPOSITION = new Point(655, 95);
        private static readonly Point RESICONPOSITION = new Point(604, 82);

        private Point position;
        private Point iconPosition;
        public ImageRenderer iconRenderer;
        public CardTextRenderer renderer;
        public BrushChangerByType brushChanger;

        public IconTextRenderer(CardPosition cardPosition, Card card, Font font, string iconFilename) {
            this.position = getPosition(cardPosition);
            Bitmap bitmap = new Bitmap(iconFilename);
            this.iconPosition = getIconPosition(cardPosition, position, bitmap.Size);
            this.iconRenderer = new ImageRenderer(bitmap, iconPosition);
            int gradientOffset = 28;
            if (cardPosition == CardPosition.TopLeft || cardPosition == CardPosition.TopRight) {
                gradientOffset = 0;
            }
            this.renderer = new CardTextRenderer() { brush = FontService.getGradiantBrush(font, gradientOffset), font = font, position = position };
            this.brushChanger = FontService.getDefaultGradientBrushChangerByType(font, card);
        }

        public static Point getIconPosition(CardPosition cardPosition, Point position, Size bitmapSize) {
            switch (cardPosition) {
                case CardPosition.HP:
                    return HPICONPOSITION;
                case CardPosition.Resources:
                    return RESICONPOSITION;
                default:
                    return new Point(position.X - bitmapSize.Width / 2, position.Y - bitmapSize.Height - 20);
            }
        }

        public static Point getPosition(CardPosition position) {
            switch (position) {
                case CardPosition.HP:
                    return HPPOSITION;
                case CardPosition.Resources:
                    return RESPOSITION;
                case CardPosition.BottomLeft:
                    return BOTTOMLEFT;
                case CardPosition.TopLeft:
                    return TOPLEFT;
                case CardPosition.BottomRight:
                    return BOTTOMRIGHT;
                case CardPosition.TopRight:
                    return TOPRIGHT;
                default:
                    throw new NotSupportedException();
            }
        }

        public void draw(Graphics graphics, string toDraw) {
            brushChanger.update(renderer);
            iconRenderer.draw(graphics);
            renderer.draw(graphics, toDraw);
        }
    }
}
