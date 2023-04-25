using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpLogicPrograming.Models
{
    public class RequestOperations
    {
        [Required]
        public string Operation { get; set; }

        [Required]
        public double Value1 { get; set; }

        [Required]
        public double Value2 { get; set; }
    }
}
