using cSharpLogicPrograming.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpLogicPrograming
{
    class Program
    {
        public static int QntExec = 0;
        public static int cont = 0;
         
        static void Main(string[] args)
        {
            var item = "";
            var calculadora = new CalculadoraService();

            calculadora.Soma(1,2);

            calculadora.Soma(1, 2);

            calculadora.Soma(1, 2);

            ExibirHistorico();

            Console.ReadLine();


            /*
            int continuar = 0;
            do
            {
                continuar = historic.Menu();
                QntExec++;
            } while (continuar != 6);
            Console.WriteLine("Obrigado por utilizar a calculadora! \n Pressione 'Enter' para sair!");
            Console.Read();*/
        }

        

      /*  private static void IMC() 
        {
            Console.WriteLine("Digite sua Altura(Metros):\n");
            Double altura = Double.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu peso(kilogrmas):\n");
            Double peso = Double.Parse(Console.ReadLine());

            Double imc = peso / (Math.Pow(altura, 2));

            if (imc < 18.5)
            {
                Console.WriteLine("Abaixo do peso normal.\n");
            } else if (imc >= 18.5 &&  24.9){ }
        }*/
        
        
        
    }
}
