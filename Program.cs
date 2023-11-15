using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ispitCetvrti1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Upisite a stranicu");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Upisite b stranicu");
            b=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Upisite c stranicu");
            c=Convert.ToInt32(Console.ReadLine());
            if (a*a+b*b==c*c)
            {
                Console.WriteLine("Trokut je pravokutan");
            }
            else
            {
                Console.WriteLine("Nije pravokutan");
            }
            Console.ReadKey();

        }
    }
}
