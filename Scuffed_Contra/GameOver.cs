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
    public partial class GameOver : UserControl
    {
        //private integer for selected button
        private int buttonSelected;

        public GameOver()
        {
            InitializeComponent();
        }

        // go back to menu screen 
        private void returnbutton_Click(object sender, EventArgs e)
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

        //quit the game
        private void quitGameButton_Click(object sender, EventArgs e)
        {
            //exits game
            Application.Exit();
        }

        //set focus on return button
        private void returnbutton_Enter(object sender, EventArgs e)
        {
            setFocusedButton(0);
            returnbutton.BackColor = Color.Green;
            quitGameButton.BackColor = Color.White;
        }

        //set focus on quitgame button
        private void quitGameButton_Enter(object sender, EventArgs e)
        {
            setFocusedButton(1);
            returnbutton.BackColor = Color.White;
            quitGameButton.BackColor = Color.Red;
        }

        //  set the colour of the focus button 
        private void setFocusedButton(int buttonIndex)
        {
            buttonSelected = buttonIndex;
            switch (buttonIndex)
            {
                case 0:
                    returnbutton.ForeColor = Color.White;
                    break;
                case 1:
                    quitGameButton.ForeColor = Color.White;
                    break;
            }
        }
    }
}

