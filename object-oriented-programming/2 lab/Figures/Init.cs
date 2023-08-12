using System.Drawing;
using System.Windows.Forms;

namespace Figures
{
    public static class Init
    {
        public static Bitmap bitmap;
        public static PictureBox pictureBox;
        public static Pen pen;
        public static ListBox figuresListBox;
        public static BindingSource bs;
        public static bool Coords_check(int x, int y, int w, int h)
        {
            if (!((x < 0) || (y < 0) || (x + w > Init.pictureBox.Width) || (y + h > Init.pictureBox.Height)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void Clear()
        {
            Graphics g = Graphics.FromImage(Init.bitmap);
            g.Clear(Color.White);
        }
    }
}
