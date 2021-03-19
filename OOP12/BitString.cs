using System;

namespace OOP12
{
    class BitString : MyString, ICloneable, IComparable<BitString>
    {
        private long binVal;

        /// <summary>
        /// Містить бінарне число. Якщо до складу рядка для ініціалізації будуть входити інші символи, відмінні від допустимих, клас Str приймає нульове значення.
        /// </summary>
        public new string Str
        {
            get => str;
            set
            {
                binVal = CheckBinary(value);
                str = (binVal == 0) ? null : binVal.ToString();
            }
        }

        public BitString() : this(null) { }
        public BitString(string str)
        {
            Str = str;
        }

        private long CheckBinary(string str)
        {
            if (str == null) { return 0; }
            // check if the first element is correct
            switch (str[0])
            {
                case '+' when str.Length > 1: str = str.Substring(1); break;
                case '-' when str.Length > 1: break;
                case '0': break;
                case '1': break;
                default: return 0;
            }

            for (int i = 1; i < str.Length; i++)
            {
                // if string isn't a binary - return 0
                if (str[i] != '0' && str[i] != '1')
                {
                    return 0;
                }
            }
            return long.Parse(str);
        }

        public override string ToString() => Str;
        public override bool Equals(object obj) => obj.ToString() == this.ToString();
        public override int GetHashCode() => this.ToString().GetHashCode();
        public override void Clear() => Str = string.Empty;

        public int CompareTo(BitString other) => this.binVal.CompareTo(other.binVal);

        // Обрахунок арифметичної суми/різниці рядків;
        public static string operator +(BitString bitStr, BitString other) => Convert.ToString(bitStr.binVal + other.binVal);
        public static string operator -(BitString bitStr, BitString other) => Convert.ToString(bitStr.binVal - other.binVal);

        // Перевірка на рівність.
        public static bool operator ==(BitString bitStr, BitString other) => bitStr.Equals(other);
        public static bool operator !=(BitString bitStr, BitString other) => !bitStr.Equals(other);
    }
}