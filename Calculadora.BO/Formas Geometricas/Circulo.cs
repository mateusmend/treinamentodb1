using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.BO
{
    public class Circulo : Icalculos
    {
        public int raio { get; set; }
        public Circulo(int Raio)
        {
            raio = Raio;
        }
        public void CalcularArea()
        {
            double area = Math.PI * (raio * raio);
            Console.WriteLine("A área do circulo é de : " + area);
        }

        public void CalcularPerimetro()
        {
            double perimetro = 2 * Math.PI * raio;
            Console.WriteLine("O perimetro do circulo é de : " + perimetro);
        }
    }
}
