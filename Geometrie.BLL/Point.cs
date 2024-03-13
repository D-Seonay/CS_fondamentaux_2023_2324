using System;
namespace Geometrie.BLL
{
    /// <summary>
    /// Représente un point dans un repère galiléen
    /// </summary>
    public class Point
    {
        #region Champs et accesseurs
        
        private int x;
        
        /// <summary>
        /// Abscisse du point
        /// </summary>
        public int X
        {
            get { return x; }
            set { x = value; }
        }

        /// <summary>
        /// Ordonnée du point
        /// </summary>
        public int Y { get; private set; }
        #endregion

        #region Constructeurs
        /// <summary>
        /// Crée un point à l'abscisse et l'ordonnée données
        /// </summary>
        /// <param name="abscisse">Abscisse du point</param>
        /// <param name="ordonnee">Ordonnée du point</param>
        public Point(int abscisse, int ordonnee)
        {
            X = abscisse;
            Y = ordonnee;
        }
        #endregion
        
        #region Méthodes
        
        public override string ToString()
        {
            return $"({X}, {Y})";
        }
        
        public double CalculerDistance(Point autrePoint) =>
            Math.Sqrt(Math.Pow(X - autrePoint.X, 2) + Math.Pow(Y - autrePoint.Y, 2));
        #endregion
        
        #region Opérateurs
        public static bool operator ==(Point p1, Point p2) => p1.X == p2.X && p1.Y == p2.Y;
        public static bool operator !=(Point p1, Point p2) => !(p1 == p2);
        #endregion
    }
}