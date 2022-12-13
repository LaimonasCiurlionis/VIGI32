using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class Extensions
    {
        public static int DecreaseByInteger(this int num1, int num2, string word)
        {
            Console.WriteLine(word);
            return num1 - num2;
        }

        public static void RemoveDigitAndPrintRemainingDigits(this List<int> list, int digit)
        {
            list.Remove(digit);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        public static void PrintCarModel(this Car bestCar)
        {
            Console.WriteLine(bestCar.Model);
        }

    }
}
