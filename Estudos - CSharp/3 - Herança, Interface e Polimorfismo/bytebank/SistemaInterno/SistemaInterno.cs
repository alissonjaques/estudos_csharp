using System;
using bytebank.model.funcionarios;

namespace bytebank.SistemaInterno
{
    public class SistemaInterno
    {
        public bool Logar(IAutenticavel autenticavel, string senha)
        {
            bool usuarioAutenticado = autenticavel.Autenticar(senha);
            if (usuarioAutenticado)
            {
                Console.WriteLine("Bem vindo ao sistema!");
            }
            else
            {
                Console.WriteLine("Senha incorreta!");
            }
            return usuarioAutenticado;
        }
    }
}

