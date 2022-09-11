﻿using System;
using bytebank.model.util;

namespace bytebank.model.funcionarios
{
	public class Diretor:Funcionario
	{
        public Diretor(string nome, string cpf):base(nome, cpf, 5000.0)
        {
            
        }
        
        public Diretor()
        {
        
        }

        public override void aumentarSalario()
        {
            this.Salario *= 1.15;
        }
    }
}
