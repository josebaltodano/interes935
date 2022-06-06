using Domain.interes.Entities;
using Domain.interes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.interes.Repositories
{
    public class RepositoryInteres : IInteres
    {
        public double ConvertEfectiva(double efectiva)
        {
            

            
            

            Interes inte = new Interes();
            efectiva = inte.nominal / 100;
            double fectiva  = Math.Pow(Math.Sqrt(1 + efectiva - 1), ((double)inte.producto)) * ((double)inte.producto);
            double Efectiva = fectiva * 100;
            return  Efectiva;

        }

        public double ConvertExponencial(double exponecail)
        {
            try
            {
                double efectiva;
               if(exponecail == 0)
                {
                    throw new Exception($"El Interes {exponecail} No puede ser Cero");
                }
                Interes inte = new Interes();
                exponecail = inte.nominal / 100;
                  efectiva   = Math.Exp(exponecail) - 1;
                return efectiva;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public double ConvetNominal(double nominal)
        {
            Interes inte = new Interes();
            nominal = inte.nominal / 100;
            double minal = (Math.Pow(1 + nominal / ((double)inte.producto), ((double)inte.producto) / inte.producto2) - 1) * inte.producto2;
            double Nominal = minal * 100;
            return Nominal;
        }

        public void Create(Interes t)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Interes t)
        {
            throw new NotImplementedException();
        }

        public double EfectivaContinua(double efectiva)
        {
            Interes interes = new Interes();
            efectiva = interes.nominal / 100;
            double efecti = Math.Log(1 + Math.Exp(efectiva));
            return efecti;
        }

        public List<Interes> GetAll()
        {
            throw new NotImplementedException();
        }

        public double Getfuturo(double futuro ,double m)
        {
            try
            {
                Interes inte = new Interes();
                double J = inte.nominal / 100;
                m = 0;
                futuro = inte.presente * Math.Pow(1 + J / ((double)inte.producto), (-1 * ((double)inte.producto)) * inte.periodo);
                return futuro;
            }
            catch (Exception)
            {
                throw;
            }
           
        }

        public double GeTPeriodo(double periodo)
        {
            Interes inte = new Interes();

            double J = inte.nominal / 100;
            periodo = (Math.Log(inte.Futuro / inte.presente)) / ((double)inte.producto) * Math.Log(1 + J / ((double)inte.producto));
            return periodo;
        }

        public double GetPresente(double presente)
        {
            Interes inte = new Interes();
            double pres = inte.nominal / 100 * -1;

            
            presente = inte.Futuro * Math.Pow(1 + pres / inte.M, inte.nominal * inte.periodo);
            return presente;
        }

        public int Update(Interes t)
        {
            throw new NotImplementedException();
        }
    }
}
