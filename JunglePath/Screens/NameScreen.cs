using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;


namespace JunglePath
{
    public partial class NameScreen : UserControl
    {
        int initial = 1;
        Char c = 'A';
        string name;

        public NameScreen()
        {
            InitializeComponent();

            //Outputs player score
            scoreLabel.Text = "Your score is: " + GameScreen.score;
        }

        private void NameScreen_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void NameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //Goes through the three initials and allows player to choose their letters
            if (initial < 4)
            {
                switch (e.KeyCode)
                {
                    case Keys.Down:
                        if (c != 'Z')
                        {
                            c++;
                        }
                        break;
                    case Keys.Up:
                        if (c != 'A')
                        {
                            c--;
                        }
                        break;
                    case Keys.Space:
                        initial++;
                        c = 'A';
                        break;
                }

                switch (initial)
                {
                    case 1:
                        initial1.BackColor = Color.White;
                        initial1.Text = "" + c;
                        break;
                    case 2:
                        initial2.BackColor = Color.White;
                        initial1.BackColor = Color.Transparent;
                        initial2.Text = "" + c;
                        break;
                    case 3:
                        initial3.BackColor = Color.White;
                        initial2.BackColor = Color.Transparent;
                        initial3.Text = "" + c;                       
                        break;
                    default:                       
                        break;
                }
            }            
            else if (initial >= 4)
            {
                //Set the name to equal the initials
                name = initial1.Text + initial2.Text + initial3.Text;

                //Create a new score with the player's name and score
                Score s = new Score(GameScreen.score, name);

                //Add it to the list of scores and sort 
                Form1.HighScores.Add(s);
                Form1.HighScores = Form1.HighScores.OrderBy(x => (x.score * -1)).ToList();

                //Reduce to top ten scores
                if (Form1.HighScores.Count > 10)
                {
                    for (int i = Form1.HighScores.Count - 1; i > 10; i--)
                    {
                        Form1.HighScores.RemoveAt(i);
                    }
                }

                scoreSave();

                //Change to high score screen
                HighScores hs = new HighScores();
                Form f = this.FindForm();
                f.Controls.Add(hs);
                hs.Location = new Point((f.Width - hs.Width) / 2, (f.Height - hs.Height) / 2);
                f.Controls.Remove(this);

            }
        }

        void scoreSave()
        {
            //Write all the scores in the list to the XML file
            XmlWriter writer = XmlWriter.Create("Resources/scores.xml");
            writer.WriteStartElement("scores");
            foreach (Score s in Form1.HighScores)
            {
                writer.WriteElementString("name", s.name);
                writer.WriteElementString("score", Convert.ToString(s.score));
            }
            writer.WriteEndElement();

            writer.Close();

        }
    }
}
