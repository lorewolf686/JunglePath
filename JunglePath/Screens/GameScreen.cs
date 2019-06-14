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
using System.Threading;
using JunglePath.Screens;
using JunglePath;

namespace JunglePath
{
    public partial class GameScreen : UserControl
    {
        #region variables
        List<Block> blocks = new List<Block>();
        List<Player> players = new List<Player>();
        int pX, pY, next;
        int level = 1;
        public static int score;
        

        int lives = 5;
        string moveOK;
        #endregion

        public GameScreen()
        {
            InitializeComponent();

            //Add the player to the list
            Player p = new Player(pX, pY, 5, "right");
            players.Add(p);

            //Make sure the pause menu is not visible
            exitCheck.Visible = false;
            resume.Visible = false;
            quit.Visible = false;
        }
        private void GameScreen_Load(object sender, EventArgs e)
        {
            //Load the first level
            LevelLoad(level);

            //Set the score to 0
            score = 0;

            //Play jungle sounds
            Form1.jungleSounds.Play();

            //Place the player at the start position
            findStart();
        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftKey();
                    break;

                case Keys.Right:
                    rightKey();
                    break;

                case Keys.Up:
                    upKey();
                    break;

                case Keys.Down:
                    downKey();
                    break;

                case Keys.Space:
                    spaceKey();
                    break;

                case Keys.Escape:
                    exitCheck.Visible = true;
                    resume.Visible = true;
                    quit.Visible = true;
                    quit.Focus();
                    break;
            }
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            //Paints blocks based on whether or not they are revealed or selected
            foreach (Block b in blocks)
            {
                if (b.revealed == true)
                {
                    switch (b.type)
                    {
                        case "start":
                            e.Graphics.DrawImage(Properties.Resources.path, b.x, b.y, b.size, b.size);
                            break;
                        case "path":
                            e.Graphics.DrawImage(Properties.Resources.path, b.x, b.y, b.size, b.size);
                            break;
                        case "monster":
                            e.Graphics.DrawImage(Properties.Resources.slime, b.x, b.y, b.size, b.size);
                            break;
                        case "win":
                            e.Graphics.DrawImage(Properties.Resources.treasure, b.x, b.y, b.size, b.size);
                            break;
                    }
                }
                else if (b.select == true)
                {
                    e.Graphics.DrawImage(Properties.Resources.selectBlock, b.x, b.y, b.size, b.size);
                }
                else
                {
                    e.Graphics.DrawImage(Properties.Resources.block, b.x, b.y, b.size, b.size);
                }
            }

            //Paints the player depending on direction
            foreach (Player p in players)
            {
                switch (p.direction)
                {
                    case "left":
                        e.Graphics.DrawImage(Properties.Resources.pLeft, p.x, p.y, p.size, p.size);
                        break;
                    case "right":
                        e.Graphics.DrawImage(Properties.Resources.pRight, p.x, p.y, p.size, p.size);
                        break;
                    case "up":
                        e.Graphics.DrawImage(Properties.Resources.pUp, p.x, p.y, p.size, p.size);
                        break;
                    case "down":
                        e.Graphics.DrawImage(Properties.Resources.pDown, p.x, p.y, p.size, p.size);
                        break;
                }
            }

            //Writes the score and the lives
            scoreLabel.Text = "Score: " + score;

            lifeLabel.Text = "Lives: " + lives;

        }

        void LevelLoad(int levelNum)
        {            
            XmlReader reader;

            //Chooses the level based on levelNum
            reader = XmlReader.Create("Resources/Level" + levelNum + ".xml");

            //reads the level
            while (reader.Read())
            {

                string x, y, type;
                x = y = type = "";
                reader.ReadToFollowing("block");
                x = reader.GetAttribute("x");
                y = reader.GetAttribute("y");
                type = reader.GetAttribute("type");

                //Makes sure the block exists
                if (x != null)
                {
                    Block b = new Block(Convert.ToInt16(x), Convert.ToInt16(y), false, false, type);
                    blocks.Add(b);
                }

            }

            reader.Close();
        }

        void findStart()
        {
            foreach (Block b in blocks)
            {
                //Combs through to find the start
                if (b.type == "start")
                {
                    //Reveals start
                    b.revealed = true;
                    
                    //Places player on the start block
                    players[0].x = b.x;
                    players[0].y = b.y;
                    players[0].current = blocks.IndexOf(b);

                    //Turns player to face right 
                    players[0].direction = "right";
                }
            }
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            //switch (e.KeyCode)
            //{
            //    case Keys.Left:
            //        leftPress = false;
            //        break;

            //    case Keys.Right:
            //        rightPress = false;
            //        break;

            //    case Keys.Up:
            //        upPress = false;
            //        break;

            //    case Keys.Down:
            //        downPress = false;
            //        break;

            //    case Keys.Space:
            //        spacePress = false;
            //        break;
            //}
        }
        void monster()
        {
            //Removes a life
            lives -= 1;

            //Removes 600 pts
            if (score > 600)
            {
                score -= 600;
            }
            else if (score <= 600)
            {
                score = 0;
            }

            foreach (Block b in blocks)
            {
                b.revealed = false;
                b.select = false;
            }

            players[0].direction = "right";            
            findStart();
        }

