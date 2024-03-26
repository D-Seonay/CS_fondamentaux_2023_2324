using Geometrie.BLL;
using Geometrie.DTO;

namespace Geometrie.Services
{
    public class Point_Service
    {
        Point_Depot depot = new Point_Depot();
        public Point_DTO GetById(int id)
        {
            var p_BLL = depot.GetById(id);
            return new Point_DTO() { 
                Id = p_BLL.Id, 
                X = p_BLL.X, 
                Y = p_BLL.Y 
            };
        }
    }
}