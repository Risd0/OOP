using System;
using System.Collections.Generic;
using System.Text;

namespace OOP9
{
    class Room
    {
        public const double maxSquare = 1e5;
        public const double maxHeight = 20;
        public const int maxWindows = 1000;

        private double square;
        private double height;
        private int windowsCount;

        public double Square
        {
            get => square;

            set
            {
                if (value >= 0 && value <= maxSquare)
                {
                    square = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Invalid value! The value must be not negative and no more " + maxSquare);
                }
            }
        }

        public double Height
        {
            get => height;
            set
            {
                if (value >= 0 && value <= maxHeight)
                    height = value;
                else
                {
                    throw new ArgumentOutOfRangeException("Invalid value! The value must be not negative and no more " + maxHeight);
                }
            }
        }
        public int WindowsCount
        {
            get => windowsCount;
            set
            {
                if (value >= 0 && value <= maxWindows)
                    windowsCount = value;
                else
                {
                    throw new ArgumentOutOfRangeException("Invalid value! The value must be not negative and no more " + maxWindows);
                }
            }
        }
        public string Condition { get => @$"{this} info:
square: {Square}
height: {Height}
volume: {Square * Height}
The number of windows: {WindowsCount}"; }

        public Room() : this(default, default, default) { }
        public Room(double square) : this(square, default, 0) { }
        public Room(double square, double height) : this(square, height, 0) { }
        public Room(double square, double height, int windowsNumber)
        {
            Square = square;
            Height = height;
            WindowsCount = windowsNumber;
        }

        public void SquareCompute(double length, double width) => Square = length * width;
        public double Volume(double length, double width) => Square * Height;

        public static string UselessMethod() => "Only just static and don't tell anything useful";
    }
}
