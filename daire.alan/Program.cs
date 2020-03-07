using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daire.alan
{
    class Program
    {
        static void Main(string[] args)
        {
            double yaricap = 0;
            double area = 0;

            Console.WriteLine("dairenin yaricapini giriniz: ");
            yaricap = Convert.ToDouble(Console.ReadLine());

            area = yaricap * 2 * 3.1416;

            Console.WriteLine("dairenin alani {0} metredir.", area);

            Console.ReadKey();
        }
    }
}
