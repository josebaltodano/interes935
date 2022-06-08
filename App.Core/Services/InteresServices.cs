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
        public double ConvertEfectiva(Interes interes)
        {
            return interes1.ConvertEfectiva(interes);
        }

        public double ConvertExponencial(double exponecail)
        {
            return exponecail;
        }

        public double ConvertExponencial(Interes interes)
        {
            return interes1.ConvertExponencial(interes);
        }

        public double ConvetNominal(Interes interes)
        {
            return interes1.ConvetNominal(interes);
        }

        public double EfectivaContinua(Interes interes)
        {
            return interes1.EfectivaContinua(interes);
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

        public double GetPresente(Interes interes)
        {
            return interes1.GetPresente(interes);
        }
    }
}
