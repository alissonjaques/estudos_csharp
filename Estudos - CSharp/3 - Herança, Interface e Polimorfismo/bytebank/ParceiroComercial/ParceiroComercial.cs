using System;

using System;
using bytebank.model.funcionarios;
using bytebank.SistemaInterno;

namespace bytebank.ParceiroComercial
{
    public class ParceiroComercial : IAutenticavel
    {
        public string Senha { get; private set; }
        public string Nome { get; private set; }

        public ParceiroComercial(string nome, string senha)
        {
            this.Nome = nome;
            this.Senha = senha;
        }

        public ParceiroComercial()
        {
            this.Nome = "";
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