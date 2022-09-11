using System;
using bytebank.model.funcionarios;

namespace bytebank.SistemaInterno
{
    public abstract class Autenticavel:Funcionario
    {
        public string Senha { get; private set; }

        public Autenticavel(string nome, string cpf, string salario, string senha) : base(nome, cpf, salario)
        {
            this.Senha = senha;
        }

        public Autenticavel()
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
