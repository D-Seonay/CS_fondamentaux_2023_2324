namespace Geometrie.DAL;

public interface IDepot_DAL<T_DAL>
{
    T_DAL Insert(T_DAL entity);
    T_DAL Update(T_DAL entity);
    T_DAL Delete(T_DAL entity);
    T_DAL GetById(int id);
    IEnumerable<T_DAL> GetAll();
    
    
    
}