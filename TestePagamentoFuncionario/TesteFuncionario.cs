using System;
using System.Collections.Generic;
using System.Text;

namespace TestePagamentoFuncionario
{
    class TesteFuncionario
    {
        public string Nome { get; set; }
        public int Horas { get; set; }
        public double ValorPorHora { get; set; }

        public TesteFuncionario()
        {
        }

        public TesteFuncionario(string nome, int horas, double valorPorHora)
        {
            Nome = nome;
            Horas = horas;
            ValorPorHora = valorPorHora;
        }

        public virtual double Pagamento()
        {
            return Horas * ValorPorHora;
        }
    }
}
