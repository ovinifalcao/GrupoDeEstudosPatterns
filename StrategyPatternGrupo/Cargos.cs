namespace StrategyPatternGrupo
{
    public abstract class Cargo
    {
        public IRegraDeCalculo Regra { get; protected set; }
    }
}
