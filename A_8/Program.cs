using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj temperaturę w stopniach Celsjusza:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Temperatura w K: {0}", a + 273.15);
            Console.WriteLine("Temperatura w F: {0}", (9 * a / 5 + 32));
            Console.ReadKey();
        }
    }
}
