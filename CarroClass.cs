using System;
using System.Collections.Generic;
using System.Text;

namespace Questão_3_lista5
{
    class Carro
    {
        private string placa;
        private int ano;
        private string modelo;

        public string Placa
        {
            get => placa;
            set => placa = value;
        }
        
        public int Ano
        {
            get => ano;
            set => ano = value;
        }

        public string Modelo
        {
            get => modelo;
            set => modelo = value;
        }
    }
}
