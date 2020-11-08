using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SaperTheGame
{
    class Saper
    {
        private int[,] _area;
        private bool[,] _isOpen;
        private int _n;
        private int _mines;
        private int _startRow;
        private int _startCol;

        public Saper(int n, int mines, int row, int col)
        {
            _startRow = row;
            _startCol = col;
            _n = Math.Abs(n);
            _area = new int[_n, _n];
            _isOpen = new bool[_n, _n];
            _mines = Math.Abs(mines);

            if (mines > _n * _n - 1)
                _mines = _n;

            for (int i = 0; i < _n; i++)
            {
                for (int j = 0; j < _n; j++)
                {
                    _area[i, j] = 0;
                    _isOpen[i, j] = false;
                }
            }
            newGame();
        }

        public int[,] Area
        {
            get { return _area; }
        }

        public int openCell(int row, int col)
        {
            if (_area[row, col] == 0)
            {
                showEmpty(row, col);
            }
            _isOpen[row, col] = true;
            return _area[row, col];
        }

        private bool showEmpty(int row, int col)
        {
            if (_isOpen[row, col] == false)
            {
                _isOpen[row, col] = true;
                if (_area[row, col] == 0)
                {
                    if (row > 0)
                    {
                        showEmpty(row - 1, col);
                        if (col > 0) showEmpty(row - 1, col - 1);
                        if (col < _n - 1) showEmpty(row - 1, col + 1);
                    }
                    if (row < _n - 1)
                    {
                        showEmpty(row + 1, col);
                        if (col > 0) showEmpty(row + 1, col - 1);
                        if (col < _n - 1) showEmpty(row + 1, col + 1);
                    }
                    if (col > 0) showEmpty(row, col - 1);
                    if (col < _n - 1) showEmpty(row, col + 1);
                    return true;
                }
                else
                    return false;
            }
            else
                return false;

        }

        public bool isWon()
        {
            int num = 0;
            for (int i = 0; i < _n; i++)
                for (int y = 0; y < _n; y++)
                    if (_isOpen[i, y] == true)
                        num++;
            if (num == _n * _n - _mines)
                return true;
            else
                return false;
        }

        public void newGame()
        {
            Random rand = new Random();
            int x, y, count = 0;
            for (int i = 0; i < _n && count < _mines; i++)
            {
                for (int j = 0; j < _n && count < _mines; j++)
                {
                    if (count < _mines && (i != _startRow || j != _startCol))
                    {
                        _area[i, j] = 50;
                        count++;

                    }
                }
            }
            count = 0;
            for (int i = 0; i < _n; i++)
            {
                for (int j = 0; j < _n; j++)
                {
                    x = rand.Next(_n);
                    y = rand.Next(_n);

                    if ((x != _startRow || y != _startCol) && (i != _startRow || j != _startCol))
                    {
                        int temp = _area[x, y];
                        _area[x, y] = _area[i, j];
                        _area[i, j] = temp;
                    }
                }
            }

            for (int i = 0; i < _n; i++)
                for (int j = 0; j < _n; j++)
                {
                    if (_area[i, j] > 10)
                    {
                        if (i > 0)
                        {
                            _area[i - 1, j]++;
                            if (j > 0) _area[i - 1, j - 1]++;
                            if (j < _n - 1) _area[i - 1, j + 1]++;
                        }
                        if (i < _n - 1)
                        {
                            _area[i + 1, j]++;
                            if (j > 0) _area[i + 1, j - 1]++;
                            if (j < _n - 1) _area[i + 1, j + 1]++;
                        }
                        if (j > 0) _area[i, j - 1]++;
                        if (j < _n - 1) _area[i, j + 1]++;
                    }
                }
        }
        public bool[,] IsOpen
        {
            get { return _isOpen; }
        }
    }
}

