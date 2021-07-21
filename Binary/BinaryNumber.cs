using System;
using System.Linq;

namespace Binary
{
    public class BinaryNumber
    {
        private int decimalRepresentation;

        public string binaryValue
        {
            get
            {
                return ConvertDecimalToinaryString(decimalRepresentation);
            }
            set
            {
                this.decimalRepresentation = ConvertBinaryStringToDecimal(value);
            }
        }

        
        public int integerValue
        {
            get
            {
                return decimalRepresentation;
            }
            set
            {
                this.decimalRepresentation = value;
            }
        }

        public BinaryNumber(string binary)
        {
            this.decimalRepresentation = this.ConvertBinaryStringToDecimal(binary);
        }

        public BinaryNumber(int value)
        {
            this.decimalRepresentation = value;
        }

        private int ConvertBinaryStringToDecimal(string binary)
        {
            var b = 0;
            var index = binary.Count() - 1;
            foreach (var c in binary)
            {
                var number = Int32.Parse(c.ToString());
                b += number * (int)Math.Pow(2, index);
                index--;
            }

            return b;
        }

        private string ConvertDecimalToinaryString(int value)
        {
            var quo = value / 2;
            var rem = value % 2;
            var s = rem.ToString();

            while (quo != 0)
            {
                rem = quo % 2;
                quo = quo / 2;

                s = rem.ToString() + s;
            }

            return s;
        }
    }
}
