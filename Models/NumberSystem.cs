using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scientific_Calculator.Models
{
    public class NumberSystem
    {
        public string GetHexChar(int inputNumber)
        {
            switch (inputNumber)
            {
                case 10:
                    return "A";
                case 11:
                    return "B";
                case 12:
                    return "C";
                case 13:
                    return "D";
                case 14:
                    return "E";
                case 15:
                    return "F";
            }
            return "";
        }

        public int GetDecimalCharFromHex(string inputNumber)
        {
            switch (inputNumber.ToUpper())
            {
                case "A":
                    return 10;
                case "B":
                    return 11;
                case "C":
                    return 12;
                case "D":
                    return 13;
                case "E":
                    return 14;
                case "F":
                    return 15;
            }
            return 0;
        }

        public int HexToDecimal(string current_number)
        {
            int result = 0;
            int x = 0;
            int[] symbols = new int[current_number.Length];
            foreach (var symbol in current_number.ToCharArray())
            {
                if ((int)(symbol - '0') >= 0 && (int)(symbol - '0') <= 9)
                {
                    symbols[x] = (int)(symbol - '0');
                }
                else
                {
                    symbols[x] = GetDecimalCharFromHex(symbol.ToString());
                }
                x++;
            }
            int powerOfSixteen = current_number.Length - 1;
            for (int i = 0; i < current_number.Length; i++)
            {
                result += symbols[i] * Convert.ToInt32(Math.Pow(16, powerOfSixteen));
                powerOfSixteen--;
            }
            return result;
        }

        public string HexToOctal(string current_number)
        {
            int tempDecimal = HexToDecimal(current_number);
            return DecimalToOctal(tempDecimal);
        }

        public string HexToBinary(string current_number)
        {
            int tempDecimal = HexToDecimal(current_number);
            return DecimalToBinary(tempDecimal);
        }

        public string DecimalToHex(double current_number)
        {
            string result = "";
            while (current_number > 0)
            {
                current_number = current_number / 16;
                string word = current_number.ToString();
                double decimalPart = Convert.ToDouble("0." + word.Split('.')[1]);
                current_number = Convert.ToDouble(word.Split('.')[0]);
                if (Convert.ToInt32(decimalPart * 16) < 10)
                {
                    result += Convert.ToInt32(decimalPart * 16);
                }
                else
                {
                    result += GetHexChar(Convert.ToInt32(decimalPart * 16));
                }
            }
            char[] res = result.ToCharArray();
            Array.Reverse(res);
            return new string(res);
        }

        public int BinaryToDecimal(string current_number)
        {
            int[] symbols = new int[current_number.Length];
            int x = 0;
            foreach (var symbol in current_number.ToCharArray())
            {
                symbols[x] = (int)(symbol - '0');
                x++;
            }
            int powerOfTwo = current_number.Length - 1;
            int result = 0;

            for (int i = 0; i < current_number.Length; i++)
            {
                result += symbols[i] * Convert.ToInt32(Math.Pow(2, powerOfTwo));
                powerOfTwo--;
            }
            return result;
        }

        public string BinaryToOctal(string current_number)
        {
            int tempDecimal = BinaryToDecimal(current_number);
            return DecimalToOctal(tempDecimal);
        }

        public string BinaryToHex(string current_number)
        {
            int tempDecimal = BinaryToDecimal(current_number);
            return DecimalToHex(tempDecimal);
        }

        public string DecimalToBinary(int current_number)
        {
            string result = "";
            while (current_number != 0)
            {
                if (current_number % 2 != 0)
                {
                    current_number -= 1;
                    current_number /= 2;
                    result += 1;
                }
                else
                {
                    current_number /= 2;
                    result += 0;
                }
            }
            char[] res = result.ToCharArray();
            Array.Reverse(res);
            return new string(res);
        }

        public int OctalToDecimal(string current_number)
        {
            int result = 0;
            int[] symbols = new int[current_number.Length];
            int x = 0;
            foreach (var symbol in current_number.ToCharArray())
            {
                symbols[x] = (int)(symbol - '0');
                x++;
            }
            int powerOfEight = current_number.Length - 1;
            for (int i = 0; i < current_number.Length; i++)
            {
                result += symbols[i] * Convert.ToInt32(Math.Pow(8, powerOfEight));
                powerOfEight--;
            }
            return result;
        }

        public string OctalToBinary(string current_number)
        {
            int tempDecimal = OctalToDecimal(current_number);
            return DecimalToBinary(tempDecimal);
        }

        public string OctalToHex(string current_number)
        {
            int tempDecimal = OctalToDecimal(current_number);
            return DecimalToHex(tempDecimal);
        }


        public string DecimalToOctal(double current_number)
        {
            string result = "";
            while (current_number > 0)
            {
                current_number = current_number / 8;
                string word = current_number.ToString();
                double decimalPart = Convert.ToDouble("0." + word.Split('.')[1]);
                current_number = Convert.ToDouble(word.Split('.')[0]);
                result += Convert.ToInt32(decimalPart * 8);
            }
            char[] res = result.ToCharArray();
            Array.Reverse(res);
            return new string(res);
        }
    }
}
