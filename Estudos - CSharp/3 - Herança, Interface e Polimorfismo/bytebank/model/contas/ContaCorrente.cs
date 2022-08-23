using System.Text;
using bytebank.model.clientes;

namespace bytebank.model.contas
{
    public class ContaCorrente
    {
        public static int TotalContasCorrentesCadastradas { get; set; }
        public Cliente Titular { get; set; }
        public string Conta { get; set; }
        private int _numeroAgencia;
        public int NumeroAgencia 
        {
            get
            {
                return _numeroAgencia;
            }
            set
            {
                if(value < 0)
                {
                    _numeroAgencia = value;

                }
            }
        }
        public string nomeAgencia { get; set; }
        private double _saldo;

        public double Saldo
        {
            get
            {
                return this._saldo;
            }
            set
            {
                if (value >= 0)
                {
                    _saldo = value;
                }
            }
        }

        public ContaCorrente(Cliente titular, string conta, int numeroAgencia, string nomeAgencia, double saldo)
        {
            this.Titular = titular;
            this.Conta = conta;
            this.NumeroAgencia = numeroAgencia;
            this.nomeAgencia = nomeAgencia;
            this._saldo = saldo;
            TotalContasCorrentesCadastradas++;
        }

        public ContaCorrente()
        {
            Titular = new Cliente();
            Conta = "";
            NumeroAgencia = 0;
            nomeAgencia = "";
            _saldo = 0.0;
            TotalContasCorrentesCadastradas++;

        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor < 0)
            {
                Console.WriteLine("Valor para transferência é inválido!");
                return false;
            }
            else if (valor > _saldo)
            {
                Console.WriteLine("Não foi possível transferir, saldo insuficiente!");
                return false;
            }
            else
            {
                _saldo -= valor;
                contaDestino.Depositar(valor);
                Console.WriteLine("Transferência realizada com sucesso!");
                return true;
            }
        }

        public bool Depositar(double valor)
        {
            if (valor < 0)
            {
                Console.WriteLine("Valor para depósito é inválido!");
                return false;
            }
            else
            {
                _saldo += valor;
                Console.WriteLine("Depósito realizado com sucesso!");
                return true;
            }
        }

        public bool Sacar(double valor)
        {
            if (_saldo < 0)
            {
                Console.WriteLine("O valor para saque não é válido! " + valor + " < 0");
                return false;
            }
            else if (_saldo >= valor)
            {
                _saldo -= valor;
                Console.WriteLine("Saque realizado com sucesso!");
                return true;
            }
            else
            {
                Console.WriteLine("Não foi possível fazer o saque, saldo insuficiente.");
                return false;
            }
        }

        public override string? ToString()
        {
            StringBuilder resultado = new StringBuilder();
            resultado.Append(Titular);
            resultado.Append("\nNúmero da Conta: ").Append(Conta);
            resultado.Append("\nNúmero da Agência: ").Append(NumeroAgencia);
            resultado.Append("\nNome Agência: ").Append(nomeAgencia);
            resultado.Append("\nSaldo: R$ ").Append(_saldo);
            resultado.Append("\nTotal de Contas Correntes Cadastradas: ").Append(ContaCorrente.TotalContasCorrentesCadastradas);
            return resultado.ToString();
        }
    }
}
