namespace WinFormsApp1
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
            osoa = new TextBox();
            osob = new TextBox();
            osoc = new TextBox();
            x1 = new TextBox();
            x2 = new TextBox();
            pt2 = new CheckBox();
            pt1 = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // osoa
            // 
            osoa.Location = new Point(246, 120);
            osoa.Name = "osoa";
            osoa.Size = new Size(95, 27);
            osoa.TabIndex = 1;
            osoa.TextChanged += textBox2_TextChanged;
            // 
            // osob
            // 
            osob.Location = new Point(246, 166);
            osob.Name = "osob";
            osob.Size = new Size(95, 27);
            osob.TabIndex = 2;
            osob.TextChanged += osob_TextChanged;
            // 
            // osoc
            // 
            osoc.Location = new Point(246, 222);
            osoc.Name = "osoc";
            osoc.Size = new Size(96, 27);
            osoc.TabIndex = 5;
            osoc.TextChanged += textBox6_TextChanged;
            // 
            // x1
            // 
            x1.Location = new Point(492, 291);
            x1.Name = "x1";
            x1.Size = new Size(125, 27);
            x1.TabIndex = 8;
            x1.TextChanged += x1_TextChanged;
            // 
            // x2
            // 
            x2.Location = new Point(492, 123);
            x2.Name = "x2";
            x2.Size = new Size(125, 27);
            x2.TabIndex = 9;
            // 
            // pt2
            // 
            pt2.AutoSize = true;
            pt2.Location = new Point(128, 28);
            pt2.Name = "pt2";
            pt2.Size = new Size(156, 24);
            pt2.TabIndex = 11;
            pt2.Text = "Phương trình bậc 2";
            pt2.UseVisualStyleBackColor = true;
            pt2.CheckedChanged += pt2_CheckedChanged;
            // 
            // pt1
            // 
            pt1.AutoSize = true;
            pt1.Location = new Point(128, 58);
            pt1.Name = "pt1";
            pt1.Size = new Size(156, 24);
            pt1.TabIndex = 12;
            pt1.Text = "Phương trình bậc 1";
            pt1.UseVisualStyleBackColor = true;
            pt1.CheckedChanged += pt1_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(124, 123);
            label1.Name = "label1";
            label1.Size = new Size(19, 20);
            label1.TabIndex = 13;
            label1.Text = "A";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(124, 173);
            label2.Name = "label2";
            label2.Size = new Size(18, 20);
            label2.TabIndex = 14;
            label2.Text = "B";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(124, 220);
            label3.Name = "label3";
            label3.Size = new Size(18, 20);
            label3.TabIndex = 15;
            label3.Text = "C";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(418, 123);
            label5.Name = "label5";
            label5.Size = new Size(26, 20);
            label5.TabIndex = 17;
            label5.Text = "X1";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(418, 201);
            label6.Name = "label6";
            label6.Size = new Size(26, 20);
            label6.TabIndex = 18;
            label6.Text = "X2";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(418, 298);
            label7.Name = "label7";
            label7.Size = new Size(18, 20);
            label7.TabIndex = 19;
            label7.Text = "X";
            label7.Click += label7_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(492, 194);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 20;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // button1
            // 
            button1.Location = new Point(95, 303);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 21;
            button1.Text = "=";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(246, 303);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 22;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pt1);
            Controls.Add(pt2);
            Controls.Add(x2);
            Controls.Add(x1);
            Controls.Add(osoc);
            Controls.Add(osob);
            Controls.Add(osoa);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox osoa;
        private TextBox osob;
        private TextBox osoc;
        private TextBox x1;
        private TextBox x2;
        private CheckBox pt2;
        private CheckBox pt1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
    }
}
