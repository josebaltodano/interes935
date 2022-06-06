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
        double Getfuturo(double futuro, double M);
        double GetPresente(double presente);
        double GeTPeriodo(double periodo);
        double ConvertEfectiva(double efectiva);
        double ConvetNominal(double nominal);
        double ConvertExponencial(double exponecail);
        double EfectivaContinua(double efectiva);
    }
}
