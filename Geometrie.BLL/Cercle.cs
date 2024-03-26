using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrie.BLL
{
    public class Cercle : IForme
    {
        public double Rayon { get; private set; }
        public Point Centre { get; private set; }

        /// <summary>
        /// Constructeur par défaut d'un cercle
        /// </summary>
        /// <param name="rayon">Rayon du cercle</param>
        /// <param name="centre"><see cref="Point"/> au centre du cercle</param>
        public Cercle(double rayon, Point centre)
        {
            Rayon = rayon;
            Centre = centre;
        }
        public double CalculerAire()
        {
            //pi*r^2
            return Math.PI * Math.Pow(Rayon, 2);
        }

        public double CalculerPerimetre() => 2 * Math.PI * Rayon;

        public override string ToString() => $"{Centre}-{Rayon}";
    }
}
