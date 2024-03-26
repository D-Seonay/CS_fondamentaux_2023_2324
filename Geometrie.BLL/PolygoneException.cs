using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrie.BLL.Exceptions
{
    public class PolygoneException : Exception
    {
        private IEnumerable<Point> points;

        public IEnumerable<Point> Points => points;
        public PolygoneException(string message, IEnumerable<Point> points) : base(message)
        {
            this.points = points;
        }
    }
}
