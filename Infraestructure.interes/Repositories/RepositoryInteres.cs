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
        public double ConvertEfectiva(Interes interes)
        {
            double Efectiva;
            double fectiva =0;



            double efectiva;
           

            efectiva = interes.nominal / 100;
              fectiva= Math.Pow(Math.Sqrt(1 + efectiva - 1), ((double)interes.producto)) * ((double)interes.producto);
             Efectiva = fectiva * 100;
            return  Efectiva;

        }



        public double ConvertExponencial(Interes interes)
        {
            double expone = interes.nominal / 100;
            double efe = Math.Exp(expone) - 1;
            return efe;
        }

        public double ConvetNominal(Interes interes )
        {
            double nominal;
            nominal = interes.nominal / 100;
            double minal = (Math.Pow(1 + nominal / ((double)interes.producto), ((double)interes.producto) / interes.producto2) - 1) * interes.producto2;
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

        public double EfectivaContinua(Interes interes)
        {
           double efectiva;
            efectiva = interes.nominal / 100;
            double efecti = Math.Log(1 + Math.Exp(efectiva));
            return efecti;
        }

        public List<Interes> GetAll()
        {
            throw new NotImplementedException();
        }


        public double Getfuturo(double Nominal, double M, double Presente, double periodo)
        {
            double J = Nominal / 100;
            double futuro = Presente * Math.Pow(1 + J /M,  M * periodo);
            return futuro;
        }

        public double GeTPeriodo(Interes interes)
        {
            double periodo;

            double J = interes.nominal / 100;
            periodo = (Math.Log(interes.Futuro / interes.presente)) / ((double)interes.producto) * Math.Log(1 + J / ((double)interes.producto));
            return periodo;
        }

        public double GeTPeriodo(double nominal, double M, double presente, double futuro)
        {
            double J = nominal / 100;
            double años;
            años = (Math.Log(futuro / presente)) / (M * Math.Log(1 + J / M));
            return años;
        }

        public double GetPresente(Interes interes)
        {
            double presente;
            double pres = interes.nominal / 100 ;

            
            presente = interes.Futuro * Math.Pow(1 + pres / ((double)interes.producto), -1*pres * interes.periodo);
            return presente;
        }

        public int Update(Interes t)
        {
            throw new NotImplementedException();
        }
    }
}
