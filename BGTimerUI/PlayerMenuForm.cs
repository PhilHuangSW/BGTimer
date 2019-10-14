using BGTimer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Entry point for BGTimer
/// </summary>
namespace BGTimerUI
{
    public partial class PlayerMenuForm : Form
    {
        public PlayerMenuForm()
        {
            InitializeComponent();
            addNumberOfPlayersText();
        }

        public StartMenu sm = new StartMenu();

        private void GameNameTextBox_TextChanged(object sender, EventArgs e)
        {
            sm.GameName = GameNameTextBox.Text;
        }

        /// <summary>
        /// Displays the selected number of players' labels and textboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumberOfPlayersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(NumberOfPlayersComboBox.SelectedIndex)
            {
                case 0:
                    hidePlayers();
                    TwoPlayers();
                    break;

                case 1:
                    hidePlayers();
                    ThreePlayers();
                    break;

                case 2:
                    hidePlayers();
                    FourPlayers();
                    break;

                case 3:
                    hidePlayers();
                    FivePlayers();
                    break;

                case 4:
                    hidePlayers();
                    SixPlayers();
                    break;

                case 5:
                    hidePlayers();
                    SevenPlayers();
                    break;

                case 6:
                    hidePlayers();
                    EightPlayers();
                    break;

                default:
                    hidePlayers();
                    break;
            }
        }

        /// <summary>
        /// Adds players 2-8 options in the Number of Players Combo Box
        /// </summary>
        private void addNumberOfPlayersText()
        {
            NumberOfPlayersComboBox.Items.Add(2);
            NumberOfPlayersComboBox.Items.Add(3);
            NumberOfPlayersComboBox.Items.Add(4);
            NumberOfPlayersComboBox.Items.Add(5);
            NumberOfPlayersComboBox.Items.Add(6);
            NumberOfPlayersComboBox.Items.Add(7);
            NumberOfPlayersComboBox.Items.Add(8);
        }

        /// <summary>
        /// Hides all Players' Labels and TextBoxes
        /// </summary>
        private void hidePlayers()
        {
            Player1TextBox.Visible = false;
            PlayerMenuP1Label.Visible = false;
            Player2TextBox.Visible = false;
            PlayerMenuP2Label.Visible = false;
            Player3TextBox.Visible = false;
            PlayerMenuP3Label.Visible = false;
            Player4TextBox.Visible = false;
            PlayerMenuP4Label.Visible = false;
            Player5TextBox.Visible = false;
            PlayerMenuP5Label.Visible = false;
            Player6TextBox.Visible = false;
            PlayerMenuP6Label.Visible = false;
            Player7TextBox.Visible = false;
            PlayerMenuP7Label.Visible = false;
            Player8TextBox.Visible = false;
            PlayerMenuP8Label.Visible = false;
        }

        /// <summary>
        /// Makes Players 1-2 Labels and TextBox Visible
        /// </summary>
        private void TwoPlayers()
        {
            Player1TextBox.Visible = true;
            PlayerMenuP1Label.Visible = true;
            Player2TextBox.Visible = true;
            PlayerMenuP2Label.Visible = true;
        }

        /// <summary>
        /// Makes Players 1-3 Labels and TextBox Visible
        /// </summary>
        private void ThreePlayers()
        {
            Player1TextBox.Visible = true;
            PlayerMenuP1Label.Visible = true;
            Player2TextBox.Visible = true;
            PlayerMenuP2Label.Visible = true;
            Player3TextBox.Visible = true;
            PlayerMenuP3Label.Visible = true;
        }

        /// <summary>
        /// Makes Players 1-4 Labels and TextBox Visible
        /// </summary>
        private void FourPlayers()
        {
            Player1TextBox.Visible = true;
            PlayerMenuP1Label.Visible = true;
            Player2TextBox.Visible = true;
            PlayerMenuP2Label.Visible = true;
            Player3TextBox.Visible = true;
            PlayerMenuP3Label.Visible = true;
            Player4TextBox.Visible = true;
            PlayerMenuP4Label.Visible = true;
        }

        /// <summary>
        /// Makes Players 1-5 Labels and TextBox Visible
        /// </summary>
        private void FivePlayers()
        {
            Player1TextBox.Visible = true;
            PlayerMenuP1Label.Visible = true;
            Player2TextBox.Visible = true;
            PlayerMenuP2Label.Visible = true;
            Player3TextBox.Visible = true;
            PlayerMenuP3Label.Visible = true;
            Player4TextBox.Visible = true;
            PlayerMenuP4Label.Visible = true;
            Player5TextBox.Visible = true;
            PlayerMenuP5Label.Visible = true;
        }

        /// <summary>
        /// Makes Players 1-6 Labels and TextBox Visible
        /// </summary>
        private void SixPlayers()
        {
            Player1TextBox.Visible = true;
            PlayerMenuP1Label.Visible = true;
            Player2TextBox.Visible = true;
            PlayerMenuP2Label.Visible = true;
            Player3TextBox.Visible = true;
            PlayerMenuP3Label.Visible = true;
            Player4TextBox.Visible = true;
            PlayerMenuP4Label.Visible = true;
            Player5TextBox.Visible = true;
            PlayerMenuP5Label.Visible = true;
            Player6TextBox.Visible = true;
            PlayerMenuP6Label.Visible = true;
        }

