using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Bebida : ItemMenu
    {
        private string tamanho;

        public override float ImprimirPreco()
        {
            return this.Preco;
        }
        public override string ImprimirNome()
        {
            return this.Nome;
        }

        public override string Tamanho()
        {
            if (Preco <= 3.5f)
            {
                tamanho = "pequeno";
            }
            else if(Preco < 6)
            {
                tamanho = "medio";
            }
            else if (Preco >= 7)
            {
                tamanho = "grande";
            }
            else
            {
                tamanho = null;
            }

            return this.tamanho;
        }

    }
}
