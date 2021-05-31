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
    class TileEmpty : Tiles
    {
        public TileEmpty(int _value, Point _location, Form _game) : base( _location)
        {
            numbers = new Label()
            {
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Text = "",
                ForeColor = Color.Black,
                Font = new Font("Times New Romans", 15),
                Size = new Size(70, 70)
            };
            tile = new PictureBox();
            tile.Controls.Add(numbers);
            tile.BackColor = Color.Gray;
            tile.Size = new Size(70, 70);
            tile.Location = location;
            _game.Controls.Add(tile);
            tile.BringToFront();
            value = _value;
        }
        public override int Value
        {

            get
            {
                return value;
            }
            set
            {
                numbers.Text = value.ToString();
                this.value = value;
                switch (value)
                {
                    case 0:
                        tile.BackColor = Color.Gray;
                        numbers.Text = "";
                        break;

                }
            }
        }
    }





}

