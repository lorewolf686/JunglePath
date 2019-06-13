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
            this.no = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            // no
            // 
            this.no.BackColor = System.Drawing.Color.Black;
            this.no.BackgroundImage = global::JunglePath.Properties.Resources.button;
            this.no.FlatAppearance.BorderSize = 0;
            this.no.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.no.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no.ForeColor = System.Drawing.Color.GreenYellow;
            this.no.Location = new System.Drawing.Point(653, 305);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(150, 80);
            this.no.TabIndex = 1;
            this.no.Text = "NO";
            this.no.UseVisualStyleBackColor = false;
            this.no.Visible = false;
            this.no.Click += new System.EventHandler(this.Play_Click);
            this.no.Enter += new System.EventHandler(this.No_Enter);
            this.no.Leave += new System.EventHandler(this.No_Leave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.BackgroundImage = global::JunglePath.Properties.Resources.button;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.GreenYellow;
            this.button1.Location = new System.Drawing.Point(245, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 80);
            this.button1.TabIndex = 0;
            this.button1.Text = "YES";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            this.button1.Enter += new System.EventHandler(this.Button1_Enter);
            this.button1.Leave += new System.EventHandler(this.Button1_Leave);
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JunglePath.Properties.Resources.gameBack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.no);
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
        internal System.Windows.Forms.Button no;
        internal System.Windows.Forms.Button button1;
    }
}
