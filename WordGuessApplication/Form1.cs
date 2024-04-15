using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordGuessApplication
{
    public partial class Form1 : Form
    {
        private string CheckWord = "computer";
        private StringBuilder Wguess;
        private object listBox1;

        public Form1()
        {
          
            InitializeComponent();
            Wguess = new StringBuilder(CheckWord.Length);
            Wguess.Append(CheckWord[0]);
            for (int i = 1; i < CheckWord.Length - 1; i++)
            {
                if (char.IsLetter(CheckWord[i]) && i > 1 && i < CheckWord.Length - 1)
                   Wguess.Append('?');
                else
                    Wguess.Append(CheckWord[i]);
            }
            Wguess.Append(CheckWord[CheckWord.Length - 1]);
            label1.Text = Wguess.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string CorrectAnswer = textBox1.Text;

            if (CorrectAnswer == CheckWord)
            {
                label1.Text = CheckWord;
                MessageBox.Show("Correct Guess!");
            }
            else
            {
                object value = listBox3.Items.Add(CorrectAnswer);
                MessageBox.Show("Wrong Guess!, Try Again");

            }

            textBox1.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_2(object sender, EventArgs e)
        {
        }
    }
    
}
