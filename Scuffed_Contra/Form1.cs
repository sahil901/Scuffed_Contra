using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Scuffed_Contra
{
    public partial class Form1 : Form
    {
        public Form1() 
        {
            InitializeComponent();
        }
      
        //Form One Load
        private void Form1_Load(object sender, EventArgs e)
        {
           //setting gofullscreen to "true"
            GoFullscreen(true);

            //launch mainscreen
            MainScreen ms = new MainScreen();

            //add main screen
            this.Controls.Add(ms);

            // centre screen
            ms.Location = new Point((this.Width - ms.Width) / 2, (this.Height - ms.Height) / 2);
        }

        // Go full screen to be optimized for arcade
        void GoFullscreen(bool fullscreen)
        {
         
            //sets border style 
            if (fullscreen)
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.Bounds = Screen.PrimaryScreen.Bounds;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            }
        }
    }
}
