using System;
using bytebank.SistemaInterno;

namespace bytebank.model.funcionarios
{
    public class GerenteDeContas : FuncionarioAutenticavel
    {
        public GerenteDeContas(string nome, string cpf, string senha) : base(nome, cpf, 4000.0,senha)
        {
            
        }

        public GerenteDeContas()
        {
            
        }

        public override void aumentarSalario()
        {
            this.Salario *= 1.05;
        }             
    }
}