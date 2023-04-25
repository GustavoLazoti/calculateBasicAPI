using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpLogicPrograming.Models
{
    public class MathOperation
    {
        public string Expression { get; set; }
        public DateTime CreatedAt { get; set; }
        public double Value1 { get; set; }
        public double Value2 { get; set; }
        public double Resultado { get; set; }
        public string Operation { get; set; }

        public MathOperation(RequestOperations request, double resultado)
        {
            Expression = ResultToFormat(request.Value1, request.Value2, resultado, request.Operation);
            CreatedAt = DateTime.Now;
            Value1 = request.Value1;
            Value2 = request.Value2;
            Resultado = resultado;
            Operation = request.Operation;
        }

        private string ResultToFormat(double valor1, double valor2, double resultado, string operando)
        {
            return $"{valor1} {operando} {valor2} = {resultado}";
        }
    }
}
