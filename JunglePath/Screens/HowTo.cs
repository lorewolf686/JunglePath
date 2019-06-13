using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JunglePath.Screens
{
    public partial class HowTo : UserControl
    {
        public HowTo()
        {
            InitializeComponent();
        }

        #region selection stuff
        private void Play_Enter(object sender, EventArgs e)
        {
            play.BackgroundImage = Properties.Resources.selectButton;
        }

        private void Play_Leave(object sender, EventArgs e)
        {
            play.BackgroundImage = Properties.Resources.button;
        }

        private void Menu_Enter(object sender, EventArgs e)
        {
            menu.BackgroundImage = Properties.Resources.selectButton;
        }

        private void Menu_Leave(object sender, EventArgs e)
        {
            menu.BackgroundImage = Properties.Resources.button;
        }
        #endregion

        private void Menu_Click(object sender, EventArgs e)
        {
            //Returns to the menu
            Form f = this.FindForm();
            MenuScreen ms = new MenuScreen();
            f.Controls.Remove(this);
            f.Controls.Add(ms);
            ms.Focus();
            ms.Location = new Point((f.Width - ms.Width) / 2, (f.Height - ms.Height) / 2);
        }

        private void Play_Click(object sender, EventArgs e)
        {
            //Changes to the game screen
            GameScreen gs = new GameScreen();
            Form f = this.FindForm();
            f.Controls.Remove(this);
            f.Controls.Add(gs);
            gs.Location = new Point((f.Width - gs.Width) / 2, (f.Height - gs.Height) / 2);
        }
    }
}
