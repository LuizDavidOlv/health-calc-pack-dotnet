
using health_calc_pack_dotnet;
using helath_calc_pack_dotnet;
using helath_calc_pack_dotnet.Models;

Console.WriteLine("Entre com sua altura e peso para calcular seu IMC!");

Console.Write("Altura: ");
var Height = Console.ReadLine();

Console.Write("Peso: ");
var Weight = Console.ReadLine();

Console.Write("Sexo: ");
var Sexo = Console.ReadLine();;

IMC objIMC = new IMC();
MacroNutrient objMacroNutrient = new MacroNutrient();

double Result = objIMC.Calc(double.Parse(Height), double.Parse(Weight));
string Category = objIMC.GetIMCCategory(Result);

Console.WriteLine("O resultado de seu IMC foi: " + Category);

var sex = (Sexo == "f") ? health_calc_pack_dotnet.Enums.SexoEnum.female : health_calc_pack_dotnet.Enums.SexoEnum.male;
var macro = objMacroNutrient.Calc(sex, double.Parse(Height), double.Parse(Weight), 
    health_calc_pack_dotnet.Enums.NivelAtividadeFisicaEnum.ExtremanteAtivo,
    health_calc_pack_dotnet.Enums.ObjetivoFisicoEnum.Cutting);


Console.WriteLine($"O consumo de macro nutrientes deve ser =>" +
    $" Proteínas: {macro.Protein}, " +
    $"Carboidratos: {macro.Carbs}, " +
    $"Gorduras: {macro.Fat}");


Console.ReadKey();
