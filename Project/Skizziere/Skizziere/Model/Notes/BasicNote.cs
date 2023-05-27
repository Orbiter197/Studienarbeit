﻿using PropertyChanged;
using Skizziere.Core;

namespace Skizziere.Model.Notes
{
    public abstract class BasicNote : ObservableObject, IHitBox, IVisible
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public VisibilityState Visibility { get; set; }

        public int X2 { get => X + Width; }
        public int Y2 { get => Y + Width; }
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

        public bool CheckIntersection(int x, int y)
        {
            return X < x && x < X + Width && Y < y && y < Y + Height;
        }

        public bool CheckIntersection(IHitBox note)
        {
            return !(X + Width < ((BasicNote)note).X || 
                ((BasicNote)note).X + ((BasicNote)note).Width < X || 
                Y + Height < ((BasicNote)note).Y || 
                ((BasicNote)note).Y + ((BasicNote)note).Height < Y);
        }

        public void SetVisibilityState(VisibilityState visibilityState)
        {
            Visibility = visibilityState;
        }
    }
}
