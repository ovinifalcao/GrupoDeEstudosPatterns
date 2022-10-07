namespace StrategyPatternGrupo
{
    public class Funcionario
    {
        public Funcionario(string nome, double salario, Cargo cargo)
        {
            Cargo = cargo;
            Nome = nome;
            Salario = salario;
        }

        public string Nome { get; private set; }
        public double Salario { get; private set; }
        public Cargo Cargo { get; private set; }

        public double CalcularSalario()
        {
            return Cargo.Regra.CalculaSalario(this);
        }
    }
}
