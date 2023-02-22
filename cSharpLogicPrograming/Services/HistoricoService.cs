using cSharpLogicPrograming;
using cSharpLogicPrograming.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpLogicPrograming.Services
{
    
    internal class HistoricoService
    {
        private readonly List<MathOperation> Historico;

        public HistoricoService()
        {
            Historico = new List<MathOperation>();
        }

        /// <summary>
        /// Realiza a exibição das operações aritiméticas realizadas
        /// </summary>
        public void ExibirHistorico()
        {            

            if (Historico.Count > 0)
            {
                Console.WriteLine("Aqui segue suas opereções realizadas");
                foreach (var item in Historico)
                    Console.WriteLine($"Created at:{item.CreatedAt} -> {item.Expression}");
                   
            }
            else
            {
                Console.WriteLine("Ainda não há nenhuma operação realizada");
            }
        }

        /// <summary>
        /// Remove e limpa todo conteudo do histórico
        /// </summary>x
        public void LimparHistorico()
        {
            Historico.Clear();
        }

        /// <summary>
        /// Realizar a inserção de um novo item dentro do histórico
        /// </summary>
        /// <param name="operacao"></param>
        public void AddItemHistorico(string operacao)
        {
            Historico.Add(new MathOperation
            {
                CreatedAt = DateTime.Now,
                Expression = operacao
            }) ;
        }
    }
}
