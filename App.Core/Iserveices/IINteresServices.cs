using Domain.interes.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Iserveices
{
   public interface IINteresServices
    {
        double Getfuturo(double Nominal, double M, double Presente, double periodo);
        double GetPresente(double nominal, double M, double futuro, double periodo);
        double ConvetNominal(double nominal, double M, double M1);
        double GeTPeriodo(double nominal, double M, double presente, double futuro);
        double ConvertEfectiva(double nominal, double M);

        double ConvertExponencial(double nominal);
        double EfectivaContinua(double efectiva);
    }
}
