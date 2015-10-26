using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.BO
{
    public class Paralelogramo : Icalculos
    {
        public int Base{get; set;}
        public int Altura { get; set; }
        public Paralelogramo(int b, int a)
        {
            Base = b;
            Altura = a;
        }
        public void CalcularArea()
        {
            Console.WriteLine("A área do Paralelogramo é : " + Base *Altura);
        }

        public void CalcularPerimetro()
        {
            Console.WriteLine("O perimetro do paralelogramo é :" + (Base * Altura) / 2);
        }
    }
}
