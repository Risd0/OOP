using System;

namespace OOP14
{
    public enum Sex
    {
        Male,
        Female
    }

    [Serializable]
    public class Dog : IComparable<Dog>
    {
        // fields
        [NonSerialized]
        private int id;
        private string breed;
        private Sex sex;
        private float price;
        private float age;

        // properties
        public int ID { get => id; set => id = value; }
        public string Breed { get => breed; set => breed = value; }
        public float Price
        {
            get => price;
            set
            {
                if (value < 0) { throw new ArgumentOutOfRangeException("Price can't be a negative number!"); }
                else { price = (this.Sex == Sex.Female && this.Age == 2) ? value * 1.25f : value; }
            }
        }
        public float Age
        {
            get => age;
            set
            {
                if (value >= 0 && value < 40) { age = value; }
                else { throw new ArgumentOutOfRangeException("No one dog can have a lifetime of less than 0 or 40 and more years!"); }
            }
        }
        public Sex Sex { get => sex; set => sex = value; }

        // constructors
        public Dog() : this(0, "Not Detected", 0, 0) { }
        public Dog(int id, string breed, float price, float age, Sex sex = Sex.Male)
        {
            ID = id;
            Breed = breed;
            Sex = sex;
            Price = price;
            Age = age;
        }

        public int CompareTo(Dog other)
        {
            if (this.ID > other.ID) { return 1; }
            else if (this.ID < other.ID) { return -1; }
            else { return 0; }
        }

        public override string ToString() => $"ID: {this.id}; Breed: {this.Breed}; Price: {this.Price}; Age: {this.Age}; Sex: {this.Sex}";
    }
}