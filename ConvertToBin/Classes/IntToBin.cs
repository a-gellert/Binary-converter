using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertToBin.Classes
{
    class IntToBin
    {
        private static Dictionary<int, string> IntAndBin = new Dictionary<int, string>();

        public static string StandartConvert(int digit)
        {
            string binaryCode;

            if (IntAndBin.TryGetValue(digit, out binaryCode))
            {
                return binaryCode;
            }
            else
            {
                binaryCode = Convert.ToString(digit, 2);
                IntAndBin.Add(digit, binaryCode);

                return binaryCode;
            }
        }

        public static string MyConvert(int digit)
        {
            string binaryCode;

            if (IntAndBin.TryGetValue(digit, out binaryCode))
            {
                return binaryCode;
            }
            else
            {
                int temp;
                int temp2 = digit;
                string tempStr = "";

                while (temp2 > 0)
                {
                    temp = temp2 % 2;
                    temp2 = temp2 / 2;
                    tempStr += temp;
                }
                binaryCode = ReverseStr(tempStr);

                IntAndBin.Add(digit, binaryCode);
                return binaryCode;
            }
        }
        private static string ReverseStr(string input)
        {
            string output = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                output += input[i];
            }
            return output;
        }
    }
}
