using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instaciando o Vetor
            ItemMenu[] compras = new ItemMenu[5];
            #region Bebidas
            //Instaciando os indices do vetor
            compras[0] = new Bebida();
            compras[1] = new Bebida();
            compras[2] = new Bebida();

            //Atribuido valores
            compras[0].Nome = "Coca-Cola";
            compras[0].Preco = 3.5f;

            compras[1].Nome = "Fanta Laranja";
            compras[1].Preco = 5.0f;

            compras[2].Nome = "Guarana";
            compras[2].Preco = 8.0f;
            #endregion

            #region Aperitivos
            //Instaciando os indices do vetor
            compras[3] = new Aperitivo();
            compras[4] = new Aperitivo();

            //Atribuido valores
            compras[3].Nome = "Batata Frita";
            compras[3].Preco = 3.0f;

            compras[4].Nome = "Espedinho";
            compras[4].Preco = 4.0f;
            #endregion

            LerCardapio(compras);
            Console.ReadLine();
        }
        static void LerCardapio(ItemMenu[] cardapio)
        {
            for(int i = 0; i < cardapio.Length; i++)
            {
                if(cardapio[i].GetType() == typeof(Bebida))
                {
                    Console.WriteLine("{0} | Tamanho: {1} | R$ {2}", cardapio[i].ImprimirNome(), cardapio[i].Tamanho(), cardapio[i].ImprimirPreco());
                }

                if(cardapio[i].GetType() == typeof(Aperitivo))
                {
                    Console.WriteLine("{0} | R$ {1}", cardapio[i].ImprimirNome(), cardapio[i].ImprimirPreco());
                }
            }
        }
    }
}
