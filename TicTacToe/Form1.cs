using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        bool turn = true; // true = X turn, false = O turn
        int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Kizza", "Tic Tac Toe");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
            {
                b.Text = "X";
            }
            else
            {
                b.Text = "O";
            }

            turn = !turn;
            b.Enabled = false;
            count++;

            CheckForWinner();
        }

        private void CheckForWinner()
        {
            bool thereIsAWinner = false;

            // Horizontal clicks
            if (A1.Text == A2.Text && A2.Text == A3.Text && !A1.Enabled)
            {
                thereIsAWinner = true;
            }

            else if (B1.Text == B2.Text && B2.Text == B3.Text && !B1.Enabled)
            {
                thereIsAWinner = true;
            }

            else if (C1.Text == C2.Text && C2.Text == C3.Text && !C1.Enabled)
            {
                thereIsAWinner = true;
            }

            // Vertical clicks
            if (A1.Text == B1.Text && B1.Text == C1.Text && !A1.Enabled)
            {
                thereIsAWinner = true;
            }

            else if (A2.Text == B2.Text && B2.Text == C2.Text && !A2.Enabled)
            {
                thereIsAWinner = true;
            }

            else if (A3.Text == B3.Text && B3.Text == C3.Text && !A3.Enabled)
            {
                thereIsAWinner = true;
            }

            // Diagonal checks

            if (A1.Text == B2.Text && B2.Text == C3.Text && !A1.Enabled)
            {
                thereIsAWinner = true;
            }

            else if (C1.Text == B2.Text && B2.Text == A3.Text && !A3.Enabled)
            {
                thereIsAWinner = true;
            }

            if (thereIsAWinner)
            {
                DisableButtons();

                string winner = null;
                if (turn)
                {
                    winner = "O";
                    OWinsCount.Text = (int.Parse(OWinsCount.Text) + 1).ToString();
                }
                else
                {
                    winner = "X";
                    XWinsCount.Text = (int.Parse(XWinsCount.Text) + 1).ToString();
                }

                MessageBox.Show("Winner is " + winner);
            }
            else
            {
                if (count == 9)
                {
                    MessageBox.Show("This game is draw");
                    DrawsCount.Text = (int.Parse(DrawsCount.Text) + 1).ToString();
                }
            }
        }

        private void DisableButtons()
        {

            foreach (Control c in Controls)
            {

                try
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
                catch { }
            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            count = 0;

            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = string.Empty;
                }
                catch { }
            }
        }

        private void ButtonEnter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                if (turn)
                {
                    b.Text = "X";
                }
                else
                {
                    b.Text = "O";
                }
            }
        }

        private void ButtonLeave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                b.Text = string.Empty;
            }
        }

        private void resetWinCountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OWinsCount.Text = "0";
            XWinsCount.Text = "0";
            DrawsCount.Text = "0";
        }
    }
}
