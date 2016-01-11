using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_18
{
    class Balls
    {
        double radius;
        Colors color;
        uint throws = 0;

        public Balls(double radius, Colors color)
        {
            this.radius = radius;
            this.color = color;
        }

        public double GetSize()
        {
            return radius;
        }

        public void Pop()
        {
            radius = 0;
        }

        public void Throw()
        {
            if (radius > 0)
            {
                throws += 1;
            }
        }

        public uint ThrowCount()
        {
            return throws;
        }
    }
}
