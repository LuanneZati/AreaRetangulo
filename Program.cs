using System;

namespace AreaRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the height: ");
            float Height = float.Parse(Console.ReadLine());
            Console.Write("Enter the width: ");
            float Width = float.Parse(Console.ReadLine());
            Retangulo retangulo = new Retangulo(Height, Width);

            Console.WriteLine("Area: " + retangulo.Result);
        }

    }
}