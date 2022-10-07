using StrategyPatternGrupo.Implementacoes;

namespace StrategyPatternGrupo.Cargos
{
    public class DBA : Cargo
    {

        private IRegraDeCalculo regraDeCalculo = new CalculadoraGeral();

        public override IRegraDeCalculo Regra => regraDeCalculo;
    }
}
