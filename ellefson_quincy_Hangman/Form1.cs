/*Program Author: Quincy Ellefson
 * 
 * Assignment: Bonus Opportunity
 * 
 * Description: I ran out of time but this was intended to be a hangman game.
 *              I'll be honest it's not functionally sound but I think I was
 *              going in the right direction. The letterGuess text box accepts
 *              lowercase despite all the words being uppercase. I also messed up the
 *              translation from the wordList to the wordLetters character array and 
 *              now the words are all out of order. Oh and the pictureBox functionality
 *              isn't working. I guess this is better than not submitting anything?
 *              
 */



using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ellefson_quincy_Hangman
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        string[] wordList =
        {
            "COMPUTER",
            "MINECRAFT",
            "FINALS",
            "COFFEE",
            "KEYBOARD",
            "SPONGEBOB",
            "LEBRON"
        };
        int guessAttempts;
        char letterGuessed;
        public Char[] wordLetters;
        public bool guessCorrect;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadWord();//Calls the loadWord function to populate the secretWord label
            hangmanPicture.Image = Properties.Resources.hang0;
            guessAttempts = 0;
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            letterGuessed = letterGuess.Text[0];

            if (wordLetters.Contains(letterGuessed))
            {
                string sameLetter = Char.ToString(letterGuessed);
                lblFeedback.Text = "Nice Guess!";
                for (int i = 0; i < wordLetters.Length; i++)
                {
                if (wordLetters[i] == letterGuessed)
                {
                    guessCorrect = true;
                        secretWord.Text = secretWord.Text.Remove(i, 1);
                        secretWord.Text = secretWord.Text.Insert(1, sameLetter);
                }
                else
                {
                    guessCorrect = false;
                        lblFeedback.Text = "That was incorrect!";
                        guessAttempts++;

                }
                    checkGuess();
            }
        }
    }

        private void loadWord()
        {
            string randWord = wordList[rand.Next(0, wordList.Length)];
            wordLetters = randWord.ToCharArray();

            secretWord.Text = "";
            for (int i = 0; i < wordLetters.Length; i++)
            {
                secretWord.Text = secretWord.Text.Insert(i, "*");
            }
        }

        private void checkGuess()
        {
            if(guessAttempts is 1)
            {
                hangmanPicture.Image = Properties.Resources.hang1;
            }
            if (guessAttempts is 2)
            {
                hangmanPicture.Image = Properties.Resources.hang2;
            }
            if (guessAttempts is 3)
            {
                hangmanPicture.Image = Properties.Resources.hang3;
            }
            if (guessAttempts is 4)
            {
                hangmanPicture.Image = Properties.Resources.hang4;
            }
            if (guessAttempts is 5)
            {
                hangmanPicture.Image = Properties.Resources.hang5;
            }
            if (guessAttempts is 6)
            {
                hangmanPicture.Image = Properties.Resources.hang6;
            }
            if (guessAttempts is 7)
            {
                hangmanPicture.Image = Properties.Resources.hang7;
            }
        }
    }
}
