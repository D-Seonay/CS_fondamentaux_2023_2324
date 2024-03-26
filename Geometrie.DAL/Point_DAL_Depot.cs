using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Geometrie.DAL
{
    public class Point_DAL_Depot : Depot_DAL<Point_DAL>
    {
        public override void Delete(Point_DAL entity)
        {
            OuvrirConnexion();

            Commande.CommandText = "DELETE FROM Points WHERE Id = @Id";
            Commande.Parameters.AddWithValue("@Id", entity.Id);
            Commande.ExecuteNonQuery();

            FermerConnexion();
        }

        public override IEnumerable<Point_DAL> GetAll()
        {
            OuvrirConnexion();

            List<Point_DAL> points = new List<Point_DAL>();

            Commande.CommandText = "SELECT Id, X, Y FROM Points";
            var reader = Commande.ExecuteReader();
            while (reader.Read())
                points.Add(new Point_DAL(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2)));

            reader.Close();
            reader.Dispose();

            FermerConnexion();

            return points;
        }

        public override Point_DAL? GetById(int id)
        {
            OuvrirConnexion();

            Point_DAL? point = null;

            Commande.CommandText = "SELECT X, Y FROM Points WHERE Id = @Id";
            Commande.Parameters.AddWithValue("@Id", id);
            var reader = Commande.ExecuteReader();
            if (reader.Read())
                point = new Point_DAL(id, reader.GetInt32(0), reader.GetInt32(1));

            reader.Close();
            reader.Dispose();

            FermerConnexion();

            return point;
        }

        public override Point_DAL Insert(Point_DAL entity)
        {
            OuvrirConnexion();

            Commande.CommandText = "INSERT INTO Points (X, Y) VALUES (@X, @Y); SELECT SCOPE_IDENTITY()";
            Commande.Parameters.AddWithValue("@X", entity.X);
            Commande.Parameters.AddWithValue("@Y", entity.Y);
            entity.Id = Convert.ToInt32((decimal)Commande.ExecuteScalar());

            FermerConnexion();
            return entity;
        }

        public override Point_DAL Update(Point_DAL entity)
        {
            OuvrirConnexion();

            Commande.CommandText = "UPDATE Points SET X = @X, Y = @Y WHERE Id = @Id";
            Commande.Parameters.AddWithValue("@X", entity.X);
            Commande.Parameters.AddWithValue("@Y", entity.Y);
            Commande.Parameters.AddWithValue("@Id", entity.Id);
            Commande.ExecuteNonQuery();

            FermerConnexion();

            return entity;
        }
    }
}
