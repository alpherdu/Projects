using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace DecoratorPattern.Classes
{
    public class SantaClausDecorator : AlbumDecorator
    {
        public SantaClausDecorator(Album album)
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
            _album.Graphics.DrawImage(Images.SantaClaus, new Point(230, 20));
        }
    }
}
