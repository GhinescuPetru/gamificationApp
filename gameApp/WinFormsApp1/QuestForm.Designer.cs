namespace gameApp
{
    partial class QuestForm
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
            createQuestButton = new Button();
            textBox1 = new TextBox();
            descriptionTextBox = new TextBox();
            difficultyComboBox = new ComboBox();
            rewardNumericUpDown = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)rewardNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // createQuestButton
            // 
            createQuestButton.BackgroundImage = Properties.Resources.button;
            createQuestButton.BackgroundImageLayout = ImageLayout.Stretch;
            createQuestButton.FlatStyle = FlatStyle.Flat;
            createQuestButton.Font = new Font("MV Boli", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            createQuestButton.ForeColor = SystemColors.ButtonFace;
            createQuestButton.Location = new Point(166, 188);
            createQuestButton.Name = "createQuestButton";
            createQuestButton.Size = new Size(138, 50);
            createQuestButton.TabIndex = 0;
            createQuestButton.Text = "Create";
            createQuestButton.UseVisualStyleBackColor = true;
            createQuestButton.Click += createQuestButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(-464, -44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(157, 28);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(100, 23);
            descriptionTextBox.TabIndex = 2;
            // 
            // difficultyComboBox
            // 
            difficultyComboBox.FormattingEnabled = true;
            difficultyComboBox.Location = new Point(157, 70);
            difficultyComboBox.Name = "difficultyComboBox";
            difficultyComboBox.Size = new Size(121, 23);
            difficultyComboBox.TabIndex = 3;
            // 
            // rewardNumericUpDown
            // 
            rewardNumericUpDown.Location = new Point(158, 121);
            rewardNumericUpDown.Name = "rewardNumericUpDown";
            rewardNumericUpDown.Size = new Size(120, 23);
            rewardNumericUpDown.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("MV Boli", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(128, 28);
            label1.TabIndex = 5;
            label1.Text = "Description:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("MV Boli", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Gold;
            label2.Location = new Point(31, 70);
            label2.Name = "label2";
            label2.Size = new Size(109, 28);
            label2.TabIndex = 6;
            label2.Text = "Difficulty:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("MV Boli", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Gold;
            label3.Location = new Point(50, 116);
            label3.Name = "label3";
            label3.Size = new Size(90, 28);
            label3.TabIndex = 7;
            label3.Text = "Reward:";
            // 
            // QuestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(479, 250);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rewardNumericUpDown);
            Controls.Add(difficultyComboBox);
            Controls.Add(descriptionTextBox);
            Controls.Add(textBox1);
            Controls.Add(createQuestButton);
            Name = "QuestForm";
            Text = "QuestForm";
            Load += QuestForm_Load;
            ((System.ComponentModel.ISupportInitialize)rewardNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button createQuestButton;
        private TextBox textBox1;
        private TextBox descriptionTextBox;
        private ComboBox difficultyComboBox;
        private NumericUpDown rewardNumericUpDown;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}