using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Geometrie.DAL
{
    public abstract class Depot_DAL<Type_DAL> : IDepot_DAL<Type_DAL>
    {
        private string chaineDeConnexion;

        protected SqlConnection Connexion { get; set; }
        protected SqlCommand Commande { get; set; }
        protected Depot_DAL()
        {
            var builder = new ConfigurationBuilder();
            var config = builder.AddJsonFile("app.json", false, true).Build();
            var chaineDeConnexion = config.GetConnectionString("default");
        }
        public void OuvrirConnexion()
        {
            Connexion = new SqlConnection(chaineDeConnexion);
            Commande = new SqlCommand();
            Commande.Connection = Connexion;
            Connexion.Open();
        }
        public void FermerConnexion()
        {
            Connexion.Close();
            Connexion.Dispose();
            Commande.Dispose();
        }

        #region Méthodes statiques transmises aux classes filles
        public abstract Type_DAL Insert(Type_DAL entity);
        public abstract Type_DAL Update(Type_DAL entity);
        public abstract Type_DAL Delete(Type_DAL entity);
        public abstract Type_DAL GetById(int id);
        public abstract IEnumerable<Type_DAL> GetAll();
        #endregion
    }
}