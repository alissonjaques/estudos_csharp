using System;

using System;
using bytebank.model.funcionarios;
using bytebank.SistemaInterno;

namespace bytebank.SistemaInterno
{
    public abstract class FuncionarioAutenticavel:Funcionario,IAutenticavel
    {
        public string Senha { get; private set; }

        public FuncionarioAutenticavel(string nome, string cpf, double salario, string senha) : base(nome, cpf, salario)
        {
            this.Senha = senha;
        }

        public FuncionarioAutenticavel()
        {
            this.Senha = "123456";
        }

        public void setSenha(string senha)
        {
            this.Senha = senha;
        }

        public bool Autenticar(string senha)
        {
            return this.Senha == senha;
        }
    }
}

