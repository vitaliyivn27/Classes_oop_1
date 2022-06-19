
namespace Oop_1
{
    public class Fractions
    {
        public long Integer { get; set; }
        public ushort FractionPart { get; set; }
        int hmz = 0;


        public Fractions(double num)
        {
            SetValues(num);
        }

        private void SetValues(double num)
        {
            Integer = (long)Math.Truncate(num);
            FractionPart = GetFractionPart(num);

        }

        ushort GetFractionPart(double num)
        {
            ushort res;
            try
            {
                var dStr = num.ToString().Split('.')[1];
                foreach (var n in dStr.ToCharArray())
                {
                    if (n == '0')
                    {
                        hmz++;
                    }
                    else { break; }
                }
                res = Convert.ToUInt16(dStr);
            }
            catch { res = 0; }
            return res;
        }

        string FractionPartString
        {
            get
            {
                var res = "";
                for (int i = 0; i < hmz; i++)
                {
                    res += "0";
                }
                res += FractionPart;
                return res;
            }
        }
        public string ToString()
        {
            return string.Format("Integer: {0}; FractionPart: {1}. ", Integer, FractionPart);
        }

        public string Operations()
        {
            var FractionPartInt = Convert.ToInt64(FractionPartString);
            var summury = Integer + FractionPartInt;
            var substraction = Integer - FractionPartInt;
            var multiplication = Integer * FractionPartInt;
            
            if (Integer > FractionPartInt)
            {
                return string.Format("Summury: {0}; Substraction: {1}; Multiplication: {2}; Integer > FractionPart.", summury, substraction, multiplication); 
            }
            else if (Integer < FractionPartInt)
            {
                return string.Format("Summury: {0}; Substraction: {1}; Multiplication: {2}; Integer < FractionPart.", summury, substraction, multiplication);
            }
            else
            {
                return string.Format("Summury: {0}; Substraction: {1}; Multiplication: {2}; Integer = FractionPart.", summury, substraction, multiplication);
            }
            
        }
    }
}
