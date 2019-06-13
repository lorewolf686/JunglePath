namespace JunglePath
{
    partial class HighScores
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
            this.topFive = new System.Windows.Forms.Label();
            this.topTen = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.play = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // topFive
            // 
            this.topFive.BackColor = System.Drawing.Color.Transparent;
            this.topFive.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topFive.ForeColor = System.Drawing.Color.GreenYellow;
            this.topFive.Location = new System.Drawing.Point(333, 239);
            this.topFive.Name = "topFive";
            this.topFive.Size = new System.Drawing.Size(160, 182);
            this.topFive.TabIndex = 0;
            this.topFive.Text = "1. AAA 00000 2. AAA 00000 3. AAA 00000 4. AAA 00000 5. AAA 00000";
            // 
            // topTen
            // 
            this.topTen.BackColor = System.Drawing.Color.Transparent;
            this.topTen.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topTen.ForeColor = System.Drawing.Color.GreenYellow;
            this.topTen.Location = new System.Drawing.Point(544, 239);
            this.topTen.Name = "topTen";
            this.topTen.Size = new System.Drawing.Size(160, 182);
            this.topTen.TabIndex = 1;
            this.topTen.Text = "1. AAA 00000 2. AAA 00000 3. AAA 00000 4. AAA 00000 5. AAA 00000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.GreenYellow;
            this.label1.Location = new System.Drawing.Point(293, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 72);
            this.label1.TabIndex = 2;
            this.label1.Text = "TOP EXPLORERS";
            // 
            // play
            // 
            this.play.BackColor = System.Drawing.Color.Transparent;
            this.play.BackgroundImage = global::JunglePath.Properties.Resources.button;
            this.play.FlatAppearance.BorderSize = 0;
            this.play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play.ForeColor = System.Drawing.Color.YellowGreen;
            this.play.Location = new System.Drawing.Point(629, 592);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(150, 80);
            this.play.TabIndex = 3;
            this.play.Text = "PLAY AGAIN";
            this.play.UseVisualStyleBackColor = false;
            this.play.Click += new System.EventHandler(this.Play_Click);
            this.play.Enter += new System.EventHandler(this.Play_Enter);
            this.play.Leave += new System.EventHandler(this.Play_Leave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::JunglePath.Properties.Resources.button;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.YellowGreen;
            this.button1.Location = new System.Drawing.Point(258, 592);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 80);
            this.button1.TabIndex = 4;
            this.button1.Text = "MAIN MENU";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            this.button1.Enter += new System.EventHandler(this.Button1_Enter);
            this.button1.Leave += new System.EventHandler(this.Button1_Leave);
            // 
            // HighScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JunglePath.Properties.Resources.menuBack;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.play);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.topTen);
            this.Controls.Add(this.topFive);
            this.DoubleBuffered = true;
            this.Name = "HighScores";
            this.Size = new System.Drawing.Size(990, 700);
            this.Load += new System.EventHandler(this.HighScores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label topFive;
        private System.Windows.Forms.Label topTen;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button play;
        internal System.Windows.Forms.Button button1;
    }
}
