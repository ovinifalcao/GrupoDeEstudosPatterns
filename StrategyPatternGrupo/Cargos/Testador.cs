using StrategyPatternGrupo.Implementacoes;

namespace StrategyPatternGrupo.Cargos
{
    public class Testador : Cargo
    {
        private IRegraDeCalculo regraDeCalculo = new CalculadoraGeral();
        public override IRegraDeCalculo Regra => regraDeCalculo;
    }
}
