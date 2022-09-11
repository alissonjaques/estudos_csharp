using System;
using bytebank.SistemaInterno;

namespace bytebank.model.funcionarios
{
	public class Diretor:FuncionarioAutenticavel
	{
        public Diretor(string nome, string cpf, string senha):base(nome, cpf, 5000.0,senha)
        {
            
        }
        
        public Diretor()
        {
            
        }

        public override void aumentarSalario()
        {
            this.Salario *= 1.15;
        }
    }
}
