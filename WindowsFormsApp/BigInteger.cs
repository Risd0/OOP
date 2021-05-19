using System.Linq;
using System.Numerics;

namespace WindowsFormsApp
{
    class BigInteger : CharString
    {
        private string bigInt;
        public string BigInt
        {
            get => bigInt;
            set
            {
                // take from value only digits and '-' if its index == 0
                if (value[0] == '-') { bigInt = value[0] + new string(value.Substring(1).Where<char>(ch => char.IsDigit(ch)).ToArray<char>()); }
                else { bigInt = '+' + new string(value.Where<char>(ch => char.IsDigit(ch)).ToArray<char>()); }
            }
        }

        public BigInteger() : this("0") { }

        /// <param name="str">general string</param>
        public BigInteger(string str) : base(str)     // appeal to base class ctor
        {
            BigInt = String;
        }
    }
}
