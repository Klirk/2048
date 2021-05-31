using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kurs_Final
{
    abstract class Tiles
    {
        public Label numbers = new Label();
        public PictureBox tile = new PictureBox();
        public Color color { get; set; }
        public Point location { get; set; }
        public abstract int Value { get; set; }
        public Tiles(Color _color, Point _location)
        {
            color = _color;
            location = _location;
        }
     
       
    }

}