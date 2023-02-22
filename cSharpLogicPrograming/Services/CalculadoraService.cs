using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpLogicPrograming.Services
{
    internal class CalculadoraService
    {
        private readonly HistoricoService Historico;

        public CalculadoraService()
        {
            Historico = new HistoricoService();
        }

        public double Soma(double valor1, double valor2)
        {
            var resultado = valor1 + valor2;
            var resultadoFormatado = FormartarResultado(valor1, valor2, resultado, "+");
            Historico.AddItemHistorico(resultadoFormatado);
            return resultado;
        }

        public void ExibirHistorico()
        {
            Historico.ExibirHistorico();
        }

        public void LimparHistorico()
        {
            Historico.LimparHistorico();
        }

        private string FormartarResultado(double valor1, double valor2, double resultado, string operando)
        {
            return $"{valor1} {operando} {valor2} = {resultado}";
        }


    }
}
