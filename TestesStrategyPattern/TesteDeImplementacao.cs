using StrategyPatternGrupo;
using StrategyPatternGrupo.Cargos;
using Xunit;

namespace TestesStrategyPattern
{
    public class TesteDeImplementacao
    {
        [Fact]
        public void SalarioLiquidoDeveSer2700_QuandoCargoForDesenvolvedorESalarioBrutoForIgual3000()
        {
            var funcionario = new Funcionario
            (
                "Renato Gaúcho",
                3000,
                new Desenvolvedor()
                
            );
            var salario = funcionario.CalcularSalario();
            Assert.Equal(2700, salario);
        }

        [Fact]
        public void SalarioLiquidoDeveSer3200_QuandoCargoForDesenvolvedorESalarioBrutoForIgual4000()
        {
            var funcionario = new Funcionario
            (
                "Renato Gaúcho",
                4000,
                new Desenvolvedor()
            );

            var salario = funcionario.CalcularSalario();
            Assert.Equal(3200, salario);
        }

        [Fact]
        public void SalarioLiquidoDeveSer2135_QuandoCargoForNaoForDesenvolvedorESalarioBrutoForIgual2500()
        {
            var funcionario = new Funcionario
            (
                "Odete Rotman",
                2500,
                new DBA()
            );

            var salario = funcionario.CalcularSalario();
            Assert.Equal(2125, salario);
        }


        [Fact]
        public void SalarioLiquidoDeveSer2250_QuandoCargoForNaoForDesenvolvedorESalarioBrutoForIgual3000()
        {
            var funcionario = new Funcionario
            (
                "Odete Rotman",
                3000,
                new DBA()
            );

            var salario = funcionario.CalcularSalario();
            Assert.Equal(2250, salario);
        }
    }
}
