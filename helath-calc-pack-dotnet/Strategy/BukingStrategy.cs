using helath_calc_pack_dotnet.Interfaces;
using helath_calc_pack_dotnet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helath_calc_pack_dotnet.Strategy
{
    
    public class BukingStrategy : IMacroNutrientStrategy
    {
        const int PROTEIN = 2;
        const int FAT = 2;
        const int CARBS = 4;
        
        public MacroNutrientsModel Calc(double weight)
        {
            var result = new MacroNutrientsModel()
            {
                Protein = PROTEIN * (int)weight,
                Carbs = CARBS * (int)weight,
                Fat = FAT * (int)weight
            };
            
            return result;
        }
    }
}
