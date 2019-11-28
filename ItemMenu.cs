using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class ItemMenu
    {
        private string nome;
        private float preco;

        public float Preco { get => preco; set => preco = value; }

        public string Nome { get => nome; set => nome = value; }

        public virtual string ImprimirNome()
        {
            return nome;
        }

        public virtual float ImprimirPreco()
        {
            return preco;
        }

        public virtual string Tamanho()
        {
            return null;
        }
    }
}
