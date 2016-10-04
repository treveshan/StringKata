using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sc
{
    public class KataStringCalc
    {
        public int Add(string numbers)
        {
            if (numbers.Length == 0)
            {
                return 0;
            }

            if (numbers.Length == 1)
            {
                return Convert.ToInt16(numbers);
            }

            if (numbers.Contains("-"))
            {
                numbers = numbers.Replace(",", "");
                numbers = numbers.Replace("\n", "");
                numbers = numbers.Replace("//", "");
                numbers = numbers.Replace(";", "");
                numbers = numbers.Replace("*", "");
                numbers = numbers.Replace("%", "");
                numbers = numbers.Replace("[", "");
                numbers = numbers.Replace("]", "");

                var numbersToArray1 = numbers.ToCharArray();
                StringBuilder stringBuilder = new StringBuilder();
                for (int i = 0; i < numbersToArray1.Length; i++)
                {
                    if (numbersToArray1[i].Equals("-"))
                    {
                        stringBuilder.Append("-");
                        stringBuilder.Append(numbersToArray1[i++]);
                        stringBuilder.Append(",");

                    }


                }

                throw new Exception($"negatives {stringBuilder.ToString()} not allowed");

            }



            numbers = numbers.Replace(",", "");
            numbers = numbers.Replace("\n", "");
            numbers = numbers.Replace("//", "");
            numbers = numbers.Replace(";", "");
            numbers = numbers.Replace("*", "");
            numbers = numbers.Replace("%", "");
            numbers = numbers.Replace("[", "");
            numbers = numbers.Replace("]", "");

            var numbersToArray = numbers.ToCharArray();
            int sum = 0;

            foreach (var item in numbersToArray)
            {
                sum += Convert.ToInt32(item.ToString());
            }


            return sum;
        }
    }
}
