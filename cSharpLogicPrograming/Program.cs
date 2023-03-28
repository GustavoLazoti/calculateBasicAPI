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
                int i = userInterface.Menu();
                if (i == 1 || i == 2 || i == 3 || i == 4)
                {
                    var result = calculadora.ExecOperation(userInterface.UserChoice(i));
                    userInterface.ShowSingleResult(result);
                }
                else if(i == 5)
                {
                    var a = userInterface.UserChoice(i);
                    calculadora.ExecOperation(a);
                }
                else 
                {
                    break;
                }
            } while (true);
        }
        
    }
}
