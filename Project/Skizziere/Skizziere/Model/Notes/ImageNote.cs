﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skizziere.Model.Notes
{
    class ImageNote : BasicNote
    {
        public ImageNote()
        {

        }

        public ImageNote(int x, int y, int width, int height, VisibilityState visibilityState) : base(x, y, width, height, visibilityState)
        {

        }
    }
}
