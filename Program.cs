using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beecrowd_Simple_Calculate_1010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String line1 = Console.ReadLine();
            String line2 = Console.ReadLine();

            string[] values1 = line1.Split(' ');
            int cod1 = Convert.ToInt32(values1[0]);
            int qtd1 = Convert.ToInt32(values1[1]);
            double valor1 = Convert.ToDouble(values1[2]);


            string[] values2 = line2.Split(' ');
            int cod2 = Convert.ToInt32(values2[0]);
            int qtd2 = Convert.ToInt32(values2[1]);
            double valor2 = Convert.ToDouble(values2[2]);

            double total = (valor1 * qtd1) + (valor2 * qtd2);

            Console.WriteLine("VALOR A PAGAR: R$ {0:00.00}", total);
            Console.ReadKey();
        }
    }
}
