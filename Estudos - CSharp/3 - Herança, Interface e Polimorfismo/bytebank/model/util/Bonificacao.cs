using System;
using bytebank.model.funcionarios;

namespace bytebank.model.util
{
    public static class Bonificacao
    {
        public static double getBonificacao(Funcionario funcionario)
        {
            if (funcionario is Diretor)
            {
                return funcionario.Salario * 0.5;
            } 
            else if (funcionario is Design) 
            {
                return funcionario.Salario * 0.17;
            }
            else if (funcionario is GerenteDeContas)
            {
                return funcionario.Salario * 0.25;
            } 
            else {
                return funcionario.Salario * 0.20;
            }            
        }
    }
}
