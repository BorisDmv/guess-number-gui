using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Globalization;

namespace GuessNumber_DesktopApp
{
    public partial class GuessNumber : Form
    {
        //Random three digit-number
        int Min = 0;
        int Min2 = 1;
        int Max = 9;
        int[] randomNumber = new int[3];
        List<int> aux = new List<int>();

        //User
        string userNumber;
        bool win = false;
        int life = 15;
        bool lose = false;


        public GuessNumber()
        {
            InitializeComponent();
        }

        private void GuessNumber_Load(object sender, EventArgs e)
        {
            Random randNum = new Random();
            for (int i = 0; i < randomNumber.Length; i++)
            {
                if (i == 0)
                {
                    randomNumber[i] = randNum.Next(Min2, Max);
                }
                else
                {
                    randomNumber[i] = randNum.Next(Min, Max);
                }
                aux.Add(randomNumber[i]);
                Console.Write(randomNumber[i]);
            }

            randTxt.Text = "...";
            //Generated number and displayed on the form
            //randTxt.Text = String.Join(",", aux).Replace(",", "");
        }



        private void tryBtn_Click(object sender, EventArgs e)
        {
            if (life > 0)
            {
                try
                {
                    userNumber = textBox.Text;


                    if (Convert.ToInt32(userNumber) < 100 || Convert.ToInt32(userNumber) > 999)
                    {
                        InfoText.Text = "Please enter only 3 digit numbers!";
                    }
                    else
                    {

                        int firstNum = Convert.ToInt32(userNumber) / 100;
                        int secondNum = Convert.ToInt32(userNumber) / 10;
                        secondNum = secondNum % 10;
                        int thirdNum = Convert.ToInt32(userNumber) % 10;


                        var firstItem = aux.ElementAt(0);
                        var secondItem = aux.ElementAt(1);
                        var thirdItem = aux.ElementAt(2);

                        bool firstGuessedNoPos = aux.IndexOf(firstNum) != -1;
                        bool secondGuessedNoPos = aux.IndexOf(secondNum) != -1;
                        bool thirdGuessedNoPos = aux.IndexOf(thirdNum) != -1;


                        if (firstNum == firstItem && secondNum == secondItem && thirdNum == thirdItem)
                        {
                            win = true;
                            InfoText.Text = "You guessed the number!";
                            tryBtn.Enabled = false;
                        }
                        else if (firstNum == firstItem && secondNum == secondItem || firstNum == firstItem && thirdNum == thirdItem || secondNum == secondItem && thirdNum == thirdItem)
                        {
                            InfoText.Text = "You guessed two numbers and their position";
                        }
                        else if (firstNum == firstItem || secondNum == secondItem || thirdNum == thirdItem)
                        {
                            InfoText.Text = "You guessed one number and position";

                            //Checking other two if they are included
                            if (firstNum != firstItem || secondNum != secondItem || thirdNum != thirdItem)
                            {
                                InfoText.Text = "You guessed one number and position and the other two maybe are included";
                            }
                        }
                        else if (firstGuessedNoPos == true && secondGuessedNoPos == true && thirdGuessedNoPos == true)
                        {
                            InfoText.Text = "You guessed all numbers but not the positions";
                        }
                        else if (firstGuessedNoPos == true && secondGuessedNoPos == true || firstGuessedNoPos == true && thirdGuessedNoPos == true || secondGuessedNoPos == true && thirdGuessedNoPos == true)
                        {
                            InfoText.Text = "You guessed two numbers but not the positions";
                        }
                        else if (firstGuessedNoPos == true || secondGuessedNoPos == true || thirdGuessedNoPos == true)
                        {
                            InfoText.Text = "You guessed one number but not the position";
                        }
                        else
                        {
                            InfoText.Text = "No matches";
                        }

                        life--;
                        lifeText.Text = "Life: " + life.ToString();
                    }
                }
                catch (Exception)
                {
                    InfoText.Text = "This was not a number!";
                }
            }
            else if (life == 0)
            {
                lose = true;
                InfoText.Text = "You Lose!";
                tryBtn.Enabled = false;
                randTxt.Text = String.Join(",", aux).Replace(",", "");
            }
            else if (win == true)
            {
                InfoText.Text = "You Win!";
                tryBtn.Enabled = false;
            }
        }
    }
}
