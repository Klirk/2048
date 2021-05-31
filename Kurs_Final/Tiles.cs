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
        public PictureBox tile = new PictureBox();
        private Point location { get; set; }
        
        public Tiles(Form game, Point _location)
        {
            location = _location;
            tile = new PictureBox();
            tile.BackColor = Color.Gray;
            tile.Size = new Size(70, 70);
            tile.Location = _location;
            game.Controls.Add(tile);
            tile.BringToFront();
        }
        public abstract int Value { get; set; }
    }

}