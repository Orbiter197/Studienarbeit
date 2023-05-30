using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Skizziere.Model.Notes
{
    class ImageNote : BasicNote
    {
        public ImageNote()
        {

        }

        public ImageNote(int x, int y, int width, int height, VisibilityState visibilityState) : base(x, y, width, height, visibilityState)
        {
            image = new BitmapImage();
        }
    }
}
