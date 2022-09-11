using System.Text;

using bytebank.model.util;

namespace bytebank.model.funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; private set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }
        public static double TotalDeBonificacoes { get; private set; }
        public static int TotalFuncionarios { get; private set; }

        public Funcionario(string nome, string cpf, double salario)
        {
            this.Nome = nome;
            this.Cpf = cpf;
            this.Salario = salario;
            TotalFuncionarios++;
        }

        public Funcionario()
        {
            this.Nome = "";
            this.Cpf = "";
            this.Salario = 0.0;
            TotalFuncionarios++;
        }

        public double getBonificacao() {
            double bonificacao = Bonificacao.getBonificacao(this);
            Funcionario.TotalDeBonificacoes += bonificacao;
            return bonificacao;
        }
        
        public virtual void aumentarSalario() 
        {
            this.Salario *= 1.1;
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


