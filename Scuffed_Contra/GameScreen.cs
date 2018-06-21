using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;
using System.Xml;
using System.Threading;
using System.Media; 
namespace Scuffed_Contra
{
    public partial class GameScreen : UserControl
    {
        // VALUES HERE 
        //Player controls
        Boolean downArrowDown, rightArrowDown, upArrowDown, spaceDown, escDown;

      //  #region Calling Classes 
        //Classes call 
        character joe;
        character ai;
        character bullets;
        character chasm; 

      //  #region Lists
        //Lists
        public static List<character> aiList = new List<character>();
        public static List<character> bulletList = new List<character>();
        public static List<character> aiBList = new List<character>();
        public static List<character> chasmList = new List<character>(); 

        //   #region random powerup generator
        // randgen for powerups 
        public static Random randGen = new Random();

    //    #region stopwatch 
        //Time to complete Stopwatch
        Stopwatch timeWatch = new Stopwatch();
        long eTime;
        long tTime;
        long sTime = 300000;

        //Player position, mostly for bullets values and other ints 
        int playerX = 522;
        int playerY = 295;
        int bulletcounter;
        int attackcounter;
        int jumpcounter;
        int downcounter;
        int presscontrol = 75;
        int removecontrol;
        int hitcontrol; 
        int score;
        int airemovecontrol; 

        //WE DID NOT USE THIS - did not have enough time to utilize 
        public static Image[] powerImages = new[]
        {
        Properties.Resources.ExtraLifeBlue,
        };

        // #region Brushes and Grpahics Values 
        //Brushs and graphics values 
        SolidBrush textBrush = new SolidBrush(Color.White);
        SolidBrush aiBrush = new SolidBrush(Color.Pink);
        SolidBrush playerBrush = new SolidBrush(Color.Black);
        SolidBrush bBrush = new SolidBrush(Color.Red);
        Font drawFont = new Font("Arial", 12);

        //#region Sounds
        //sets up sounds to be used in game
        SoundPlayer playerdeathsound = new SoundPlayer(Properties.Resources.playerDead);
        SoundPlayer playershootsound = new SoundPlayer(Properties.Resources.playerShoot);
        SoundPlayer enemyshootsound = new SoundPlayer(Properties.Resources.enemyDead);
        SoundPlayer enemydeadsound= new SoundPlayer(Properties.Resources.enemyShoot);
        SoundPlayer playerjumpsound = new SoundPlayer(Properties.Resources.playerJump);

        public GameScreen()
        {
            InitializeComponent();

            StartFunction(0);
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            SolidBrush playerBrush = new SolidBrush(Color.Black);    
            timeWatch.Start();
        }


        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //player button presses
            switch (e.KeyCode)
            {
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Space:
                    spaceDown = true;
                    break;
                case Keys.Escape:
                    escDown = true;
                    break; ;
                default:
                    break;
            }
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            //player button releases
            switch (e.KeyCode)
            {
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Space:
                    spaceDown = false;
                    break;
                case Keys.Escape:
                    escDown = false;
                    break;
                default:
                    break;
            }
        }
        
