using System;
using System.Collections.Generic;
using System.Text;

namespace Questão_5_lista5
{
    class Triangulo
    {
        private double lado;

        public double Lado
        {
            get => lado;
            set => lado = value;
        }

        public Double CalcularArea()
        {
            double area = ((Math.Pow(lado, 2) * Math.Sqrt(3)) / 4);
            return area;
        }
        public Double CalcularPerimetro()
        {
            double perimetro = lado * 3;
            return perimetro;
        }
    }
}
