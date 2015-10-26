using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.BO
{
    public class Quadrado : Icalculos
    {
        public int altura{get; set;}
        public int lado { get; set; }
        public Quadrado(int Altura, int Lado)
        {
            altura = Altura;
            lado = Lado;
        }
        public void CalcularArea()
        {
            Console.WriteLine("A Área do Quadrado é : " + altura*lado);
        }

        public void CalcularPerimetro()
        {
            int perimetro = (altura*2) + (lado*2);
            Console.WriteLine("O Perimetro do Quadrado é: " + perimetro);
        }
    }
}
