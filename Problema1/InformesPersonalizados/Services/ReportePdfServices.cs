﻿using InformesPersonalizados.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformesPersonalizados.Services
{
    public class ReportePdfServices : IInforme
    {
        public void GenerarReporte()
        {
            Console.WriteLine("InformePDF.pdf");
        }
    }
}
