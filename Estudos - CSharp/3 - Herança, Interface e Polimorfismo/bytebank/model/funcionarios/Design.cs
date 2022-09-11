using System;
using bytebank.model.util;

namespace bytebank.model.funcionarios
{
    public class Design : Funcionario
    {
        public Design(string nome, string cpf) : base(nome, cpf, 3000.0)
        {

        }

        public Design()
        {

        }

        public override void aumentarSalario()
        {
            this.Salario *= 1.11;
        }
    }
}
