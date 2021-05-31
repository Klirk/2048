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
        public TileEmpty(Form _game, Point _location) : base(_game, _location)
        {
        }
        public override int Value { get => throw new NotImplementedException(); set => throw new NotImplementedException(); };
    }
}