        /// <summary>
        /// Makes Players 1-7 Labels and TextBox Visible
        /// </summary>
        private void SevenPlayers()
        {
            Player1TextBox.Visible = true;
            PlayerMenuP1Label.Visible = true;
            Player2TextBox.Visible = true;
            PlayerMenuP2Label.Visible = true;
            Player3TextBox.Visible = true;
            PlayerMenuP3Label.Visible = true;
            Player4TextBox.Visible = true;
            PlayerMenuP4Label.Visible = true;
            Player5TextBox.Visible = true;
            PlayerMenuP5Label.Visible = true;
            Player6TextBox.Visible = true;
            PlayerMenuP6Label.Visible = true;
            Player7TextBox.Visible = true;
            PlayerMenuP7Label.Visible = true;
        }

        /// <summary>
        /// Makes Players 1-8 Labels and TextBox Visible
        /// </summary>
        private void EightPlayers()
        {
            Player1TextBox.Visible = true;
            PlayerMenuP1Label.Visible = true;
            Player2TextBox.Visible = true;
            PlayerMenuP2Label.Visible = true;
            Player3TextBox.Visible = true;
            PlayerMenuP3Label.Visible = true;
            Player4TextBox.Visible = true;
            PlayerMenuP4Label.Visible = true;
            Player5TextBox.Visible = true;
            PlayerMenuP5Label.Visible = true;
            Player6TextBox.Visible = true;
            PlayerMenuP6Label.Visible = true;
            Player7TextBox.Visible = true;
            PlayerMenuP7Label.Visible = true;
            Player8TextBox.Visible = true;
            PlayerMenuP8Label.Visible = true;
        }

        /// <summary>
        /// Player 1's Name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Player1TextBox_TextChanged(object sender, EventArgs e)
        {
            sm.Player1 = Player1TextBox.Text;
        }

        /// <summary>
        /// Player 2's Name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Player2TextBox_TextChanged(object sender, EventArgs e)
        {
            sm.Player2 = Player2TextBox.Text;
        }

        /// <summary>
        /// Player 3's Name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Player3TextBox_TextChanged(object sender, EventArgs e)
        {
            sm.Player3 = Player3TextBox.Text;
        }

        /// <summary>
        /// Player 4's Name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Player4TextBox_TextChanged(object sender, EventArgs e)
        {
            sm.Player4 = Player4TextBox.Text;
        }

        /// <summary>
        /// Player 5's Name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Player5TextBox_TextChanged(object sender, EventArgs e)
        {
            sm.Player5 = Player5TextBox.Text;
        }

        /// <summary>
        /// Player 6's Name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Player6TextBox_TextChanged(object sender, EventArgs e)
        {
            sm.Player6 = Player6TextBox.Text;
        }

        /// <summary>
        /// Player 7's Name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Player7TextBox_TextChanged(object sender, EventArgs e)
        {
            sm.Player7 = Player7TextBox.Text;
        }

        /// <summary>
        /// Player 8's Name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Player8TextBox_TextChanged(object sender, EventArgs e)
        {
            sm.Player8 = Player8TextBox.Text;
        }

        /// <summary>
        /// Starts the game with the number of players and their names
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartGameButton_Click(object sender, EventArgs e)
        {
            if(PlayerMenuP1Label.Visible == false)
            {
                MessageBox.Show("Select number of players!", "No players selected");
            }
            // 8 Players
            if(PlayerMenuP8Label.Visible == true)
            {
                sm.NumberOfPlayers = 8;
                this.Hide();
                TimerForm timer = new TimerForm(sm.GameName, sm.NumberOfPlayers, sm.Player1, sm.Player2, sm.Player3, sm.Player4, sm.Player5, sm.Player6, sm.Player7, sm.Player8);
                timer.Show();
            }
            // 7 Players
            if (PlayerMenuP7Label.Visible == true)
            {
                sm.NumberOfPlayers = 7;
                this.Hide();
                TimerForm timer = new TimerForm(sm.GameName, sm.NumberOfPlayers, sm.Player1, sm.Player2, sm.Player3, sm.Player4, sm.Player5, sm.Player6, sm.Player7);
                timer.Show();
            }
            // 6 Players
            if (PlayerMenuP6Label.Visible == true)
            {
                sm.NumberOfPlayers = 6;
                this.Hide();
                TimerForm timer = new TimerForm(sm.GameName, sm.NumberOfPlayers, sm.Player1, sm.Player2, sm.Player3, sm.Player4, sm.Player5, sm.Player6);
                timer.Show();
            }
            // 5 Players
            if (PlayerMenuP5Label.Visible == true)
            {
                sm.NumberOfPlayers = 5;
                this.Hide();
                TimerForm timer = new TimerForm(sm.GameName, sm.NumberOfPlayers, sm.Player1, sm.Player2, sm.Player3, sm.Player4, sm.Player5);
                timer.Show();
            }
            // 4 Players
            if (PlayerMenuP4Label.Visible == true)
            {
                sm.NumberOfPlayers = 4;
                this.Hide();
                TimerForm timer = new TimerForm(sm.GameName, sm.NumberOfPlayers, sm.Player1, sm.Player2, sm.Player3, sm.Player4);
                timer.Show();
            }
            // 3 Players
            if (PlayerMenuP3Label.Visible == true)
            {
                sm.NumberOfPlayers = 3;
                this.Hide();
                TimerForm timer = new TimerForm(sm.GameName, sm.NumberOfPlayers, sm.Player1, sm.Player2, sm.Player3);
                timer.Show();
            }
            // 2 Players
            if (PlayerMenuP2Label.Visible == true)
            {
                sm.NumberOfPlayers = 2;
                this.Hide();
                TimerForm timer = new TimerForm(sm.GameName, sm.NumberOfPlayers, sm.Player1, sm.Player2);
                timer.Show();
            }

        }

        /// <summary>
        /// Closes the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlayerMenuExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
