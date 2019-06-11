using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace _2018_Level2_Dodge
{
    class Planet
    {
        public int x, y, width, height;
        public Image planetImage;

        public Rectangle planetRec;
        public int score;

        public Planet(int spacing)
        {
            x = spacing;
            y = 10;
            width = 20;
            height = 20;
            planetImage = Image.FromFile("planet1.png");
            planetRec = new Rectangle(x, y, width, height);
        }
        public void drawPlanet(Graphics g)
        {
            planetRec = new Rectangle(x, y, width, height);
            g.DrawImage(planetImage, planetRec);
        }
        public void movePlanet()
        {
            y += 5;

            planetRec.Location = new Point(x, y);

            if (planetRec.Location.Y > 400)
            {
                y = 20;
                planetRec.Location = new Point(x, y);
            }

        }


    }
}
