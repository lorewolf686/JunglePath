namespace JunglePath
{
    partial class MenuScreen
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
            this.play = new System.Windows.Forms.Button();
            this.scores = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.YellowGreen;
            this.label1.Location = new System.Drawing.Point(237, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(551, 97);
            this.label1.TabIndex = 0;
            this.label1.Text = "JUNGLE PATH";
            // 
            // play
            // 
            this.play.BackColor = System.Drawing.Color.Transparent;
            this.play.BackgroundImage = global::JunglePath.Properties.Resources.button;
            this.play.FlatAppearance.BorderSize = 0;
            this.play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play.ForeColor = System.Drawing.Color.YellowGreen;
            this.play.Location = new System.Drawing.Point(437, 162);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(150, 80);
            this.play.TabIndex = 1;
            this.play.Text = "EXPLORE";
            this.play.UseVisualStyleBackColor = false;
            this.play.Click += new System.EventHandler(this.Play_Click);
            this.play.Enter += new System.EventHandler(this.Play_Enter);
            this.play.Leave += new System.EventHandler(this.Play_Leave);
            // 
            // scores
            // 
            this.scores.BackColor = System.Drawing.Color.Transparent;
            this.scores.BackgroundImage = global::JunglePath.Properties.Resources.button;
            this.scores.FlatAppearance.BorderSize = 0;
            this.scores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scores.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scores.ForeColor = System.Drawing.Color.YellowGreen;
            this.scores.Location = new System.Drawing.Point(437, 270);
            this.scores.Name = "scores";
            this.scores.Size = new System.Drawing.Size(150, 80);
            this.scores.TabIndex = 2;
            this.scores.Text = "HALL OF FAME";
            this.scores.UseVisualStyleBackColor = false;
            this.scores.Click += new System.EventHandler(this.Scores_Click);
            this.scores.Enter += new System.EventHandler(this.Scores_Enter);
            this.scores.Leave += new System.EventHandler(this.Scores_Leave);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.BackgroundImage = global::JunglePath.Properties.Resources.button;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.YellowGreen;
            this.exit.Location = new System.Drawing.Point(437, 377);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(150, 80);
            this.exit.TabIndex = 3;
            this.exit.Text = "ESCAPE";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.Exit_Click);
            this.exit.Enter += new System.EventHandler(this.Exit_Enter);
            this.exit.Leave += new System.EventHandler(this.Exit_Leave);
            // 
            // MenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JunglePath.Properties.Resources.menuBack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.exit);
            this.Controls.Add(this.scores);
            this.Controls.Add(this.play);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "MenuScreen";
            this.Size = new System.Drawing.Size(990, 700);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button play;
        internal System.Windows.Forms.Button scores;
        internal System.Windows.Forms.Button exit;
    }
}
