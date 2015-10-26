using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculadora.BO;
namespace CalculadoraO.O
{
    public class Program
    {
        static void Main(string[] args)
        {
            Triangulo t = new Triangulo(10);
            Circulo c = new Circulo(50);
            Losango l = new Losango(10, 5);
            Paralelogramo p = new Paralelogramo(10, 10);
            Quadrado q = new Quadrado(10, 5);
            Retangulo r = new Retangulo(10, 5);
            Trapezio tp = new Trapezio(5, 5, 10);
            Calcule calculadora = new Calcule();
            calculadora.CalcularArea(t);
            calculadora.CalcularArea(c);
            Console.ReadKey();
        }
    }
}
