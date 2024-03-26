using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrie.BLL
{
    /// <summary>
    /// Représente une forme géométrique
    /// </summary>
    public interface IForme
    {
        /// <summary>
        /// Calcule l'aire de la forme
        /// </summary>
        /// <returns>un <see cref="double"/></returns>
        double CalculerAire();

        /// <summary>
        /// Calcule le périmètre de la forme
        /// </summary>
        /// <returns>un <see cref="double"/></returns>
        double CalculerPerimetre();
    }
}
