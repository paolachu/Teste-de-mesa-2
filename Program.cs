using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Testemesa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, este é o código para a Parte 2 do backend C#.");
            Console.WriteLine("Escolha o exercício que deseja ver(1,2,3,4,5): ");
            Console.WriteLine("1. Exercicio 1 ");
            Console.WriteLine("2. Exercício 2 ");
            Console.WriteLine("3. Exercíco 3 ");
            Console.WriteLine("4. Exercico 4 ");
            Console.WriteLine("5. Exercício 5 ");

            int exercicio = int.Parse(Console.ReadLine()); 

            switch (exercicio)
            {
                case 1:
                    Exercicio1();
                    break;
                case 2:
                    Exercicio2();
                    break;
                case 3:
                    Exercicio3();
                    break;
                case 4:
                    Exercicio4();
                    break;
                case 5: 
                    Exercicio5();
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
                

            Console.ReadLine();

        }

        static void Exercicio1()
        {
            //declaração de variáveis
            double valorfuturo;
            double valorpresente = 1000;
            double taxajuros = 5.30 / 100;
            int periodomes = 10;

            //lógica para saber o rendimento (valorfuturo)
            //F = p * ( 1 + taxa )^mes
            valorfuturo = valorpresente * Math.Pow(1 + taxajuros, periodomes);

            Console.WriteLine("O valor presente é de R$ " + valorpresente);
            Console.WriteLine("A taxa de Juros é de " + taxajuros + " %.");
            Console.WriteLine("O período do mês é de " + periodomes + " meses.");
            Console.WriteLine();


            Console.WriteLine("Valor Presente | Taxa de Juros | Período do Mês |   Rendimento");
            Console.WriteLine($"{"R$ " + valorpresente,14} | {taxajuros + " %",13} | {periodomes + " Meses",14} | {valorfuturo,12:C2}");

        }

        static void Exercicio2()
        {

            int valorpresente = 3800;
            double taxajuros = 1.25 / 100;


            Console.WriteLine("Valor Presente | Taxa de Juros | Período do Mês |   Rendimento   | Rendimento Líquido");

            //metódo de repetição, comando for
            for (int i = 1; i <= 6; i++)
            {

                double valorfuturo = valorpresente * Math.Pow(1 + taxajuros, i);
                double rendimento = valorfuturo - valorpresente;

                Console.WriteLine($"{"R$ " + valorpresente,14} | {taxajuros + " %",13} | {i + "º Mês",14} | {valorfuturo,14:C2} | {rendimento,12:C2}");

            }

            Console.ReadLine();

        }

        static void Exercicio3()
        {
            //solicita valores e depois os guarda
            Console.WriteLine("Digite o valor inicial de investimento:");
            double valorpresente = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da taxa de juros:");
            double taxajuros = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o período do mês para cálculo:");
            int mes = int.Parse(Console.ReadLine());

            double i = taxajuros / 100;
            double valorfuturo = valorpresente * Math.Pow(1 + i, mes);
            //arredonda valores
            double p = Math.Round(valorfuturo, 2);

            Console.WriteLine("Valor Presente | Taxa de Juros | Período do Mês |   Rendimento   ");
            Console.WriteLine($"{"R$ " + valorpresente,14} | {i + " %",13} |  {mes + " Meses",13} | {"R$ " + p,14}");

            Console.ReadLine();
        }

        static void Exercicio4()
        {
            Console.WriteLine("Digite o valor inicial de investimento:");
            double valorpresente = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da taxa de juros:");
            double taxajuros = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o período do mês para cálculo:");
            int mes = int.Parse(Console.ReadLine());

            double juros = taxajuros / 100;
            
            
            Console.WriteLine("Valor Presente | Taxa de Juros | Período do Mês |   Rendimento   | Rendimento Líquido |    Saldo    | Saque");

            for (int i = 1; i <= mes; i++)
            {
                double rendimento = valorpresente * Math.Pow(1 + juros, i);
                double rendimentoliquido = rendimento - valorpresente;
                double saque = 0;
                double saldo = rendimento;

                //if dentro do comando for, para informar que no 5º mês terá um saque de R$ 1000,00
                if (i == 5)
                {
                    saque = 1000;
                    saldo = valorpresente + rendimentoliquido - saque;
                    valorpresente = saldo;
                }
                    double rendaacumulada = Math.Round(saldo, 2);  
                    double p = Math.Round(valorpresente, 2);
                               
                Console.WriteLine($"{"R$ " + p,14:C2} | {juros + " %",13} | {i + "º Mês",14} | {rendimento,14:C2} | {rendimentoliquido,18:C2} | {"R$ " + rendaacumulada,11:C2} | {"R$ " + saque,12}");
            }
            Console.ReadLine();
            
        }

        static void Exercicio5()
        {
                    
            double taxajuros = 10.00 / 100;
            int anos = 2;
            double valorfuturo = 7390.61;
            double valorpresente = 0;

            
            Console.WriteLine("Valor Futuro | Valor Presente | Taxa de Juros |   Período em anos ");

            for (int i = 1; i <= anos; i++)
            {
                //VP = VF / (1 + taxa)^anos
                valorpresente = valorfuturo / Math.Pow(1 + taxajuros, i);

                double p = Math.Round(valorpresente, 2);

                Console.WriteLine($"{"R$ " + valorfuturo,12} | {"R$ " + p,14} | {taxajuros + " %",13} | {i + " anos",14}");

            }

            Console.ReadLine();

        }


    }
}


    
