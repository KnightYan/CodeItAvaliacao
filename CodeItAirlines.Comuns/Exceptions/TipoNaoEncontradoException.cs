using System;

namespace CodeItAirlines.Comuns.Exceptions
{
    public class TipoNaoEncontradoException : Exception
    {
        public TipoNaoEncontradoException()
        {
        }

        public TipoNaoEncontradoException(string mensagem)
            : base(mensagem)
        {
        }
    }
}
