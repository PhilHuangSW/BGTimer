using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BGTimer;

namespace BGTimerUI
{
    public partial class TimerForm : Form
    {
        int numPlayers, timerHelper = 1, P1seconds, P1minutes, P1hours, P2seconds, P2minutes, P2hours, P3seconds, P3minutes, P3hours,
        P4seconds, P4minutes, P4hours, P5seconds, P5minutes, P5hours, P6seconds, P6minutes, P6hours, P7seconds, P7minutes, P7hours, P8seconds, P8minutes, P8hours;

        private void TimerForm_FormClosing(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Constructor for 2 Players
        /// </summary>
        /// <param name="gameName"></param>
        /// <param name="NumOfPlayers"></param>
        /// <param name="P1"></param>
        /// <param name="P2"></param>
        public TimerForm(string gameName, int NumOfPlayers, string P1, string P2)
        {
            InitializeComponent();
            TimerP1Label.Show();
            TimerP2Label.Show();
            TimerP1TextBox.Show();
            TimerP2TextBox.Show();
            if(P1 == null)
            {
                TimerP1Label.Text = "Player 1";
            }
            else
            {
                TimerP1Label.Text = P1;
            }
            if(P2 == null)
            {
                TimerP2Label.Text = "Player 2";
            }
            else
            {
                TimerP2Label.Text = P2;
            }
            if(gameName == null)
            {
                TimerGameNameLabel.Text = "Board Game";
            }
            else
            {
                TimerGameNameLabel.Text = gameName;
            }
            numPlayers = NumOfPlayers;
        }
        /// <summary>
        /// Constructor for 3 Players
        /// </summary>
        /// <param name="gameName"></param>
        /// <param name="NumOfPlayers"></param>
        /// <param name="P1"></param>
        /// <param name="P2"></param>
        /// <param name="P3"></param>
        public TimerForm(string gameName, int NumOfPlayers, string P1, string P2, string P3)
        {
            InitializeComponent();
            TimerP1Label.Show();
            TimerP2Label.Show();
            TimerP3Label.Show();
            TimerP1TextBox.Show();
            TimerP2TextBox.Show();
            TimerP3TextBox.Show();
            if (P1 == null)
            {
                TimerP1Label.Text = "Player 1";
            }
            else
            {
                TimerP1Label.Text = P1;
            }
            if (P2 == null)
            {
                TimerP2Label.Text = "Player 2";
            }
            else
            {
                TimerP2Label.Text = P2;
            }
            if (P3 == null)
            {
                TimerP3Label.Text = "Player 3";
            }
            else
            {
                TimerP3Label.Text = P3;
            }
            if (gameName == null)
            {
                TimerGameNameLabel.Text = "Board Game";
            }
            else
            {
                TimerGameNameLabel.Text = gameName;
            }
            numPlayers = NumOfPlayers;
        }
        /// <summary>
        /// Constructor for 4 Players
        /// </summary>
        /// <param name="gameName"></param>
        /// <param name="NumOfPlayers"></param>
        /// <param name="P1"></param>
        /// <param name="P2"></param>
        /// <param name="P3"></param>
        /// <param name="P4"></param>
        public TimerForm(string gameName, int NumOfPlayers, string P1, string P2, string P3, string P4)
        {
            InitializeComponent();
            TimerP1Label.Show();
            TimerP2Label.Show();
            TimerP3Label.Show();
            TimerP4Label.Show();
            TimerP1TextBox.Show();
            TimerP2TextBox.Show();
            TimerP3TextBox.Show();
            TimerP4TextBox.Show();
            if (P1 == null)
            {
                TimerP1Label.Text = "Player 1";
            }
            else
            {
                TimerP1Label.Text = P1;
            }
            if (P2 == null)
            {
                TimerP2Label.Text = "Player 2";
            }
            else
            {
                TimerP2Label.Text = P2;
            }
            if (P3 == null)
            {
                TimerP3Label.Text = "Player 3";
            }
            else
            {
                TimerP3Label.Text = P3;
            }
            if (P4 == null)
            {
                TimerP4Label.Text = "Player 4";
            }
            else
            {
                TimerP4Label.Text = P4;
            }
            if (gameName == null)
            {
                TimerGameNameLabel.Text = "Board Game";
            }
            else
            {
                TimerGameNameLabel.Text = gameName;
            }
            numPlayers = NumOfPlayers;
        }
        /// <summary>
        /// Constructor for 5 Players
        /// </summary>
        /// <param name="gameName"></param>
        /// <param name="NumOfPlayers"></param>
        /// <param name="P1"></param>
        /// <param name="P2"></param>
        /// <param name="P3"></param>
        /// <param name="P4"></param>
        /// <param name="P5"></param>
        public TimerForm(string gameName, int NumOfPlayers, string P1, string P2, string P3, string P4, string P5)
        {
            InitializeComponent();
            TimerP1Label.Show();
            TimerP2Label.Show();
            TimerP3Label.Show();
            TimerP4Label.Show();
            TimerP5Label.Show();
            TimerP1TextBox.Show();
            TimerP2TextBox.Show();
            TimerP3TextBox.Show();
            TimerP4TextBox.Show();
            TimerP5TextBox.Show();
            if (P1 == null)
            {
                TimerP1Label.Text = "Player 1";
            }
            else
            {
                TimerP1Label.Text = P1;
            }
            if (P2 == null)
            {
                TimerP2Label.Text = "Player 2";
            }
            else
            {
                TimerP2Label.Text = P2;
            }
            if (P3 == null)
            {
                TimerP3Label.Text = "Player 3";
            }
            else
            {
                TimerP3Label.Text = P3;
            }
            if (P4 == null)
            {
                TimerP4Label.Text = "Player 4";
            }
            else
            {
                TimerP4Label.Text = P4;
            }
            if (P5 == null)
            {
                TimerP5Label.Text = "Player 5";
            }
            else
            {
                TimerP5Label.Text = P5;
            }
            if (gameName == null)
            {
                TimerGameNameLabel.Text = "Board Game";
            }
            else
            {
                TimerGameNameLabel.Text = gameName;
            }
            numPlayers = NumOfPlayers;
        }
        /// <summary>
        /// Constructor for 6 Players
        /// </summary>
        /// <param name="gameName"></param>
        /// <param name="NumOfPlayers"></param>
        /// <param name="P1"></param>
        /// <param name="P2"></param>
        /// <param name="P3"></param>
        /// <param name="P4"></param>
        /// <param name="P5"></param>
        /// <param name="P6"></param>
        public TimerForm(string gameName, int NumOfPlayers, string P1, string P2, string P3, string P4, string P5, string P6)
        {
            InitializeComponent();
            TimerP1Label.Show();
            TimerP2Label.Show();
            TimerP3Label.Show();
            TimerP4Label.Show();
            TimerP5Label.Show();
            TimerP6Label.Show();
            TimerP1TextBox.Show();
            TimerP2TextBox.Show();
            TimerP3TextBox.Show();
            TimerP4TextBox.Show();
            TimerP5TextBox.Show();
            TimerP6TextBox.Show();
            if (P1 == null)
            {
                TimerP1Label.Text = "Player 1";
            }
            else
            {
                TimerP1Label.Text = P1;
            }
            if (P2 == null)
            {
                TimerP2Label.Text = "Player 2";
            }
            else
            {
                TimerP2Label.Text = P2;
            }
            if (P3 == null)
            {
                TimerP3Label.Text = "Player 3";
            }
            else
            {
                TimerP3Label.Text = P3;
            }
            if (P4 == null)
            {
                TimerP4Label.Text = "Player 4";
            }
            else
            {
                TimerP4Label.Text = P4;
            }
            if (P5 == null)
            {
                TimerP5Label.Text = "Player 5";
            }
            else
            {
                TimerP5Label.Text = P5;
            }
            if (P6 == null)
            {
                TimerP6Label.Text = "Player 6";
            }
            else
            {
                TimerP6Label.Text = P6;
            }
            if (gameName == null)
            {
                TimerGameNameLabel.Text = "Board Game";
            }
            else
            {
                TimerGameNameLabel.Text = gameName;
            }
            numPlayers = NumOfPlayers;
        }
        /// <summary>
        /// Constructor for 7 Players
        /// </summary>
        /// <param name="gameName"></param>
        /// <param name="NumOfPlayers"></param>
        /// <param name="P1"></param>
        /// <param name="P2"></param>
        /// <param name="P3"></param>
        /// <param name="P4"></param>
        /// <param name="P5"></param>
        /// <param name="P6"></param>
        /// <param name="P7"></param>
        public TimerForm(string gameName, int NumOfPlayers, string P1, string P2, string P3, string P4, string P5, string P6, string P7)
        {
            InitializeComponent();
            TimerP1Label.Show();
            TimerP2Label.Show();
            TimerP3Label.Show();
            TimerP4Label.Show();
            TimerP5Label.Show();
            TimerP6Label.Show();
            TimerP7Label.Show();
            TimerP1TextBox.Show();
            TimerP2TextBox.Show();
            TimerP3TextBox.Show();
            TimerP4TextBox.Show();
            TimerP5TextBox.Show();
            TimerP6TextBox.Show();
            TimerP7TextBox.Show();
            if (P1 == null)
            {
                TimerP1Label.Text = "Player 1";
            }
            else
            {
                TimerP1Label.Text = P1;
            }
            if (P2 == null)
            {
                TimerP2Label.Text = "Player 2";
            }
            else
            {
                TimerP2Label.Text = P2;
            }
            if (P3 == null)
            {
                TimerP3Label.Text = "Player 3";
            }
            else
            {
                TimerP3Label.Text = P3;
            }
            if (P4 == null)
            {
                TimerP4Label.Text = "Player 4";
            }
            else
            {
                TimerP4Label.Text = P4;
            }
            if (P5 == null)
            {
                TimerP5Label.Text = "Player 5";
            }
            else
            {
                TimerP5Label.Text = P5;
            }
            if (P6 == null)
            {
                TimerP6Label.Text = "Player 6";
            }
            else
            {
                TimerP6Label.Text = P6;
            }
            if (P7 == null)
            {
                TimerP7Label.Text = "Player 7";
            }
            else
            {
                TimerP7Label.Text = P7;
            }
            if (gameName == null)
            {
                TimerGameNameLabel.Text = "Board Game";
            }
            else
            {
                TimerGameNameLabel.Text = gameName;
            }
            numPlayers = NumOfPlayers;
        }
        /// <summary>
        /// Constructor for 8 Players
        /// </summary>
        /// <param name="gameName"></param>
        /// <param name="NumOfPlayers"></param>
        /// <param name="P1"></param>
        /// <param name="P2"></param>
        /// <param name="P3"></param>
        /// <param name="P4"></param>
        /// <param name="P5"></param>
        /// <param name="P6"></param>
        /// <param name="P7"></param>
        /// <param name="P8"></param>
        public TimerForm(string gameName, int NumOfPlayers, string P1, string P2, string P3, string P4, string P5, string P6, string P7, string P8)
        {
            InitializeComponent();
            TimerP1Label.Show();
            TimerP2Label.Show();
            TimerP3Label.Show();
            TimerP4Label.Show();
            TimerP5Label.Show();
            TimerP6Label.Show();
            TimerP7Label.Show();
            TimerP8Label.Show();
            TimerP1TextBox.Show();
            TimerP2TextBox.Show();
            TimerP3TextBox.Show();
            TimerP4TextBox.Show();
            TimerP5TextBox.Show();
            TimerP6TextBox.Show();
            TimerP7TextBox.Show();
            TimerP8TextBox.Show();
            if (P1 == null)
            {
                TimerP1Label.Text = "Player 1";
            }
            else
            {
                TimerP1Label.Text = P1;
            }
            if (P2 == null)
            {
                TimerP2Label.Text = "Player 2";
            }
            else
            {
                TimerP2Label.Text = P2;
            }
            if (P3 == null)
            {
                TimerP3Label.Text = "Player 3";
            }
            else
            {
                TimerP3Label.Text = P3;
            }
            if (P4 == null)
            {
                TimerP4Label.Text = "Player 4";
            }
            else
            {
                TimerP4Label.Text = P4;
            }
            if (P5 == null)
            {
                TimerP5Label.Text = "Player 5";
            }
            else
            {
                TimerP5Label.Text = P5;
            }
            if (P6 == null)
            {
                TimerP6Label.Text = "Player 6";
            }
            else
            {
                TimerP6Label.Text = P6;
            }
            if (P7 == null)
            {
                TimerP7Label.Text = "Player 7";
            }
            else
            {
                TimerP7Label.Text = P7;
            }
            if (P8 == null)
            {
                TimerP8Label.Text = "Player 8";
            }
            else
            {
                TimerP8Label.Text = P8;
            }
            if (gameName == null)
            {
                TimerGameNameLabel.Text = "Board Game";
            }
            else
            {
                TimerGameNameLabel.Text = gameName;
            }
            numPlayers = NumOfPlayers;
    }
        /// <summary>
        /// Displays player 1's time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void P1Timer_Tick(object sender, EventArgs e)
        {
            P1seconds++;
            if (P1seconds == 60)
            {
                P1seconds = 0;
                P1minutes++;
                if (P1minutes == 60)
                {
                    P1minutes = 0;
                    P1hours++;
                }
            }
            if (P1hours == 0)
            {
                TimerP1TextBox.Text = P1minutes.ToString() + "m : " + P1seconds.ToString() + "s";
            }
            else
            {
                TimerP1TextBox.Text = P1hours.ToString() + "h : " + P1minutes.ToString() + "m : " + P1seconds.ToString() + "s";

            }
        }
        /// <summary>
            /// Displays player 2's time
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
        private void P2Timer_Tick(object sender, EventArgs e)
        {
            P2seconds++;
            if (P2seconds == 60)
            {
                P2seconds = 0;
                P2minutes++;
                if (P2minutes == 60)
                {
                    P2minutes = 0;
                    P2hours++;
                }
            }
            if(P2hours == 0)
            {
                TimerP2TextBox.Text = P2minutes.ToString() + "m : " + P2seconds.ToString() + "s";
            }
            else
            {
                TimerP2TextBox.Text = P2hours.ToString() + "h : " + P2minutes.ToString() + "m : " + P2seconds.ToString() + "s";
            }            
        }
        /// <summary>
        /// Displays player 3's time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void P3Timer_Tick(object sender, EventArgs e)
        {
            P3seconds++;
            if (P3seconds == 60)
            {
                P3seconds = 0;
                P3minutes++;
                if (P3minutes == 60)
                {
                    P3minutes = 0;
                    P3hours++;
                }
            }
            if (P3hours == 0)
            {
                TimerP3TextBox.Text = P3minutes.ToString() + "m : " + P3seconds.ToString() + "s";
            }
            else
            {
                TimerP3TextBox.Text = P3hours.ToString() + "h : " + P3minutes.ToString() + "m : " + P3seconds.ToString() + "s";

            }
        }
        /// <summary>
        /// Displays player 4's time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void P4Timer_Tick(object sender, EventArgs e)
        {
            P4seconds++;
            if (P4seconds == 60)
            {
                P4seconds = 0;
                P4minutes++;
                if (P4minutes == 60)
                {
                    P4minutes = 0;
                    P4hours++;
                }
            }
            if(P4hours == 0)
            {
                TimerP4TextBox.Text = P4minutes.ToString() + "m : " + P4seconds.ToString() + "s";
            }
            else
            {
                TimerP4TextBox.Text = P4hours.ToString() + "h : " + P4minutes.ToString() + "m : " + P4seconds.ToString() + "s";
            }                
        }
        /// <summary>
        /// Displays player 5's time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void P5Timer_Tick(object sender, EventArgs e)
        {
            P5seconds++;
            if (P5seconds == 60)
            {
                P5seconds = 0;
                P5minutes++;
                if (P5minutes == 60)
                {
                    P5minutes = 0;
                    P5hours++;
                }
            }
            if (P5hours == 0)
            {
                TimerP5TextBox.Text = P5minutes.ToString() + "m : " + P5seconds.ToString() + "s";
            }
            else
            {
                TimerP5TextBox.Text = P5hours.ToString() + "h : " + P5minutes.ToString() + "m : " + P5seconds.ToString() + "s";
            }
        }
        /// <summary>
        /// Displays player 6's time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void P6Timer_Tick(object sender, EventArgs e)
        {
            P6seconds++;
            if (P6seconds == 60)
            {
                P6seconds = 0;
                P6minutes++;
                if (P6minutes == 60)
                {
                    P6minutes = 0;
                    P6hours++;
                }
            }
            if (P6hours == 0)
            {
                TimerP6TextBox.Text = P6minutes.ToString() + "m : " + P6seconds.ToString() + "s";
            }
            else
            {
                TimerP6TextBox.Text = P6hours.ToString() + "h : " + P6minutes.ToString() + "m : " + P6seconds.ToString() + "s";
            }
        }
        /// <summary>
        /// Displays player 7's time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void P7Timer_Tick(object sender, EventArgs e)
        {
            P7seconds++;
            if (P7seconds == 60)
            {
                P7seconds = 0;
                P7minutes++;
                if (P7minutes == 60)
                {
                    P7minutes = 0;
                    P7hours++;
                }
            }
            if (P7hours == 0)
            {
                TimerP7TextBox.Text = P7minutes.ToString() + "m : " + P7seconds.ToString() + "s";
            }
            else
            {
                TimerP7TextBox.Text = P7hours.ToString() + "h : " + P7minutes.ToString() + "m : " + P7seconds.ToString() + "s";
            }
        }
        /// <summary>
        /// Displays player 8's time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void P8Timer_Tick(object sender, EventArgs e)
        {
            P8seconds++;
            if (P8seconds == 60)
            {
                P8seconds = 0;
                P8minutes++;
                if (P8minutes == 60)
                {
                    P8minutes = 0;
                    P8hours++;
                }
            }
            if (P8hours == 0)
            {
                TimerP8TextBox.Text = P8minutes.ToString() + "m : " + P8seconds.ToString() + "s";
            }
            else
            {
                TimerP8TextBox.Text = P8hours.ToString() + "h : " + P8minutes.ToString() + "m : " + P8seconds.ToString() + "s";
            }
        }
        /// <summary>
        /// Pauses the current player's time and starts the next player's timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerNextPlayerButton_Click(object sender, EventArgs e)
        {
            TimerResumeButton.Visible = false;
            TimerPauseButton.Visible = true;
            switch(timerHelper)
            {
                case 1:
                    P1Timer.Stop();
                    TimerP1TextBox.BackColor = Color.White;
                    P2Timer.Start();
                    TimerP2TextBox.BackColor = Color.LightGreen;
                    timerHelper++;
                    break;

                case 2:
                    P2Timer.Stop();
                    TimerP2TextBox.BackColor = Color.White;
                    if (numPlayers > 2)
                    {
                        P3Timer.Start();
                        TimerP3TextBox.BackColor = Color.LightGreen;
                        timerHelper++;
                    }
                    else
                    {
                        P1Timer.Start();
                        TimerP1TextBox.BackColor = Color.LightGreen;
                        timerHelper = 1;
                    }
                    break;
                case 3:
                    P3Timer.Stop();
                    TimerP3TextBox.BackColor = Color.White;
                    if (numPlayers > 3)
                    {
                        P4Timer.Start();
                        TimerP4TextBox.BackColor = Color.LightGreen;
                        timerHelper++;
                    }
                    else
                    {
                        P1Timer.Start();
                        TimerP1TextBox.BackColor = Color.LightGreen;
                        timerHelper = 1;
                    }
                    break;
                case 4:
                    P4Timer.Stop();
                    TimerP4TextBox.BackColor = Color.White;
                    if (numPlayers > 4)
                    {
                        P5Timer.Start();
                        TimerP5TextBox.BackColor = Color.LightGreen;
                        timerHelper++;
                    }
                    else
                    {
                        P1Timer.Start();
                        TimerP1TextBox.BackColor = Color.LightGreen;
                        timerHelper = 1;
                    }
                    break;
                case 5:
                    P5Timer.Stop();
                    TimerP5TextBox.BackColor = Color.White;
                    if (numPlayers > 5)
                    {
                        P6Timer.Start();
                        TimerP6TextBox.BackColor = Color.LightGreen;
                        timerHelper++;
                    }
                    else
                    {
                        P1Timer.Start();
                        TimerP1TextBox.BackColor = Color.LightGreen;
                        timerHelper = 1;
                    }
                    break;
                case 6:
                    P6Timer.Stop();
                    TimerP6TextBox.BackColor = Color.White;
                    if (numPlayers > 6)
                    {
                        P7Timer.Start();
                        TimerP7TextBox.BackColor = Color.LightGreen;
                        timerHelper++;
                    }
                    else
                    {
                        P1Timer.Start();
                        TimerP1TextBox.BackColor = Color.LightGreen;
                        timerHelper = 1;
                    }
                    break;
                case 7:
                    P7Timer.Stop();
                    TimerP7TextBox.BackColor = Color.White;
                    if (numPlayers > 7)
                    {
                        P8Timer.Start();
                        TimerP8TextBox.BackColor = Color.LightGreen;
                        timerHelper++;
                    }
                    else
                    {
                        P1Timer.Start();
                        TimerP1TextBox.BackColor = Color.LightGreen;
                        timerHelper = 1;
                    }
                    break;
                case 8:
                    P8Timer.Stop();
                    TimerP8TextBox.BackColor = Color.White;
                    P1Timer.Start();
                    TimerP1TextBox.BackColor = Color.LightGreen;
                    timerHelper = 1;
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        /// Goes to end game screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerEndGameButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Resumes the timer for the current player
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerResumeButton_Click(object sender, EventArgs e)
        {
            switch (timerHelper)
            {
                case 1:
                    P1Timer.Start();
                    TimerP1TextBox.BackColor = Color.LightGreen;
                    TimerPauseButton.Visible = true;
                    TimerResumeButton.Visible = false;                    
                    break;
                case 2:
                    P2Timer.Start();
                    TimerP2TextBox.BackColor = Color.LightGreen;
                    TimerPauseButton.Visible = true;
                    TimerResumeButton.Visible = false;
                    break;
                case 3:
                    P3Timer.Start();
                    TimerP3TextBox.BackColor = Color.LightGreen;
                    TimerPauseButton.Visible = true;
                    TimerResumeButton.Visible = false;
                    break;
                case 4:
                    P4Timer.Start();
                    TimerP4TextBox.BackColor = Color.LightGreen;
                    TimerPauseButton.Visible = true;
                    TimerResumeButton.Visible = false;
                    break;
                case 5:
                    P5Timer.Start();
                    TimerP5TextBox.BackColor = Color.LightGreen;
                    TimerPauseButton.Visible = true;
                    TimerResumeButton.Visible = false;
                    break;
                case 6:
                    P6Timer.Start();
                    TimerP6TextBox.BackColor = Color.LightGreen;
                    TimerPauseButton.Visible = true;
                    TimerResumeButton.Visible = false;
                    break;
                case 7:
                    P7Timer.Start();
                    TimerP7TextBox.BackColor = Color.LightGreen;
                    TimerPauseButton.Visible = true;
                    TimerResumeButton.Visible = false;
                    break;
                case 8:
                    P8Timer.Start();
                    TimerP8TextBox.BackColor = Color.LightGreen;
                    TimerPauseButton.Visible = true;
                    TimerResumeButton.Visible = false;
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        /// Pauses the timer for the current player
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerPauseButton_Click(object sender, EventArgs e)
        {
            switch (timerHelper)
            {
                case 1:
                    P1Timer.Stop();
                    TimerP1TextBox.BackColor = Color.PaleVioletRed;
                    TimerResumeButton.Visible = true;
                    TimerPauseButton.Visible = false;
                    break;
                case 2:
                    P2Timer.Stop();
                    TimerP2TextBox.BackColor = Color.PaleVioletRed;
                    TimerResumeButton.Visible = true;
                    TimerPauseButton.Visible = false;                    
                    break;
                case 3:
                    P3Timer.Stop();
                    TimerP3TextBox.BackColor = Color.PaleVioletRed;
                    TimerResumeButton.Visible = true;
                    TimerPauseButton.Visible = false;                    
                    break;
                case 4:
                    P4Timer.Stop();
                    TimerP4TextBox.BackColor = Color.PaleVioletRed;
                    TimerResumeButton.Visible = true;
                    TimerPauseButton.Visible = false;
                    break;
                case 5:
                    P5Timer.Stop();
                    TimerP5TextBox.BackColor = Color.PaleVioletRed;
                    TimerResumeButton.Visible = true;
                    TimerPauseButton.Visible = false;                    
                    break;
                case 6:
                    P6Timer.Stop();
                    TimerP6TextBox.BackColor = Color.PaleVioletRed;
                    TimerResumeButton.Visible = true;
                    TimerPauseButton.Visible = false;
                    break;
                case 7:
                    P7Timer.Stop();
                    TimerP7TextBox.BackColor = Color.PaleVioletRed;
                    TimerResumeButton.Visible = true;
                    TimerPauseButton.Visible = false;
                    break;
                case 8:
                    P8Timer.Stop();
                    TimerP8TextBox.BackColor = Color.PaleVioletRed;
                    TimerResumeButton.Visible = true;
                    TimerPauseButton.Visible = false;
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        /// Closes the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
