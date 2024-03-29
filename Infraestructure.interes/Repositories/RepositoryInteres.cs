﻿using Domain.interes.Entities;
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
       
  

        public double ConvertEfectiva(double nominal, double M)
        {
            double J = nominal / 100;
            double x = (Math.Pow(Math.Sqrt(1 + J ), M)-1)*M ;
            double y = x;
            double efectiva = Math.Round(y, 2);
            return efectiva;
        }



        public double ConvertExponencial(double nominal)
        {
            double x = nominal / 100;
            double y = Math.Exp(x) - 1;
            double o = y * 100;
            double exponencial = Math.Round(o, 2);
            return exponencial;
        }

        public double ConvetNominal(double nominal, double M, double M1)
        {
            double J = nominal / 100;
            double x = (Math.Pow(1+J/M,M/M1)-1)*M1;
            double minal = x;
            double N = minal * 100;
            double Nominal = Math.Round(N, 2);
            return Nominal;
        }

        public void Create(Interes t)
        {
           if(t == null)
            {
                throw new ArgumentNullException("El objeto no puede ser null");

            }
           
        }

        public bool Delete(Interes t)
        {
            throw new NotImplementedException();
        }

        public double EfectivaContinua(double efectiva)
        {
            double x;
            x =efectiva / 100;
            double efecti = Math.Log(1 + Math.Exp(x));
            double nominal = Math.Round(efecti * 100, 2);
            return nominal;
        }

        public List<Interes> GetAll()
        {
            throw new NotImplementedException();
        }


        public double Getfuturo(double Nominal, double M, double Presente, double periodo)
        {
            double J = Nominal / 100;
            double f = Presente * Math.Pow(1 + J /M,  M * periodo);
            double futuro = Math.Round(f, 2);
            return futuro;
        }

      

        public double GeTPeriodo(double nominal, double M, double presente, double futuro)
        {
            double J = nominal / 100;
            double años;
            años = (Math.Log(futuro / presente)) / (M * Math.Log(1 + J / M));
            double periodo = Math.Round(años, 2);
            return periodo;
        }

    

        public double GetPresente(double nominal, double M, double futuro, double periodo)
        {
            double J = nominal / 100;
           
            double x = futuro * Math.Pow(1 + J / M, -1 * M * periodo);
            double presente = Math.Round(x, 2);
            return presente;
        }

        public double prueba(double interes, double m, double periodo, double presente, double tiempo)
        {
            double t = periodo *tiempo;
            double i = interes / m;
            double o = i / 100;
            double futuro = presente * (Math.Pow(1 + o,t));
            double f = Math.Round(futuro, 2);
            return f;
        }

        public double prueba1(double interes, double m, double periodo, double futuro, double tiempo)
        {
            double t = periodo * tiempo;
            double i = interes / m;
            double o = i/100;
            double presente = futuro / Math.Pow(1 + o, t);
            return presente;
        }

        public int Update(Interes t)
        {
            throw new NotImplementedException();
        }
    }
}
