using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.model
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Profissao { get; set; }
        public static int TotalClienteCadastrados { get; set; }

        public Cliente(string nome, string cpf, string profissao)
        {
            this.Nome = nome;
            this.Cpf = cpf;
            this.Profissao = profissao;
            TotalClienteCadastrados++;
        }

        public Cliente()
        {
            Nome = "";
            Cpf = "";
            Profissao = "";
            TotalClienteCadastrados++;
        }

        public override string? ToString()
        {
            StringBuilder resultado = new StringBuilder();
            resultado.Append("Nome do Titular: ").Append(Nome);
            resultado.Append("\nCPF: ").Append(Cpf);
            resultado.Append("\nProfissão: ").Append(Profissao);
            resultado.Append("\nTotal de Clientes Cadastrados: ").Append(Cliente.TotalClienteCadastrados);
            return resultado.ToString();
        }
    }
}
