using health_calc_pack_dotnet.Enums;
using helath_calc_pack_dotnet;
using helath_calc_pack_dotnet.Interfaces;
using helath_calc_pack_dotnet.Models;
using helath_calc_pack_dotnet.Strategy;

namespace health_calc_pack_dotnet
{
    public class MacroNutrient : IMacroNutrient
    {
        const int MIN_WEIGTH = 35;
        
        public MacroNutrientsModel Calc(SexoEnum Sexo, double Height, double Weight,
                           NivelAtividadeFisicaEnum NivelAtividadeFisica,
                           ObjetivoFisicoEnum ObjetivoFisico)
        {
            if(!IsValidData(Weight))
            {
                throw new NotImplementedException();
            }
            IMacroNutrientStrategy macroNutrientStrategy = new CuttingStrategy();

            if (ObjetivoFisico == ObjetivoFisicoEnum.Cutting)
            {
                macroNutrientStrategy = new CuttingStrategy();
            }
            else if (ObjetivoFisico == ObjetivoFisicoEnum.Bucking)
            {
                macroNutrientStrategy = new BukingStrategy();
            }
            else if (ObjetivoFisico == ObjetivoFisicoEnum.Maintenance)
            {
                macroNutrientStrategy = new MaintenanceStrategy();
            }

            var context = new MacroNutrientContext(macroNutrientStrategy);

            var resultado = context.Execute(Weight);
            return resultado;

        }
        public bool IsValidData(double Weight)
        {
            return true;
        }

    }
}
