using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JunglePath
{
    public partial class HighScores : UserControl
    {
        public HighScores()
        {
            InitializeComponent();
        }

        private void HighScores_Load(object sender, EventArgs e)
        {
            scoreLoad();
        }

        void scoreLoad()
        {
            //clear both labels
            topFive.Text = "";
            topTen.Text = "";

            //Output the top five scores to the left label
            for (int i = 0; i <= 4; i++)
            {
                topFive.Text += i + 1 + ": " + Form1.HighScores[i].name + " " + Form1.HighScores[i].score + "\n";
            }

            //Output the 6-10 scores to the right label
            for (int i = 5; i <= 9; i++)
            {
                topTen.Text += i + 1 + ": " + Form1.HighScores[i].name + " " + Form1.HighScores[i].score + "\n";
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Return tot the menu screen
            Form f = this.FindForm();
            MenuScreen ms = new MenuScreen();
            f.Controls.Add(ms);
            ms.Location = new Point((f.Width - ms.Width) / 2, (f.Height - ms.Height) / 2);
            f.Controls.Remove(this);
        }

        #region button selection
        private void Play_Enter(object sender, EventArgs e)
        {
            play.BackgroundImage = Properties.Resources.selectButton;
        }

        private void Play_Leave(object sender, EventArgs e)
        {
            play.BackgroundImage = Properties.Resources.button;
        }

        private void Button1_Enter(object sender, EventArgs e)
        {
            button1.BackgroundImage = Properties.Resources.selectButton;            
        }

        private void Button1_Leave(object sender, EventArgs e)
        {
            button1.BackgroundImage = Properties.Resources.button;
        }

        #endregion
        private void Play_Click(object sender, EventArgs e)
        {
            //Open the game screen
            Form f = this.FindForm();
            GameScreen gs = new GameScreen();
            f.Controls.Add(gs);
            gs.Location = new Point((f.Width - gs.Width) / 2, (f.Height - gs.Height) / 2);
            f.Controls.Remove(this);
        }
    }
}
