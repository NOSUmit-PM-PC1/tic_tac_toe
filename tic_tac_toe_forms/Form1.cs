using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using tic_tac_toe;

namespace tic_tac_toe_forms
{
   
    public partial class Form1 : Form
    {
        string[] hod = {"крестик", "нолик"};
        string[] show_hod = {"x", "o"};
        bool gameOver = false;
        int[,] field = new int[3, 3];
        int player = 1; // 2 - ход ноликов, 1 - ход крестиков

        bool move(int[,] field, ref int player, int row, int column)
        {
            if ((row >= 0 && row < 3 && column >= 0 && column < 3) && field[row, column] == 0)
            {
                field[row, column] = player;
                return true;
            }
            else
                return false;
        }

        bool checkWin(int[,] field, int player)
        {
            for (int y = 0; y < 3; y++)
            {
                int count_y = 0;
                int count_x = 0;
                for (int x = 0; x < 3; x++)
                {
                    if (field[y, x] == player) count_y++;
                    if (field[x, y] == player) count_x++;
                }
                if (count_y == 3) return true;
                if (count_x == 3) return true;
            }
            int count_main = 0;
            int count_side = 0;
            for (int i = 0; i < 3; i++)
            {
                if (field[i, i] == player) count_main++;
                if (field[i, 2 - i] == player) count_side++;
            }
            if (count_main == 3) return true;
            if (count_side == 3) return true;
            return false;
        }
        public Form1()
        {
            InitializeComponent();
            dataGridGame.RowTemplate.Height = 100;
            dataGridGame.Rows.Add();
            dataGridGame.Rows.Add();
            dataGridGame.Rows.Add();
        }

        private void MenuItemNewGame_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridGame_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(e.RowIndex.ToString() + " " + e.ColumnIndex.ToString());
            if (move(field, ref player, e.RowIndex, e.ColumnIndex))
            {
                dataGridGame.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = show_hod[player - 1];
                if (checkWin(field, player))
                {
                    MessageBox.Show("Победил " + hod[player - 1].ToString() + "!!!!");

                }
                else
                    if (player == 1) player = 2;
                    else player = 1;
            }
            else
                MessageBox.Show("Нельзя так!!!!");
        }

    }
}
