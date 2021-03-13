namespace OOP11_WinForms
{
    /// <summary>
    /// Базовий клас Стрічка.
    /// </summary>
    class MyString
    {
        protected string str;  // Поле для зберігання символів стрічки;
        protected byte length;    // Значення типу byte для зберігання довжини стрічки в байтах;

        // Метод для отримання довжини стрічки;
        public byte Length
        {
            get => length;
            private set
            {
                if (value > byte.MaxValue) { length = byte.MaxValue; }
                else { length = value; }
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
            this.Str = str;
            length = (byte)Str.Length;
        }
        public MyString(char charater)
        {
            Str = charater.ToString();
            length = (byte)Str.Length;
        }

        public virtual void Clear()
        {
            Str = "";
        }

        public override string ToString() => Str;
    }
}
