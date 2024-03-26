using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrie.BLL
{
    public class Triangle : Polygone
    {
        public Triangle(Point a, Point b, Point c)
            : base(a, b, c)
        {

        }

        //avec la formule de Héron
        //https://fr.wikipedia.org/wiki/Formule_de_H%C3%A9ron
        public override double CalculerAire()
        {
            var p = CalculerPerimetre() / 2;
            var ab = this[0].Distance(this[1]);
            var bc = this[1].Distance(this[2]);
            var ca = this[2].Distance(this[0]);
            return Math.Sqrt(p * (p - ab) * (p - bc) * (p - ca));
        }
    }
}
