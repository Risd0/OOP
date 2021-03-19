using System;
using System.Collections;

namespace OOP12
{
    class Program
    {
        static void Main(string[] args)
        {
            FunWithMyStringArr();
            FunWithBitStringArr();
        }

        static void FunWithMyStringArr()
        {
            System.Console.WriteLine("******************************** Fun with MyString Arr ********************************");
            MyString[] strings = new MyString[8];
            strings[0] = new MyString("Ichigo");
            strings[1] = new MyString("Urahara");
            strings[2] = new MyString("Ulquiorra");
            strings[3] = new MyString("Zangetsu");
            strings[4] = (MyString)strings[0].Clone();
            strings[5] = (MyString)strings[1].Clone();
            strings[6] = (MyString)strings[2].Clone();
            strings[7] = (MyString)strings[3].Clone();
            strings[4].Str = "Rangiku";
            strings[5].Str = "Aizen";
            strings[6].Str = "Byakuya";
            strings[7].Str = "Harribel";

            try
            {
                Array.Sort<MyString>(strings);
            }
            catch (System.InvalidOperationException ex)
            {
                System.Console.WriteLine(ex.Message);
            }
            catch { System.Console.WriteLine("Something bad happened!"); }

            foreach (var item in strings)
            {
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine($"Shuffled strings[2] = {strings[5].Shuffle()}");
            System.Console.WriteLine();
        }
        static void FunWithBitStringArr()
        {
            System.Console.WriteLine("******************************** Fun with BitString Arr ********************************");
            BitString[] bitStrings = new BitString[5];
            bitStrings[0] = new BitString("-0110110");
            bitStrings[1] = new BitString("-101");
            bitStrings[2] = new BitString("1001");
            bitStrings[3] = (BitString)bitStrings[2].Clone();
            bitStrings[3].Str = "11111";
            bitStrings[4] = (BitString)bitStrings[0].Clone();
            bitStrings[4].Str = "+110101";

            Array.Sort<BitString>(bitStrings);
            foreach (var item in bitStrings)
            {
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine("Shuffle bitStrings[2]: {0}", bitStrings[2].Shuffle());
        }
    }
}
