using Domain.interes.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.interes.Entities
{
   public  class Interes
    {
        public double Futuro { get; set; }
        public double presente { get; set; }
        public double nominal { get; set; }
   
        public double periodo { get; set; }

        public Producto producto { get; set; }

       
    }
}
