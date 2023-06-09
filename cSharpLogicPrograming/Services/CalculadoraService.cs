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
                    resultado = Sum(request.Value1, request.Value2);
                    break;
                case '-':
                    resultado = Subtraction(request.Value1, request.Value2);
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
            var objResult = new MathOperation(request, resultado);
            Historico.AddItemHistoric(objResult);
            return objResult;
            }
            return null;
        }

        private double Sum(double value1, double value2)
        {
            var result = value1 + value2;
            return result;
        }

        private double Subtraction(double value1, double value2)
        {
            var result = value1 - value2;
            return result;
        }
        private double Mult(double value1, double value2)
        {
            var result = value1 * value2;
            return result;
        }
        private double Div(double value1, double value2)
        {
            if (value2 == 0)
            {
                Console.WriteLine("Impossível realizar a operação");
                return 0;
            }
            else
            {
                var result = value1 / value2;
                return result;
            }
        }
    }
}
