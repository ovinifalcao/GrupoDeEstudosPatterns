using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternGrupo.Implementacoes
{
    public class CalculadoraDesenvolvedor : IRegraDeCalculo
    {
        public double CalculaSalario(Funcionario funcionario)
        {
            if(funcionario.Salario > 3000)
            {
                return funcionario.Salario * 0.8;
            }
            return funcionario.Salario * 0.9;
        }

        //Desenvolvedores
        //Salarios > 3000 ? 20% desconto : 10%
    }
}
