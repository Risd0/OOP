using System;

namespace WindowsFormsApp
{

    class CharString : ICloneable
    {
        protected string _string;
        /// <summary>
        /// Max allowed length of String.
        /// </summary>
        public const int maxLength = 100;
        /// <summary>
        /// The first element of String
        /// </summary>

        public char FirstElement { get; private set; }
        public string String
        {
            get => _string;
            set
            {
                if (value.Length > maxLength) { _string = value.Substring(0, maxLength); }
                _string = string.IsNullOrEmpty(value) ? " " : value;
                FirstElement = _string[0];
            }
        }

        public CharString() { }
        public CharString(string str)
        {
            String = str;
        }
        public CharString(CharString other)
        {
            this.String = other.String;
        }
        ~CharString() { }

        public static CharString operator +(CharString chStr1, CharString chStr2) => new CharString(chStr1.String + chStr2.String);
        public static CharString operator -(CharString chStr1, CharString chStr2)
        {
            int removeFrom = chStr1.String.IndexOf(chStr2.String, comparisonType: StringComparison.OrdinalIgnoreCase);
            if (removeFrom >= 0)
            {
                return new CharString(chStr1.String.Remove(removeFrom, chStr2.String.Length));  // if it's all ok
            }
            else
            {
                return new CharString("Undefined");
            }
        }
        public static bool operator *(CharString chStr1, CharString chStr2) => chStr1.String.Contains(chStr2.String);

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
