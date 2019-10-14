using System.Drawing;

namespace BGTimerUI
{
    partial class TimerForm
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
            this.components = new System.ComponentModel.Container();
            this.TimerGameNameLabel = new System.Windows.Forms.Label();
            this.TimerP1Label = new System.Windows.Forms.Label();
            this.TimerP2Label = new System.Windows.Forms.Label();
            this.TimerP3Label = new System.Windows.Forms.Label();
            this.TimerP4Label = new System.Windows.Forms.Label();
            this.TimerP5Label = new System.Windows.Forms.Label();
            this.TimerP6Label = new System.Windows.Forms.Label();
            this.TimerP7Label = new System.Windows.Forms.Label();
            this.TimerP8Label = new System.Windows.Forms.Label();
            this.P1Timer = new System.Windows.Forms.Timer(this.components);
            this.TimerExitButton = new System.Windows.Forms.Button();
            this.TimerP1TextBox = new System.Windows.Forms.TextBox();
            this.TimerNextPlayerButton = new System.Windows.Forms.Button();
            this.P2Timer = new System.Windows.Forms.Timer(this.components);
            this.TimerP2TextBox = new System.Windows.Forms.TextBox();
            this.TimerP3TextBox = new System.Windows.Forms.TextBox();
            this.TimerP4TextBox = new System.Windows.Forms.TextBox();
            this.TimerP5TextBox = new System.Windows.Forms.TextBox();
            this.TimerP6TextBox = new System.Windows.Forms.TextBox();
            this.TimerP7TextBox = new System.Windows.Forms.TextBox();
            this.TimerP8TextBox = new System.Windows.Forms.TextBox();
            this.TimerPauseButton = new System.Windows.Forms.Button();
            this.TimerEndGameButton = new System.Windows.Forms.Button();
            this.TimerResumeButton = new System.Windows.Forms.Button();
            this.P3Timer = new System.Windows.Forms.Timer(this.components);
            this.P4Timer = new System.Windows.Forms.Timer(this.components);
            this.P5Timer = new System.Windows.Forms.Timer(this.components);
            this.P6Timer = new System.Windows.Forms.Timer(this.components);
            this.P7Timer = new System.Windows.Forms.Timer(this.components);
            this.P8Timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // TimerGameNameLabel
            // 
            this.TimerGameNameLabel.AutoSize = true;
            this.TimerGameNameLabel.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerGameNameLabel.Location = new System.Drawing.Point(247, 27);
            this.TimerGameNameLabel.Name = "TimerGameNameLabel";
            this.TimerGameNameLabel.Size = new System.Drawing.Size(0, 34);
            this.TimerGameNameLabel.TabIndex = 30;
            this.TimerGameNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimerP1Label
            // 
            this.TimerP1Label.AutoSize = true;
            this.TimerP1Label.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerP1Label.Location = new System.Drawing.Point(49, 132);
            this.TimerP1Label.MaximumSize = new System.Drawing.Size(160, 35);
            this.TimerP1Label.Name = "TimerP1Label";
            this.TimerP1Label.Size = new System.Drawing.Size(58, 32);
            this.TimerP1Label.TabIndex = 29;
            this.TimerP1Label.Text = "P1: ";
            this.TimerP1Label.Visible = false;
            // 
            // TimerP2Label
            // 
            this.TimerP2Label.AutoSize = true;
            this.TimerP2Label.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerP2Label.Location = new System.Drawing.Point(49, 173);
            this.TimerP2Label.MaximumSize = new System.Drawing.Size(160, 35);
            this.TimerP2Label.Name = "TimerP2Label";
            this.TimerP2Label.Size = new System.Drawing.Size(58, 32);
            this.TimerP2Label.TabIndex = 28;
            this.TimerP2Label.Text = "P2: ";
            this.TimerP2Label.Visible = false;
            // 
            // TimerP3Label
            // 
            this.TimerP3Label.AutoSize = true;
            this.TimerP3Label.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerP3Label.Location = new System.Drawing.Point(49, 211);
            this.TimerP3Label.MaximumSize = new System.Drawing.Size(160, 35);
            this.TimerP3Label.Name = "TimerP3Label";
            this.TimerP3Label.Size = new System.Drawing.Size(58, 32);
            this.TimerP3Label.TabIndex = 27;
            this.TimerP3Label.Text = "P3: ";
            this.TimerP3Label.Visible = false;
            // 
            // TimerP4Label
            // 
            this.TimerP4Label.AutoSize = true;
            this.TimerP4Label.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerP4Label.Location = new System.Drawing.Point(49, 251);
            this.TimerP4Label.MaximumSize = new System.Drawing.Size(160, 35);
            this.TimerP4Label.Name = "TimerP4Label";
            this.TimerP4Label.Size = new System.Drawing.Size(58, 32);
            this.TimerP4Label.TabIndex = 26;
            this.TimerP4Label.Text = "P4: ";
            this.TimerP4Label.Visible = false;
            // 
            // TimerP5Label
            // 
            this.TimerP5Label.AutoSize = true;
            this.TimerP5Label.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerP5Label.Location = new System.Drawing.Point(380, 132);
            this.TimerP5Label.MaximumSize = new System.Drawing.Size(160, 35);
            this.TimerP5Label.Name = "TimerP5Label";
            this.TimerP5Label.Size = new System.Drawing.Size(58, 32);
            this.TimerP5Label.TabIndex = 25;
            this.TimerP5Label.Text = "P5: ";
            this.TimerP5Label.Visible = false;
            // 
            // TimerP6Label
            // 
            this.TimerP6Label.AutoSize = true;
            this.TimerP6Label.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerP6Label.Location = new System.Drawing.Point(380, 173);
            this.TimerP6Label.MaximumSize = new System.Drawing.Size(160, 35);
            this.TimerP6Label.Name = "TimerP6Label";
            this.TimerP6Label.Size = new System.Drawing.Size(58, 32);
            this.TimerP6Label.TabIndex = 20;
            this.TimerP6Label.Text = "P6: ";
            this.TimerP6Label.Visible = false;
            // 
            // TimerP7Label
            // 
            this.TimerP7Label.AutoSize = true;
            this.TimerP7Label.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerP7Label.Location = new System.Drawing.Point(380, 211);
            this.TimerP7Label.MaximumSize = new System.Drawing.Size(160, 35);
            this.TimerP7Label.Name = "TimerP7Label";
            this.TimerP7Label.Size = new System.Drawing.Size(58, 32);
            this.TimerP7Label.TabIndex = 21;
            this.TimerP7Label.Text = "P7: ";
            this.TimerP7Label.Visible = false;
            // 
            // TimerP8Label
            // 
            this.TimerP8Label.AutoSize = true;
            this.TimerP8Label.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerP8Label.Location = new System.Drawing.Point(380, 251);
            this.TimerP8Label.MaximumSize = new System.Drawing.Size(160, 35);
            this.TimerP8Label.Name = "TimerP8Label";
            this.TimerP8Label.Size = new System.Drawing.Size(58, 32);
            this.TimerP8Label.TabIndex = 22;
            this.TimerP8Label.Text = "P8: ";
            this.TimerP8Label.Visible = false;
            // 
            // P1Timer
            // 
            this.P1Timer.Enabled = true;
            this.P1Timer.Interval = 1000;
            this.P1Timer.Tick += new System.EventHandler(this.P1Timer_Tick);
            // 
            // TimerExitButton
            // 
            this.TimerExitButton.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerExitButton.Location = new System.Drawing.Point(671, 12);
            this.TimerExitButton.Name = "TimerExitButton";
            this.TimerExitButton.Size = new System.Drawing.Size(117, 49);
            this.TimerExitButton.TabIndex = 24;
            this.TimerExitButton.Text = "Exit";
            this.TimerExitButton.UseVisualStyleBackColor = true;
            this.TimerExitButton.Click += new System.EventHandler(this.TimerExitButton_Click);
            // 
            // TimerP1TextBox
            // 
            this.TimerP1TextBox.BackColor = System.Drawing.Color.LightGreen;
            this.TimerP1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerP1TextBox.Location = new System.Drawing.Point(212, 132);
            this.TimerP1TextBox.Name = "TimerP1TextBox";
            this.TimerP1TextBox.ReadOnly = true;
            this.TimerP1TextBox.Size = new System.Drawing.Size(162, 35);
            this.TimerP1TextBox.TabIndex = 12;
            this.TimerP1TextBox.Visible = false;
            // 
            // TimerNextPlayerButton
            // 
            this.TimerNextPlayerButton.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerNextPlayerButton.Location = new System.Drawing.Point(59, 351);
            this.TimerNextPlayerButton.Name = "TimerNextPlayerButton";
            this.TimerNextPlayerButton.Size = new System.Drawing.Size(163, 49);
            this.TimerNextPlayerButton.TabIndex = 1;
            this.TimerNextPlayerButton.Text = "Next Player";
            this.TimerNextPlayerButton.UseVisualStyleBackColor = true;
            this.TimerNextPlayerButton.Click += new System.EventHandler(this.TimerNextPlayerButton_Click);
            // 
            // P2Timer
            // 
            this.P2Timer.Interval = 1000;
            this.P2Timer.Tick += new System.EventHandler(this.P2Timer_Tick);
            // 
            // TimerP2TextBox
            // 
            this.TimerP2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerP2TextBox.Location = new System.Drawing.Point(212, 173);
            this.TimerP2TextBox.Name = "TimerP2TextBox";
            this.TimerP2TextBox.ReadOnly = true;
            this.TimerP2TextBox.Size = new System.Drawing.Size(162, 35);
            this.TimerP2TextBox.TabIndex = 11;
            this.TimerP2TextBox.Visible = false;
            // 
            // TimerP3TextBox
            // 
            this.TimerP3TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerP3TextBox.Location = new System.Drawing.Point(212, 211);
            this.TimerP3TextBox.Name = "TimerP3TextBox";
            this.TimerP3TextBox.ReadOnly = true;
            this.TimerP3TextBox.Size = new System.Drawing.Size(162, 35);
            this.TimerP3TextBox.TabIndex = 10;
            this.TimerP3TextBox.Visible = false;
            // 
            // TimerP4TextBox
            // 
            this.TimerP4TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerP4TextBox.Location = new System.Drawing.Point(212, 251);
            this.TimerP4TextBox.Name = "TimerP4TextBox";
            this.TimerP4TextBox.ReadOnly = true;
            this.TimerP4TextBox.Size = new System.Drawing.Size(162, 35);
            this.TimerP4TextBox.TabIndex = 9;
            this.TimerP4TextBox.Visible = false;
            // 
            // TimerP5TextBox
            // 
            this.TimerP5TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerP5TextBox.Location = new System.Drawing.Point(543, 132);
            this.TimerP5TextBox.Name = "TimerP5TextBox";
            this.TimerP5TextBox.ReadOnly = true;
            this.TimerP5TextBox.Size = new System.Drawing.Size(163, 35);
            this.TimerP5TextBox.TabIndex = 8;
            this.TimerP5TextBox.Visible = false;
            // 
            // TimerP6TextBox
            // 
            this.TimerP6TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerP6TextBox.Location = new System.Drawing.Point(543, 173);
            this.TimerP6TextBox.Name = "TimerP6TextBox";
            this.TimerP6TextBox.ReadOnly = true;
            this.TimerP6TextBox.Size = new System.Drawing.Size(163, 35);
            this.TimerP6TextBox.TabIndex = 7;
            this.TimerP6TextBox.Visible = false;
            // 
            // TimerP7TextBox
            // 
            this.TimerP7TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerP7TextBox.Location = new System.Drawing.Point(543, 211);
            this.TimerP7TextBox.Name = "TimerP7TextBox";
            this.TimerP7TextBox.ReadOnly = true;
            this.TimerP7TextBox.Size = new System.Drawing.Size(163, 35);
            this.TimerP7TextBox.TabIndex = 6;
            this.TimerP7TextBox.Visible = false;
            // 
            // TimerP8TextBox
            // 
            this.TimerP8TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerP8TextBox.Location = new System.Drawing.Point(543, 251);
            this.TimerP8TextBox.Name = "TimerP8TextBox";
            this.TimerP8TextBox.ReadOnly = true;
            this.TimerP8TextBox.Size = new System.Drawing.Size(163, 35);
            this.TimerP8TextBox.TabIndex = 5;
            this.TimerP8TextBox.Visible = false;
            // 
            // TimerPauseButton
            // 
            this.TimerPauseButton.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerPauseButton.Location = new System.Drawing.Point(305, 351);
            this.TimerPauseButton.Name = "TimerPauseButton";
            this.TimerPauseButton.Size = new System.Drawing.Size(163, 49);
            this.TimerPauseButton.TabIndex = 2;
            this.TimerPauseButton.Text = "Pause";
            this.TimerPauseButton.UseVisualStyleBackColor = true;
            this.TimerPauseButton.Click += new System.EventHandler(this.TimerPauseButton_Click);
            // 
            // TimerEndGameButton
            // 
            this.TimerEndGameButton.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerEndGameButton.Location = new System.Drawing.Point(543, 351);
            this.TimerEndGameButton.Name = "TimerEndGameButton";
            this.TimerEndGameButton.Size = new System.Drawing.Size(163, 49);
            this.TimerEndGameButton.TabIndex = 41;
            this.TimerEndGameButton.Text = "End Game";
            this.TimerEndGameButton.UseVisualStyleBackColor = true;
            this.TimerEndGameButton.Click += new System.EventHandler(this.TimerEndGameButton_Click);
            // 
            // TimerResumeButton
            // 
            this.TimerResumeButton.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerResumeButton.Location = new System.Drawing.Point(305, 351);
            this.TimerResumeButton.Name = "TimerResumeButton";
            this.TimerResumeButton.Size = new System.Drawing.Size(163, 49);
            this.TimerResumeButton.TabIndex = 3;
            this.TimerResumeButton.Text = "Resume";
            this.TimerResumeButton.UseVisualStyleBackColor = true;
            this.TimerResumeButton.Visible = false;
            this.TimerResumeButton.Click += new System.EventHandler(this.TimerResumeButton_Click);
            // 
            // P3Timer
            // 
            this.P3Timer.Interval = 1000;
            this.P3Timer.Tick += new System.EventHandler(this.P3Timer_Tick);
            // 
            // P4Timer
            // 
            this.P4Timer.Interval = 1000;
            this.P4Timer.Tick += new System.EventHandler(this.P4Timer_Tick);
            // 
            // P5Timer
            // 
            this.P5Timer.Interval = 1000;
            this.P5Timer.Tick += new System.EventHandler(this.P5Timer_Tick);
            // 
            // P6Timer
            // 
            this.P6Timer.Interval = 1000;
            this.P6Timer.Tick += new System.EventHandler(this.P6Timer_Tick);
            // 
            // P7Timer
            // 
            this.P7Timer.Interval = 1000;
            this.P7Timer.Tick += new System.EventHandler(this.P7Timer_Tick);
            // 
            // P8Timer
            // 
            this.P8Timer.Interval = 1000;
            this.P8Timer.Tick += new System.EventHandler(this.P8Timer_Tick);
            // 
            // TimerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 466);
            this.Controls.Add(this.TimerResumeButton);
            this.Controls.Add(this.TimerEndGameButton);
            this.Controls.Add(this.TimerPauseButton);
            this.Controls.Add(this.TimerP8TextBox);
            this.Controls.Add(this.TimerP7TextBox);
            this.Controls.Add(this.TimerP6TextBox);
            this.Controls.Add(this.TimerP5TextBox);
            this.Controls.Add(this.TimerP4TextBox);
            this.Controls.Add(this.TimerP3TextBox);
            this.Controls.Add(this.TimerP2TextBox);
            this.Controls.Add(this.TimerNextPlayerButton);
            this.Controls.Add(this.TimerP1TextBox);
            this.Controls.Add(this.TimerExitButton);
            this.Controls.Add(this.TimerP8Label);
            this.Controls.Add(this.TimerP7Label);
            this.Controls.Add(this.TimerP6Label);
            this.Controls.Add(this.TimerP5Label);
            this.Controls.Add(this.TimerP4Label);
            this.Controls.Add(this.TimerP3Label);
            this.Controls.Add(this.TimerP2Label);
            this.Controls.Add(this.TimerP1Label);
            this.Controls.Add(this.TimerGameNameLabel);
            this.Name = "TimerForm";
            this.Text = "Board Game Timer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TimerGameNameLabel;
        private System.Windows.Forms.Label TimerP1Label;
        private System.Windows.Forms.Label TimerP2Label;
        private System.Windows.Forms.Label TimerP3Label;
        private System.Windows.Forms.Label TimerP4Label;
        private System.Windows.Forms.Label TimerP5Label;
        private System.Windows.Forms.Label TimerP6Label;
        private System.Windows.Forms.Label TimerP7Label;
        private System.Windows.Forms.Label TimerP8Label;
        private System.Windows.Forms.Timer P1Timer;
        private System.Windows.Forms.Button TimerExitButton;
        private System.Windows.Forms.TextBox TimerP1TextBox;
        private System.Windows.Forms.Button TimerNextPlayerButton;
        private System.Windows.Forms.Timer P2Timer;
        private System.Windows.Forms.TextBox TimerP2TextBox;
        private System.Windows.Forms.TextBox TimerP3TextBox;
        private System.Windows.Forms.TextBox TimerP4TextBox;
        private System.Windows.Forms.TextBox TimerP5TextBox;
        private System.Windows.Forms.TextBox TimerP6TextBox;
        private System.Windows.Forms.TextBox TimerP7TextBox;
        private System.Windows.Forms.TextBox TimerP8TextBox;
        private System.Windows.Forms.Button TimerPauseButton;
        private System.Windows.Forms.Button TimerEndGameButton;
        private System.Windows.Forms.Button TimerResumeButton;
        private System.Windows.Forms.Timer P3Timer;
        private System.Windows.Forms.Timer P4Timer;
        private System.Windows.Forms.Timer P5Timer;
        private System.Windows.Forms.Timer P6Timer;
        private System.Windows.Forms.Timer P7Timer;
        private System.Windows.Forms.Timer P8Timer;
    }
}