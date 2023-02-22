using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpLogicPrograming
{
    internal class historic
    {
        public static List<string> Historico = new List<string>();
       
        public static int Menu()
        {

            int escolha = 0;
            if (Program.QntExec == 0)
            {
                Console.WriteLine("Bem vindo!");
            }
            Console.WriteLine("Escolha a operação desejada: \n 1 = Soma \n 2 = Subtração \n 3 = Multiplicação \n 4 = Divisão \n 5 = Histórico \n 6 = Sair");
            var valorlido = Console.ReadLine();
            escolha = Int32.Parse(valorlido);
            Procedural.EscolhasUsuario(escolha);
            return (escolha);
        }
        public static void HistoricoContas()
        {
            int escolha;
            Console.WriteLine("Em realação ao histórico, você deseja:\n\n-Checar histórico: Digite '1'\n\nApagar Histórico: Digite '2'\n");
            escolha = Int32.Parse(Console.ReadLine());
            switch (escolha)
            {
                case 1:
                    Console.WriteLine("Histórico de opeerações:\n");
                    foreach (var item in Historico)
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine("Fim do histórico!\n");
                    break;

                case 2:
                    Historico = new List<string>();
                    Console.WriteLine("Histórico Apagado!\n");
                    break;

                case 0:
                    Menu();
                    break;
                default:
                    break;
            }
        }


    }
}
