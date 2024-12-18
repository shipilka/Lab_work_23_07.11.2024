namespace Lab_work_23_07._11._2024
{
    partial class MainForm
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
            TaskButton1 = new Button();
            TaskButton2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // TaskButton1
            // 
            TaskButton1.Location = new Point(68, 46);
            TaskButton1.Name = "TaskButton1";
            TaskButton1.Size = new Size(94, 29);
            TaskButton1.TabIndex = 0;
            TaskButton1.Text = "Задание 2";
            TaskButton1.UseVisualStyleBackColor = true;
            TaskButton1.Click += TaskButton1_Click;
            // 
            // TaskButton2
            // 
            TaskButton2.Location = new Point(68, 113);
            TaskButton2.Name = "TaskButton2";
            TaskButton2.Size = new Size(94, 29);
            TaskButton2.TabIndex = 1;
            TaskButton2.Text = "Задание 3";
            TaskButton2.UseVisualStyleBackColor = true;
            TaskButton2.Click += TaskButton2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(68, 188);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 2;
            button3.Text = "Задание 4";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(232, 303);
            Controls.Add(button3);
            Controls.Add(TaskButton2);
            Controls.Add(TaskButton1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Главная форма";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button TaskButton1;
        private Button TaskButton2;
        private Button button3;
    }
}
