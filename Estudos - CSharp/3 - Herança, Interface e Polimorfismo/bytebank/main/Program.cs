using bytebank.model.clientes;
using bytebank.model.contas;
using bytebank.model.funcionarios;

Console.WriteLine("Bem vindo ao ByteBank!\n");
Cliente titular = new Cliente("Alisson Jaques","111.111.111-11","Engenheiro da Computação");

ContaCorrente conta = new ContaCorrente(titular, "4543136", (int)124, "Sicoob Minas", (double)30.0);
conta.Depositar(10000);
conta.Depositar(-1);
conta.Sacar(500.55);
Console.WriteLine("\n"+conta.ToString());
ContaCorrente contaDefault = new ContaCorrente();
conta.Transferir(500.55, contaDefault);
Console.WriteLine("\n"+contaDefault.ToString());

Console.ReadKey();