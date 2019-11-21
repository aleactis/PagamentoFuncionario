using System;
using System.Collections.Generic;
using System.Text;

namespace TestePagamentoFuncionario
{
    class TesteFuncionarioTerceirizado : TesteFuncionario
    {
        public double TaxaAdicional { get; set; }

        public TesteFuncionarioTerceirizado()
        {
        }

        public TesteFuncionarioTerceirizado(string nome, int horas, double valorPorHora, double taxaAdicional)
            : base (nome, horas, valorPorHora)
        {
            TaxaAdicional = taxaAdicional;
        }

        public override double Pagamento()
        {
            return base.Pagamento() + 1.1 * TaxaAdicional;
        }
    }
}
