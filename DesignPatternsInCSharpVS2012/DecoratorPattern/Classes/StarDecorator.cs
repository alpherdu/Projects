using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace DecoratorPattern.Classes
{
    public class StarDecorator : AlbumDecorator
    {
        public StarDecorator(Album album)
            : base(album)
        {
            Graphics = album.Graphics;
        }

        public override void Draw()
        {
            _album.Draw();
            this.InternalDraw();
        }

        private void InternalDraw()
        {
            _album.Graphics.DrawImage(Images.Star, new Point(7, 4));
            _album.Graphics.DrawImage(Images.Star, new Point(156, 55));
            _album.Graphics.DrawImage(Images.Star, new Point(164, 192));
            _album.Graphics.DrawImage(Images.Star, new Point(190, 345));
            _album.Graphics.DrawImage(Images.Star, new Point(369, 362));
            _album.Graphics.DrawImage(Images.Star, new Point(504, 360));
        }
    }
}
