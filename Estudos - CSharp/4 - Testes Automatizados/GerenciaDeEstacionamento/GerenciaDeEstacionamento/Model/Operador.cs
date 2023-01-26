using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciaDeEstacionamento.Model
{
    public class Operador
    {
        // Campos
        private string _matricula;
        private string _nome;

        // Propriedades
        public string Matricula { get => _matricula; set => _matricula = value; }
        public string Nome { get => _nome; set => _nome = value; }

        public Operador() 
        { 
            this.Matricula = new Guid().ToString().Substring(0,8);
        }

        public override string ToString()
        {
            return new StringBuilder()
                .Append($"Operador: {this.Nome}\n")
                .Append($"Matrícula: {this.Matricula}")
                .ToString();
        }
    }
}
