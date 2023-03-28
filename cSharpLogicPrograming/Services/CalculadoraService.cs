﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cSharpLogicPrograming.Models;
using cSharpLogicPrograming.View;
using cSharpLogicPrograming.Services;

namespace cSharpLogicPrograming.Services
{
    internal class CalculadoraService
    {
        private readonly HistoricoService Historico;
        private ToUser toUser;

        public CalculadoraService()
        {
            Historico = new HistoricoService();
            toUser = new ToUser();
        }



        public MathOperation LastOperation()
        {
            return Historico.LastOperation();
        }

        public void HistoricShow()
        {
            

            Historico.HistoricShow();
        }

        public MathOperation ExecOperation(RequestOperations request)
        {
            double resultado = 0;
            switch (request.Operation) 
            {
                case '+':
                    resultado = Soma(request.Value1, request.Value2);
                    break;
                case '-':
                    resultado = Subtracao(request.Value1, request.Value2);
                    break;
                case '*':
                    resultado = Mult(request.Value1, request.Value2);
                    break;
                case '/':
                    resultado = Div(request.Value1, request.Value2);
                    break;
                case 'h':
                    var hist = Historico.HistoricShow();
                    toUser.ShowHistoric(hist);
                    break;
            }
            if(request.Operation != 'h') 
            { 
            var objResultado = new MathOperation(request, resultado);
            Historico.AddItemHistoric(objResultado);
            return objResultado;
            }
            return null;
        }

        private double Soma(double valor1, double valor2)
        {
            var resultado = valor1 + valor2;
            return resultado;
        }

        private double Subtracao(double valor1, double valor2)
        {
            var resultado = valor1 - valor2;
            return resultado;
        }
        private double Mult(double valor1, double valor2)
        {
            var resultado = valor1 * valor2;
            return resultado;
        }
        private double Div(double valor1, double valor2)
        {
            if (valor2 == 0)
            {
                Console.WriteLine("Impossível realizar a operação");
                return 0;
            }
            else
            {
                var resultado = valor1 / valor2;
                return resultado;
            }
        }
    }
}
