﻿using System;
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
    class TileFilled : Tiles
    {
        public TileFilled(int _value, Point _location, Form _game) : base( _location)
        {
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
                    case 2:
                        tile.BackColor = Color.LightGray;
                        break;
                    case 4:
                        tile.BackColor = Color.Yellow;
                        break;
                    case 8:
                        tile.BackColor = Color.LightYellow;
                        break;
                    case 16:
                        tile.BackColor = Color.LightPink;
                        break;
                    case 32:
                        tile.BackColor = Color.DeepPink;
                        break;
                    case 64:
                        tile.BackColor = Color.LightGreen;
                        break;
                    case 128:
                        tile.BackColor = Color.Green;
                        break;
                    case 256:
                        tile.BackColor = Color.LightBlue;
                        break;
                    case 512:
                        tile.BackColor = Color.Blue;
                        break;
                    case 1024:
                        tile.BackColor = Color.Coral;
                        break;
                    case 2048:
                        tile.BackColor = Color.Red;
                        break;
                }
            }
        }
    }
}
