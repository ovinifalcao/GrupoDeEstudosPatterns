using StrategyPatternGrupo.Implementacoes;

namespace StrategyPatternGrupo.Enumeracoes
{
    public enum Cargos
    {
        Desenvolvedor,
        DBA,
        Tester
    }

    public static class ExtenssoesCargos
    {
        public static IRegraDeCalculo regraDeCalculo(this Cargos cargo)
        {
            if (cargo == Cargos.Desenvolvedor) return new CalculadoraDesenvolvedor();
            return new CalculadoraGeral();
        } 
    }
}
