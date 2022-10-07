using StrategyPatternGrupo.Implementacoes;

namespace StrategyPatternGrupo.Cargos
{
    public class Testador : Cargo
    {
        public Testador()
        {
            Regra = new CalculadoraGeral();
        }
    }
}
