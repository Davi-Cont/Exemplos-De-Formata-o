using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor para ser formatado: ");
            double valor = double.Parse(Console.ReadLine());

            // 01 casa decimal

            Console.WriteLine("Valor formatado: " + valor.ToString("F1"));
            Console.WriteLine("Valor formatado: " + valor.ToString("N1"));

            // 02 casa decimal

            Console.WriteLine("Valor formatado: " + valor.ToString("F2"));
            Console.WriteLine("Valor formatado: " + valor.ToString("N2"));

            // 03 casa decimal

            Console.WriteLine("Valor formatado: " + valor.ToString("F3"));
            Console.WriteLine("Valor formatado: " + valor.ToString("N3"));

            // porcentagem

            Console.WriteLine("Valor formatado: " + valor.ToString("P1"));

            Console.WriteLine("Valor formatado: " + valor.ToString("P2"));

            Console.WriteLine("Valor formatado: " + valor.ToString("P3"));

            // moeda

            Console.WriteLine("Valor formatado: " + valor.ToString("C"));

            Console.WriteLine("Valor formatado: " + valor.ToString("C" , System.Globalization.CultureInfo.GetCultureInfo("ja-JA")));

            Console.WriteLine("Valor formatado: " + valor.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-US")));

            Console.WriteLine("Valor formatado: " + valor.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("es-AG")));

            // data

            DateTime data = DateTime.Now;

            Console.WriteLine("Data atual: " + data.ToString());

            Console.WriteLine("Dia atual: " + data.ToString("dd"));

            Console.WriteLine("Dia atual: " + data.ToString("dddd"));

            Console.WriteLine("Dia atual: " + data.ToString("MM"));

            Console.WriteLine("Dia atual: " + data.ToString("MMMM"));







            Console.ReadKey();

        }
    }
}
