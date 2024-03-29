﻿using Domain.interes.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.interes.Interfaces
{
     public interface IInteres : IRepository<Interes>
    {
        double prueba1(double interes, double m, double periodo, double futuro, double tiempo);
        double prueba(double interes, double m, double periodo, double presente, double tiempo);
        double Getfuturo(double Nominal, double M,double Presente,double periodo);
        double GetPresente(double nominal, double M ,double futuro ,double periodo);
        double GeTPeriodo(double nominal ,double M,double presente, double futuro);
        double ConvertEfectiva(double nominal,double M);
        double ConvetNominal(double nominal ,double M,double M1);
        double ConvertExponencial(double nominal);
        double EfectivaContinua(double efectiva);
    }
}
