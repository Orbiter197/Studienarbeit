using System.Collections.Generic;
using System.Linq;

namespace Skizziere.Model.Notes
{
    public class Selector
    {
        public List<BasicNote> Selected { get; private set; }

        public int X 
        { 
            get 
            { 
                return Selected.Count == 0 ? 0 : Selected.Min(note => note.X); 
            } 
        }
        public int Y
        {
            get
            {
                return Selected.Count == 0 ? 0 : Selected.Min(note => note.Y);
            }
        }
        public int Width
        {
            get
            {
                return Selected.Count == 0 ? int.MaxValue : Selected.Max(note => note.X2) - X;
            }
        }
        public int Height
        {
            get
            {
                return Selected.Count == 0 ? int.MaxValue : Selected.Max(note => note.Y2) - Y;
            }
        }

        public Selector() 
        { 
            Selected = new List<BasicNote>();
        }
    }
}
