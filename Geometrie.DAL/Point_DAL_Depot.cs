using System.Data.SqlClient;

namespace Geometrie.DAL
{
    public class Point_DAL_Depot : Depot_DAL<Point_DAL>
    {
        public override Point_DAL Insert(Point_DAL entity)
        {
            OuvrirConnexion();
            Commande.CommandText = "INSERT INTO Point (X, Y) VALUES (@X, @Y); SELECT SCOPE_IDENTITY()";
            Commande.Parameters.AddWithValue("@x", entity.X);
            Commande.Parameters.AddWithValue("@y", entity.Y);
            entity.Id = Convert.ToInt32((decimal)Commande.ExecuteScalar());
            FermerConnexion();
            return entity;
        }
        public override Point_DAL Update(Point_DAL entity)
        {
            OuvrirConnexion();
            Commande.CommandText = "UPDATE Point SET X = @X, Y = @Y WHERE Id = @Id";
            Commande.Parameters.AddWithValue("@x", entity.X);
            Commande.Parameters.AddWithValue("@y", entity.Y);
            Commande.Parameters.AddWithValue("@id", entity.Id);
            Commande.ExecuteNonQuery();
            FermerConnexion();
            return entity;
        }

        public override Point_DAL Delete(Point_DAL entity)
        {
            throw new NotImplementedException();
        }

        public override Point_DAL GetById(int id)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<Point_DAL> GetAll()
        {
            OuvrirConnexion();
            
            List<Point_DAL> points = new List<Point_DAL>();
            
            Commande.CommandText = "SELECT Id, X, Y FROM Point";
            var reader = Commande.ExecuteReader();
            if (reader.Read()) 
                points.Add(new Point_DAL(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2)));

            reader.Close();
            reader.Dispose();
                
            FermerConnexion();
                
            return points;
                
              
        }
    }
}