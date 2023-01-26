using GerenciaDeEstacionamento.Model;
using GerenciaDeEstacionamento.Enum;
using Xunit.Abstractions;

namespace Testes.Model
{
    public class PatioTeste : IDisposable
    {
        private Patio estacionamento;
        private Veiculo veiculo;
        public ITestOutputHelper Output { get; }

        public PatioTeste(ITestOutputHelper saidaConsoleTeste)
        {
            estacionamento = new Patio();
            veiculo = new Veiculo();
            Output = saidaConsoleTeste;
            Output.WriteLine("Construtor Invocado.");
        }

        [Fact]
        [Trait("Patio","TotalFaturado")]
        public void DeveRetornar2AoRegistrarEntradaESaidaDeUmAutomovel()
        {          
            // Arrange
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
        [Trait("Patio", "TotalFaturado")]
        public void DeveValidarFaturamentoComVariosVeiculos(string proprietario,
            string placa,
            string cor,
            string modelo)
        {
            // Arrange
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

        [Fact(DisplayName = "Deve ser Ignorado", Skip = "Exemplo de teste ignorado.")]
        public void ExemploTesteIgnorado()
        {

        }

        [Theory]
        [InlineData("Amanda Silva", "ASD-9999", "Preto", "Gol")]
        [Trait("Patio", "TotalFaturado")]
        public void DeveLocalizarVeiculoNoPatioPeloIdDoTicket(string proprietario,
            string placa,
            string cor,
            string modelo)
        {
            // Arrange
            veiculo.Proprietario = proprietario;
            veiculo.Tipo = TipoVeiculo.Automovel;
            veiculo.Cor = cor;
            veiculo.Modelo = modelo;
            veiculo.Placa = placa;
            estacionamento.RegistrarEntradaVeiculo(veiculo);

            // Act
            var consultado = estacionamento.PesquisaVeiculo(veiculo.IdTicket);

            // Assert
            Assert.Contains("======= Ticket Estacionamento =======", veiculo.Ticket);
        }

        [Fact]
        [Trait("Patio","AlterarDadosVeiculo")]
        public void DeveAlterarDadosVeiculo()
        {
            // Arrange
            veiculo.Proprietario = "Pedro Abreu";
            veiculo.Cor = "Preto";
            veiculo.Modelo = "Corsa";
            veiculo.Placa = "ASD-8888";
            estacionamento.RegistrarEntradaVeiculo(veiculo);

            var veiculoAlterado = new Veiculo();
            veiculoAlterado.Proprietario = "Pedro Abreu";
            veiculoAlterado.Cor = "Branco";
            veiculoAlterado.Modelo = "Corsa";
            veiculoAlterado.Placa = "ASD-8888";

            // Act
            Veiculo alterado = estacionamento.AlterarDadosVeiculo(veiculoAlterado);

            // Assert
            Assert.Equal(alterado.Cor, veiculoAlterado.Cor);
        }

        public void Dispose()
        {
            Output.WriteLine("Execução do Cleanup: Limpando os objetos.");
        }
    }
}