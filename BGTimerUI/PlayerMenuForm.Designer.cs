namespace BGTimerUI
{
    partial class PlayerMenuForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BGTimerLabel = new System.Windows.Forms.Label();
            this.GameNameLabel = new System.Windows.Forms.Label();
            this.NumberOfPlayersLabel = new System.Windows.Forms.Label();
            this.GameNameTextBox = new System.Windows.Forms.TextBox();
            this.NumberOfPlayersComboBox = new System.Windows.Forms.ComboBox();
            this.Player1TextBox = new System.Windows.Forms.TextBox();
            this.Player2TextBox = new System.Windows.Forms.TextBox();
            this.Player3TextBox = new System.Windows.Forms.TextBox();
            this.Player4TextBox = new System.Windows.Forms.TextBox();
            this.Player5TextBox = new System.Windows.Forms.TextBox();
            this.Player6TextBox = new System.Windows.Forms.TextBox();
            this.Player7TextBox = new System.Windows.Forms.TextBox();
            this.Player8TextBox = new System.Windows.Forms.TextBox();
            this.PlayerMenuP1Label = new System.Windows.Forms.Label();
            this.PlayerMenuP2Label = new System.Windows.Forms.Label();
            this.PlayerMenuP3Label = new System.Windows.Forms.Label();
            this.PlayerMenuP4Label = new System.Windows.Forms.Label();
            this.PlayerMenuP5Label = new System.Windows.Forms.Label();
            this.PlayerMenuP6Label = new System.Windows.Forms.Label();
            this.PlayerMenuP7Label = new System.Windows.Forms.Label();
            this.PlayerMenuP8Label = new System.Windows.Forms.Label();
            this.StartGameButton = new System.Windows.Forms.Button();
            this.PlayerMenuExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BGTimerLabel
            // 
            this.BGTimerLabel.AutoSize = true;
            this.BGTimerLabel.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BGTimerLabel.Location = new System.Drawing.Point(274, 9);
            this.BGTimerLabel.Name = "BGTimerLabel";
            this.BGTimerLabel.Size = new System.Drawing.Size(232, 32);
            this.BGTimerLabel.TabIndex = 0;
            this.BGTimerLabel.Text = "Board Game Timer";
            // 
            // GameNameLabel
            // 
            this.GameNameLabel.AutoSize = true;
            this.GameNameLabel.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameNameLabel.Location = new System.Drawing.Point(20, 66);
            this.GameNameLabel.Name = "GameNameLabel";
            this.GameNameLabel.Size = new System.Drawing.Size(129, 25);
            this.GameNameLabel.TabIndex = 1;
            this.GameNameLabel.Text = "Game Name: ";
            // 
            // NumberOfPlayersLabel
            // 
            this.NumberOfPlayersLabel.AutoSize = true;
            this.NumberOfPlayersLabel.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfPlayersLabel.Location = new System.Drawing.Point(20, 109);
            this.NumberOfPlayersLabel.Name = "NumberOfPlayersLabel";
            this.NumberOfPlayersLabel.Size = new System.Drawing.Size(191, 25);
            this.NumberOfPlayersLabel.TabIndex = 2;
            this.NumberOfPlayersLabel.Text = "Number of Players: ";
            // 
            // GameNameTextBox
            // 
            this.GameNameTextBox.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameNameTextBox.Location = new System.Drawing.Point(155, 63);
            this.GameNameTextBox.Name = "GameNameTextBox";
            this.GameNameTextBox.Size = new System.Drawing.Size(217, 32);
            this.GameNameTextBox.TabIndex = 3;
            this.GameNameTextBox.TextChanged += new System.EventHandler(this.GameNameTextBox_TextChanged);
            // 
            // NumberOfPlayersComboBox
            // 
            this.NumberOfPlayersComboBox.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfPlayersComboBox.FormattingEnabled = true;
            this.NumberOfPlayersComboBox.Location = new System.Drawing.Point(217, 106);
            this.NumberOfPlayersComboBox.Name = "NumberOfPlayersComboBox";
            this.NumberOfPlayersComboBox.Size = new System.Drawing.Size(84, 33);
            this.NumberOfPlayersComboBox.TabIndex = 4;
            this.NumberOfPlayersComboBox.SelectedIndexChanged += new System.EventHandler(this.NumberOfPlayersComboBox_SelectedIndexChanged);
            // 
            // Player1TextBox
            // 
            this.Player1TextBox.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1TextBox.Location = new System.Drawing.Point(67, 168);
            this.Player1TextBox.Name = "Player1TextBox";
            this.Player1TextBox.Size = new System.Drawing.Size(217, 32);
            this.Player1TextBox.TabIndex = 5;
            this.Player1TextBox.Visible = false;
            this.Player1TextBox.TextChanged += new System.EventHandler(this.Player1TextBox_TextChanged);
            // 
            // Player2TextBox
            // 
            this.Player2TextBox.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2TextBox.Location = new System.Drawing.Point(67, 206);
            this.Player2TextBox.Name = "Player2TextBox";
            this.Player2TextBox.Size = new System.Drawing.Size(217, 32);
            this.Player2TextBox.TabIndex = 6;
            this.Player2TextBox.Visible = false;
            this.Player2TextBox.TextChanged += new System.EventHandler(this.Player2TextBox_TextChanged);
            // 
            // Player3TextBox
            // 
            this.Player3TextBox.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player3TextBox.Location = new System.Drawing.Point(67, 244);
            this.Player3TextBox.Name = "Player3TextBox";
            this.Player3TextBox.Size = new System.Drawing.Size(217, 32);
            this.Player3TextBox.TabIndex = 7;
            this.Player3TextBox.Visible = false;
            this.Player3TextBox.TextChanged += new System.EventHandler(this.Player3TextBox_TextChanged);
            // 
            // Player4TextBox
            // 
            this.Player4TextBox.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player4TextBox.Location = new System.Drawing.Point(67, 282);
            this.Player4TextBox.Name = "Player4TextBox";
            this.Player4TextBox.Size = new System.Drawing.Size(217, 32);
            this.Player4TextBox.TabIndex = 8;
            this.Player4TextBox.Visible = false;
            this.Player4TextBox.TextChanged += new System.EventHandler(this.Player4TextBox_TextChanged);
            // 
            // Player5TextBox
            // 
            this.Player5TextBox.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player5TextBox.Location = new System.Drawing.Point(425, 168);
            this.Player5TextBox.Name = "Player5TextBox";
            this.Player5TextBox.Size = new System.Drawing.Size(217, 32);
            this.Player5TextBox.TabIndex = 9;
            this.Player5TextBox.Visible = false;
            this.Player5TextBox.TextChanged += new System.EventHandler(this.Player5TextBox_TextChanged);
            // 
            // Player6TextBox
            // 
            this.Player6TextBox.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player6TextBox.Location = new System.Drawing.Point(425, 206);
            this.Player6TextBox.Name = "Player6TextBox";
            this.Player6TextBox.Size = new System.Drawing.Size(217, 32);
            this.Player6TextBox.TabIndex = 10;
            this.Player6TextBox.Visible = false;
            this.Player6TextBox.TextChanged += new System.EventHandler(this.Player6TextBox_TextChanged);
            // 
            // Player7TextBox
            // 
            this.Player7TextBox.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player7TextBox.Location = new System.Drawing.Point(425, 244);
            this.Player7TextBox.Name = "Player7TextBox";
            this.Player7TextBox.Size = new System.Drawing.Size(217, 32);
            this.Player7TextBox.TabIndex = 12;
            this.Player7TextBox.Visible = false;
            this.Player7TextBox.TextChanged += new System.EventHandler(this.Player7TextBox_TextChanged);
            // 
            // Player8TextBox
            // 
            this.Player8TextBox.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player8TextBox.Location = new System.Drawing.Point(425, 282);
            this.Player8TextBox.Name = "Player8TextBox";
            this.Player8TextBox.Size = new System.Drawing.Size(217, 32);
            this.Player8TextBox.TabIndex = 13;
            this.Player8TextBox.Visible = false;
            this.Player8TextBox.TextChanged += new System.EventHandler(this.Player8TextBox_TextChanged);
            // 
            // PlayerMenuP1Label
            // 
            this.PlayerMenuP1Label.AutoSize = true;
            this.PlayerMenuP1Label.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerMenuP1Label.Location = new System.Drawing.Point(20, 171);
            this.PlayerMenuP1Label.Name = "PlayerMenuP1Label";
            this.PlayerMenuP1Label.Size = new System.Drawing.Size(47, 25);
            this.PlayerMenuP1Label.TabIndex = 14;
            this.PlayerMenuP1Label.Text = "P1: ";
            this.PlayerMenuP1Label.Visible = false;
            // 
            // PlayerMenuP2Label
            // 
            this.PlayerMenuP2Label.AutoSize = true;
            this.PlayerMenuP2Label.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerMenuP2Label.Location = new System.Drawing.Point(20, 209);
            this.PlayerMenuP2Label.Name = "PlayerMenuP2Label";
            this.PlayerMenuP2Label.Size = new System.Drawing.Size(47, 25);
            this.PlayerMenuP2Label.TabIndex = 15;
            this.PlayerMenuP2Label.Text = "P2: ";
            this.PlayerMenuP2Label.Visible = false;
            // 
            // PlayerMenuP3Label
            // 
            this.PlayerMenuP3Label.AutoSize = true;
            this.PlayerMenuP3Label.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerMenuP3Label.Location = new System.Drawing.Point(20, 247);
            this.PlayerMenuP3Label.Name = "PlayerMenuP3Label";
            this.PlayerMenuP3Label.Size = new System.Drawing.Size(47, 25);
            this.PlayerMenuP3Label.TabIndex = 16;
            this.PlayerMenuP3Label.Text = "P3: ";
            this.PlayerMenuP3Label.Visible = false;
            // 
            // PlayerMenuP4Label
            // 
            this.PlayerMenuP4Label.AutoSize = true;
            this.PlayerMenuP4Label.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerMenuP4Label.Location = new System.Drawing.Point(20, 285);
            this.PlayerMenuP4Label.Name = "PlayerMenuP4Label";
            this.PlayerMenuP4Label.Size = new System.Drawing.Size(47, 25);
            this.PlayerMenuP4Label.TabIndex = 17;
            this.PlayerMenuP4Label.Text = "P4: ";
            this.PlayerMenuP4Label.Visible = false;
            // 
            // PlayerMenuP5Label
            // 
            this.PlayerMenuP5Label.AutoSize = true;
            this.PlayerMenuP5Label.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerMenuP5Label.Location = new System.Drawing.Point(372, 171);
            this.PlayerMenuP5Label.Name = "PlayerMenuP5Label";
            this.PlayerMenuP5Label.Size = new System.Drawing.Size(47, 25);
            this.PlayerMenuP5Label.TabIndex = 18;
            this.PlayerMenuP5Label.Text = "P5: ";
            this.PlayerMenuP5Label.Visible = false;
            // 
            // PlayerMenuP6Label
            // 
            this.PlayerMenuP6Label.AutoSize = true;
            this.PlayerMenuP6Label.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerMenuP6Label.Location = new System.Drawing.Point(372, 209);
            this.PlayerMenuP6Label.Name = "PlayerMenuP6Label";
            this.PlayerMenuP6Label.Size = new System.Drawing.Size(47, 25);
            this.PlayerMenuP6Label.TabIndex = 19;
            this.PlayerMenuP6Label.Text = "P6: ";
            this.PlayerMenuP6Label.Visible = false;
            // 
            // PlayerMenuP7Label
            // 
            this.PlayerMenuP7Label.AutoSize = true;
            this.PlayerMenuP7Label.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerMenuP7Label.Location = new System.Drawing.Point(372, 247);
            this.PlayerMenuP7Label.Name = "PlayerMenuP7Label";
            this.PlayerMenuP7Label.Size = new System.Drawing.Size(47, 25);
            this.PlayerMenuP7Label.TabIndex = 20;
            this.PlayerMenuP7Label.Text = "P7: ";
            this.PlayerMenuP7Label.Visible = false;
            // 
            // PlayerMenuP8Label
            // 
            this.PlayerMenuP8Label.AutoSize = true;
            this.PlayerMenuP8Label.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerMenuP8Label.Location = new System.Drawing.Point(372, 285);
            this.PlayerMenuP8Label.Name = "PlayerMenuP8Label";
            this.PlayerMenuP8Label.Size = new System.Drawing.Size(47, 25);
            this.PlayerMenuP8Label.TabIndex = 21;
            this.PlayerMenuP8Label.Text = "P8: ";
            this.PlayerMenuP8Label.Visible = false;
            // 
            // StartGameButton
            // 
            this.StartGameButton.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartGameButton.Location = new System.Drawing.Point(335, 353);
            this.StartGameButton.Name = "StartGameButton";
            this.StartGameButton.Size = new System.Drawing.Size(117, 49);
            this.StartGameButton.TabIndex = 22;
            this.StartGameButton.Text = "Start";
            this.StartGameButton.UseVisualStyleBackColor = true;
            this.StartGameButton.Click += new System.EventHandler(this.StartGameButton_Click);
            // 
            // PlayerMenuExitButton
            // 
            this.PlayerMenuExitButton.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerMenuExitButton.Location = new System.Drawing.Point(671, 12);
            this.PlayerMenuExitButton.Name = "PlayerMenuExitButton";
            this.PlayerMenuExitButton.Size = new System.Drawing.Size(117, 49);
            this.PlayerMenuExitButton.TabIndex = 23;
            this.PlayerMenuExitButton.Text = "Exit";
            this.PlayerMenuExitButton.UseVisualStyleBackColor = true;
            this.PlayerMenuExitButton.Click += new System.EventHandler(this.PlayerMenuExitButton_Click);
            // 
            // PlayerMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 428);
            this.Controls.Add(this.PlayerMenuExitButton);
            this.Controls.Add(this.NumberOfPlayersComboBox);
            this.Controls.Add(this.PlayerMenuP8Label);
            this.Controls.Add(this.PlayerMenuP7Label);
            this.Controls.Add(this.PlayerMenuP6Label);
            this.Controls.Add(this.PlayerMenuP5Label);
            this.Controls.Add(this.PlayerMenuP4Label);
            this.Controls.Add(this.PlayerMenuP3Label);
            this.Controls.Add(this.PlayerMenuP2Label);
            this.Controls.Add(this.PlayerMenuP1Label);
            this.Controls.Add(this.Player8TextBox);
            this.Controls.Add(this.Player7TextBox);
            this.Controls.Add(this.Player6TextBox);
            this.Controls.Add(this.Player4TextBox);
            this.Controls.Add(this.Player2TextBox);
            this.Controls.Add(this.Player5TextBox);
            this.Controls.Add(this.Player3TextBox);
            this.Controls.Add(this.Player1TextBox);
            this.Controls.Add(this.StartGameButton);
            this.Controls.Add(this.GameNameTextBox);
            this.Controls.Add(this.NumberOfPlayersLabel);
            this.Controls.Add(this.GameNameLabel);
            this.Controls.Add(this.BGTimerLabel);
            this.Name = "PlayerMenuForm";
            this.Text = "Board Game Timer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BGTimerLabel;
        private System.Windows.Forms.Label GameNameLabel;
        private System.Windows.Forms.Label NumberOfPlayersLabel;
        private System.Windows.Forms.TextBox GameNameTextBox;
        private System.Windows.Forms.ComboBox NumberOfPlayersComboBox;        
        private System.Windows.Forms.TextBox Player1TextBox;
        private System.Windows.Forms.TextBox Player2TextBox;
        private System.Windows.Forms.TextBox Player3TextBox;
        private System.Windows.Forms.TextBox Player4TextBox;
        private System.Windows.Forms.TextBox Player5TextBox;   
        private System.Windows.Forms.TextBox Player6TextBox;
        private System.Windows.Forms.TextBox Player7TextBox;
        private System.Windows.Forms.TextBox Player8TextBox;
        private System.Windows.Forms.Label PlayerMenuP1Label;
        private System.Windows.Forms.Label PlayerMenuP2Label;
        private System.Windows.Forms.Label PlayerMenuP3Label;
        private System.Windows.Forms.Label PlayerMenuP4Label;
        private System.Windows.Forms.Label PlayerMenuP5Label;
        private System.Windows.Forms.Label PlayerMenuP6Label;
        private System.Windows.Forms.Label PlayerMenuP7Label;
        private System.Windows.Forms.Label PlayerMenuP8Label;
        private System.Windows.Forms.Button StartGameButton;
        private System.Windows.Forms.Button PlayerMenuExitButton;
    }
}

