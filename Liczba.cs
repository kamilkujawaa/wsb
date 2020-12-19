using System;

namespace First
{
    class Liczba
    {
        private int value { get; set; }

        public Liczba(int value)
        {
            this.value = value;
        }

        public bool IsPrime()
        {
            if (this.value <= 1) return false;

            for (int i = 2; i < this.value; i++)
                if (this.value % i == 0)
                    return false;

            return true;
        }

        public string ToBin()
        {
            return Convert.ToString(this.value, 2);
        }

        public string ToHex()
        {
            return Convert.ToString(this.value, 16);
        }
    }
}
