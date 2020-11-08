using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace SaperTheGame
{
    class Style
    {

        private Color _bomb;
        private Color _terraIncognita;
        private Color _number;
        private Color _empty;
        private Color _flag;

        public Style()
        {
            _bomb = Color.DarkRed;
            _terraIncognita = Color.LightYellow;
            _number = Color.LightBlue;
            _empty = Color.LightSalmon;
            _flag = Color.Firebrick;
        }

        public Color Bomb
        {
            get { return _bomb; }
        }
        public Color TerraIncognita
        {
            get { return _terraIncognita; }
        }
        public Color Number
        {
            get { return _number; }
        }
        public Color Empty
        {
            get { return _empty; }
        }
        public Color Flag
        {
            get { return _flag; }
        }

    }
}

