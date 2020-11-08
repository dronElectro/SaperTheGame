using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SaperTheGame
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private int n;
        private bool isFrstClick;
        private int mines;
        private Saper saper;
        private Style style = new Style();

        private void resizeGrid()
        {
            if (n != 0)
            {
                int size = SaperField.Width > SaperField.Height ? SaperField.Height : SaperField.Width;
                size -= n / 90;
                size /= n;
                for (int i = 0; i < n; i++)
                {
                    SaperField.Columns[i].Width = size;
                    SaperField.Rows[i].Height = size;

                }
            }
        }

        private void newGame()
        {
            isFrstClick = true;
            SaperField.Enabled = true;
            SaperField.ColumnCount = 0;
            SaperField.RowCount = 0;
            mines = 0;
            n = FieldSIzeTB.Value;
            mines = NumOfMinesTB.Value;
            SaperField.ColumnCount = n;
            SaperField.RowCount = n;
            resizeGrid();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    SaperField[i, j].Style.BackColor = style.TerraIncognita;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            newGame();
        }


        private void show()
        {
            int[,] area = saper.Area;

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {

                    if (saper.IsOpen[j, i] == true)
                    {

                        if (area[j, i] == 0)
                        {
                            SaperField[i, j].Style.BackColor = style.Empty;
                        }
                        else if (area[j, i] < 10)
                        {
                            SaperField[i, j].Value = area[j, i];
                            SaperField[i, j].Style.BackColor = style.Number;
                        }
                        else
                        {
                            SaperField[i, j].Style.BackColor = style.Bomb;
                        }
                    }
                }
        }


        private void FieldSIzeTB_Scroll(object sender, EventArgs e)
        {
            FieldSizeLabel.Text = FieldSIzeTB.Value.ToString();
        }

        private void MainWindow_ResizeEnd(object sender, EventArgs e)
        {
            resizeGrid();
        }

        private void NumOfMinesTB_Scroll(object sender, EventArgs e)
        {
            mines = NumOfMinesTB.Value;
            NumOfMinesLabel.Text = NumOfMinesTB.Value.ToString();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void SaperField_CellMouseDown_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = e.RowIndex;
            int col = e.ColumnIndex;
            SaperField.ClearSelection();
            if (isFrstClick == true)
            {
                saper = new Saper(n, mines, row, col);
            }
            show();
            isFrstClick = false;


            if (e.Button == MouseButtons.Left && SaperField[col, row].Style.BackColor != style.Flag)
            {
                int cell = saper.openCell(row, col);
                if (cell == 0)
                {
                    SaperField[col, row].Style.BackColor = style.Empty;
                    show();
                }
                else if (cell < 10)
                {
                    SaperField[col, row].Style.BackColor = style.Number;
                    SaperField[col, row].Value = cell;
                }
                else
                {
                    SaperField[col, row].Style.BackColor = style.Bomb;
                    MessageBox.Show("You lose");
                    SaperField.Enabled = false;
                }
                if (saper.isWon())
                {
                    MessageBox.Show("You won");
                    SaperField.Enabled = false;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (SaperField[col, row].Style.BackColor == style.TerraIncognita)
                    SaperField[col, row].Style.BackColor = style.Flag;
                else if (SaperField[col, row].Style.BackColor == style.Flag)
                    SaperField[col, row].Style.BackColor = style.TerraIncognita;
            }
        }
    }
}

