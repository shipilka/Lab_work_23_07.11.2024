namespace Lab_work_23_07._11._2024
{
    partial class Task3
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
            Login = new TextBox();
            label3 = new Label();
            Password = new TextBox();
            AuthButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(170, 12);
            label1.Name = "label1";
            label1.Size = new Size(87, 17);
            label1.TabIndex = 2;
            label1.Text = "Пока пусто";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 68);
            label2.Name = "label2";
            label2.Size = new Size(52, 17);
            label2.TabIndex = 3;
            label2.Text = "Логин";
            // 
            // Login
            // 
            Login.Location = new Point(71, 88);
            Login.Name = "Login";
            Login.Size = new Size(186, 25);
            Login.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 115);
            label3.Name = "label3";
            label3.Size = new Size(59, 17);
            label3.TabIndex = 5;
            label3.Text = "Пароль";
            // 
            // Password
            // 
            Password.Location = new Point(71, 135);
            Password.Name = "Password";
            Password.PasswordChar = '*';
            Password.Size = new Size(186, 25);
            Password.TabIndex = 6;
            // 
            // AuthButton
            // 
            AuthButton.Location = new Point(75, 166);
            AuthButton.Name = "AuthButton";
            AuthButton.Size = new Size(182, 29);
            AuthButton.TabIndex = 7;
            AuthButton.Text = "Авторизироваться";
            AuthButton.UseVisualStyleBackColor = true;
            AuthButton.Click += AuthButton_Click;
            // 
            // Task3
            // 
            AutoScaleDimensions = new SizeF(9F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 203);
            Controls.Add(AuthButton);
            Controls.Add(Password);
            Controls.Add(label3);
            Controls.Add(Login);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximumSize = new Size(300, 250);
            MinimumSize = new Size(0, 0);
            Name = "Task3";
            Text = "Задание 3";
            Load += Task3_Load;
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(Login, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(Password, 0);
            Controls.SetChildIndex(AuthButton, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox Login;
        private Label label3;
        private TextBox Password;
        private Button AuthButton;
    }
}