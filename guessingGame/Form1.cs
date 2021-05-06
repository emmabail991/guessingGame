using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guessingGame
{
    public partial class Form1 : Form
    {
        //random generated number
        Random randGen = new Random();

        //variable to hold user guess
        int guessNumber;
        int randomNumber;

        public Form1()
        {
            InitializeComponent();
            
            randomNumber = randGen.Next(1, 101);
        }
        
        private void guessButton_Click(object sender, EventArgs e)
        {
            try
            {
                guessNumber = Convert.ToInt32(inputNumber.Text);


                if (randomNumber < guessNumber)
                {
                    outputLabel.Text = "too high";
                }
                else if (randomNumber > guessNumber)
                {
                    outputLabel.Text = "too low";
                }
                else if (randomNumber==guessNumber)
                {
                    outputLabel.Text = " YOU GOT IT !!!!";
                }
            }
            catch
            {
                outputLabel.Text = " please use numbers only";
            }



        }
    }
}
