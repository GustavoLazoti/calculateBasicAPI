using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cSharpLogicPrograming;
using cSharpLogicPrograming.Models;

namespace cSharpLogicPrograming.View
{
    public class ToUser
    {
        public int Menu()
        {
            int escolha = 0;
            Console.WriteLine("Escolha a operação desejada: \n 1 = Soma \n 2 = Subtração \n 3 = Multiplicação \n 4 = Divisão \n 5 = Histórico \n 6 = Sair");
            var valorlido = Console.ReadLine();
            escolha = Int32.Parse(valorlido);
            return escolha;
        }

        public RequestOperations GetValues(char operation)
        {
            var operacao = operation;
            if (operation != 'h') 
            { 
            Console.WriteLine("Digite o primeiro valor:");
            double valor1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor:");
            double valor2 = Double.Parse(Console.ReadLine());
            Console.WriteLine("\n");
                return new RequestOperations()
                {
                    Value1 = valor1,
                    Value2 = valor2,
                    Operation = operacao
                };
            }
            else 
            {
                return new RequestOperations()
                {
                    Value1 = 0,
                    Value2 = 0,
                    Operation = operacao
                };
            }
            

        }
        public RequestOperations UserChoice(int escolha)
        {
            RequestOperations request = null;
            switch (escolha)
            {
                case 1:
                    Console.WriteLine("Realizando Soma:\n");
                    request = GetValues('+');
                    break;
                case 2:
                    Console.WriteLine("Realizando Subtração:\n");
                    request = GetValues('-');
                    break;
                case 3:
                    Console.WriteLine("Realizando Multiplicação:\n");
                    request = GetValues('*');
                    break;
                case 4:
                    Console.WriteLine("Realizando Divisão:\n");
                    request = GetValues('/');
                    break;
                case 5:
                    Console.WriteLine("Exibindo Histórico");
                    request = GetValues('h');
                    return request;
                default:
                    break;
            }
            return request;
        }

        public void ShowSingleResult(MathOperation mathOperation)
        {

            Console.WriteLine($"Operação realizada: {mathOperation.Expression}\n");
        }

        public void ShowHistoric(List<String> LastHistoric) 
        {
            foreach(var item in LastHistoric) { Console.WriteLine($"{item}"); }
        }
    }
}
