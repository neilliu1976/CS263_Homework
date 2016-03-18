using GameLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessNumber
{
    public partial class Form1 : Form
    {
        public Guess guessMain = new Guess();

        public Form1()
        {
            InitializeComponent();
        }

        private void AddMessage(string message)
        {
            this.txtbMessage.Text += message + "\r\n";
        }

        private void btnPress_Click(object sender, EventArgs e)
        {
            this.guessMain.MakeNewNumber();
            this.txtbMessage.ResetText();
        }

        private void btnGetAnswer_Click(object sender, EventArgs e)
        {
            this.AddMessage(this.guessMain.GetAnswer());
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            this.AddMessage(this.guessMain.CheckAnswer(this.txtbInput.Text));
            this.txtbInput.Text = "";
        }
    }
}