using StrategyPatternGrupo;
using StrategyPatternGrupo.Cargos;
using System;
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
            Assert.Equal(salario, 2700);
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
            Assert.Equal(salario, 3200);
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
            Assert.Equal(salario, 2125);
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
            Assert.Equal(salario, 2250);
        }


        //// todo: criar theory e mudar os nomes?

        ////Desenvolvedores
        ////Salarios > 3000 ? 20% desconto : 10%

        ////Outros
        ////Salarios > 2500 ? 25% desconto : 15%
    }
}
