using helath_calc_pack_dotnet.Interfaces;
using helath_calc_pack_dotnet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helath_calc_pack_dotnet.Strategy
{
    public class MaintenanceStrategy : IMacroNutrientStrategy
    {
        const int PROTEIN = 2;
        const int FAT = 1;
        const int CARBS = 2;

        public MacroNutrientsModel Calc(double Weight)
        {
            var result = new MacroNutrientsModel()
            {
                Protein = PROTEIN * (int)Weight,
                Carbs = CARBS * (int)Weight,
                Fat = FAT * (int)Weight
            };
            return result;
        }
    }
}
