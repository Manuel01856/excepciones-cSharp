using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excepciones_cSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresé un numero");
            int num1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresé otro numero");
            int num2= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num1/num2);
            Console.ReadLine();

            try
            {

            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine();
            }

        }
    }
}
