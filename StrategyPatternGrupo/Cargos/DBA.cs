using StrategyPatternGrupo.Implementacoes;

namespace StrategyPatternGrupo.Cargos
{
    public class DBA : Cargo
    {
        public DBA()
        {
            Regra = new CalculadoraGeral();
        }
    }
}
