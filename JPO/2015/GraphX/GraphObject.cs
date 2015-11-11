using System.Drawing;

namespace GraphX
{
    public abstract class GraphObject
    {
        private static int nextId = 0;

        protected int id;
        #region Id accessers
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        #endregion
        protected byte width;
        #region Width accessers
        public byte Width
        {
            get { return width; }
            set { width = value; }
        }
        #endregion
        protected Color trueColor;
        #region TrueColor accessers
        public Color TrueColor
        {
            get { return trueColor; }
            set { trueColor = value; }
        }
        #endregion
        protected Color color;
        #region Color accessers
        public Color Color
        {
            get { return color; }
            set { color = value; }
        }
        #endregion

        public GraphObject()
        {
            Id = nextId++;
            Width = 0;
            TrueColor = Color.Black;
            Color = Color.Black;
        }
        public GraphObject(byte w, Color t, Color c)
        {
            Id = nextId++;
            Width = w;
            TrueColor = t;
            Color = c;
        }

        public virtual void Paint(Point origin, Font f, Graphics g)
        {

        }
    }
}