        void gameOver()
        {
            //Change to name screen
            Form f = this.FindForm();
            NameScreen ns = new NameScreen();
            f.Controls.Add(ns);
            ns.Location = new Point((f.Width - ns.Width) / 2, (f.Height - ns.Height) / 2);
            ns.Focus();
            f.Controls.Remove(this);
        }

        void onWin()
        {
            level += 1;
            lives += 1;
            score += 1000;

            if (level < 11)
            {
                for (int i = 0; i < 49; i++)
                {
                    blocks.Remove(blocks[0]);
                }
                LevelLoad(level);
                findStart();
            }
            else
            {
                //Change to the name screen
                Form f = this.FindForm();
                HowTo hs = new HowTo();
                f.Controls.Add(hs);
                hs.Location = new Point((f.Width - hs.Width) / 2, (f.Height - hs.Height) / 2);
                hs.Focus();
                f.Controls.Remove(this);
            }
            
        }

        void rightKey()
        {
            //make the player face right
            players[0].direction = "right";

            //deselect any other blocks that could be selected 
            foreach (Block b in blocks)
            {
                if (b.select == true)
                {
                    b.select = false;
                    break;
                }
            }

            switch (players[0].current)
            {
                //checks for the right edge blocks
                case 6:
                    break;
                case 13:
                    break;
                case 20:
                    break;
                case 27:
                    break;
                case 34:
                    break;
                case 41:
                    break;
                case 48:
                    break;
                default:
                    //sets select on the block to the right
                    next = players[0].current + 1;
                    blocks[next].select = true;
                    break;
            }
            Refresh();
        }

        void leftKey()
        {
            //change character direction 
            players[0].direction = "left";

            //deselect any other blocks that could be selected 
            foreach (Block b in blocks)
            {
                if (b.select == true)
                {
                    b.select = false;
                    break;
                }
            }

            switch (players[0].current)
            {
                //checks for the left edge
                case 0:
                    break;
                case 7:
                    break;
                case 14:
                    break;
                case 21:
                    break;
                case 28:
                    break;
                case 35:
                    break;
                case 42:
                    break;
                default:
                    next = players[0].current - 1;
                    blocks[next].select = true;
                    break;
            }
            Refresh();
        }

        void upKey()
        {
            //change character direction 
            players[0].direction = "up";

            //deselect any other blocks that could be selected 
            foreach (Block b in blocks)
            {
                if (b.select == true)
                {
                    b.select = false;
                    break;
                }
            }

            switch (players[0].current)
            {
                //checks for the left edge
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                default:
                    next = players[0].current - 7;
                    blocks[next].select = true;
                    break;
            }
            Refresh();
        }

       

        private void Button1_Click(object sender, EventArgs e)
        {
            //Change to name screen
            Form f = this.FindForm();
            MenuScreen ms = new MenuScreen();
            f.Controls.Add(ms);
            ms.Location = new Point((f.Width - ms.Width) / 2, (f.Height - ms.Height) / 2);
            ms.Focus();
            f.Controls.Remove(this);
        }

        #region button selection

        private void Button1_Enter(object sender, EventArgs e)
        {
            quit.BackgroundImage = Properties.Resources.selectButton;
        }

        private void Button1_Leave(object sender, EventArgs e)
        {
            quit.BackgroundImage = Properties.Resources.button;
        }

        private void No_Enter(object sender, EventArgs e)
        {
            resume.BackgroundImage = Properties.Resources.selectButton;
        }

        private void No_Leave(object sender, EventArgs e)
        {
           resume.BackgroundImage = Properties.Resources.button;
        }

        #endregion

        private void Resume_Click(object sender, EventArgs e)
        {
            exitCheck.Visible = false;
            resume.Visible = false;
            quit.Visible = false;
        }

        void downKey()
        {
            //change character direction 
            players[0].direction = "down";

            //deselect any other blocks that could be selected 
            foreach (Block b in blocks)
            {
                if (b.select == true)
                {
                    b.select = false;
                    break;
                }
            }

            switch (players[0].current)
            {
                //checks for the left edge
                case 42:
                    break;
                case 43:
                    break;
                case 44:
                    break;
                case 45:
                    break;
                case 46:
                    break;
                case 47:
                    break;
                case 48:
                    break;
                default:
                    next = players[0].current + 7;
                    blocks[next].select = true;
                    break;
            }
            Refresh();
        }

        void spaceKey()
        {
            //reveal the block, check safety
            foreach (Block b in blocks)
            {
                if (b.select == true && b.revealed == false)
                {
                    b.revealed = true;
                    next = blocks.IndexOf(b);
                    moveOK = b.Check();
                }
                else if (b.select == true && b.revealed == true)
                {
                    moveOK = null;
                }
            }
            Refresh();
            Thread.Sleep(50);

            switch (moveOK)
            {
                case "safe":
                    score += 100;
                    players[0].current = next;
                    players[0].move(blocks[players[0].current]);
                    break;

                case "lose":
                    if (lives > 1)
                    {
                        monster();
                    }
                    else
                    {
                        gameOver();
                    }

                    break;

                case "win":
                    onWin();
                    break;

                case null:
                    break;
            }
            Refresh();
        }
    }


}
