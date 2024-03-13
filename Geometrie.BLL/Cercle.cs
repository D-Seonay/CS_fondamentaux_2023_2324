using System;

namespace Geometrie.BLL
{
    public class Cercle : IForme
    {
        public double Rayon { get; private set; }
        public Point Centre { get; private set; }
        
        public Cercle(Point centre, double rayon)
        {
            Centre = centre;
            Rayon = rayon;
        }
        
        public double CalculerAire()
        {
            return Math.PI * Rayon * Rayon;
        }
        
        public double CalculerPerimetre()
        {
            return 2 * Math.PI * Rayon;
        }
        
        public override string ToString() => $"{Centre} - rayon = {Rayon}";
            
        
    }
}