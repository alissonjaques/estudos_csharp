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
                return funcionario.Salario * 1.1;                
            } else 
            {
                return funcionario.Salario * 0.1;
            }            
        }
    }
}
