using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Food
    {
        public Point Location { get; private set; }

        public void CreatFood()
        {
            Random rnd = new Random(); //soretear número no eixo X e Y
            Location = new Point(rnd.Next(0,27), rnd.Next(0, 27));

        }
    }


}
