using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP9_WindowsForms
{

    class Room
    {
        public const double maxSquare = 1e5;
        public const double maxHeight = 20;
        public const int maxWindows = 1000;

        private double square;
        private double height;
        private uint windowsCount;

        public double Square
        {
            get => square;

            set
            {
                if (value > 0 && value <= maxSquare)
                {
                    square = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Invalid value! The square value must be not negative and no more " + maxSquare);
                }
            }
        }

        public double Height
        {
            get => height;
            set
            {
                if (value > 0 && value <= maxHeight) { height = value; }
                else
                {
                    throw new ArgumentOutOfRangeException("Invalid height value! The value must be not negative and no more " + maxHeight);
                }
            }
        }
        public uint WindowsCount
        {
            get => windowsCount;
            set
            {
                if (value >= 0 && value <= maxWindows) { windowsCount = value; }
                else
                {
                    throw new ArgumentOutOfRangeException("Invalid value! The windows number must be not negative and no more " + maxWindows);
                }
            }
        }
        public string Condition { get => $@"{this} info:
square: {Square}
height: {Height}
volume: {Square * Height}
The number of windows: {WindowsCount}"; }

        public Room() : this(1, 1, 0) { }
        public Room(double square) : this(square, 1, 0) { }
        public Room(double square, double height) : this(square, height, 0) { }
        public Room(double square, double height, uint windowsNumber)
        {
            Square = square;
            Height = height;
            WindowsCount = windowsNumber;
        }

        public void SquareCompute(double length, double width) => Square = length * width;
        public double Volume() => Square * Height;

        public static string UselessMethod() => "Only just static and don't tell anything useful";
    }
}
