namespace gameApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gameNameLabel = new Label();
            loginButton = new Button();
            registerButton = new Button();
            SuspendLayout();
            // 
            // gameNameLabel
            // 
            gameNameLabel.AutoSize = true;
            gameNameLabel.BackColor = Color.Transparent;
            gameNameLabel.Font = new Font("MV Boli", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            gameNameLabel.ForeColor = Color.DarkSlateGray;
            gameNameLabel.Location = new Point(46, 9);
            gameNameLabel.Name = "gameNameLabel";
            gameNameLabel.Size = new Size(627, 39);
            gameNameLabel.TabIndex = 0;
            gameNameLabel.Text = "The Great Expedition: The Eastern Realm\r\n";
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.Transparent;
            loginButton.BackgroundImage = gameApp.Properties.Resources.button;
            loginButton.BackgroundImageLayout = ImageLayout.Stretch;
            loginButton.Cursor = Cursors.Hand;
            loginButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            loginButton.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("MV Boli", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            loginButton.ForeColor = SystemColors.ButtonFace;
            loginButton.Location = new Point(46, 68);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(147, 56);
            loginButton.TabIndex = 1;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // registerButton
            // 
            registerButton.BackColor = Color.Transparent;
            registerButton.BackgroundImage = gameApp.Properties.Resources.button;
            registerButton.BackgroundImageLayout = ImageLayout.Stretch;
            registerButton.Cursor = Cursors.Hand;
            registerButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            registerButton.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue;
            registerButton.FlatStyle = FlatStyle.Flat;
            registerButton.Font = new Font("MV Boli", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            registerButton.ForeColor = SystemColors.ButtonFace;
            registerButton.Location = new Point(46, 130);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(147, 52);
            registerButton.TabIndex = 2;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += registerButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            BackgroundImage = gameApp.Properties.Resources.background1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1190, 496);
            Controls.Add(registerButton);
            Controls.Add(loginButton);
            Controls.Add(gameNameLabel);
            Name = "Form1";
            Text = "The Great Expedition";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label gameNameLabel;
        private Button loginButton;
        private Button registerButton;
    }
}