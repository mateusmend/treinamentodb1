using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.BO
{
    public class Losango : Icalculos
    {
        public int Base { get; set; }
        public int Altura { get; set; }
        public Losango(int b, int a)
        {
            Base = b;
            Altura = a;
        }
        public void CalcularArea()
        {
            int area = (Altura * Base) / 2;
            Console.WriteLine("A área do Losango é de : "+ area);
        }

        public void CalcularPerimetro()
        {
            int perimetro = (Altura * Altura) + (Base * Base);
            Console.WriteLine("O perimetro do Losando é de : " + perimetro);
        }
    }
}
