using GerenciaDeEstacionamento.Enum;
using GerenciaDeEstacionamento.Model;

namespace Testes.Model
{
    public class VeiculoTeste
    {
        [Fact]
        [Trait("Veiculo", "Acelerar()")]
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
        [Trait("Veiculo", "Frear()")]
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
        [Trait("Veiculo", "Testa Tipo")]
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

        [Theory]
        [ClassData(typeof(Veiculo))]
        [Trait("Veiculo", "Acelerar()")]
        public void TestaVeiculoClass(Veiculo modelo)
        {
            // Arrange
            var veiculo = new Veiculo();
            
            // Act
            veiculo.Acelerar(10);
            modelo.Acelerar(10);
            
            // Assert
            Assert.Equal(modelo.VelocidadeAtual, veiculo.VelocidadeAtual);
        }

        [Fact]
        public void TestaDadosVeiculos()
        {
            // Arrange
            var moto = new Veiculo();
            moto.Proprietario = "Alisson Santos da Silva";
            moto.Tipo = TipoVeiculo.Motocicleta;
            moto.Placa = "JDA-7878";
            moto.Cor = "Preta";
            moto.Modelo = "Fan 150";

            // Act
            string dados = moto.ToString();

            // Assert
            Assert.Contains("Ficha do Veículo:", dados);
        }
    }
}