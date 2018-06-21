namespace Scuffed_Contra
{
    partial class GameOver
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
            this.gameoverLabel = new System.Windows.Forms.Label();
            this.returnbutton = new System.Windows.Forms.Button();
            this.quitGameButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameoverLabel
            // 
            this.gameoverLabel.AutoSize = true;
            this.gameoverLabel.Font = new System.Drawing.Font("Palatino Linotype", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameoverLabel.ForeColor = System.Drawing.Color.White;
            this.gameoverLabel.Location = new System.Drawing.Point(63, 15);
            this.gameoverLabel.Name = "gameoverLabel";
            this.gameoverLabel.Size = new System.Drawing.Size(363, 86);
            this.gameoverLabel.TabIndex = 1;
            this.gameoverLabel.Text = "Game Over";
            // 
            // returnbutton
            // 
            this.returnbutton.BackColor = System.Drawing.Color.Black;
            this.returnbutton.FlatAppearance.BorderSize = 0;
            this.returnbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.returnbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.returnbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnbutton.Font = new System.Drawing.Font("Palatino Linotype", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnbutton.ForeColor = System.Drawing.Color.White;
            this.returnbutton.Location = new System.Drawing.Point(78, 133);
            this.returnbutton.Name = "returnbutton";
            this.returnbutton.Size = new System.Drawing.Size(341, 100);
            this.returnbutton.TabIndex = 6;
            this.returnbutton.Text = "Main Menu";
            this.returnbutton.UseVisualStyleBackColor = false;
            this.returnbutton.Click += new System.EventHandler(this.returnbutton_Click);
            this.returnbutton.Enter += new System.EventHandler(this.returnbutton_Enter);
            // 
            // quitGameButton
            // 
            this.quitGameButton.BackColor = System.Drawing.Color.Black;
            this.quitGameButton.FlatAppearance.BorderSize = 0;
            this.quitGameButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.quitGameButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.quitGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitGameButton.Font = new System.Drawing.Font("Palatino Linotype", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitGameButton.ForeColor = System.Drawing.Color.White;
            this.quitGameButton.Location = new System.Drawing.Point(78, 230);
            this.quitGameButton.Name = "quitGameButton";
            this.quitGameButton.Size = new System.Drawing.Size(298, 100);
            this.quitGameButton.TabIndex = 7;
            this.quitGameButton.Text = "Quit ";
            this.quitGameButton.UseVisualStyleBackColor = false;
            this.quitGameButton.Click += new System.EventHandler(this.quitGameButton_Click);
            this.quitGameButton.Enter += new System.EventHandler(this.quitGameButton_Enter);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(89, 122);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 13);
            this.outputLabel.TabIndex = 8;
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.quitGameButton);
            this.Controls.Add(this.returnbutton);
            this.Controls.Add(this.gameoverLabel);
            this.Name = "GameOver";
            this.Size = new System.Drawing.Size(456, 333);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gameoverLabel;
        private System.Windows.Forms.Button returnbutton;
        private System.Windows.Forms.Button quitGameButton;
        private System.Windows.Forms.Label outputLabel;
    }
}
