using health_calc_pack_dotnet.Enums;
using health_calc_pack_dotnet;
using helath_calc_pack_dotnet.Models;
using helath_calc_pack_dotnet.Interfaces;

namespace health_calc_test_xunit
{
    public class MacronutrienteTest
    {
        [Fact]
        public void When_RequestMacronutrientsCalcWithValidDataForCutting_ThenReturnResult()
        {
            //Arrange
            var MacronutrienteObj = new MacroNutrient();
            var Sexo = SexoEnum.male;
            var Height = 1.68;
            var Weight = 85;
            var NivelAtividadeFisica = NivelAtividadeFisicaEnum.Sedentario;
            var ObjetivoFisico = ObjetivoFisicoEnum.Cutting;

            var Expected = new MacroNutrientsModel()
            {
                Carbs = 170,
                Protein = 170,
                Fat = 85


            };


            //Act
            var Result = MacronutrienteObj.Calc(
                Sexo,
                Height,
                Weight,
                NivelAtividadeFisica,
                ObjetivoFisico);

            //Assert

            Assert.Equal(Expected.Carbs, Result.Carbs);
            Assert.Equal(Expected.Protein, Result.Protein);
            Assert.Equal(Expected.Fat, Result.Fat);


        }


        [Theory]
        [InlineData(NivelAtividadeFisicaEnum.Sedentario, 340)]
        [InlineData(NivelAtividadeFisicaEnum.ModeradamenteAtivo, 340)]
        [InlineData(NivelAtividadeFisicaEnum.BastanteAtivo, 595)]
        [InlineData(NivelAtividadeFisicaEnum.ExtremanteAtivo, 595)]

        public void When_RequestMacronutrientsCalcWithValidDataForBuking_TheReturnResult(
            NivelAtividadeFisicaEnum NivelAtividadeFisica,
            int Carboitrados)
        {
            //Arrange
            var MacronutrienteObj = new MacroNutrient();
            var Sexo = SexoEnum.male;
            var Height = 1.68;
            var Weight = 85;
            var ObjetivoFisico = ObjetivoFisicoEnum.Bucking;

            var Expected = new MacroNutrientsModel()
            {
                Carbs = Carboitrados,
                Protein = 170,
                Fat = 170
            };


            //Act
            var Result = MacronutrienteObj.Calc(
                Sexo,
                Height,
                Weight,
                NivelAtividadeFisica,
                ObjetivoFisico);

            //Assert
            Assert.Equal(Expected.Carbs, Result.Carbs);
            Assert.Equal(Expected.Protein, Result.Protein);
            Assert.Equal(Expected.Fat, Result.Fat);


        }

        [Fact]
        public void When_RequestMacronutrientsCalcWithValidDataForMaintenance_ThenReturnResult()
        {
            //Arrange
            var MacronutrienteObj = new MacroNutrient();
            var Sexo = SexoEnum.male;
            var Height = 1.68;
            var Weight = 85;
            var NivelAtividadeFisica = NivelAtividadeFisicaEnum.Sedentario;
            var ObjetivoFisico = ObjetivoFisicoEnum.Maintenance;

            var Expected = new MacroNutrientsModel()
            {
                Carbs = 425,
                Protein = 170,
                Fat = 85
            };


            //Act
            var Result = MacronutrienteObj.Calc(
                Sexo,
                Height,
                Weight,
                NivelAtividadeFisica,
                ObjetivoFisico);

            //Assert
            Assert.Equal(Expected.Carbs, Result.Carbs);
            Assert.Equal(Expected.Protein, Result.Protein);
            Assert.Equal(Expected.Fat, Result.Fat);


        }

        [Fact]
        public void When_RequestMacronutrientsCalcWithInvalidData_ThenThrowsException()
        {
            //Arrange
            var MacronutrienteObj = new MacroNutrient();
            var Sexo = SexoEnum.male;
            var Height = 1.68;
            var Weight = 34;
            var NivelAtividadeFisica = NivelAtividadeFisicaEnum.Sedentario;
            var ObjetivoFisico = ObjetivoFisicoEnum.Maintenance;


            //Act & Assert
            Assert.Throws<Exception>(() => MacronutrienteObj.Calc(
                Sexo,
                Height,
                Weight,
                NivelAtividadeFisica,
                ObjetivoFisico));

        }
    }
}