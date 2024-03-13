using System;

namespace Geometrie.BLL
{
    public class Quadrilatère : IForme
    
    {
        
        public Point A { get; private set; }
        public Point B { get; private set; }
        public Point C { get; private set; }
        public Point D { get; private set; }
        
        public Quadrilatère(Point a, Point b, Point c, Point d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
        }
        
        public double CalculerAire()
        {
            double aire = 0;
            aire += A.X * B.Y - B.X * A.Y;
            aire += B.X * C.Y - C.X * B.Y;
            aire += C.X * D.Y - D.X * C.Y;
            aire += D.X * A.Y - A.X * D.Y;
            return Math.Abs(aire) / 2;
        }
        
        public double CalculerPerimetre()
        {
            double perimetre = 0;
            perimetre += A.CalculerDistance(B);
            perimetre += B.CalculerDistance(C);
            perimetre += C.CalculerDistance(D);
            perimetre += D.CalculerDistance(A);
            return perimetre;
        }
        
        public override string ToString() => $"[{A}, {B}, {C}, {D}]";
        
    }
}