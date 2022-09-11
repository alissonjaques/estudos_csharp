using System;
using bytebank.model.util;

namespace bytebank.model.funcionarios
{
    public class GerenteDeContas : Funcionario
    {
        public GerenteDeContas(string nome, string cpf) : base(nome, cpf, 4000.0)
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