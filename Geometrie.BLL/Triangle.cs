using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Geometrie.BLL
{
    public class Triangle : Polygone
    {
        public Triangle(Point a, Point b, Point c) : base(a, b, c)
        {

        }

        public override double CalculerAire()
        {
            // Formule de Héron
            double p = CalculerPerimetre() / 2;
            double a = Math.Sqrt(p * (p - this[0].CalculerDistance(this[1])) * (p - this[1].CalculerDistance(this[2])) * (p - this[2].CalculerDistance(this[0])));  
            return a;
        
        }   
    }
}