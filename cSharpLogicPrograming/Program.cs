using cSharpLogicPrograming.Services;
using cSharpLogicPrograming.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cSharpLogicPrograming.Models;

namespace cSharpLogicPrograming
{
    class Program
    {
         
        static void Main(string[] args)
        {
            var calculadora = new CalculadoraService();
            var userInterface = new ToUser();
            
            do
            {
                var resultado = calculadora.ExecOperation(userInterface.EscolhasUsuario(userInterface.EscolhasMenu()));
                userInterface.ShowSingleResult(resultado);
            } while (true);
        }
        
    }
}
