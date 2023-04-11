using System.Collections.Generic;
using System.Linq;

namespace Skizziere.Model.Notes
{
    public class Selector : IRectangle
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

        public void Add(BasicNote note) => Selected.Add(note);
        public void Remove(BasicNote note) => Selected.Remove(note);

        public void Move(int dx, int dy)
        {
            foreach(BasicNote note in Selected)
                note.Move(dx, dy);
        }

        public bool CheckIntersection(int x, int y)
        {
            return X < x && x < X + Width && Y < y && y < Y + Height;
        }

        public bool CheckIntersection(IRectangle note)
        {
            return !(X + Width < ((BasicNote)note).X ||
                ((BasicNote)note).X + ((BasicNote)note).Width < X ||
                Y + Height < ((BasicNote)note).Y ||
                ((BasicNote)note).Y + ((BasicNote)note).Height < Y);
        }

        public void Resize(int dLeft, int dTop, int dRight, int dBottom)
        {
            foreach (BasicNote note in Selected)
                note.Resize(dLeft, dTop, dRight, dBottom);
        }
    }
}
