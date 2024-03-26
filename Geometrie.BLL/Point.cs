namespace Geometrie.BLL
{
    /// <summary>
    /// Représente un point dans un repère galiléen
    /// </summary>
    public class Point
    {
        #region Champs et accesseurs
        public int? Id { get; private set; }

        private int x;

        /// <summary>
        /// Abscisse du point
        /// </summary>
        public int X
        {
            get { return x; }
            private set { x = value; }
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
        /// <param name="abscisse">Abscisse du point (x)</param>
        /// <param name="ordonnée">Ordonnée du point (y)</param>
        public Point(int abscisse, int ordonnée)
        {
            X = abscisse;
            Y = ordonnée;
        }

        public Point(int? id, int abscisse, int ordonnée)
            : this(abscisse, ordonnée)
        {
            Id=id;
        }
        #endregion

        #region Méthodes
        public override string ToString()
        {
            return $"({X};{Y})";
        }

        public double Distance(Point autrePoint)
        {
            if(autrePoint == null)
                throw new ArgumentNullException(nameof(autrePoint));
            
            return Math.Sqrt(Math.Pow(X - autrePoint.X, 2) + Math.Pow(Y - autrePoint.Y, 2));
        }



        #endregion

        #region opérateurs
        public static bool operator == (Point p1, Point p2)
        {
            if (p1 is null)
                return (p2 is null);
            if (p2 is null)
                return false;

            return p1.X == p2.X && p1.Y == p2.Y;
        }
        public static bool operator != (Point p1, Point p2)
        {
           return !(p1 == p2);
        }
        #endregion
    }
}
