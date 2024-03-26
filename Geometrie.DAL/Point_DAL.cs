namespace Geometrie.DAL
{
    public class Point_DAL
    {
        public int? Id { get; set; } // ? = nullable Nullable<int>
        public int X { get; set; }
        public int Y { get; set; }

        public Point_DAL(int x, int y)=> (X, Y) = (x, y);
        public Point_DAL(int id, int x, int y) : this(x, y) => Id = id;
    }
}