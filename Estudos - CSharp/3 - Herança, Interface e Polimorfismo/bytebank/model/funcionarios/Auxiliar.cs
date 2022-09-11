using System;
using bytebank.model.util;

namespace bytebank.model.funcionarios
{
    public class Auxiliar : Funcionario
    {
        public Auxiliar(string nome, string cpf) : base(nome, cpf, 2000.0)
        {

        }

        public Auxiliar()
        {

        }

        public override void aumentarSalario()
        {
            this.Salario *= 1.10;
        }
    }
}