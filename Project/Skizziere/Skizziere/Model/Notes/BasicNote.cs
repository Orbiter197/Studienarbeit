namespace Skizziere.Model.Notes
{
    public abstract class BasicNote
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public VisibilityState Visibility { get; set; }
        public string VisibilityString
        {
            get
            {
                return VisibilityConverter.VisibilityToSting(Visibility);
            }
        }

        public BasicNote() { 
            X = 0;
            Y = 0;
            Width = 0; 
            Height = 0;
            Visibility = VisibilityState.Collapsed;
        }

        public BasicNote(int x, int y, int width, int height, VisibilityState visibilityState)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
            Visibility = visibilityState;
        }

        public bool Intersect(int x, int y)
        {
            return X < x && x < X + Width && Y < y && y < Y + Height;
        }

        public bool Intersect(BasicNote note)
        {
            return !(X + Width < note.X || note.X + note.Width < X || Y + Height < note.Y || note.Y + note.Height < Y);
        }

        public void Move(int dx, int dy)
        {
            X += dx;
            Y += dy;
        }

        public void Resize(int dLeft, int dTop, int dRight, int dBottom)
        {
            X -= dLeft;
            Y -= dTop;
            Width += dRight;
            Height += dBottom;
        }
    }
}
