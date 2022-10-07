namespace StrategyPatternGrupo.Implementacoes
{
    public class CalculadoraGeral : IRegraDeCalculo
    {
        public double CalculaSalario(Funcionario funcionario)
        {
            if (funcionario.Salario <= 2500)
                return funcionario.Salario * 0.85;

            return funcionario.Salario * 0.75;
        }

        //Outros
        //Salarios > 2500 ? 25% desconto : 15%
    }
}
