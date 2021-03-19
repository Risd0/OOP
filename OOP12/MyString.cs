using System;

namespace OOP12
{
    public class MyString : IComparable<MyString>, ICloneable, IDisordered<string>
    {
        protected string str;  // Поле для зберігання символів рядка;
        protected int length;    // Значення типу byte для зберігання довжини рядка в байтах;

        // Метод для отримання довжини рядка;
        public int Length
        {
            get => length;
            private set
            {
                length = UtilityClass.Clamp(0, byte.MaxValue, value);
            }
        }

        public string Str { get => str; set => str = value; }

        public MyString()
        {
            Str = default;
            length = default;
        }
        public MyString(string str)
        {
            Str = str;
            Length = str?.Length ?? 0;
        }
        public MyString(char character)
        {
            Str = character.ToString();
            length = (byte)Str.Length;
        }

        public virtual void Clear()
        {
            Str = "";
        }

        public override string ToString() => Str;

        public int CompareTo(MyString other) => this.Str.CompareTo(other.Str);
        public object Clone() => this.MemberwiseClone();

        public string Shuffle()
        {
            char[] charArr = Str.ToCharArray();

            var rand = new Random();
            char temp;
            for (var i = 0; i < charArr.Length; i++)
            {
                var randIndex = rand.Next(i, charArr.Length);
                temp = charArr[i];
                charArr[i] = charArr[randIndex];
                charArr[randIndex] = temp;
            }
            return new string(charArr);
        }
    }
}