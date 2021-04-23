using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace OOP14
{
    public static class DogExtension
    {
        public static void SaveToFile(this Dog dog)
        {
            BinaryFormatter binformat = new BinaryFormatter();
            using (FileStream fileStream = new FileStream("zoostore.dat", FileMode.Append, FileAccess.Write))
            {
                binformat.Serialize(fileStream, dog);
            }
        }
        public static Dog LoadFromFile(this Dog dog)
        {
            BinaryFormatter binformat = new BinaryFormatter();
            using (FileStream fileStream = new FileStream("zoostore.dat", FileMode.OpenOrCreate, FileAccess.Read))
            {
                return (Dog)binformat.Deserialize(fileStream);
            }
        }
    }
}