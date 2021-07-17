using System;
using System.Linq;

namespace Binary
{
    public class BinaryNumber
    {
        double decimalRepresentation;

        public double binaryValue
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

        private double ConvertBinaryStringToDecimal(string binary)
        {
            var b = 0d;
            var index = binary.Count() - 1;
            foreach (var c in binary)
            {
                var number = Int32.Parse(c.ToString());
                b += Convert.ToDouble(number) * Math.Pow(2, Convert.ToDouble(index));
                index--;
            }

            return b;
        }
    }
}
