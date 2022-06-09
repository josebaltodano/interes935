using App.Core.Iserveices;
using Domain.interes.Entities;
using Domain.interes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Services
{
    public class InteresServices : IINteresServices
    { IInteres interes1;
        public InteresServices(IInteres interes)
        {
            this.interes1 = interes;
        }
       

        public double ConvertEfectiva(double nominal, double M)
        {
            return interes1.ConvertEfectiva(nominal, M);
        }

        public double ConvertExponencial(double nominal)
        {
            return interes1.ConvertExponencial(nominal);
        }

    

    

        public double ConvetNominal(double nominal, double M, double M1)
        {
            return interes1.ConvetNominal(nominal, M, M1);
        }

        public double EfectivaContinua(double efectiva)
        {
            return interes1.EfectivaContinua(efectiva);
        }

        public double Getfuturo(double Nominal, double M, double Presente, double periodo)
        {
            try
            {
                return interes1.Getfuturo(Nominal, M, Presente, periodo);
            }
            catch (Exception)
            {
                throw;
            }
            
        }

       

        public double GeTPeriodo(double nominal, double M, double presente, double futuro)
        {
            return interes1.GeTPeriodo(nominal, M, presente, futuro);
        }

        public double GetPresente(double nominal, double M, double futuro, double periodo)
        {
            return interes1.GetPresente(nominal, M, futuro, periodo);
        }
    }
}
