using StrategyPatternGrupo.Implementacoes;

namespace StrategyPatternGrupo.Cargos
{
    public class Desenvolvedor : Cargo
    {
        private IRegraDeCalculo regraDeCalculo = new CalculadoraDesenvolvedor();
        public override IRegraDeCalculo Regra => regraDeCalculo;
    }
}
