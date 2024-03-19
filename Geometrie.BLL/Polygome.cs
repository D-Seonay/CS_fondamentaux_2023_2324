using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Geometrie.BLL
{
    /// <summary>
    /// Un polygone composé de points
    /// 
    /// </summary>
    public abstract class Polygone : IEnumerable<Point> , IForme
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
        /// <param name="index">indice du point</param>
        /// <returns><see cref="Point"/>le point à l'indice donné</returns>
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
            for (int i = 0; i < Count; i++)
            {
                for (int j = i + 1; j < Count; j++)
                {
                    if (this[i] == this[j])
                    {
                        throw new Exceptions.PolygoneException("Deux points identiques dans un polygone", this);
                    }
                }
            }
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
            double perimetre = 0;
            for (int i = 0; i < Count; i++)
            {
                perimetre += this[i].CalculerDistance(this[(i + 1) % Count]);
            }
            return perimetre;
        }

        //public override string ToString()
        //{
        //    var coord = "[";
            
        //    foreach (var point in sommets)
        //    {
        //        coord += point + "; ";
        //    }
        //    coord += "]";

        //    return coord;
        //}

        public override string ToString() => $"[{string.Join(";", sommets)}]";
    }
}