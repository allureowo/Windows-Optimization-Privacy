namespace WOP
{
    partial class Form2
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
            panel1 = new Panel();
            button5 = new Button();
            button4 = new Button();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button7 = new Button();
            button8 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(59, 66, 82);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(752, 30);
            panel1.TabIndex = 4;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // button5
            // 
            button5.BackColor = Color.Transparent;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.FromArgb(216, 222, 233);
            button5.Location = new Point(696, 0);
            button5.Name = "button5";
            button5.Size = new Size(29, 30);
            button5.TabIndex = 7;
            button5.Text = "_";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.FromArgb(216, 222, 233);
            button4.Location = new Point(722, 0);
            button4.Name = "button4";
            button4.Size = new Size(29, 30);
            button4.TabIndex = 5;
            button4.Text = "X";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(216, 222, 233);
            label1.Location = new Point(12, -2);
            label1.Name = "label1";
            label1.Size = new Size(235, 32);
            label1.TabIndex = 6;
            label1.Text = "WOP | Optimizations";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(216, 222, 233);
            button1.Location = new Point(12, 51);
            button1.Name = "button1";
            button1.Size = new Size(135, 23);
            button1.TabIndex = 5;
            button1.Text = "Privacy Clean";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            button1.MouseClick += button1_MouseClick;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(216, 222, 233);
            button2.Location = new Point(153, 51);
            button2.Name = "button2";
            button2.Size = new Size(135, 23);
            button2.TabIndex = 6;
            button2.Text = "Disable Collection";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.FromArgb(216, 222, 233);
            button3.Location = new Point(294, 51);
            button3.Name = "button3";
            button3.Size = new Size(135, 23);
            button3.TabIndex = 7;
            button3.Text = "REMOVE SECURITY";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Transparent;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.ForeColor = Color.FromArgb(216, 222, 233);
            button7.Location = new Point(435, 51);
            button7.Name = "button7";
            button7.Size = new Size(135, 23);
            button7.TabIndex = 9;
            button7.Text = "Disable Services";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.Transparent;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.ForeColor = Color.FromArgb(216, 222, 233);
            button8.Location = new Point(576, 51);
            button8.Name = "button8";
            button8.Size = new Size(135, 23);
            button8.TabIndex = 10;
            button8.Text = "Remove Bloat";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(76, 86, 106);
            ClientSize = new Size(749, 85);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            Text = "Optimizations";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button button5;
        private Button button4;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button7;
        private Button button8;
        private Button button9;
    }
}