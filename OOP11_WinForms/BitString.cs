using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP11_WinForms
{
    class BitString : MyString
    {
        private char sign = '+';

        /// <summary>
        /// Стрічки даного класу можуть містити тільки символи «0» або «1». Якщо до складу стрічки для ініціалізації будуть входити інші символи, відмінні від допустимих, клас Бітова_стрічка приймає нульове значення.
        /// </summary>
        public new string Str
        {
            get { return str; }
            set
            {
                if (value.All(x => x == '0' || x == '1')) { str = value; }
                else { str = null; }
            }
        }
        public char Sign { get => sign; }

        public BitString(string str)
        {
            Str = str;
        }

        public void ChangeSign() => sign = (sign == '+') ? '-' : '+'; // '-' - знак представляє від'ємне число, а '+' - позитивне

        public override string ToString() => string.Concat(Sign, Str);
        public override bool Equals(object obj) => obj.ToString() == this.ToString();
        public override int GetHashCode() => this.ToString().GetHashCode();
        public override void Clear() => Str = string.Empty;

        // Обрахунок арифметичної суми стрічок;
        public static string operator +(BitString bitStr, BitString other)
        {
            long a = Convert.ToInt64(bitStr.Str, 2);
            long b = Convert.ToInt64(other.Str, 2);
            long sum = 0;
            sum += bitStr.Sign == '+' ? a : -a;
            sum += other.Sign == '+' ? b : -b;
            return Convert.ToString(sum, 2);
        }

        // Перевірка на рівність.
        public static bool operator ==(BitString bitStr, BitString other) => bitStr.Equals(other);
        public static bool operator !=(BitString bitStr, BitString other) => !bitStr.Equals(other);
    }
}
