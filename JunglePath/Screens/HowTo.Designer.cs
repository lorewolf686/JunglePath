namespace JunglePath.Screens
{
    partial class HowTo
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
            this.play = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // play
            // 
            this.play.BackColor = System.Drawing.Color.Transparent;
            this.play.BackgroundImage = global::JunglePath.Properties.Resources.button;
            this.play.FlatAppearance.BorderSize = 0;
            this.play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play.ForeColor = System.Drawing.Color.LightGreen;
            this.play.Location = new System.Drawing.Point(767, 598);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(150, 80);
            this.play.TabIndex = 2;
            this.play.Text = "EXPLORE";
            this.play.UseVisualStyleBackColor = false;
            this.play.Click += new System.EventHandler(this.Play_Click);
            this.play.Enter += new System.EventHandler(this.Play_Enter);
            this.play.Leave += new System.EventHandler(this.Play_Leave);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Transparent;
            this.menu.BackgroundImage = global::JunglePath.Properties.Resources.button;
            this.menu.FlatAppearance.BorderSize = 0;
            this.menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.ForeColor = System.Drawing.Color.LightGreen;
            this.menu.Location = new System.Drawing.Point(93, 598);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(150, 80);
            this.menu.TabIndex = 3;
            this.menu.Text = "ESCAPE";
            this.menu.UseVisualStyleBackColor = false;
            this.menu.Click += new System.EventHandler(this.Menu_Click);
            this.menu.Enter += new System.EventHandler(this.Menu_Enter);
            this.menu.Leave += new System.EventHandler(this.Menu_Leave);
            // 
            // HowTo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JunglePath.Properties.Resources.How_To_Play;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.menu);
            this.Controls.Add(this.play);
            this.DoubleBuffered = true;
            this.Name = "HowTo";
            this.Size = new System.Drawing.Size(990, 700);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button play;
        internal System.Windows.Forms.Button menu;
    }
}
