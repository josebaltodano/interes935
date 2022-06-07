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
        public double ConvertEfectiva(double efectiva)
        {
            return interes1.ConvertEfectiva(efectiva);
        }

        public double ConvertExponencial(double exponecail)
        {
            return exponecail;
        }

        public double ConvertExponencial(Interes interes)
        {
            return interes1.ConvertExponencial(interes);
        }

        public double ConvetNominal(double nominal)
        {
            throw new NotImplementedException();
        }

        public double EfectivaContinua(double efectiva)
        {
            throw new NotImplementedException();
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

        public double GeTPeriodo(double periodo)
        {
            throw new NotImplementedException();
        }

        public double GetPresente(double presente)
        {
            throw new NotImplementedException();
        }
    }
}
