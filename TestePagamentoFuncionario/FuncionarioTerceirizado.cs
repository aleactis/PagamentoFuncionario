using System;
using System.Collections.Generic;
using System.Text;

namespace PagamentoFuncionario
{
    class FuncionarioTerceirizado : Funcionario
    {
        public double TaxaAdicional { get; set; }

        public FuncionarioTerceirizado()
        {
        }

        public FuncionarioTerceirizado(string nome, int horas, double valorPorHora, double taxaAdicional)
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
