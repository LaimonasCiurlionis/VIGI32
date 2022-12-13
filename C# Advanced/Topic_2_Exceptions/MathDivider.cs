using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic_2_Exceptions
{
    public class MathDivider
    {
        public void Division(int num1, int num2)
        {
			var result = 0;
			try
			{
				result = num1 / num2;
			}
			catch (DivideByZeroException e)
			{
				Console.WriteLine($"Can't divide by zero {e}");
			}
			finally
			{
				Console.WriteLine($"Result: {result}");
			}
			Console.WriteLine("Program is still working !!!");
        }
    }
}
