namespace gameApp
{
    partial class RegisterForm
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
            label3 = new Label();
            userRegisterBox = new TextBox();
            emailRegisterBox = new TextBox();
            passwordRegisterBox = new TextBox();
            tryRegisterButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("MV Boli", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(98, 25);
            label1.Name = "label1";
            label1.Size = new Size(102, 25);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("MV Boli", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(134, 54);
            label2.Name = "label2";
            label2.Size = new Size(65, 25);
            label2.TabIndex = 1;
            label2.Text = "Email:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("MV Boli", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(101, 83);
            label3.Name = "label3";
            label3.Size = new Size(99, 25);
            label3.TabIndex = 2;
            label3.Text = "Password:";
            // 
            // userRegisterBox
            // 
            userRegisterBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userRegisterBox.Location = new Point(205, 25);
            userRegisterBox.Name = "userRegisterBox";
            userRegisterBox.Size = new Size(100, 23);
            userRegisterBox.TabIndex = 3;
            // 
            // emailRegisterBox
            // 
            emailRegisterBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            emailRegisterBox.Location = new Point(205, 54);
            emailRegisterBox.Name = "emailRegisterBox";
            emailRegisterBox.Size = new Size(100, 23);
            emailRegisterBox.TabIndex = 4;
            // 
            // passwordRegisterBox
            // 
            passwordRegisterBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            passwordRegisterBox.Location = new Point(205, 83);
            passwordRegisterBox.Name = "passwordRegisterBox";
            passwordRegisterBox.PasswordChar = '*';
            passwordRegisterBox.Size = new Size(100, 23);
            passwordRegisterBox.TabIndex = 5;
            // 
            // tryRegisterButton
            // 
            tryRegisterButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tryRegisterButton.BackgroundImage = Properties.Resources.button;
            tryRegisterButton.BackgroundImageLayout = ImageLayout.Stretch;
            tryRegisterButton.Cursor = Cursors.Hand;
            tryRegisterButton.FlatStyle = FlatStyle.Flat;
            tryRegisterButton.Font = new Font("MV Boli", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tryRegisterButton.ForeColor = SystemColors.ButtonFace;
            tryRegisterButton.ImageAlign = ContentAlignment.MiddleLeft;
            tryRegisterButton.Location = new Point(155, 144);
            tryRegisterButton.Name = "tryRegisterButton";
            tryRegisterButton.Size = new Size(114, 45);
            tryRegisterButton.TabIndex = 6;
            tryRegisterButton.Text = "Register";
            tryRegisterButton.UseVisualStyleBackColor = true;
            tryRegisterButton.Click += tryRegisterButton_Click;
            // 
            // registerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.register;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(421, 201);
            Controls.Add(tryRegisterButton);
            Controls.Add(passwordRegisterBox);
            Controls.Add(emailRegisterBox);
            Controls.Add(userRegisterBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "registerForm";
            Text = "registerForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox userRegisterBox;
        private TextBox emailRegisterBox;
        private TextBox passwordRegisterBox;
        private Button tryRegisterButton;
    }
}