namespace gameApp
{
    partial class LoginForm
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
            label1 = new Label();
            label2 = new Label();
            usernameLoginBox = new TextBox();
            passwordLoginBox = new TextBox();
            tryLoginButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("MV Boli", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(80, 18);
            label1.Name = "label1";
            label1.Size = new Size(113, 28);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("MV Boli", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(85, 56);
            label2.Name = "label2";
            label2.Size = new Size(108, 28);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // usernameLoginBox
            // 
            usernameLoginBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            usernameLoginBox.Location = new Point(199, 23);
            usernameLoginBox.Name = "usernameLoginBox";
            usernameLoginBox.Size = new Size(106, 23);
            usernameLoginBox.TabIndex = 2;
            // 
            // passwordLoginBox
            // 
            passwordLoginBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            passwordLoginBox.Location = new Point(199, 61);
            passwordLoginBox.Name = "passwordLoginBox";
            passwordLoginBox.PasswordChar = '*';
            passwordLoginBox.Size = new Size(106, 23);
            passwordLoginBox.TabIndex = 3;
            // 
            // tryLoginButton
            // 
            tryLoginButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tryLoginButton.BackgroundImage = Properties.Resources.button;
            tryLoginButton.BackgroundImageLayout = ImageLayout.Stretch;
            tryLoginButton.Cursor = Cursors.Hand;
            tryLoginButton.FlatStyle = FlatStyle.Flat;
            tryLoginButton.Font = new Font("MV Boli", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tryLoginButton.ForeColor = SystemColors.ButtonFace;
            tryLoginButton.Location = new Point(161, 113);
            tryLoginButton.Name = "tryLoginButton";
            tryLoginButton.Size = new Size(98, 46);
            tryLoginButton.TabIndex = 4;
            tryLoginButton.Text = "Login";
            tryLoginButton.UseVisualStyleBackColor = true;
            tryLoginButton.Click += tryLoginButton_Click;
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.login;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(416, 197);
            Controls.Add(tryLoginButton);
            Controls.Add(passwordLoginBox);
            Controls.Add(usernameLoginBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "loginForm";
            Text = "loginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox usernameLoginBox;
        private TextBox passwordLoginBox;
        private Button tryLoginButton;
    }
}