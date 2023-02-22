using cSharpLogicPrograming;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpLogicPrograming.Services
{
    
    internal class HistoricoService
    {
        private readonly List<string> Historico;

        public HistoricoService()
        {
            Historico = new List<string>();
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
                    Console.WriteLine(item, item + 1);
                   
            }
            else
            {
                Console.WriteLine("Ainda não há nenhuma operação realizada");
            }
        }

        /// <summary>
        /// Remove e limpa todo conteudo do histórico
        /// </summary>
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
            Historico.Add(operacao);
            Historico.Add(DateTime.Now.ToString("D"));
        }
    }
}
