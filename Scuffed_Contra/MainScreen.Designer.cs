namespace Scuffed_Contra
{
    partial class MainScreen
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.startButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.howtoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(206, 394);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            this.startButton.Enter += new System.EventHandler(this.startButton_Enter);
            this.startButton.MouseEnter += new System.EventHandler(this.startButton_MouseEnter);
            this.startButton.MouseLeave += new System.EventHandler(this.startButton_MouseLeave);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(434, 394);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            this.exitButton.Enter += new System.EventHandler(this.exitButton_Enter);
            // 
            // howtoButton
            // 
            this.howtoButton.Location = new System.Drawing.Point(625, 394);
            this.howtoButton.Name = "howtoButton";
            this.howtoButton.Size = new System.Drawing.Size(92, 23);
            this.howtoButton.TabIndex = 2;
            this.howtoButton.Text = "How To Play";
            this.howtoButton.UseVisualStyleBackColor = true;
            this.howtoButton.Click += new System.EventHandler(this.howtoButton_Click);
            this.howtoButton.Enter += new System.EventHandler(this.howtoButton_Enter);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Scuffed_Contra.Properties.Resources.mainimage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.howtoButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.startButton);
            this.Name = "MainScreen";
            this.Size = new System.Drawing.Size(1280, 720);
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button howtoButton;
    }
}
