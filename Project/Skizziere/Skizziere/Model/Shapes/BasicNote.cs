using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skizziere.Model
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
