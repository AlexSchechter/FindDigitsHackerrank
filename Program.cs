using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindDigitsHackerrank
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            List<int> results = new List<int>();
            for (int a0 = 0; a0 < t; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine());               
                List<int> digits = ConvertNumberToDigits(n.ToString());
                foreach (int digit in digits)
                {
                    if (n % digit == 0)
                        count++;
                }
                results.Add(count);               
                count = 0;
            }
            foreach (int c in results)
                Console.WriteLine(c);
            Console.ReadLine();

        }

        static List<int> ConvertNumberToDigits(string num)
        {
 
            List<int> digits = new List<int>();
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] != '0')
                    digits.Add((int)Char.GetNumericValue(num[i]));
            }
            return digits;

        }
    }
}
