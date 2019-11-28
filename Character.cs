using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Character
    {
        private string nome;
        private int forca;
        private int agilidade;

        public void Personagem(string _nome, int _forca, int _agilidade)
        {
            nome = _nome;
            forca = _forca;
            agilidade = _agilidade;
        }

        public void LerPersonagem()
        {
            Console.WriteLine("O nome do personagem e {0} , possui forca {1} e agilidade {2}", nome, forca, agilidade);
        }
    }
}
