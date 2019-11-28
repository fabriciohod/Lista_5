using System;

namespace Questão_5_lista5
{
    class TesteTriangulo
    {
        static void Main(string[] args)
        {
            Triangulo triangulo1 = new Triangulo();
            triangulo1.Lado = 3;

            Console.WriteLine("a area do triangulo e " + triangulo1.CalcularArea());
            Console.WriteLine("*************************************************************");
            Console.WriteLine("o perimetro do triangulo e " + triangulo1.CalcularPerimetro());
            Console.ReadLine();
        }
    }
}
