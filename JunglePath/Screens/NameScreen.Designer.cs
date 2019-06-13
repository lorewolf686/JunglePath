namespace JunglePath
{
    partial class NameScreen
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
            this.initial3 = new System.Windows.Forms.Label();
            this.initial2 = new System.Windows.Forms.Label();
            this.initial1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // initial3
            // 
            this.initial3.AutoSize = true;
            this.initial3.BackColor = System.Drawing.Color.Transparent;
            this.initial3.Font = new System.Drawing.Font("Monotype Corsiva", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initial3.ForeColor = System.Drawing.Color.GreenYellow;
            this.initial3.Location = new System.Drawing.Point(600, 309);
            this.initial3.Name = "initial3";
            this.initial3.Size = new System.Drawing.Size(136, 147);
            this.initial3.TabIndex = 7;
            this.initial3.Text = "A";
            // 
            // initial2
            // 
            this.initial2.AutoSize = true;
            this.initial2.BackColor = System.Drawing.Color.Transparent;
            this.initial2.Font = new System.Drawing.Font("Monotype Corsiva", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initial2.ForeColor = System.Drawing.Color.GreenYellow;
            this.initial2.Location = new System.Drawing.Point(446, 309);
            this.initial2.Name = "initial2";
            this.initial2.Size = new System.Drawing.Size(136, 147);
            this.initial2.TabIndex = 6;
            this.initial2.Text = "A";
            // 
            // initial1
            // 
            this.initial1.AutoSize = true;
            this.initial1.BackColor = System.Drawing.Color.White;
            this.initial1.Font = new System.Drawing.Font("Monotype Corsiva", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initial1.ForeColor = System.Drawing.Color.GreenYellow;
            this.initial1.Location = new System.Drawing.Point(292, 309);
            this.initial1.Name = "initial1";
            this.initial1.Size = new System.Drawing.Size(136, 147);
            this.initial1.TabIndex = 5;
            this.initial1.Text = "A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.GreenYellow;
            this.label1.Location = new System.Drawing.Point(335, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 72);
            this.label1.TabIndex = 4;
            this.label1.Text = "GAME OVER";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.Color.GreenYellow;
            this.scoreLabel.Location = new System.Drawing.Point(271, 201);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(275, 72);
            this.scoreLabel.TabIndex = 8;
            this.scoreLabel.Text = "Your score:";
            // 
            // NameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JunglePath.Properties.Resources.menuBack;
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.initial3);
            this.Controls.Add(this.initial2);
            this.Controls.Add(this.initial1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "NameScreen";
            this.Size = new System.Drawing.Size(990, 700);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NameScreen_KeyDown);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.NameScreen_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label initial3;
        private System.Windows.Forms.Label initial2;
        private System.Windows.Forms.Label initial1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label scoreLabel;
    }
}
