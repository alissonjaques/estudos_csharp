using System;
using bytebank.model.util;

namespace bytebank.model.funcionarios
{
	public class Diretor:Funcionario
	{
        public Diretor(string nome, string cpf, double salario)
            : base(nome, cpf, salario)
        {
            
        }
        
        public Diretor()
        {
        
        }
    }
}
