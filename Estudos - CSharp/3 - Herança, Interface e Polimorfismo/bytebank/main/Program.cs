﻿using bytebank.model.clientes;
using bytebank.model.contas;
using bytebank.model.funcionarios;
using bytebank.model.util;
using bytebank.SistemaInterno;
using bytebank.ParceiroComercial;

Console.WriteLine("Bem vindo ao ByteBank!\n");
//TestaContas();
//TestaFuncionarios();
TestaLogin();

void TestaLogin() { 
    SistemaInterno sistemaInterno = new SistemaInterno();

    Diretor diretor = new Diretor("Steve Jobs","123.153.134-78","123456");
    sistemaInterno.Logar(diretor,"123456");

    GerenteDeContas gerenteDeContas = new GerenteDeContas("Harry Potter da Silva","456.123.789-78","124578");
    sistemaInterno.Logar(gerenteDeContas,"124578");

    gerenteDeContas.setSenha("124578");
    sistemaInterno.Logar(gerenteDeContas,"456789");

    ParceiroComercial parceiro = new ParceiroComercial("Amazon","456852");
    sistemaInterno.Logar(parceiro,"456852");
    sistemaInterno.Logar(parceiro,"456432");
}

void TestaContas()
{
    Cliente titular = new Cliente("Alisson Jaques","111.111.111-11","Engenheiro da Computação");
    
    ContaCorrente conta = new ContaCorrente(titular, "4543136", (int)124, "Sicoob Minas", (double)30.0);
    conta.Depositar(10000);
    conta.Depositar(-1);
    conta.Sacar(500.55);
    Console.WriteLine("\n"+conta.ToString());
    ContaCorrente contaDefault = new ContaCorrente();
    conta.Transferir(500.55, contaDefault);
    Console.WriteLine("\n"+contaDefault.ToString());
}

void TestaFuncionarios() 
{ 
    GerenteDeContas gerente = new GerenteDeContas("Richard Dawkins","888.888.888-88","123456");
    Console.WriteLine(gerente);
    gerente.aumentarSalario();
    Console.WriteLine("Novo salário do gerente: R$" + gerente.Salario);
    Console.WriteLine("Bonificação gerente: R$ " + gerente.getBonificacao());
    Console.WriteLine("Total de Funcionários: " + Funcionario.TotalFuncionarios);

    Diretor diretor = new Diretor("Galileu Galilei","999.999.999-99","123456");
    Console.WriteLine(diretor);
    diretor.aumentarSalario();
    Console.WriteLine("Novo salário do diretor: R$" + diretor.Salario);
    Console.WriteLine("Bonificação diretor: R$ " + diretor.getBonificacao());
    Console.WriteLine("Total de Funcionários: " + Funcionario.TotalFuncionarios);

    Design design = new Design("Euler","222.222.222-22");
    Console.WriteLine(design);
    design.aumentarSalario();
    Console.WriteLine("Novo salário do design: R$" + design.Salario);
    Console.WriteLine("Bonificação design: R$ " + design.getBonificacao());
    Console.WriteLine("Total de Funcionários: " + Funcionario.TotalFuncionarios);

    Auxiliar auxiliar = new Auxiliar("Sherlock Holmes","333.333.333-33");
    Console.WriteLine(auxiliar);
    auxiliar.aumentarSalario();
    Console.WriteLine("Novo salário do auxiliar: R$" + auxiliar.Salario);
    Console.WriteLine("Bonificação auxiliar: R$ " + auxiliar.getBonificacao());
    Console.WriteLine("Total de Funcionários: " + Funcionario.TotalFuncionarios);

    Console.WriteLine("\nTotal de Bonificações: " + Funcionario.TotalDeBonificacoes);
}

Console.ReadKey();