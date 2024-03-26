using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrie.BLL
{
    /// <summary>
    /// Un polygone composé de points
    /// On implémente IEnumerable pour pouvoir itérer sur les points
    /// On inmplémente un indexeur pour pouvoir accéder aux points par leur indice
    /// </summary>
    public abstract class Polygone : IEnumerable<Point>, IForme
    {
        private List<Point> sommets;

        public int Count => sommets.Count; //syntaxe raccourcie pour une propriété en lecture seule
        //public int Count
        //{
        //    get { return sommets.Count; }
        //}

        /// <summary>
        /// Indexeur pour accéder aux points par leur indice
        /// </summary>
        /// <param name="index">indice du point voulu</param>
        /// <returns><see cref="Point"/> le point à l'indice donné</returns>
        public Point this[int index]
        {
            get
            {
                return sommets[index];
            }
            //je pourrais ajouter un set pour modifier un point
        }
        public Polygone(Point a, Point b, Point c, params Point[] autresPoints)
        {
            sommets = new List<Point>() { a, b, c };
            sommets.AddRange(autresPoints);

            //on vérifie que les points ne sont pas identiques
            for (var i = 0; i < Count - 1; i++)
                for (var j = i + 1; j < Count; j++)
                    if (this[i] == this[j])
                        throw new Exceptions.PolygoneException("Deux points identiques dans un polygone", this);

        }

        public IEnumerator<Point> GetEnumerator()
        {
            return sommets.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return sommets.GetEnumerator();
        }

        public abstract double CalculerAire();

        public double CalculerPerimetre()
        {
            var res = 0d;
            //Du premier point à l'avant dernier
            for (var i = 0; i < Count - 1; i++)
            {
                var point1 = this[i];
                var point2 = this[(i + 1)];
                res += point1.Distance(point2);
            }
            res += this[Count - 1].Distance(this[0]);

            return res;
        }

        public override string ToString() => $"[{string.Join("; ", this)}]";
        //{
        //var res= "[";

        //foreach (var point in sommets)
        //{
        //    res += point + "; ";
        //}

        //res+="]";

        //return res;

        //var sb= new StringBuilder("[");
        ////foreach (var point in sommets)
        ////{
        ////    sb.Append(point);
        ////    sb.Append("; ");
        ////}
        ////sb.Remove(sb.Length-2, 2);
        //sb.Append(string.Join("; ", this));

        //sb.Append("]");
        //}
    }
}
