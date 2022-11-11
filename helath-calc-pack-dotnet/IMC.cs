using helath_calc_pack_dotnet.Interfaces;
using System.Security.Cryptography;

namespace helath_calc_pack_dotnet
{
    public class IMC : IIMC
    {
        public double Calc( double height,double weight)
        {
            if(!IsValid(height,weight))
            {
                throw new Exception("Invalid Parameters!");
            }

            var result = Math.Round(weight / (Math.Pow(height, 2)), 2);

            return result;
        }

        public string GetIMCCategory(double IMC)
        {
            var result = string.Empty;

            if (IMC>=0 && IMC < 18.5)
            {
                result = "Underweight";
            }
            else if (IMC >= 18.5 && IMC < 25)
            {
                result = "Normal weight";
            }
            else if (IMC >= 25 && IMC < 30)
            {
                result = "Overweight";
            }
            else if (IMC >= 30 && IMC < 35)
            {
                result = "Obesity grade I";
            }
            else if (IMC >= 35 && IMC < 40)
            {
                result = "Obesity grade II";
            }
            else if (IMC >= 40)
            {
                result = "Obesity grade III";
            }
            else
            {
                result = "Invalid IMC";
            }

            return result;
        }

        public bool IsValid(double peso, double altura)
        {
            if (altura <= 0 || peso <= 0)
            {
                return false;
            }

            return true;
        }
    }
}