using System;
using System.Collections.Generic;


namespace Geometrie.BLL.Exceptions
{
    public class PolygoneException : System.Exception
    {
        private IEnumerable<Point> points;
        
        public IEnumerable<Point> Points => points;
        
        public PolygoneException(string message, IEnumerable<Point> points) : base(message)
        {
            this.points = points;
        }
    }
}
