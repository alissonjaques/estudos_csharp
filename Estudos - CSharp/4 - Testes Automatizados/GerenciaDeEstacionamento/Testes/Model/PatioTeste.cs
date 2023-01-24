using GerenciaDeEstacionamento.Model;
using GerenciaDeEstacionamento.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testes.Model
{
    public class PatioTeste
    {
        [Fact]
        public void ValidaFaturamento()
        {
            // Arrange
            var estacionamento = new Patio();
            var veiculo = new Veiculo();
            veiculo.Proprietario = "João da Silva";
            veiculo.Tipo = TipoVeiculo.Automovel;
            veiculo.Cor = "Amarelo";
            veiculo.Modelo = "Combe";
            veiculo.Placa = "AAA-7777";
            estacionamento.RegistrarEntradaVeiculo(veiculo);
            estacionamento.RegistrarSaidaVeiculo(veiculo.Placa);

            // Act
            double faturamento = estacionamento.TotalFaturado();

            // Assert
            Assert.Equal(2, faturamento);
        }

        [Theory]
        [InlineData("Amanda Silva","ASD-9999","Preto","Gol")]
        [InlineData("Joaquim Fracisco Santos","ABD-8888","Vermelha","Titan")]
        [InlineData("Juvenal Domingues Barbosa","CAS-4444","Cinza","Corsa")]
        public void ValidaFaturamentoComVariosVeiculos(string proprietario,
            string placa,
            string cor,
            string modelo)
        {
            // Arrange
            var estacionamento = new Patio();
            var veiculo = new Veiculo();
            veiculo.Proprietario = proprietario;

            if (modelo == "Titan")
            {
                veiculo.Tipo = TipoVeiculo.Motocicleta;
            }
            else
            {
                veiculo.Tipo = TipoVeiculo.Automovel;
            }            
            
            veiculo.Cor = cor;
            veiculo.Modelo = modelo;
            veiculo.Placa = placa;
            estacionamento.RegistrarEntradaVeiculo(veiculo);
            estacionamento.RegistrarSaidaVeiculo(veiculo.Placa);

            // Act
            double faturamento = estacionamento.TotalFaturado();

            // Assert
            if(modelo == "Titan")
            {
                Assert.Equal(1, faturamento);
            }
            else
            {
                Assert.Equal(2, faturamento);
            }            
        }
    }
}
