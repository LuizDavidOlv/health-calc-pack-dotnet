﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helath_calc_pack_dotnet.Interfaces
{
    public interface IMacroNutrientStrategy
    {
        double Calc(string Sexo, double Heigth, double Weight);
    }
}
