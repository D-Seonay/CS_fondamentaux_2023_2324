namespace Geometrie.BLL
{
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
        ///  <returns>un <see cref="double"/></returns>
        double CalculerPerimetre();
        
    }
}