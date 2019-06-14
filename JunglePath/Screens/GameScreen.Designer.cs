namespace JunglePath
{
    partial class GameScreen
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
            this.lifeLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.exitCheck = new System.Windows.Forms.Label();
            this.quit = new System.Windows.Forms.Button();
            this.resume = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lifeLabel
            // 
            this.lifeLabel.AutoSize = true;
            this.lifeLabel.BackColor = System.Drawing.Color.Transparent;
            this.lifeLabel.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lifeLabel.ForeColor = System.Drawing.Color.GreenYellow;
            this.lifeLabel.Location = new System.Drawing.Point(823, 17);
            this.lifeLabel.Name = "lifeLabel";
            this.lifeLabel.Size = new System.Drawing.Size(127, 34);
            this.lifeLabel.TabIndex = 0;
            this.lifeLabel.Text = "LIVES: 00";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.Color.GreenYellow;
            this.scoreLabel.Location = new System.Drawing.Point(40, 17);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(155, 34);
            this.scoreLabel.TabIndex = 1;
            this.scoreLabel.Text = "SCORE: 0000";
            // 
            // exitCheck
            // 
            this.exitCheck.AutoSize = true;
            this.exitCheck.BackColor = System.Drawing.Color.Black;
            this.exitCheck.Font = new System.Drawing.Font("Monotype Corsiva", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitCheck.ForeColor = System.Drawing.Color.GreenYellow;
            this.exitCheck.Location = new System.Drawing.Point(244, 226);
            this.exitCheck.Name = "exitCheck";
            this.exitCheck.Size = new System.Drawing.Size(559, 57);
            this.exitCheck.TabIndex = 2;
            this.exitCheck.Text = "Are you sure you want to quit? ";
            this.exitCheck.Visible = false;
            // 
            // quit
            // 
            this.quit.BackColor = System.Drawing.Color.Black;
            this.quit.BackgroundImage = global::JunglePath.Properties.Resources.button;
            this.quit.FlatAppearance.BorderSize = 0;
            this.quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quit.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quit.ForeColor = System.Drawing.Color.GreenYellow;
            this.quit.Location = new System.Drawing.Point(245, 305);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(150, 80);
            this.quit.TabIndex = 0;
            this.quit.Text = "YES";
            this.quit.UseVisualStyleBackColor = false;
            this.quit.Visible = false;
            this.quit.Click += new System.EventHandler(this.Button1_Click);
            this.quit.Enter += new System.EventHandler(this.Button1_Enter);
            this.quit.Leave += new System.EventHandler(this.Button1_Leave);
            // 
            // resume
            // 
            this.resume.BackColor = System.Drawing.Color.Black;
            this.resume.BackgroundImage = global::JunglePath.Properties.Resources.button;
            this.resume.FlatAppearance.BorderSize = 0;
            this.resume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resume.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resume.ForeColor = System.Drawing.Color.GreenYellow;
            this.resume.Location = new System.Drawing.Point(653, 305);
            this.resume.Name = "resume";
            this.resume.Size = new System.Drawing.Size(150, 80);
            this.resume.TabIndex = 1;
            this.resume.Text = "NO";
            this.resume.UseVisualStyleBackColor = false;
            this.resume.Visible = false;
            this.resume.Click += new System.EventHandler(this.Resume_Click);
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JunglePath.Properties.Resources.gameBack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.resume);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.exitCheck);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.lifeLabel);
            this.DoubleBuffered = true;
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(990, 700);
            this.Load += new System.EventHandler(this.GameScreen_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameScreen_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GameScreen_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lifeLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label exitCheck;
        internal System.Windows.Forms.Button quit;
        internal System.Windows.Forms.Button resume;
    }
}
