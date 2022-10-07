using StrategyPatternGrupo.Implementacoes;

namespace StrategyPatternGrupo.Cargos
{
    public class Desenvolvedor : Cargo
    {
        public Desenvolvedor() 
        {
            Regra = new CalculadoraDesenvolvedor();
        }
    }
}
