namespace Scuffed_Contra
{
    partial class instructionScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.outputLabel2 = new System.Windows.Forms.Label();
            this.outputLabel4 = new System.Windows.Forms.Label();
            this.outputLabel5 = new System.Windows.Forms.Label();
            this.outputLabel6 = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 86);
            this.label1.TabIndex = 0;
            this.label1.Text = "How To Play";
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.ForeColor = System.Drawing.Color.White;
            this.outputLabel.Location = new System.Drawing.Point(63, 121);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 13);
            this.outputLabel.TabIndex = 1;
            // 
            // outputLabel2
            // 
            this.outputLabel2.AutoSize = true;
            this.outputLabel2.ForeColor = System.Drawing.Color.White;
            this.outputLabel2.Location = new System.Drawing.Point(63, 146);
            this.outputLabel2.Name = "outputLabel2";
            this.outputLabel2.Size = new System.Drawing.Size(0, 13);
            this.outputLabel2.TabIndex = 2;
            // 
            // outputLabel4
            // 
            this.outputLabel4.AutoSize = true;
            this.outputLabel4.ForeColor = System.Drawing.Color.White;
            this.outputLabel4.Location = new System.Drawing.Point(63, 176);
            this.outputLabel4.Name = "outputLabel4";
            this.outputLabel4.Size = new System.Drawing.Size(0, 13);
            this.outputLabel4.TabIndex = 4;
            // 
            // outputLabel5
            // 
            this.outputLabel5.AutoSize = true;
            this.outputLabel5.ForeColor = System.Drawing.Color.White;
            this.outputLabel5.Location = new System.Drawing.Point(63, 201);
            this.outputLabel5.Name = "outputLabel5";
            this.outputLabel5.Size = new System.Drawing.Size(0, 13);
            this.outputLabel5.TabIndex = 5;
            // 
            // outputLabel6
            // 
            this.outputLabel6.AutoSize = true;
            this.outputLabel6.ForeColor = System.Drawing.Color.White;
            this.outputLabel6.Location = new System.Drawing.Point(63, 229);
            this.outputLabel6.Name = "outputLabel6";
            this.outputLabel6.Size = new System.Drawing.Size(0, 13);
            this.outputLabel6.TabIndex = 6;
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(98, 272);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(75, 23);
            this.playButton.TabIndex = 7;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            this.playButton.Enter += new System.EventHandler(this.playButton_Enter);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(224, 272);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 8;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            this.backButton.Enter += new System.EventHandler(this.backButton_Enter);
            // 
            // instructionScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.outputLabel6);
            this.Controls.Add(this.outputLabel5);
            this.Controls.Add(this.outputLabel4);
            this.Controls.Add(this.outputLabel2);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.label1);
            this.Name = "instructionScreen";
            this.Size = new System.Drawing.Size(455, 330);
            this.Load += new System.EventHandler(this.instructionScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label outputLabel2;
        private System.Windows.Forms.Label outputLabel4;
        private System.Windows.Forms.Label outputLabel5;
        private System.Windows.Forms.Label outputLabel6;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button backButton;
    }
}
