using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_18
{
    class Colors
    {
        private uint red;
        private uint green;
        private uint blue;
        private uint alpha;

        public Colors(uint red, uint green, uint blue, uint alpha)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;
        }

        public Colors(uint red, uint green, uint blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = 255;
        }

        public uint getRed()
        {
            return this.red;
        }

        public uint getBlue()
        {
            return this.blue;
        }

        public uint getGreen()
        {
            return this.green;
        }

        public uint getAlpha()
        {
            return this.alpha;
        }

        public void SetRed(uint newValue)
        {
            this.red = newValue;
        }

        public void SetBlue(uint newValue)
        {
            this.blue = newValue;
        }

        public void SetGreen(uint newValue)
        {
            this.green = newValue;
        }

        public void SetAlpha(uint newValue)
        {
            this.alpha = newValue;
        }

        public uint GetGrayscale()
        {
            return (red + blue + green) / 3;
        }
        }
}






