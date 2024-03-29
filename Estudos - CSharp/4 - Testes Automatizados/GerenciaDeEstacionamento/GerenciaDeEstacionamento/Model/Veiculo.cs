﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GerenciaDeEstacionamento.Enum;

namespace GerenciaDeEstacionamento.Model
{
    public class Veiculo : IEnumerable<object[]>
    {
        //Campos    
        private string _placa;
        private string _proprietario;
        private TipoVeiculo _tipo;
        private string _ticket;

        //Propriedades
        public string IdTicket { get; set; }
        public string Ticket { get => _ticket; set => _ticket = value; }
        public string Placa
        {
            get
            {
                return _placa;
            }
            set
            {
                // Checa se o valor possui pelo menos 8 caracteres
                if (value.Length != 8)
                {
                    throw new FormatException("A placa deve possuir 8 caracteres");
                }
                for (int i = 0; i < 3; i++)
                {
                    // checa se os 3 primeiros caracteres são numeros
                    if (char.IsDigit(value[i]))
                    {
                        throw new FormatException("Os 3 primeiros caracteres devem ser letras!");
                    }
                }
                // checa o Hifem
                if (value[3] != '-')
                {
                    throw new FormatException("O 4° caractere deve ser um hífen");
                }
                // checa se os 3 primeiros caracteres são numeros
                for (int i = 4; i < 8; i++)
                {
                    if (!char.IsDigit(value[i]))
                    {
                        throw new FormatException("Do 5º ao 8º caractere deve-se ter um número!");
                    }
                }
                _placa = value;

            }
        }
        /// <summary>
        /// { get; set; } cria uma propriedade automática, ou seja,
        /// durante a compilação, é gerado um atributo para armazenar
        /// o valor da propriedade e os metodos get e set, respectivamente,
        /// lêem e escrevem diretamente no atributo gerado, sem
        /// qualquer validação. É um recurso útil, pois as propriedades
        /// permitem fazer melhor uso do recurso de Reflection do .Net
        /// Framework, entre outros benefícios.
        /// </summary>
        public string Cor { get; set; }
        public double Largura { get; set; }
        public double VelocidadeAtual { get; set; }
        public string Modelo { get; set; }
        public string Proprietario
        {
            get { return _proprietario; }
            set 
            { 
                if(value.Length < 3)
                {
                    throw new System.FormatException("Nome do proprietário deve ser maior ou igual a 3 caracteres.");
                }
                _proprietario = value;
            }
        }
        public DateTime HoraEntrada { get; set; }
        public DateTime HoraSaida { get; set; }
        public TipoVeiculo Tipo
        {
            get { return _tipo; }
            set
            {
                if (value == null)
                {
                    _tipo = TipoVeiculo.Automovel;
                }
                else { _tipo = value; }
            }
        }

        //Métodos
        public void Acelerar(int tempoSeg)
        {
            this.VelocidadeAtual += (tempoSeg * 10);
        }

        public void Frear(int tempoSeg)
        {
            this.VelocidadeAtual -= (tempoSeg * 15);
        }

        //Construtor
        public Veiculo()
        {

        }

        public Veiculo(string proprietario)
        {
            Proprietario = proprietario;
        }

        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new Veiculo
                {
                    Proprietario = "André Silva",
                    Placa = "ASD-9999",
                    Cor="Verde",
                    Modelo="Fusca"
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public void AlterarDados(Veiculo veiculoAlterado)
        {
            this.Proprietario = veiculoAlterado.Proprietario;
            this.Modelo = veiculoAlterado.Modelo;
            this.Largura = veiculoAlterado.Largura;
            this.Cor = veiculoAlterado.Cor;
        }

        public override string ToString()
        {
            StringBuilder resultado = new StringBuilder();
            resultado.Append($"Ficha do Veículo: \n")
                .Append($"Tipo do Veículo: {this.Tipo.ToString()}\n")
                .Append($"Proprietário: {this.Proprietario}\n")
                .Append($"Modelo: {this.Modelo}\n")
                .Append($"Cor: {this.Cor}\n")
                .Append($"Placa: {this.Placa}\n");
            return resultado.ToString();
        }
    }
}
