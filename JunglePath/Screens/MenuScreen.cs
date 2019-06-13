using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JunglePath.Screens;

namespace JunglePath
{
    public partial class MenuScreen : UserControl
    {
        public MenuScreen()
        {
            InitializeComponent();            
        }

        private void Play_Click(object sender, EventArgs e)
        {
            //Change to the how to play screen
            Form f = this.FindForm();
            HowTo hs = new HowTo();
            f.Controls.Add(hs);
            hs.Location = new Point((f.Width - hs.Width) / 2, (f.Height - hs.Height) / 2);
            hs.Focus();
            f.Controls.Remove(this);            
        }

        private void Scores_Click(object sender, EventArgs e)
        {
            //Change to the high scores screen
            Form f = this.FindForm();
            HighScores hs = new HighScores();
            f.Controls.Add(hs);
            hs.Location = new Point((f.Width - hs.Width) / 2, (f.Height - hs.Height) / 2);
            hs.Focus();
            f.Controls.Remove(this);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            //Close the app
            Application.Exit();
        }

        #region button highlights

        //Highlights buttons if they are selected
        private void Play_Enter(object sender, EventArgs e)
        {
            play.BackgroundImage = Properties.Resources.selectButton;
        }

        private void Play_Leave(object sender, EventArgs e)
        {
            play.BackgroundImage = Properties.Resources.button;
        }

        private void Scores_Enter(object sender, EventArgs e)
        {
            scores.BackgroundImage = Properties.Resources.selectButton;
        }

        private void Scores_Leave(object sender, EventArgs e)
        {
            scores.BackgroundImage = Properties.Resources.button;
        }

        private void Exit_Enter(object sender, EventArgs e)
        {
            exit.BackgroundImage = Properties.Resources.selectButton;
        }

        private void Exit_Leave(object sender, EventArgs e)
        {
            exit.BackgroundImage = Properties.Resources.button;
        }
        #endregion

        
    }
}
