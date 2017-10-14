using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPSGame
{
    public partial class Form1 : Form
    {
        int playerScore = 0, pcScore = 0;
        int computerMove = 0, playerMove = 0;
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void AIMove()
        {
            computerMove = random.Next(1, 4);
            switch (computerMove){
                case 1:
                    pictureBox1.Image = Properties.Resources.PEDRA;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.PAPEL;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.TESOURA;
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            playerMove = 2; //Paper
            pictureBox2.Image = Properties.Resources.PAPEL;
            AIMove();
            checkResults();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            playerMove = 3; //Scissors
            pictureBox2.Image = Properties.Resources.TESOURA;
            AIMove();
            checkResults();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            playerMove = 1; //Rock
            pictureBox2.Image = Properties.Resources.PEDRA;
            AIMove();
            checkResults();
        }

        private void checkResults()
        {
            if (playerMove == 1 && computerMove == 3)
                playerWins();
            if (playerMove == 2 && computerMove == 1)
                playerWins();
            if (playerMove == 3 && computerMove == 2)
                playerWins();
            if (playerMove == 1 && computerMove == 2)
                AIWins();
            if (playerMove == 2 && computerMove == 3)
                AIWins();
            if (playerMove == 3 && computerMove == 1)
                AIWins();
            if (playerMove == computerMove)
                showResult.Text = "It's a draw!";
        }

        private void playerWins()
        {
            playerScore++;
            playerScorelbl.Text = playerScore.ToString();
            showResult.Text = "congrats! you Win!";
            pictureBox3.Visible = true;
        }

        private void AIWins()
        {
            pcScore++;
            computerScroreLbl.Text = pcScore.ToString();
            showResult.Text = "I'm sorry, you lost.";
        }
    }
}
