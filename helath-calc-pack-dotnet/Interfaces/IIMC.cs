namespace helath_calc_pack_dotnet.Interfaces
{
    public interface IIMC
    {
        double Calc(double peso, double altura);
        string GetIMCCategory(double IMC);
        bool IsValid(double peso, double altura);
    }
}
