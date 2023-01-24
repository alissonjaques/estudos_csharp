using GerenciaDeEstacionamento.Enum;
using GerenciaDeEstacionamento.Model;

namespace Testes.Model
{
    public class VeiculoTeste
    {
        [Fact]
        public void TestaVeiculoAcelerar()
        {
            // Arrange
            var veiculo = new Veiculo();
            // Act
            veiculo.Acelerar(10);
            // Assert
            Assert.Equal(100, veiculo.VelocidadeAtual);
        } 
        
        [Fact]
        public void TestaVeiculoFrear()
        {
            // Arrange
            var veiculo = new Veiculo();
            // Act
            veiculo.Frear(10);
            // Assert
            Assert.Equal(-150, veiculo.VelocidadeAtual);
        }

        [Fact]
        public void TestaVeiculoTipo()
        {
            // Arrange
            var veiculo = new Veiculo();
            var carro = new Veiculo();
            // Act
            veiculo.Tipo = TipoVeiculo.Motocicleta;
            carro.Tipo = TipoVeiculo.Automovel;
            // Assert
            Assert.Equal(TipoVeiculo.Automovel, new Veiculo().Tipo);
            Assert.Equal(TipoVeiculo.Automovel, carro.Tipo);
            Assert.Equal(TipoVeiculo.Motocicleta, veiculo.Tipo);
        }
    }
}