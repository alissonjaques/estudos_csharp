using System.Text;

namespace bytebank.model.funcionarios
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public double Salario { get; set; }

        public Funcionario(string nome, string cpf, double salario)
        {
            this.Nome = nome;
            this.Cpf = cpf;
            this.Salario = salario;
        }

        public Funcionario()
        {
            this.Nome = "";
            this.Cpf = "";
            this.Salario = 0.0;
        }

        public override string? ToString()
        {
            StringBuilder resultado = new StringBuilder();
            resultado.Append("\nNome: ").Append(Nome);
            resultado.Append("\nCPF: ").Append(Cpf);
            resultado.Append("\nSalário: R$ ").Append(Salario);
            return resultado.ToString();
        }

    }
    
}


