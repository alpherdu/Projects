using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Drawing;

namespace FlyweightPattern
{
    public class StudentCard
    {
        public string Name
        {
            get;
            set;
        }

        public string Address
        {
            get;
            set;
        }

        public string CollegeName
        {
            get;
            set;
        }

        public System.Drawing.Image Photo
        {
            get;
            set;
        }

        private Font _fontBold = new Font("Calibri", 14, FontStyle.Bold);
        private Font _fontBold2 = new Font("Calibri", 12, FontStyle.Bold);
        private Font _fontRegular = new Font("Calibri", 12, FontStyle.Regular);
        private static int _nextId = 1;

        public string GenerateIdCard()
        {
            Bitmap bitmap = new Bitmap(400, 250);
            Graphics graphics = Graphics.FromImage(bitmap);

            Rectangle rectangle = new Rectangle(1, 1, bitmap.Width - 1, bitmap.Height - 1);
           
            graphics.FillRectangle(Brushes.WhiteSmoke, graphics.ClipBounds);
            graphics.DrawRectangle(Pens.Green, rectangle);
            graphics.DrawString(Name, _fontBold, Brushes.Navy, new PointF(120, 40));
            graphics.DrawString(Address, _fontRegular, Brushes.WhiteSmoke, new PointF(120, 70));

            graphics.DrawImage(Photo, new Point(10, 40));

            graphics.FillRectangle(Brushes.PaleGreen, new Rectangle(0, 0, bitmap.Width, 25));
            graphics.DrawString(CollegeName, _fontBold2, Brushes.Black, new PointF(95, 3));

            string filename = "~/cards/card" + _nextId.ToString() + ".bmp";
            bitmap.Save(HttpContext.Current.Server.MapPath(filename));

            _nextId++;

            return filename;
        }
    }
}