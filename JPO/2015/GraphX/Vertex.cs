using System.Drawing;

namespace GraphX
{
    public class Vertex : GraphObject
    {
        public static readonly Size defaultSize = new Size(40, 40);
        public static readonly byte defaultWidth = 1;
        public static readonly Color defaultColor = Color.Black;
        public static readonly Color hoveredColor = Color.DarkRed;
        public static readonly Color selectedColor = Color.Red;

        private static int nextId = 0;

        private string name;
        #region Name accessers
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        #endregion
        private Point location;
        #region Point accessers
        public Point Location
        {
            get { return location; }
            set { location = value; }
        }
        #endregion
        private Size size;
        #region Size accessers
        public Size Size
        {
            get { return size; }
            set { size = value; }
        }
        #endregion

        public Vertex() : base(defaultWidth, defaultColor, defaultColor)
        {
            Id = nextId++;
            Name = "";
            Location = new Point(0, 0);
            Size = defaultSize;
        }

        public Vertex(Point p) : base(defaultWidth, defaultColor, defaultColor)
        {
            Id = nextId++;
            Name = "Vertex" + Id;
            Location = p;
            Size = defaultSize;
        }

        public override void Paint(Point origin, Font f, Graphics g)
        {
            Point p = new Point(origin.X + Location.X - Size.Width / 2, origin.Y + Location.Y - Size.Height / 2);
            Pen pen = new Pen(Color, Width);
            g.DrawEllipse(pen, p.X, p.Y, Size.Width, Size.Height);
            g.DrawString(Name, f, new SolidBrush(Vertex.defaultColor), p.X + Size.Width, p.Y + Size.Height);
        }

        public bool Contains(Point other)
        {
            return new Rectangle(Location.X - Size.Width / 2, Location.Y - Size.Height / 2, Size.Width, Size.Height).Contains(other);
        }

        public bool Intersects(Vertex other)
        {
            return new Rectangle(Location.X - Size.Width / 2, Location.Y - Size.Height / 2, Size.Width, Size.Height).IntersectsWith(new Rectangle(other.Location.X - Size.Width / 2, other.Location.Y - Size.Height / 2, other.Size.Width, other.Size.Height));
        }
    }
}