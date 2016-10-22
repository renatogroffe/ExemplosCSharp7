using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteRefReturns
{
    public class ClasseExemplo
    {
        private int _contador = 0;

        public void Incrementar()
        {
            _contador++;
        }

        public int ObterValorContador()
        {
            return _contador;
        }

        public ref int ObterContador()
        {
            return ref _contador;
        }
    }
}