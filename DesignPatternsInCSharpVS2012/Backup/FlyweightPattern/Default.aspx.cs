using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace FlyweightPattern
{
    public partial class _Default : System.Web.UI.Page
    {
        private string[] names = new string[] { "Student A", "Student B", "Student C" };
        private string[] addresses = new string[] { "Address 1", "Address 2" };
        private Bitmap[] photos = new Bitmap[] { Images.i1, Images.i2, Images.i3 };

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                foreach (System.Web.UI.WebControls.Image image in GetIdCards())
                {
                    MainPanel.Controls.Add(image);
                }
            }
        }

        private IList<System.Web.UI.WebControls.Image> GetIdCards()
        {
            IList<System.Web.UI.WebControls.Image> list = new List<System.Web.UI.WebControls.Image>();
            Random random = new Random();

            StudentCard card = new StudentCard();
            card.CollegeName = "College of Advanced Sciences";

            for (int i = 1; i <= 100; i++)
            {
                card.Name = names[random.Next(0, names.Length - 1)];
                card.Address = addresses[random.Next(0, addresses.Length - 1)];
                card.Photo = photos[random.Next(0, photos.Length - 1)];

                list.Add(new System.Web.UI.WebControls.Image() 
                    { 
                        ImageUrl = card.GenerateIdCard() 
                    });
            }

            return list;
        }
    }
}
