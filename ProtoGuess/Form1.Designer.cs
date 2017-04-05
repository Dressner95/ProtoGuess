namespace ProtoGuess
{
    partial class Form1
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
            this.serialPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.comPort = new System.Windows.Forms.TextBox();
            this.guessButton = new System.Windows.Forms.Button();
            this.esp01GuessText = new System.Windows.Forms.TextBox();
            this.esp02GuessText = new System.Windows.Forms.TextBox();
            this.esp03GuessText = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.esp04GuessText = new System.Windows.Forms.Label();
            this.serialPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPanel
            // 
            this.serialPanel.Controls.Add(this.label2);
            this.serialPanel.Controls.Add(this.label1);
            this.serialPanel.Controls.Add(this.connectButton);
            this.serialPanel.Controls.Add(this.comPort);
            this.serialPanel.Location = new System.Drawing.Point(12, 12);
            this.serialPanel.Name = "serialPanel";
            this.serialPanel.Size = new System.Drawing.Size(287, 100);
            this.serialPanel.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Com Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Serial";
            // 
            // connectButton
            // 
            this.connectButton.BackColor = System.Drawing.Color.Yellow;
            this.connectButton.Location = new System.Drawing.Point(121, 13);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(155, 74);
            this.connectButton.TabIndex = 1;
            this.connectButton.Text = "Connect to ESP";
            this.connectButton.UseVisualStyleBackColor = false;
            this.connectButton.Click += new System.EventHandler(this.connect);
            // 
            // comPort
            // 
            this.comPort.Location = new System.Drawing.Point(13, 65);
            this.comPort.Name = "comPort";
            this.comPort.Size = new System.Drawing.Size(100, 22);
            this.comPort.TabIndex = 0;
            // 
            // guessButton
            // 
            this.guessButton.Location = new System.Drawing.Point(13, 118);
            this.guessButton.Name = "guessButton";
            this.guessButton.Size = new System.Drawing.Size(286, 71);
            this.guessButton.TabIndex = 1;
            this.guessButton.Text = "Where am I?";
            this.guessButton.UseVisualStyleBackColor = true;
            this.guessButton.Click += new System.EventHandler(this.guessButton_Click);
            // 
            // esp01GuessText
            // 
            this.esp01GuessText.Location = new System.Drawing.Point(334, 12);
            this.esp01GuessText.Name = "esp01GuessText";
            this.esp01GuessText.Size = new System.Drawing.Size(130, 22);
            this.esp01GuessText.TabIndex = 2;
            // 
            // esp02GuessText
            // 
            this.esp02GuessText.Location = new System.Drawing.Point(334, 66);
            this.esp02GuessText.Name = "esp02GuessText";
            this.esp02GuessText.Size = new System.Drawing.Size(130, 22);
            this.esp02GuessText.TabIndex = 3;
            // 
            // esp03GuessText
            // 
            this.esp03GuessText.Location = new System.Drawing.Point(334, 118);
            this.esp03GuessText.Name = "esp03GuessText";
            this.esp03GuessText.Size = new System.Drawing.Size(130, 22);
            this.esp03GuessText.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(334, 167);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(130, 22);
            this.textBox4.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(476, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "espGuess01";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(476, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "espGuess02";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(476, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "espGuess03";
            // 
            // esp04GuessText
            // 
            this.esp04GuessText.AutoSize = true;
            this.esp04GuessText.Location = new System.Drawing.Point(476, 175);
            this.esp04GuessText.Name = "esp04GuessText";
            this.esp04GuessText.Size = new System.Drawing.Size(88, 17);
            this.esp04GuessText.TabIndex = 9;
            this.esp04GuessText.Text = "espGuess03";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 201);
            this.Controls.Add(this.esp04GuessText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.esp03GuessText);
            this.Controls.Add(this.esp02GuessText);
            this.Controls.Add(this.esp01GuessText);
            this.Controls.Add(this.guessButton);
            this.Controls.Add(this.serialPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.serialPanel.ResumeLayout(false);
            this.serialPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel serialPanel;
        private System.Windows.Forms.TextBox comPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button guessButton;
        private System.Windows.Forms.TextBox esp01GuessText;
        private System.Windows.Forms.TextBox esp02GuessText;
        private System.Windows.Forms.TextBox esp03GuessText;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label esp04GuessText;
    }
}

