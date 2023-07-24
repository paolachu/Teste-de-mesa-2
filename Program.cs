using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testemesa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valorfuturo;
            double valorpresente = 1000;
            double taxajuros = 0.053;
            int periodomes = 10;

            valorfuturo = valorpresente * Math.Pow(1 + taxajuros, periodomes);

            Console.WriteLine("O valor presente é de R$ " + valorpresente);
            Console.WriteLine("A taxa de Juros é de " + taxajuros + " %.");
            Console.WriteLine("O período do mês é de " + periodomes + " meses.");
            Console.WriteLine();


            Console.WriteLine("Valor Presente | Taxa de Juros | Período do Mês |   Rendimento");
            Console.WriteLine($"{"R$ " + valorpresente,14} | {taxajuros + " %",13} | {periodomes + " meses",14} | {valorfuturo,12:C2}");

            Console.ReadLine();


        }
    }
}
