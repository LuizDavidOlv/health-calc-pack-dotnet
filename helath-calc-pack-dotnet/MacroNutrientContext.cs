using helath_calc_pack_dotnet.Interfaces;
using helath_calc_pack_dotnet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helath_calc_pack_dotnet
{
    public class MacroNutrientContext
    {
        private IMacroNutrientStrategy MacroNutrientStrategy;

        public MacroNutrientContext(IMacroNutrientStrategy macroNutrientStrategy)
        {
            MacroNutrientStrategy = macroNutrientStrategy;
        }

        public void SetStrategy(IMacroNutrientStrategy strategy)
        {
            MacroNutrientStrategy = strategy;
        }
        
        public MacroNutrientsModel Execute(double Weight)
        {
            return MacroNutrientStrategy.Calc(Weight);
        }
    }
}
