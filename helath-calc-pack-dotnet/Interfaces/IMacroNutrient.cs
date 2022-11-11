using health_calc_pack_dotnet.Enums;
using helath_calc_pack_dotnet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helath_calc_pack_dotnet.Interfaces
{
    public interface IMacroNutrient
    {
        MacroNutrientsModel Calc(
            SexoEnum Sexo,
            double Height,
            double Weight,
            NivelAtividadeFisicaEnum NivelAtividadeFisica,
            ObjetivoFisicoEnum ObjetivoFisico);

        bool IsValidData(double Weight);
    }
}
