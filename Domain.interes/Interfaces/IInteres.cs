using Domain.interes.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.interes.Interfaces
{
     public interface IInteres : IRepository<Interes>
    {
        double Getfuturo(double Nominal, double M,double Presente,double periodo);
        double GetPresente(Interes interes);
        double GeTPeriodo(double nominal ,double M,double presente, double futuro);
        double ConvertEfectiva(Interes interes);
        double ConvetNominal(Interes interes);
        double ConvertExponencial(Interes interes);
        double EfectivaContinua(Interes interes);
    }
}
