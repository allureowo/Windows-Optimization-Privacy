namespace WOP
{
    partial class WOP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WOP));
            panel1 = new Panel();
            button3 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            button5 = new Button();
            button4 = new Button();
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(59, 66, 82);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(109, 469);
            panel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(59, 66, 82);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(0, 74);
            button3.Name = "button3";
            button3.Size = new Size(109, 23);
            button3.TabIndex = 4;
            button3.Text = "Winget";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(59, 66, 82);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(3, 45);
            button1.Name = "button1";
            button1.Size = new Size(106, 23);
            button1.TabIndex = 2;
            button1.Text = "Optimizations";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(59, 66, 82);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 30);
            panel2.TabIndex = 1;
            panel2.MouseDown += panel2_MouseDown;
            panel2.MouseMove += panel2_MouseMove;
            panel2.MouseUp += panel2_MouseUp;
            // 
            // button5
            // 
            button5.BackColor = Color.Transparent;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.FromArgb(216, 222, 233);
            button5.Location = new Point(742, 0);
            button5.Name = "button5";
            button5.Size = new Size(29, 30);
            button5.TabIndex = 3;
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
            button4.Location = new Point(768, 0);
            button4.Name = "button4";
            button4.Size = new Size(29, 30);
            button4.TabIndex = 2;
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
            label1.Size = new Size(67, 32);
            label1.TabIndex = 2;
            label1.Text = "WOP";
            label1.Click += label1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(125, 36);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(646, 353);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // WOP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(76, 86, 106);
            ClientSize = new Size(795, 401);
            Controls.Add(richTextBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MinimizeBox = false;
            Name = "WOP";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += WOP_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Panel panel2;
        private Button button3;
        private Label label1;
        private Button button5;
        private Button button4;
        private RichTextBox richTextBox1;
    }
}