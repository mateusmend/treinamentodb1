using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.BO
{
    public class Retangulo : Icalculos
    {
        public int altura { get; set; }
        public int lado { get; set; }
        public Retangulo(int Altura, int Lado)
        {
            altura = Altura;
            lado = Lado;
        }
        public void CalcularArea()
        {
            Console.WriteLine("A área do retangulo é de :" + (altura * lado));
        }

        public void CalcularPerimetro()
        {
            int perimetro = (altura * 2) + (lado * 2);
            Console.WriteLine("O perimetro do retangulo é de : " + perimetro);
        }
    }
}
