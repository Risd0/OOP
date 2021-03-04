using System;

namespace OOP9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Room.UselessMethod());

            double square = Room.maxSquare;
            double height = -5.65;
            int windowsAmount = Room.maxWindows;

            var room = new Room() { Square = square };
            room.WindowsCount = windowsAmount;

            try
            {
                room.Height = height;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("What a pity! Here's error!\nMore info:\nMessage: {0}\nSource: {1}\nMethod: {2}\n", ex.Message, 
                    ex.Source, ex.TargetSite);
            }

            Console.WriteLine(room.Condition);
        }
    }
}
