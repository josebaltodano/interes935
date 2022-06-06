using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Iserveices
{
   public interface IINteresServices
    {
        double Getfuturo(double futuro);
        double GetPresente(double presente);
        double GeTPeriodo(double periodo);
        double ConvertEfectiva(double efectiva);
        double ConvetNominal(double nominal);
        double ConvertExponencial(double exponecail);
        double EfectivaContinua(double efectiva);
    }
}
