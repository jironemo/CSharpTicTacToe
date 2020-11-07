using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        static int player = 1;
        static int turn = 8;
        int[][] positions = {
        new int[3],new int[3],new int[3]
        };
        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    positions[i][j] = 0;
                }
            }
            foreach (Control p in this.Controls)
            {
                if (p is PictureBox)
                {
                    p.Click -= play;
                    p.Click += play;
                }

            }

        }
        public int checkWinner()
        {
            int winner = 0;
            if ((positions[0][0] == positions[1][0]) && positions[0][0] == positions[2][0])
            {
                winner = positions[0][0];
            }else if((positions[0][0] == positions[1][1]) && positions[0][0] == positions[2][2])
            {
                winner = positions[0][0];
            }
            else if ((positions[0][0] == positions[0][1]) && positions[0][0] == positions[0][2])
            {
                winner = positions[0][0];
            }
            else if ((positions[0][1] == positions[1][1]) && positions[0][1] == positions[2][1])
            {
                winner = positions[0][1];
            }
            else if ((positions[0][2] == positions[1][2]) && positions[0][2] == positions[2][2])
            {
                winner = positions[0][2];
            }
            else if ((positions[1][0] == positions[1][1]) && positions[1][0] == positions[1][2])
            {
                winner = positions[1][0];
            }
            else if ((positions[2][0] == positions[2][1]) && positions[2][0] == positions[2][2])
            {
                winner = positions[2][0];
            }
            else if ((positions[0][2] == positions[1][1]) && positions[0][2] == positions[2][0])
            {
                winner = positions[2][0];
            }
            return winner;
        }
        private void play(object sender, EventArgs e)
        {
            if (turn != 0)
            {
                PictureBox k = (PictureBox)sender;
            if(k.Image == null)
            {
                Char[] str = { k.Name[3], k.Name[4] };
                int x = Int32.Parse(str[0].ToString());
                int y = Int32.Parse(str[1].ToString());
                if (player == 1)
                {
                    player = 2;
                    k.Image = Image.FromFile("x.png");
                    positions[x][y] = 1;
                }
                else if (player == 2)
                {
                    player = 1;
                    k.Image = Image.FromFile("o.jfif");
                    positions[x][y] = 2;
                }
            }
            int winner = checkWinner();
            
                if (winner == 1 || winner == 2)
                {
                    MessageBox.Show(String.Format("Player {0} wins!", winner));
                    winner = 0;
                    resetBoard();
                }
                turn--;
            }
            else
            {
                MessageBox.Show("DRAW!");
                resetBoard();
            }

        }
        public void resetBoard()
        {
            player = 1;
            foreach(Control c in this.Controls)
            {
                if(c is PictureBox)
                {
                    ((PictureBox)c).Image = null;
                }
            }
            foreach (int[] g in positions)
            {
                for (int i = 0; i < 3; i++)
                {
                    g[i] = 0;
                }
            }
            turn = 8;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resetBoard();
        }
    }
}
