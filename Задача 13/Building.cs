using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_13
{
    class Building
    {
        int address;
        int length;
        int width;
        int height;

        int Address
        {
            get
            {
                return address;
            }
            set
            {
                if (value > 500)
                    address = 500;
                else if (value < 1)
                    address = 1;
                else
                    address = value;
            }
        }

        int Length
        {
            get
            {
                return length;
            }
            set
            {
                if (value > 1000)
                    length = 1000;
                else if (value < 2)
                    length = 2;
                else
                    length = value;
            }
        }

        int Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value > 350)
                    width = 350;
                else if (value < 3)
                    width = 3;
                else
                    width = value;
            }
        }

        int Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value > 1500)
                    height = 1500;
                else if (value < 100)
                    height = 100;
                else
                    height = value;
            }
        }


                public Building(int address, int length, int width, int height)
        {
            this.Address = address;
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }
        public string Print()
        {
            return $"{address} {length} {width} {height}";
        }
    }
}
