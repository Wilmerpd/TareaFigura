using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaFigura
{
    abstract class Figura
    {
        public abstract double CalcularArea();


    }
    class Rectangulo : Figura 
    {
        private double largo;
        private double ancho;
        public Rectangulo(double largo, double ancho)
        {
            this.largo = largo; 
            this.ancho = ancho;
        }
        public override double CalcularArea()
        {
            return largo* ancho;
        }
    }
    class Circulo : Figura
    {
        private double radio;
        public Circulo(double radio)
        {
            this.radio = radio;
        }
        public override double CalcularArea()
        {
            return Math.PI * radio* radio;
        }
       
    }
    class Triangulo : Figura
    {
        private double baseTriangulo;
        private double alturaTriangulo;

        public Triangulo(double baseTriangulo, double alturaTriangulo)
        {
            this.baseTriangulo = baseTriangulo;
            this.alturaTriangulo = alturaTriangulo;


        }
        public override double CalcularArea()
        {
            return baseTriangulo * alturaTriangulo / 2;
        }



    }

}
