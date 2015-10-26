using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.BO
{
    public class Triangulo : Icalculos
    {
        private int valorTriangulo;
        public int triangulo {
            get{
              return valorTriangulo;
            } 
            set
            {
             if (value > 0)
	         {
                 valorTriangulo = value;
	         }
             else
             {
                 valorTriangulo = 0;
             }
            }
        }
        public Triangulo(int valor){
            triangulo = valor;
        }
        public void CalcularArea()
        {
            int perimetro = triangulo * 3;
            Console.WriteLine("Tamanho da Area de um Triangulo: "+ perimetro/2);
        }

        public void CalcularPerimetro()
        {
            Console.WriteLine("Tamanho do Perimetro de um Triangulo: "+ triangulo*3);
        }
    }
}
