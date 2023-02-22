using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpLogicPrograming
{
    public class Procedural
    {
        public static double GetValues(int cont)
        {
            double valor1;
            if (cont == 0)
            {
                Console.WriteLine("Digite o primeiro valor:");
                valor1 = Int32.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Digite o segundo valor:");
                valor1 = Int32.Parse(Console.ReadLine());
            }

            return valor1;
        }
        public static void EscolhasUsuario(int num1)
        {
            historic p = new historic();
            var resultado = "";
            switch (num1)
            {
                case 1:
                    double valor1 = GetValues(Program.cont);
                    Program.cont++;
                    double valor2 = GetValues(Program.cont);
                    resultado = $"\n{valor1} + {valor2} = {Soma(valor1, valor2)}\n";
                    Console.WriteLine(resultado);
                    Program.cont = 0;
                    break;
                case 2:
                    valor1 = GetValues(Program.cont);
                    Program.cont++;
                    valor2 = GetValues(Program.cont);
                    resultado = $"\n{valor1} - {valor2} = {Subtracao(valor1, valor2)}\n";
                    Console.WriteLine(resultado);
                    Program.cont = 0;
                    break;
                case 3:
                    valor1 = GetValues(Program.cont);
                    Program.cont++;
                    valor2 = GetValues(Program.cont);
                    resultado = $"\n{valor1} x {valor2} = {Mult(valor1, valor2)}\n";
                    Console.WriteLine(resultado);
                    Program.cont = 0;
                    break;
                case 4:
                    valor1 = GetValues(Program.cont);
                    Program.cont++;
                    valor2 = GetValues(Program.cont);
                    resultado = $"\n{valor1} / {valor2} = {Div(valor1, valor2)}\n";
                    Console.WriteLine(resultado);
                    Program.cont = 0;
                    break;
                case 5:
                    historic.HistoricoContas();
                    break;
                default:
                    break;
            }
            historic.Historico.Add(resultado);
        }
        public static double Soma(double num1, double num2)
        {
            return num1 + num2;
        }
        public static double Subtracao(double num1, double num2)
        {
            return num1 - num2;
        }
        public static double Mult(double num1, double num2)
        {
            return num1 * num2;
        }
        public static double Div(double num1, double num2)
        {
            if (num2 == 0)
            {
                Console.WriteLine("Impossível realizar a operação");
                return default;
            }
            else
            {
                return num1 / num2;
            }
        }

    }
}
