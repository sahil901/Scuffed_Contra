using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Scuffed_Contra
{
    public class character
    {
        public int x, y, width, length, health;
        public SolidBrush sb;

        public character(SolidBrush _sb, int _x, int _y, int _width, int _length, int _health)
        {
            sb = _sb;
            x = _x;
            y = _y;
            width = _width;
            length = _length;
            health = _health;
        }

        public void Move(string direction, int joeSpeed)
        {
            if (direction == "left")
            {
                x -= joeSpeed;
            }
            if (direction == "right")
            {
                x += joeSpeed;
            }
        }

        public void Jump(int vSpeed, int dSpeed)
        {
            if(vSpeed > 0)
            {
                y -= vSpeed;
            }

            if (dSpeed > 0)
            {
                y += dSpeed;
            }
        }

        public void Shoot(string direction, int bSpeed)
        {
            if (direction == "right")
            {
                x += bSpeed; 
            }

            if(direction == "left")
                {
                x -= bSpeed;
                }
        }
    }
}
