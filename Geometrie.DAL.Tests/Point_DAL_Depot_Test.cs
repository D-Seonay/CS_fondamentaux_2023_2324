using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Geometrie.DAL.Tests
{
    /// <summary>
    /// Classe de test pour le dépôt de points <see cref="Point_DAL_Depot"/>
    /// </summary>
    public class Point_DAL_Depot_Test
    {
        //test de l'insert
        [Fact]
        public void Point_DAL_Depot_Insert()
        {
            //Arrange
            Point_DAL_Depot depot = new Point_DAL_Depot();
            Point_DAL p = new Point_DAL(1, 2);

            //Act
            depot.Insert(p);

            //Assert
            Assert.NotNull(p.Id);
        }

    }
}