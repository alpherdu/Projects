using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace DecoratorPattern.Classes
{
    public class ChristmasTreeDecorator : AlbumDecorator
    {
        public ChristmasTreeDecorator(Album album)
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
            _album.Graphics.DrawImage(Images.ChristmasTree, new Point(30, 60));
        }
    }
}
