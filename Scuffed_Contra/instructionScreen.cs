using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scuffed_Contra 
{
    public partial class instructionScreen : UserControl
    {
        public instructionScreen()
        {
            InitializeComponent();
        }
      
        //Creating the button selected integer 
        private int buttonSelected;

        //Instruction Screen Load 
        private void instructionScreen_Load(object sender, EventArgs e)
        {
            //Output Labels to tell the player how to play the game
            outputLabel.Text = "Welcome to our game!";
            outputLabel2.Text = "Pointing up will make Joe jump!";
         //  outputLabel3.Text = "Pointing left will make Joe walk back!";
            outputLabel4.Text = "Pointing right will make Joe walk forward!";
            outputLabel5.Text = "Space will allow you to shoot!";
            outputLabel6.Text = "Esc will pause the game and allow you to continue or quit Contra!";
        }

        //Play Button Click
        private void playButton_Click(object sender, EventArgs e)
        {
            //created instance of game screen
            GameScreen gs = new GameScreen();

            //close mainscreen
            Form f = this.FindForm();
            f.Controls.Remove(this);

            //centre the screen
            gs.Location = new Point((f.Width - gs.Width) / 2, (f.Height - gs.Height) / 2);

            //add game screen to the form
            f.Controls.Add(gs);
        }

        //Play Button Enter
        private void playButton_Enter(object sender, EventArgs e)
        {
            // set focus on the play button
            setButtonFocused(0);
            
            //play game button goes green and back button goes white
            playButton.BackColor = Color.Green;
            backButton.BackColor = Color.White;
        }

        //Return Button Click
        private void backButton_Click(object sender, EventArgs e)
        {
            // f is the form that this control is on - ("this" is the current User Control)
            Form f = this.FindForm();
            f.Controls.Remove(this);

            //created instance of main screen
            MainScreen ms = new MainScreen();

            //close mainscreen
            Form x = this.FindForm();
            f.Controls.Remove(this);

            // centre screen
            ms.Location = new Point((f.Width - ms.Width) / 2, (f.Height - ms.Height) / 2);

            //add menu screen
            f.Controls.Add(ms);
        }

        //Return Button Enter
        private void backButton_Enter(object sender, EventArgs e)
        {
            // set focus on back bu
            setButtonFocused(1);
            
            //play button goes white and back button goes green
            playButton.BackColor = Color.White;
            backButton.BackColor = Color.Red;
        }

        //focus button index
        private void setButtonFocused(int buttonIndex)
        {
            buttonSelected = buttonIndex;
         
            // resetAllLabelColours();
            switch (buttonIndex)
            {
                // fore color for each button
                case 0:
                    playButton.ForeColor = Color.Black;
                    break;
                case 1:
                    backButton.ForeColor = Color.Black;
                    break;
            }
        }
    }
}
