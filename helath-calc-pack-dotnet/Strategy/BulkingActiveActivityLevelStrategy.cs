using health_calc_pack_dotnet.Enums;
using helath_calc_pack_dotnet.Interfaces;
using helath_calc_pack_dotnet.Models;
using helath_calc_pack_dotnet.Strategy.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helath_calc_pack_dotnet.Strategy
{
    public class BulkingActiveActivityLevelStrategy : MacroNutrientBase, IMacroNutrientStrategy
    {
        const int PROTEIN = 2;
        const int FAT = 2;
        const int CARBS = 7;

        public BulkingActiveActivityLevelStrategy(SexoEnum Sexo) : base(Sexo)
        {
        }

      
        public MacroNutrientsModel Calc(double weight)
        {
            var result = new MacroNutrientsModel()
            {
                Protein = PROTEIN * (int)weight * GENDER_MUlTIPLIER,
                Carbs = CARBS * (int)weight * GENDER_MUlTIPLIER,
                Fat = FAT * (int)weight * GENDER_MUlTIPLIER
            };

            return result;
        }
    }
}
