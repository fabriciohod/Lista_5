using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Aperitivo : ItemMenu
    {
        

        public override string ImprimirNome()
        {
            return this.Nome;
        }
    }
}
