using Xunit;

namespace Geometrie.DAL.Tests
{
    public class Point_DAL_Test
    {
        /*
         * Sur les tests unitaires, 3 étapes :
         * SEA : Setup, Execution, Assert
         * ou AAA : Arrange, Act, Assert
         */

        [Fact]
        public void Point_DAL_Constructor_sans_id()
        {
            //Arrange
            int x = 1;
            int y = 2;

            //Act
            Point_DAL p = new Point_DAL(x, y);

            //Assert
            Assert.NotNull(p); //je vérifie que l'objet a bien été créé
            Assert.Null(p.Id); //je vérifie que l'Id est bien null
            Assert.Equal(x, p.X); //je vérifie que la propriété X a bien été initialisée
            Assert.Equal(y, p.Y); //je vérifie que la propriété Y a bien été initialisée
        }

        //on fait le même test avec une theory
        [Theory]
        [InlineData(1, 2)]
        [InlineData(3, 4)]
        [InlineData(5, 6)]
        public void Point_DAL_Constructor_sans_id_Theory(int x, int y)
        {
            //Arrange

            //Act
            Point_DAL p = new Point_DAL(x, y);

            //Assert
            Assert.NotNull(p); //je vérifie que l'objet a bien été créé
            Assert.Null(p.Id); //je vérifie que l'Id est bien null
            Assert.Equal(x, p.X); //je vérifie que la propriété X a bien été initialisée
            Assert.Equal(y, p.Y); //je vérifie que la propriété Y a bien été initialisée
        }

        [Theory]
        [InlineData(8, 1, 2)]
        [InlineData(6, 3, 4)]
        [InlineData(17, 5, 4)]
        public void Point_DAL_Constructor_avec_id_Theory(int id, int x, int y)
        {
            //Arrange

            //Act
            Point_DAL p = new Point_DAL(id, x, y);
            
            //Assert
            Assert.NotNull(p); //je vérifie que l'objet a bien été créé
            Assert.Equal(id, p.Id); //je vérifie que la propriété X a bien été initialisée
            Assert.Equal(x, p.X); //je vérifie que la propriété X a bien été initialisée
            Assert.Equal(y, p.Y); //je vérifie que la propriété Y a bien été initialisée
        }

    }
}