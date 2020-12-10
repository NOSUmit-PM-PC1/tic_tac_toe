using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tic_tac_toe
{
    class Program
    {
        static string[] hod = {"крестик", "нолик"};
        static bool gameOver;
        static void print_mass(int[,] m)
        {
            for (int y = 0; y < 3; y++)
            {
                for (int x = 0; x < 3; x++)
                    Console.Write(m[y, x]);
                Console.WriteLine();
            }
        }

        static void print_field(int[,] mm)
        {
            string[,] m = new string[3, 3];
            for (int x = 0; x < 3; x++)
                for (int y = 0; y < 3; y++)
                    if (mm[x, y] == 0) m[x, y] = " ";
                    else
                        if (mm[x, y] == 1) m[x, y] = "x";
                        else m[x, y] = "o";

            Console.WriteLine(m[0, 0] + "|"+ m[0, 1] + "|"+ m[0, 2]);
            Console.WriteLine("-+-+-");
            Console.WriteLine(m[1, 0] + "|" + m[1, 1] + "|" + m[1, 2]);
            Console.WriteLine("-+-+-");
            Console.WriteLine(m[2, 0] + "|" + m[2, 1] + "|" + m[2, 2]);
            Console.WriteLine();        
        }

        static void showMove(int[,] field, ref int player)
        {
            try
            {
                Console.WriteLine("Введите куда поставить " + hod[player - 1] + " (строка 1-3 и столбец 1-3)");
                string[] s = Console.ReadLine().Split();
                int row = Convert.ToInt32(s[0]) - 1;
                int column = Convert.ToInt32(s[1]) - 1;
                if (move(field, ref player, row, column))
                {
                    print_field(field);
                }
                else
                    Console.WriteLine("Так нельзя");
            }
            catch
            {
                Console.WriteLine("Что-то пошло не так!");
            }
        }
        static bool move(int[,] field, ref int player, int row, int column)
        {
            if ((row >= 0 && row < 3 && column >= 0 && column < 3) && field[row, column] == 0)
            {
                field[row, column] = player;
                gameOver = checkWin(field, player);
                if (!gameOver)
                    if (player == 1) player = 2;
                    else player = 1;
                return true;
            }
            else
                return false;
        }

        static bool checkWin(int[,] field, int player)
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
        static bool draw(int[,] field)
        {
            int count_empty = 0;
            for (int x = 0; x < 3; x++)
                for (int y = 0; y < 3; y++)
                    if (field[x, y] == 0) count_empty++;
            if (count_empty == 0)
            {
                gameOver = true;
                return true;
            }
            else return false;
        }
        static void Main(string[] args)
        {
            string ansUser = "";
            do
            {
                gameOver = false;
                Console.WriteLine("Играем в Крестики-Нолики");
                int[,] field = new int[3, 3];
                // print_mass(field);
                print_field(field);
                int player = 1; // 2 - ход ноликов, 1 - ход крестиков
                bool flagDraw = false;
                while (!gameOver)
                {
                    showMove(field, ref player);
                    if (!gameOver) flagDraw = draw(field);
                }
                if (flagDraw)
                    Console.WriteLine("Ничья!");
                else
                    Console.WriteLine("Победил " + hod[player - 1]);
                Console.WriteLine("Начнем с начала? (Y/N)");
                ansUser = Console.ReadLine();
            } while (ansUser == "Y");
            Console.WriteLine("Пока!");
        }
    }
}
