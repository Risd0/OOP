using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace OOP14
{
    class Program
    {
        static void Main(string[] args)
        {
            var dogList = new List<Dog>();
            try
            {
                dogList.Add(new Dog(151, "Boxer", 1000, 1));
                dogList.Add(new Dog(93, "Dachshund", 1100, 2, Sex.Female));
                dogList.Add(new Dog(15, "Beagle", 1100, 0));
                dogList.Add(new Dog(846, "Poodle", 1200, 1, Sex.Female));
                dogList.Add(new Dog(526, "Bulldog", 2000, 5, Sex.Female));
                dogList.Add(new Dog(456, "German Shepherd", 900, 6));
                dogList.Add(new Dog(97, "Labrador Retriever", 1300, 1.3f));
                dogList.Add(new Dog(45, "Rottweiler", 1400, 0.5f));
                dogList.Add(new Dog(145, "Australian Shepherd", 670, 0.5f));
                dogList.Add(new Dog(48, "Basenji", 1800, 2.5f, Sex.Female));
            }
            catch (ArgumentException ex)
            {
                System.Console.WriteLine(ex.Message);
            }
            catch (Exception) { Console.WriteLine("Some error occurred =("); }

            dogList.Sort();

            SaveToFile(dogList.ToArray<Dog>());
            var puppiesFromFile = LoadFromFile();
            foreach (var item in puppiesFromFile)
            {
                System.Console.WriteLine(item);
            }
        }

        public static void SaveToFile(Dog[] dogs)
        {
            BinaryFormatter binformat = new BinaryFormatter();
            using (FileStream fileStream = new FileStream("zoostore.txt", FileMode.Append, FileAccess.Write))
            {
                binformat.Serialize(fileStream, dogs);
            }
        }
        public static Dog[] LoadFromFile()
        {
            BinaryFormatter binformat = new BinaryFormatter();
            using (FileStream fileStream = new FileStream("zoostore.dat", FileMode.OpenOrCreate, FileAccess.Read))
            {
                return (Dog[])binformat.Deserialize(fileStream);
            }
        }
    }
}
