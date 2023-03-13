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
        public char Operation { get; set; }

        public MathOperation(RequestOperations request, double resultado)
        {
            Expression = FormatarResultado(request.Value1, request.Value2, resultado, request.Operation);
            CreatedAt = DateTime.Now;
            Value1 = request.Value1;
            Value2 = request.Value2;
            Resultado = resultado;
            Resultado = resultado;
        }

        private string FormatarResultado(double valor1, double valor2, double resultado, char operando)
        {
            return $"{valor1} {operando} {valor2} = {resultado}";
        }
    }
}
