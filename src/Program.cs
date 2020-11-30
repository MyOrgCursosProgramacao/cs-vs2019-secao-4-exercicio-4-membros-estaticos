using System;
using System.Globalization;

namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Resolução do Exercício proposto 4 da Seção 4" + Environment.NewLine);
            Console.WriteLine("Entre com os dados da aquisição de dólares.");

            Console.Write("Valor da cotação do dólar: ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Qual a quantidade de dólares a ser adquirida: $ ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write(Environment.NewLine 
                + "Total a ser pago em reais mais o IOF: R$"
                + $" {ConversorDeMoeda.DolarParaReal(cotacao,valor).ToString("F2", CultureInfo.InvariantCulture)}"
                + Environment.NewLine);

        }
    }
}
