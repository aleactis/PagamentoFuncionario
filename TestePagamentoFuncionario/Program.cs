using System;
using System.Collections.Generic;
using static System.Console;
using System.Globalization;

namespace PagamentoFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> lista = new List<Funcionario>();

            Write("Entre com o número de funcionários: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                WriteLine($"Dados do funcionário #{i}: ");
                Write("É terceirizado? (s/n): ");
                char c = char.Parse(ReadLine());
                Write("Nome: ");
                string nome = ReadLine();
                Write("Horas: ");
                int horas = int.Parse(ReadLine());
                Write("Valor por hora: ");
                double valorPorHora = double.Parse(ReadLine(), CultureInfo.InvariantCulture);

                if (c == 's')
                {
                    Write("Taxa Adicional: ");
                    double taxaAdicional = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
                    lista.Add(new FuncionarioTerceirizado(nome, horas, valorPorHora,taxaAdicional));
                }
                else
                {
                    lista.Add(new Funcionario(nome, horas, valorPorHora));
                }
            }
            WriteLine();
            WriteLine("PAGAMENTOS: ");
            foreach (Funcionario func in lista)
            {
                WriteLine($"{func.Nome} - $ {func.Pagamento().ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
