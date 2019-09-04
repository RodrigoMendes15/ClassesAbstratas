using System;
using System.Collections.Generic;
using System.Globalization;
using ClassesAbstratas.Entidades;

namespace ClassesAbstratas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo de imposto do constibuintes (PF / PJ)");
            Console.WriteLine();

            List<Contribuinte> Lista = new List<Contribuinte>();

            Console.Write("Informe o número de contribuintes: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Dados do {i}º contribuinte:");
                Console.Write("Individual ou Companhia (i / c)? ");
                char tipo = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Rendimento Anual: ");
                double rend = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (tipo == 'i' || tipo == 'I')
                {
                    Console.Write("Valor gasto com saúde: ");
                    double saude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Lista.Add(new Individual(nome, rend, saude));
                    Console.WriteLine();
                }
                else
                {
                    Console.Write("Número de Empregados: ");
                    int empregados = int.Parse(Console.ReadLine());
                    Lista.Add(new Companhia(nome, rend, empregados));
                    Console.WriteLine();
                }
            }

            double sum = 0.0;
            Console.WriteLine();
            Console.WriteLine("Impostos Pagos:");
            foreach ( Contribuinte tp in Lista)
            {
                double tax = tp.Taxa();
                Console.WriteLine(tp.Nome + ": R$ " + tax.ToString("F2", CultureInfo.InvariantCulture));
                sum += tax;
            }

            Console.WriteLine();
            Console.WriteLine("Total de Impostos: R$ " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
