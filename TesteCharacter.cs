using System;

namespace ConsoleApp2
{
    class TesteCharacter
    {
        static void Main(string[] args)
        {
            // Instaciando os indices do vetor
            Character[] chatacterS = new Character[4];
            for (int i = 0; i < chatacterS.Length; i++)
            {
                chatacterS[i] = new Character();
            }
            // Preenchendo os indices
            chatacterS[0].Personagem("Fabricio", +20, +40);
            chatacterS[1].Personagem("Alexandre", +20, +40);
            chatacterS[2].Personagem("Pedro", -80, +99999);
            chatacterS[3].Personagem("Joao", -20, -35);

            LerFicha(chatacterS);
            Console.ReadLine();
        }
        static void LerFicha(Character[] ficha)
        {
            for(int i = 0; i < ficha.Length; i++)
            {
                ficha[i].LerPersonagem();
            }
        }
    }
}
