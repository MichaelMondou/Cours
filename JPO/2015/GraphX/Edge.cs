using System.Drawing;

namespace GraphX
{
    public class Edge : GraphObject
    {
        public static readonly byte defaultWidth = 1;
        public static readonly Color defaultColor = Color.Black;

        private Vertex source;
        #region Source accessers
        public Vertex Source
        {
            get { return source; }
            set { source = value; }
        }
        #endregion
        private Vertex destination;
        #region Destination accessers
        public Vertex Destination
        {
            get { return destination; }
            set { destination = value; }
        }
        #endregion

        public Edge(Vertex s, Vertex d) : base(defaultWidth, defaultColor, defaultColor)
        {
            Source = s;
            Destination = d;
        }

        public override void Paint(Point origin, Font f, Graphics g)
        {
            Point sourceCenter = new Point(origin.X + Source.Location.X, origin.Y + Source.Location.Y);
            Point destinationCenter = new Point(origin.X + Destination.Location.X, origin.Y + Destination.Location.Y);
            Pen pen = new Pen(Color, Width);
            g.DrawLine(pen, sourceCenter, destinationCenter);
        }
    }
}
