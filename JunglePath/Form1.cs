using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Media;
using System.IO;
using System.Windows.Media;

namespace JunglePath
{
    public partial class Form1 : Form
    {
        public static MediaPlayer jungleSounds;
        
              
        public Form1()
        {
            InitializeComponent();
            loadScore();
        }

        public static List<Score> HighScores = new List<Score>();
        

        private void Form1_Load(object sender, EventArgs e)
        {
            jungleSounds = new MediaPlayer();

            //start the sounds
            jungleSounds.Open(new Uri(Application.StartupPath + "/Resources/jungleSounds.mp3"));            
            
            jungleSounds.Play();
                        
            //load the main menu 
            MenuScreen ms = new MenuScreen();
            this.Controls.Add(ms);
            ms.Location = new Point((this.Width - ms.Width) / 2, (this.Height - ms.Height) / 2);
        }

        

        void loadScore()
        {            
            
            XmlReader reader = XmlReader.Create("Resources/scores.xml");
            while (reader.Read())
            {
                //read all the scores and place in a list
                if (reader.NodeType == XmlNodeType.Text)
                {
                    string name;
                    int score;

                    name = reader.ReadString();
                    reader.ReadToNextSibling("score");
                    score = Convert.ToInt16(reader.ReadString());

                    Score s = new Score(score, name);

                    //Ensure that they exist
                    if (s.name != null)
                    {
                        HighScores.Add(s);
                    }
                }
            }
            reader.Close();
        }
    }
}
