using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simplified21ValeriaV
{
    public partial class frmGame : Form
    {
        //create global variables and contstants
        int betTot = 0;
        bool doubleButton_Clicked = false;
        bool hitButton_Clicked = false;

        Random userRandom = new Random();

        int userScore ;
        int userCard1, userCard2, userCard3, userCard4;

        int compCard1, compCard2, compCard3;
        int compScore;

        int userCounter2 = 1;
        
        //create a list that contains the cards
        List<int> cardsList = new List<int>();
        List<Image> imagesList = new List<Image>();
        
        //CARDS VALUES
        const int CARD_1 = 1;
        const int CARD_2 = 2;
        const int CARD_3 = 3;
        const int CARD_4 = 4;
        const int CARD_5 = 5;
        const int CARD_6 = 6;
        const int CARD_7 = 7;
        const int CARD_8 = 8;
        const int CARD_9 = 9;
        const int CARD_10 = 10;

        //CARDS IMAGES
        
       

        public frmGame()       
        {
            InitializeComponent();

            //hide the chip Images
            picChip.Hide();
            picChip2.Hide();
            picChip3.Hide();
            picChip4.Hide();
            picChip6.Hide();
            picChip7.Hide();

            //hide the game group box
            grbGame.Hide();

        }

        private void picChip1_Click(object sender, EventArgs e)
        {
            //constant
            const int CHIP_1 = 1;

            //calculate and display the bet
            betTot = betTot + CHIP_1;
            lblBet1.Text = String.Format("${0:0}", betTot);

            //display chip image
            picChip.Show();

            //enable the bet button
            btnBet.Enabled = true;
        }

        private void picChip5_Click(object sender, EventArgs e)
        {
            //constant
            const int CHIP_2 = 5;

            //calculate and display the bet
            betTot = betTot + CHIP_2;
            lblBet1.Text = String.Format("${0:0}", betTot);

            //display chip image
            picChip2.Show();

            //enable the bet button
            btnBet.Enabled = true;
        }

        private void picChip25_Click(object sender, EventArgs e)
        {
            //constant
            const int CHIP_3 = 25;
            //calculate and display the bet
            betTot = betTot + CHIP_3;
            lblBet1.Text = String.Format("${0:0}", betTot);
            //display chip image
            picChip3.Show();
            //enable the bet button
            btnBet.Enabled = true;
        }

        private void picChip50_Click(object sender, EventArgs e)
        {
            //constant
            const int CHIP_4 = 50;
            //calculate and display the bet
            betTot = betTot + CHIP_4;
            lblBet1.Text = String.Format("${0:0}", betTot);
            //display chip image
            picChip4.Show();
            //enable the bet button
            btnBet.Enabled = true;
        }

        private void picChip100_Click(object sender, EventArgs e)
        {
            //constant
            const int CHIP_5 = 100;
            //calculate and display the bet
            betTot = betTot + CHIP_5;
            lblBet1.Text = String.Format("${0:0}", betTot);
            //display chip image
            picChip6.Show();
            //enable the bet button
            btnBet.Enabled = true;
        }

        private void picChip500_Click(object sender, EventArgs e)
        {
            //constant
            const int CHIP_6 = 500;
            //calculate and display the bet
            betTot = betTot + CHIP_6;
            lblBet1.Text = String.Format("${0:0}", betTot);
            //display chip image
            picChip7.Show();
             //enable the bet button
            btnBet.Enabled = true;
        }

        private void btnBet_Click(object sender, EventArgs e)
        {
            cardsList.Clear();        

            //add the cards to the list
            cardsList.Add(CARD_1);
            cardsList.Add(CARD_2);
            cardsList.Add(CARD_3);
            cardsList.Add(CARD_4);
            cardsList.Add(CARD_5);
            cardsList.Add(CARD_6);
            cardsList.Add(CARD_7);
            cardsList.Add(CARD_8);
            cardsList.Add(CARD_9);
            cardsList.Add(CARD_10);

            //hide the bet group box
            grbDeal.Hide();

            //create local variables and constants
            userScore = 0;
            compScore = 0;


            //show the game group box
            grbGame.Show();

            //hide the card and display the back of the card
            picCompCar1.Hide();
            picCompBack.Show();
            picCompCar2.Hide();
            picCompBack2.Show();
            picCompCar3.Hide();

            picPLayCar3.Hide();
            picPLayCar4.Hide();

            //hide the labels and images
            lblMult.Hide();
            lblAnswer.Hide();

            // first user card
            // generate a random index between 0 and cardsList.Count()
            // userValue = cardsList[randomIndex];
            // cardsList.RemoveAt(randomIndex);
            // picPLayCar1.Image = imagesList[randomIndex];
            // imagesList.RemoveAt(randomIndex];

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //USER CARDS LOOP
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //for user counter smaller or equal to 2
            for (int userCounter = 1; userCounter <= 2; userCounter++)
            {
                //if userCounter is 1 change the first card, remove the card from the list 
                if (userCounter == 1)
                {
                    userCard1 = userRandom.Next(0, cardsList.Count());
     
                    if (userCard1 == CARD_1)
                    {
                        picPLayCar1.Image = Properties.Resources.rsz_card1;
                        cardsList.RemoveAt(0);
                    }
                    else if (userCard1 == CARD_2)
                    {
                        picPLayCar1.Image = Properties.Resources.rsz_card2;
                        cardsList.RemoveAt(1);
                    }
                    else if (userCard1 == CARD_3)
                    {
                        picPLayCar1.Image = Properties.Resources.rsz_card3;
                        cardsList.RemoveAt(2);
                    }
                    else if (userCard1 == CARD_4)
                    {
                        picPLayCar1.Image = Properties.Resources.rsz_card41;
                        cardsList.RemoveAt(3);
                    }
                    else if (userCard1 == CARD_5)
                    {
                        picPLayCar1.Image = Properties.Resources.rsz_1card5;
                        cardsList.RemoveAt(4);
                    }
                    else if (userCard1 == CARD_6)
                    {
                        picPLayCar1.Image = Properties.Resources.rsz_card6;
                        cardsList.RemoveAt(5);
                    }
                    else if (userCard1 == CARD_7)
                    {
                        picPLayCar1.Image = Properties.Resources.rsz_card7;
                        cardsList.RemoveAt(6);
                    }
                    else if (userCard1 == CARD_8)
                    {
                        picPLayCar1.Image = Properties.Resources.rsz_card8;
                        cardsList.RemoveAt(7);
                    }
                    else if (userCard1 == CARD_9)
                    {
                        picPLayCar1.Image = Properties.Resources.rsz_1card9;
                        cardsList.RemoveAt(8);
                    }
                    else if (userCard1 == CARD_10)
                    {
                        picPLayCar1.Image = Properties.Resources.rsz_card10;
                        cardsList.RemoveAt(9);
                    }
                }
                //if userCounter is 2 change the second card, remove the card from the list 
                else if (userCounter == 2)
                {
                    userCard2 = userRandom.Next(0, cardsList.Count());
                    if (userCard2 == CARD_1)
                    {
                        picPLayCar2.Image = Properties.Resources.rsz_card1;
                        cardsList.RemoveAt(0);
                    }
                    else if (userCard2 == CARD_2)
                    {
                        picPLayCar2.Image = Properties.Resources.rsz_card2;
                        cardsList.RemoveAt(1);
                    }
                    else if (userCard2 == CARD_3)
                    {
                        picPLayCar2.Image = Properties.Resources.rsz_card3;
                        cardsList.RemoveAt(2);
                    }
                    else if (userCard2 == CARD_4)
                    {
                        picPLayCar2.Image = Properties.Resources.rsz_card41;
                        cardsList.RemoveAt(3);
                    }
                    else if (userCard2 == CARD_5)
                    {
                        picPLayCar2.Image = Properties.Resources.rsz_1card5;
                        cardsList.RemoveAt(4);
                    }
                    else if (userCard2 == CARD_6)
                    {
                        picPLayCar2.Image = Properties.Resources.rsz_card6;
                        cardsList.RemoveAt(5);
                    }
                    else if (userCard2 == CARD_7)
                    {
                        picPLayCar2.Image = Properties.Resources.rsz_card7;
                        cardsList.RemoveAt(6);
                    }
                    else if (userCard2 == CARD_8)
                    {
                        picPLayCar2.Image = Properties.Resources.rsz_card8;
                        cardsList.RemoveAt(7);
                    }
                    else if (userCard2 == CARD_9)
                    {
                        picPLayCar2.Image = Properties.Resources.rsz_1card9;
                        cardsList.RemoveAt(8);
                    }
                    else if (userCard2 == CARD_10)
                    {
                        picPLayCar2.Image = Properties.Resources.rsz_card10;
                        cardsList.RemoveAt(9);
                    }
                    //calculate user score, display it, set userCounter to 2
                    userScore = userCard1 + userCard2;
                    lblUserScore.Text = Convert.ToString(userScore);
                    userCounter2 = 1;
                }
            }//ENDFOR USER

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //COMPUTER CARDS LOOP
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //for computer counter smaler or equal to 2
            for (int compCounter = 1; compCounter <= 2; compCounter++)
            {
                //if compCounter is 1 change the first card, remove the card from the list
                if (compCounter == 1)
                {
                    compCard1 = userRandom.Next(0, cardsList.Count());
                    if (compCard1 == CARD_1)
                    {
                        picCompCar1.Image = Properties.Resources.rsz_card1;
                        cardsList.RemoveAt(0);
                    }
                    else if (compCard1 == CARD_2)
                    {
                        picCompCar1.Image = Properties.Resources.rsz_card2;
                        cardsList.RemoveAt(1);
                    }
                    else if (compCard1 == CARD_3)
                    {
                        picCompCar1.Image = Properties.Resources.rsz_card3;
                        cardsList.RemoveAt(2);
                    }
                    else if (compCard1 == CARD_4)
                    {
                        picCompCar1.Image = Properties.Resources.rsz_card41;
                        cardsList.RemoveAt(3);
                    }
                    else if (compCard1 == CARD_5)
                    {
                        picCompCar1.Image = Properties.Resources.rsz_1card5;
                        cardsList.RemoveAt(4);
                    }
                    else if (compCard1 == CARD_6)
                    {
                        picCompCar1.Image = Properties.Resources.rsz_card6;
                        cardsList.RemoveAt(5);
                    }
                    else if (compCard1 == CARD_7)
                    {
                        picCompCar1.Image = Properties.Resources.rsz_card7;
                        cardsList.RemoveAt(6);
                    }
                    else if (compCard1 == CARD_8)
                    {
                        picCompCar1.Image = Properties.Resources.rsz_card8;
                        cardsList.RemoveAt(7);
                    }
                    else if (compCard1 == CARD_9)
                    {
                        picCompCar1.Image = Properties.Resources.rsz_1card9;
                        cardsList.RemoveAt(8);
                    }
                    else if (compCard1 == CARD_10)
                    {
                        picCompCar1.Image = Properties.Resources.rsz_card10;
                        cardsList.RemoveAt(9);
                    }
                }
                //if compCounter is 2 change the second card, remove the card from the list
                else if (compCounter == 2)
                {
                    compCard2 = userRandom.Next(0, cardsList.Count());
                    if (compCard2 == CARD_1)
                    {
                        picCompCar2.Image = Properties.Resources.rsz_card1;
                        cardsList.RemoveAt(0);
                    }
                    else if (compCard2 == CARD_2)
                    {
                        picCompCar2.Image = Properties.Resources.rsz_card2;
                        cardsList.RemoveAt(1);
                    }
                    else if (compCard2 == CARD_3)
                    {
                        picCompCar2.Image = Properties.Resources.rsz_card3;
                        cardsList.RemoveAt(2);
                    }
                    else if (compCard2 == CARD_4)
                    {
                        picCompCar2.Image = Properties.Resources.rsz_card41;
                        cardsList.RemoveAt(3);
                    }
                    else if (compCard2 == CARD_5)
                    {
                        picCompCar2.Image = Properties.Resources.rsz_1card5;
                        cardsList.RemoveAt(4);
                    }
                    else if (compCard2 == CARD_6)
                    {
                        picCompCar2.Image = Properties.Resources.rsz_card6;
                        cardsList.RemoveAt(5);
                    }
                    else if (compCard2 == CARD_7)
                    {
                        picCompCar2.Image = Properties.Resources.rsz_card7;
                        cardsList.RemoveAt(6);
                    }
                    else if (compCard2 == CARD_8)
                    {
                        picCompCar2.Image = Properties.Resources.rsz_card8;
                        cardsList.RemoveAt(7);
                    }
                    else if (compCard2 == CARD_9)
                    {
                        picCompCar2.Image = Properties.Resources.rsz_1card9;
                        cardsList.RemoveAt(8);
                    }
                    else if (compCard2 == CARD_10)
                    {
                        picCompCar2.Image = Properties.Resources.rsz_card10;
                        cardsList.RemoveAt(9);
                    }//END IF
                    //cacluate computer score, convert it to a string and hide it
                    compScore = compCard1 + compCard2;
                    lblCompScore.Text = Convert.ToString(compScore);
                    lblCompScore.Hide();
                }//END IF
            }//ENDFOR COMP
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //FUNCTIONS
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        ///--Hit_FUNCTION--///
        public void Hit_Function()
        {

            Console.WriteLine("***userCounter2 = " + userCounter2);

            //id Hit or Double button is clicked then choose a random card and display it
            if (doubleButton_Clicked == true || hitButton_Clicked == true)
            {
                //if it's the first time when the user presses hit Button
                if (userCounter2 == 1)
                {
                    //generate the thirs random card, display the image and remove the card from the list
                    userCard3 = userRandom.Next(0, cardsList.Count());
                    if (userCard3 == CARD_1)
                    {
                        picPLayCar3.Image = Properties.Resources.rsz_card1;
                        cardsList.RemoveAt(0);
                    }
                    else if (userCard3 == CARD_2)
                    {
                        picPLayCar3.Image = Properties.Resources.rsz_card2;
                        cardsList.RemoveAt(1);
                    }
                    else if (userCard3 == CARD_3)
                    {
                        picPLayCar3.Image = Properties.Resources.rsz_card3;
                        cardsList.RemoveAt(2);
                    }
                    else if (userCard3 == CARD_4)
                    {
                        picPLayCar3.Image = Properties.Resources.rsz_card41;
                        cardsList.RemoveAt(3);
                    }
                    else if (userCard3 == CARD_5)
                    {
                        picPLayCar3.Image = Properties.Resources.rsz_1card5;
                        cardsList.RemoveAt(4);
                    }
                    else if (userCard3 == CARD_6)
                    {
                        picPLayCar3.Image = Properties.Resources.rsz_card6;
                        cardsList.RemoveAt(5);
                    }
                    else if (userCard3 == CARD_7)
                    {
                        picPLayCar3.Image = Properties.Resources.rsz_card7;
                        cardsList.RemoveAt(6);
                    }
                    else if (userCard3 == CARD_8)
                    {
                        picPLayCar3.Image = Properties.Resources.rsz_card8;
                        cardsList.RemoveAt(7);
                    }
                    else if (userCard3 == CARD_9)
                    {
                        picPLayCar3.Image = Properties.Resources.rsz_1card9;
                        cardsList.RemoveAt(8);
                    }
                    else if (userCard3 == CARD_10)
                    {
                        picPLayCar3.Image = Properties.Resources.rsz_card10;
                        cardsList.RemoveAt(9);
                    }
                    //increase the counter by 1
                    userCounter2++;
                    //display the thirs card
                    picPLayCar3.Show();
                    //calculate the new user score and display it
                    userScore = userScore + userCard3;
                    lblUserScore.Text = Convert.ToString(userScore);

                }
               // if it's the second time when the user presses the Hit button, generate the fourth random card, display the image and remove it from the list 
                else if (userCounter2 == 2)
                {
                    userCard4 = userRandom.Next(0, cardsList.Count());
                    if (userCard4 == CARD_1)
                    {
                        picPLayCar4.Image = Properties.Resources.rsz_card1;
                        cardsList.RemoveAt(0);
                    }
                    else if (userCard4 == CARD_2)
                    {
                        picPLayCar4.Image = Properties.Resources.rsz_card2;
                        cardsList.RemoveAt(1);
                    }
                    else if (userCard4 == CARD_3)
                    {
                        picPLayCar4.Image = Properties.Resources.rsz_card3;
                        cardsList.RemoveAt(2);
                    }
                    else if (userCard4 == CARD_4)
                    {
                        picPLayCar4.Image = Properties.Resources.rsz_card41;
                        cardsList.RemoveAt(3);
                    }
                    else if (userCard4 == CARD_5)
                    {
                        picPLayCar4.Image = Properties.Resources.rsz_1card5;
                        cardsList.RemoveAt(4);
                    }
                    else if (userCard4 == CARD_6)
                    {
                        picPLayCar4.Image = Properties.Resources.rsz_card6;
                        cardsList.RemoveAt(5);
                    }
                    else if (userCard4 == CARD_7)
                    {
                        picPLayCar4.Image = Properties.Resources.rsz_card7;
                        cardsList.RemoveAt(6);
                    }
                    else if (userCard4 == CARD_8)
                    {
                        picPLayCar4.Image = Properties.Resources.rsz_card8;
                        cardsList.RemoveAt(7);
                    }
                    else if (userCard4 == CARD_9)
                    {
                        picPLayCar4.Image = Properties.Resources.rsz_1card9;
                        cardsList.RemoveAt(8);
                    }
                    else if (userCard4 == CARD_10)
                    {
                        picPLayCar4.Image = Properties.Resources.rsz_card10;
                        cardsList.RemoveAt(9);
                    }
                    //display the fourth card
                    picPLayCar4.Show();
                    //cacluate the new userScore and display the score
                    userScore = userScore + userCard4;
                    lblUserScore.Text = Convert.ToString(userScore);
                    //Check_Function();
                }
                //set the boolean var to false
                hitButton_Clicked = false;
                doubleButton_Clicked = false;

                this.Refresh();
                
            }
            //id neither the Hit nor Double button was hit, generate the third random card for the computer
            else 
            { 
                    compCard3 = userRandom.Next(0, cardsList.Count());
                    if (compCard3 == CARD_1)
                    {
                        picCompCar3.Image = Properties.Resources.rsz_card1;
                        cardsList.RemoveAt(0);
                    }
                    else if (compCard3 == CARD_2)
                    {
                        picCompCar3.Image = Properties.Resources.rsz_card2;
                        cardsList.RemoveAt(1);
                    }
                    else if (compCard3 == CARD_3)
                    {
                        picCompCar3.Image = Properties.Resources.rsz_card3;
                        cardsList.RemoveAt(2);
                    }
                    else if (compCard3 == CARD_4)
                    {
                        picCompCar3.Image = Properties.Resources.rsz_card41;
                        cardsList.RemoveAt(3);
                    }
                    else if (compCard3 == CARD_5)
                    {
                        picCompCar3.Image = Properties.Resources.rsz_1card5;
                        cardsList.RemoveAt(4);
                    }
                    else if (compCard3 == CARD_6)
                    {
                        picCompCar3.Image = Properties.Resources.rsz_card6;
                        cardsList.RemoveAt(5);
                    }
                    else if (compCard3 == CARD_7)
                    {
                        picCompCar3.Image = Properties.Resources.rsz_card7;
                        cardsList.RemoveAt(6);
                    }
                    else if (compCard3 == CARD_8)
                    {
                        picCompCar3.Image = Properties.Resources.rsz_card8;
                        cardsList.RemoveAt(7);
                    }
                    else if (compCard3 == CARD_9)
                    {
                        picCompCar3.Image = Properties.Resources.rsz_1card9;
                        cardsList.RemoveAt(8);
                    }
                    else if (compCard3 == CARD_10)
                    {
                        picCompCar3.Image = Properties.Resources.rsz_card10;
                        cardsList.RemoveAt(9);
                    }//END IF
                    //calculate the new comp score and display the third card
                    compScore = compScore + compCard3;
                    lblCompScore.Text = Convert.ToString(compScore);
                    picCompCar3.Show();
            }
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            //set the boolean vat to true
            hitButton_Clicked = true;
            //call the Hit_Function
            Hit_Function();

           /* if (userScore > 15)
            {
                btnDouble.Hide();
                btnHit.Hide();
                btnStay.Hide();
                Check_Function();
            }*/

        }

        private void frmGame_Load(object sender, EventArgs e)
        {

        }

        private void picPLayCar1_Click(object sender, EventArgs e)
        {

        }

        ///////////////////////////////////////////////////////////////////////////
        ///--CHECK_FUNCTION--
        ////////////////////////////////////////////////////////////////////////////
        public void Check_Function()
        {
            //display computer cards
            picCompCar1.Show();
            picCompCar2.Show();
            picCompBack.Hide();
            picCompBack2.Hide();
            //hide all the buttons
            btnStay.Hide();
            btnDouble.Hide();
            btnHit.Hide();
            lblCompScore.Show();
            //if computer score is lower than 16, call the Hit_Function
            if (compScore <= 16)
            {
                Hit_Function();
            }

            /////----COMPARE THE RESULTS------//////
            //if user score is bigger than 21, then user loses
            if (userScore > 21)
            {
                lblAnswer.Text = "You lost";
                lblAnswer.Show();
            }
            //if the user's score is 21, then the user wins
            else if(userScore == 21)
            {
                lblAnswer.Text = "Blackjack";
                lblAnswer.Show();
            }
            //if computer score is 21, then the user loses
            else if(compScore == 21)
            {
                lblAnswer.Text = "You lost";
                lblAnswer.Show();
            }
            //if the user score is lower than 21 then
            else if (userScore < 21)
            {
                //if user score is less than computer score then
                if (userScore < compScore)
                {
                    //if computer score is greater tha 21, the the user wins
                    if (compScore > 21)
                    {
                        lblAnswer.Text = "You won";
                        lblAnswer.Show();
                    }
                    //else the user loses
                    else
                    {
                        lblAnswer.Text = "You lost";
                        lblAnswer.Show();

                    }
                }
                //if user score is greater than computer score then the user wins
                else if (userScore > compScore)
                {
                    lblAnswer.Text = "You won";
                    lblAnswer.Show();
                }
                //if userScore equals to computer score than it's a tie
                else if (userScore == compScore)
                {
                    lblAnswer.Text = "It's a tie";
                    lblAnswer.Show();
                }
            }

        }

        private void picCompBack_Click(object sender, EventArgs e)
        {

        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            //show the double sign, calculate the new bet and display it
            lblMult.Show();
            betTot = betTot * 2;
            lblBet1.Text = String.Format("${0:0}", betTot);
            //set the boolean variable to true
            doubleButton_Clicked = true;
            //call the Hit_Function, afterwards the Check_Function
            Hit_Function();
            Check_Function();
            //hide the double button
            btnDouble.Hide();
        }

        private void btnStay_Click(object sender, EventArgs e)
        {
            //Call the Check_Function
            Check_Function();
        }

    }
}
