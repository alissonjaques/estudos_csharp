using System;
using bytebank.model.funcionarios;

namespace bytebank.SistemaInterno
{
    public interface IAutenticavel
    {
        public bool Autenticar(string senha);
    }
}
