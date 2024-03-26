using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrie.DAL
{
    public abstract class Depot_DAL<Type_DAL> : IDepot_DAL<Type_DAL>
    {
        private string chaineDeConnexion;

        protected SqlConnection Connexion { get; set; }

        public ConnectionState ConnectionState => Connexion.State;
        
        protected SqlCommand Commande { get; set; }

        protected Depot_DAL()
        {
            var builder = new ConfigurationBuilder();
            var config = builder.AddJsonFile("app.json", false, true).Build();
            chaineDeConnexion = config.GetConnectionString("default");
        }

        protected void OuvrirConnexion()
        {
            OuvrirConnexion(new SqlConnection(chaineDeConnexion), new SqlCommand());
        }
        public void OuvrirConnexion(SqlConnection connexion, 
                                        SqlCommand commande)
        {
            Connexion = connexion;
            Connexion.ConnectionString = chaineDeConnexion;
            Commande = commande;
            Commande.Connection = Connexion;
            Connexion.Open();
        }

        protected void FermerConnexion()
        {
            FermerConnexion(Connexion, Commande);
        }

        public void FermerConnexion(SqlConnection connexion, 
                                                   SqlCommand commande)
        {
            connexion.Close();
            connexion.Dispose();
            commande.Dispose();
        }

        #region Méthodes statiques transmises aux classes filles
        public abstract void Delete(Type_DAL entity);

        public abstract IEnumerable<Type_DAL> GetAll();

        public abstract Type_DAL? GetById(int id);

        public abstract Type_DAL Insert(Type_DAL entity);

        public abstract Type_DAL Update(Type_DAL entity); 
        #endregion
    }
}
