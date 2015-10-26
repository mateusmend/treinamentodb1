using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.BO
{
    public class Trapezio : Icalculos
    {
        public int base1 { get; set; }
        public int base2 { get; set; }
        public int Altura { get; set; }
        public Trapezio(int b1, int b2, int a)
        {
            base1 = b1;
            base2 = b2;
            Altura = a;
        }
        public void CalcularArea()
        {
            int Area = ((Altura * (base1 + base2)) / 2);
            Console.WriteLine("A área do trapézio é de :"+ Area);
        }

        public void CalcularPerimetro()
        {
            Console.WriteLine("O perimetro do trapézio é de : " + (base1 + base2 + Altura));
        }
    }
}
