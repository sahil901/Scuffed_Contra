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
    public partial class MainScreen : UserControl
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        //Start Button Click 
        private void startButton_Click(object sender, EventArgs e)
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

        //Exit Button Click
        private void exitButton_Click(object sender, EventArgs e)
        {
            // Exit the the program
            Application.Exit();
        }

        //Main screen Load 
        private void MainScreen_Load(object sender, EventArgs e)
        {

        }

        //Start button Enter 
        private void startButton_Enter(object sender, EventArgs e)
        {
            //start game button goes green and exit button goes white
            startButton.BackColor = Color.Green;
            exitButton.BackColor = Color.White;
            howtoButton.BackColor = Color.White;
        }

       //Exit button enter 
        private void exitButton_Enter(object sender, EventArgs e)
        {
            //start button goes white and exit button goes green
            startButton.BackColor = Color.White;
            exitButton.BackColor = Color.Red;
            howtoButton.BackColor = Color.White;
        }

        //Start Button Mouse Enter
        private void startButton_MouseEnter(object sender, EventArgs e)
        {
            //change button's color to green
            startButton.BackColor = Color.Green;
        }

        //Start Button Mouse Leave
        private void startButton_MouseLeave(object sender, EventArgs e)
        {
            //reset button's color to white
            startButton.BackColor = Color.White;
        }

        //How to Play Button Click
        private void howtoButton_Click(object sender, EventArgs e)
        {
            //created instance of simon game
           instructionScreen hs = new instructionScreen();

            //close mainscreen
            Form f = this.FindForm();
            f.Controls.Remove(this);

            // centre screen
            hs.Location = new Point((this.Width - hs.Width) / 2, (this.Height - hs.Height) / 2);

            //add game screen
            f.Controls.Add(hs);
        }

        private void howtoButton_Enter(object sender, EventArgs e)
        {
            howtoButton.BackColor = Color.Blue;
            startButton.BackColor = Color.White;
            exitButton.BackColor = Color.White;
        }
    }
}
