﻿using cSharpLogicPrograming;
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
        private readonly List<MathOperation> Historic;

        public HistoricoService()
        {
            Historic = new List<MathOperation>();
        }

        /// <summary>
        /// Realiza a exibição das operações aritiméticas realizadas
        /// </summary>
        public List<String> HistoricShow()
        {            

            if (Historic.Count > 0)
            {
                Console.WriteLine("Aqui segue suas opereções realizadas");
                var LastHistoric = new List<string>();
                foreach (var item in Historic) 
                {
                    if (LastHistoric.Count != 11)
                    {
                        LastHistoric.Add(item.CreatedAt.ToString());
                        LastHistoric.Add(item.Expression.ToString());
                    }
                    else break;
                }
                return LastHistoric;
            }
            else
            {
                Console.WriteLine("Ainda não há nenhuma operação realizada");
                return null;
            }
        }

        /// <summary>
        /// Remove e limpa todo conteudo do histórico
        /// </summary>x
        private void HistoricClear()
        {
            Historic.Clear();
        }

        /// <summary>
        /// Realizar a inserção de um novo item dentro do histórico
        /// </summary>
        /// <param name="operacao"></param>
        public void AddItemHistoric(MathOperation operation)
        { 
           Historic.Add(operation);
        }

        public MathOperation LastOperation()
        {
            return Historic.Count > 0 ? Historic    .Last() : null;
        }
    }
}
