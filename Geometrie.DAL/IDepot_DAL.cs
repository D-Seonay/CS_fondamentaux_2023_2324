using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrie.DAL
{
    public interface IDepot_DAL<T_DAL>
    {
        T_DAL Insert(T_DAL entity);
        T_DAL Update(T_DAL entity);
        void Delete(T_DAL entity);
        T_DAL? GetById(int id);
        IEnumerable<T_DAL> GetAll();
    }
}