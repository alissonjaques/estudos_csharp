using GerenciaDeEstacionamento.Enum;
using GerenciaDeEstacionamento.Model;
using Xunit.Abstractions;

namespace Testes.Model
{
    public class VeiculoTeste : IDisposable
    {
        private Veiculo veiculo;
        public ITestOutputHelper Output { get; }

        public VeiculoTeste(ITestOutputHelper saidaConsoleTeste) { 
            veiculo = new Veiculo();
            Output = saidaConsoleTeste;
            Output.WriteLine("Construtor Invocado");
        }

        [Fact]
        [Trait("Veiculo", "Acelerar")]
        public void DeveAcelerarVeiculo()
        {            
            // Act
            veiculo.Acelerar(10);
            
            // Assert
            Assert.Equal(100, veiculo.VelocidadeAtual);
        } 
        
        [Fact]
        [Trait("Veiculo", "Frear")]
        public void DeveFrearVeiculo()
        {
            // Act
            veiculo.Frear(10);
            
            // Assert
            Assert.Equal(-150, veiculo.VelocidadeAtual);
        }

        [Fact]
        [Trait("Veiculo", "Testa Tipo")]
        public void TestaOsTiposDeVeiculos()
        {
            // Arrange
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
        [Trait("Veiculo", "Acelerar")]
        public void TestaVeiculoClass(Veiculo modelo)
        {         
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
            veiculo.Proprietario = "Alisson Santos da Silva";
            veiculo.Tipo = TipoVeiculo.Motocicleta;
            veiculo.Placa = "JDA-7878";
            veiculo.Cor = "Preta";
            veiculo.Modelo = "Fan 150";

            // Act
            string dados = veiculo.ToString();

            // Assert
            Assert.Contains("Ficha do Veículo:", dados);
        }

        public void Dispose()
        {
            Output.WriteLine("Execução do Cleanup: Limpando os objetos.");
        }
    }
}