        //game loop tick 
        public void GameLoop_Tick(object sender, EventArgs e)
        {
            //check timer 
            eTime = timeWatch.ElapsedMilliseconds;

            // MOVE - Looks like Joe is moving 
            if (rightArrowDown)
            {
                foreach (character ai in aiList)
                {
                    ai.Move("left", 2);
                }
                foreach(character chasm in chasmList)
                {
                    chasm.Move("left", 2);
                }
                
            }

            if (spaceDown)
            {
                // create a laser that moves towards the ai since always right  
                 if (bulletcounter > 10)
                {
                     bullets = new character(bBrush, playerX, playerY + 15, 15, 5, 0);
                     bulletList.Add(bullets);
                     bulletcounter = 0;
                     playershootsound.Play();
                }
            }

            // decide if the ai should shoot back 
            if (attackcounter > 50 && aiList[0].x <= 750)
            {
                bullets = new character(bBrush, aiList[0].x , aiList[0].y + 15 , 15, 5, 0);
                aiBList.Add(bullets);
                attackcounter = 0;
            }

            // shoot and remove bullets made by the player
            if (bulletList.Count > 0)
            {
                // Move the bullets until they are off screen
                foreach (character bullets in bulletList)
                {
                    bullets.Shoot("right", 9);

                    if (bullets.x > this.Width)
                    {
                        bulletList.Remove(bullets);
                        break;
                    }

                }
            }

            // shoot and remove the bullets made by the ai
            if (aiBList.Count > 0)
            {
                enemyshootsound.Play();
                // Move the bullets until they are off screen
                foreach (character bullets in aiBList)
                {
                    bullets.Shoot("left", 5);

                    if (bullets.x < 0)
                    {
                        aiBList.Remove(bullets);
                        break;
                    }

                }
            }

            // Make the ai boys moves slower towards the player every tick
            foreach(character ai in aiList)
            {
                ai.Move("left", 1);
            }

            // COLLISION - between objects in game 
            Rectangle playerRec = new Rectangle(joe.x, joe.y, joe.width, joe.length);

            // ai checks collisions with player
            foreach (character ai in aiList)
            {
                Rectangle aiRec = new Rectangle(ai.x, ai.y, ai.width, ai.length);    
                // player collison
                if (playerRec.IntersectsWith(aiRec))
                {
                    if (hitcontrol > 50)
                    {
                        score = score - 100;
                        joe.health--;
                        hitcontrol = 0; 
                    }
                    break;
                }
        
            }

            // bullet collison creates rectangles for the bullets and checks against ai
            foreach (character bullets in bulletList)
            {
                Rectangle bRec = new Rectangle(bullets.x, bullets.y, 4, 20);

                foreach (character ai in aiList)
                {
                    Rectangle aiRec = new Rectangle(ai.x, ai.y, 30, 40);
                    if (aiRec.IntersectsWith(bRec))
                    {
                        enemydeadsound.Play();
                        ai.health--;
                        score = score + 25;
                        removecontrol++;
                        break;
                    }
                }

            }

            // ai bullet collison with player
            foreach (character bullets in aiBList)
            {
                Rectangle bRec = new Rectangle(bullets.x, bullets.y, 4, 20);
                    if (playerRec.IntersectsWith(bRec))
                    {
                     //   playerdeadsound.Play();
                        joe.health--;
                        score = score - 50;
                        airemovecontrol++;
                        break;
                    }

            }

            // see if joe dies
            if (joe.health <= 0)
            {
                GameOver go = new GameOver();
                GameLoop.Enabled = false;
                Form f = this.FindForm();
                f.Controls.Remove(this); 
                go.Location = new Point((f.Width - go.Width) / 2, (f.Height - go.Height) / 2);
                //add game over screen
                f.Controls.Add(go);
            }

            //checking to see if ai needs to get hit
            foreach(character ai in aiList)
            {
                if(ai.health <= 0)
                {
                    aiList.Remove(ai);
                    break;
                }
            }

            //pause screen escdown
            if (escDown)
            {
                GameLoop.Stop();
                rightArrowDown = false;
                spaceDown = false;
                escDown = false;
                DialogResult result = PauseForm.Show();
                if (result == DialogResult.Cancel)
                {
                    GameLoop.Enabled = true;
                }

                else if (result == DialogResult.Abort)
                {
                    Application.Exit();
                }

            }
         
            // jumping code
            if (upArrowDown)
            {
                if (presscontrol > 55)
                {
                    playerjumpsound.Play();
                    jumpcounter = 1;
                    presscontrol = 0;
                }
               
            }

            // if jumpcounter should be used, use it
            if (jumpcounter > 0)
            {
                joe.Jump(3, 0);
                jumpcounter++;
                    if (jumpcounter >= 20)
                {
                    jumpcounter = 0;
                    downcounter = 1;
                    joe.Jump(0, 0);
                }
            }

            // if downcounter should be use, use it
            if(downcounter > 0 )
            {
                joe.Jump(0, 3);
                downcounter++;
                if (downcounter >= 20)
                {
                    jumpcounter = 0;
                    downcounter = 0;
                    joe.Jump(0,0);
                }
            }

            // do see if the bullet should be removed
            if(removecontrol > 0)
            {
                bulletList.Remove(bullets);
                removecontrol = 0; 
            }
            if(airemovecontrol > 0)
            {
                aiBList.Remove(bullets);
                airemovecontrol = 0;
            }

            // find the current time for the timer 
            tTime = (sTime - eTime) / 1000;

            //add every tick for shot  and press timing
            bulletcounter++;
            attackcounter++;
            presscontrol++;
            hitcontrol++; 

            // get random number 

            //Redraw the screen
            Refresh();
        }

        private void StartFunction(int x)
        {
          if (x == 0)
            {
                //main boy
                joe = new character(playerBrush, playerX, playerY, 30, 50, 3);

                ai = new character(aiBrush, 850, 295, 30, 50, 2);
                aiList.Add(ai);

                ai = new character(aiBrush, 1100, 295, 30, 50, 2);
                aiList.Add(ai);

                ai = new character(aiBrush, 1200, 295, 30, 50, 2);
                aiList.Add(ai);

                ai = new character(aiBrush, 1300, 295, 30, 50, 2);
                aiList.Add(ai);

                ai = new character(aiBrush, 1400, 295, 30, 50, 2);
                aiList.Add(ai);

                ai = new character(aiBrush, 1800, 295, 30, 50, 2);
                aiList.Add(ai);

                ai = new character(aiBrush, 2000, 295, 30, 50, 2);
                aiList.Add(ai);

                chasm = new character(aiBrush, 1000, 295, 1000, 1000, 0);
                chasmList.Add(chasm);

                chasm = new character(aiBrush, 100, 295, 100, 100, 0);
                chasmList.Add(chasm);
            }

        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            foreach (character ai in aiList)
            {
                e.Graphics.DrawImage(Properties.Resources.SoldierL, ai.x, ai.y, ai.width, ai.length);
            }
            foreach (character bullets in bulletList)
            {
                e.Graphics.FillRectangle(bullets.sb, bullets.x, bullets.y, bullets.width, bullets.length);
            }
            foreach (character bullets in aiBList)
            {
                e.Graphics.FillRectangle(bullets.sb, bullets.x, bullets.y, bullets.width, bullets.length);
            }
            e.Graphics.DrawString("REMAINING TIME: " + tTime + "s", drawFont, textBrush, 820, 50);
            e.Graphics.DrawString("SCORE: " + score , drawFont, textBrush, 500, 50);
            e.Graphics.DrawString("LIVES: " + joe.health, drawFont, textBrush, 600, 50);
            e.Graphics.DrawImage(Properties.Resources.LanceWalking, joe.x, joe.y, joe.width, joe.length);
        }
    }
}