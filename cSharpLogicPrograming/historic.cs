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
       
        public static void Menu()
        {
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
