using bytebank.model.clientes;
using bytebank.model.contas;
using bytebank.model.funcionarios;
using bytebank.model.util;

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

Funcionario funcionario = new Funcionario("Richard Dawkins","888.888.888-88",(double)1000.0);
Console.WriteLine(funcionario);
Console.WriteLine("Bonificação funcionario: R$ " + funcionario.getBonificacao());

Diretor diretor = new Diretor("Galileu Galilei","999.999.999-99",(double)500.0);
Console.WriteLine(diretor);
Console.WriteLine("Bonificação diretor: R$ " + diretor.getBonificacao());

Console.WriteLine("Total de Bonificações: " + Funcionario.TotalDeBonificacoes);

Console.ReadKey();