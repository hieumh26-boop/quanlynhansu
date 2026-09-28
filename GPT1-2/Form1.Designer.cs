namespace GPT1_2
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
            cbb1 = new CheckBox();
            cbb2 = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tba = new TextBox();
            tbb = new TextBox();
            tbc = new TextBox();
            label5 = new Label();
            label6 = new Label();
            tbx1 = new TextBox();
            tbx2 = new TextBox();
            btt = new Button();
            btx = new Button();
            exit = new Button();
            SuspendLayout();
            // 
            // cbb1
            // 
            cbb1.AutoSize = true;
            cbb1.Location = new Point(88, 21);
            cbb1.Name = "cbb1";
            cbb1.Size = new Size(156, 24);
            cbb1.TabIndex = 0;
            cbb1.Text = "Phương trình bậc 1";
            cbb1.UseVisualStyleBackColor = true;
            cbb1.CheckedChanged += cbb1_CheckedChanged;
            // 
            // cbb2
            // 
            cbb2.AutoSize = true;
            cbb2.Location = new Point(88, 60);
            cbb2.Name = "cbb2";
            cbb2.Size = new Size(156, 24);
            cbb2.TabIndex = 1;
            cbb2.Text = "Phương trình bậc 2";
            cbb2.UseVisualStyleBackColor = true;
            cbb2.CheckedChanged += cbb2_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 129);
            label1.Name = "label1";
            label1.Size = new Size(19, 20);
            label1.TabIndex = 2;
            label1.Text = "A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 193);
            label2.Name = "label2";
            label2.Size = new Size(18, 20);
            label2.TabIndex = 3;
            label2.Text = "B";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 243);
            label3.Name = "label3";
            label3.Size = new Size(18, 20);
            label3.TabIndex = 4;
            label3.Text = "C";
            // 
            // tba
            // 
            tba.Location = new Point(156, 129);
            tba.Name = "tba";
            tba.Size = new Size(125, 27);
            tba.TabIndex = 5;
            // 
            // tbb
            // 
            tbb.Location = new Point(156, 186);
            tbb.Name = "tbb";
            tbb.Size = new Size(125, 27);
            tbb.TabIndex = 6;
            // 
            // tbc
            // 
            tbc.Location = new Point(156, 236);
            tbc.Name = "tbc";
            tbc.Size = new Size(125, 27);
            tbc.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(496, 193);
            label5.Name = "label5";
            label5.Size = new Size(26, 20);
            label5.TabIndex = 9;
            label5.Text = "X1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(496, 243);
            label6.Name = "label6";
            label6.Size = new Size(26, 20);
            label6.TabIndex = 10;
            label6.Text = "X2";
            // 
            // tbx1
            // 
            tbx1.Location = new Point(578, 186);
            tbx1.Name = "tbx1";
            tbx1.Size = new Size(125, 27);
            tbx1.TabIndex = 12;
            tbx1.TextChanged += textBox5_TextChanged;
            // 
            // tbx2
            // 
            tbx2.Location = new Point(578, 240);
            tbx2.Name = "tbx2";
            tbx2.Size = new Size(125, 27);
            tbx2.TabIndex = 13;
            // 
            // btt
            // 
            btt.Location = new Point(156, 338);
            btt.Name = "btt";
            btt.Size = new Size(94, 29);
            btt.TabIndex = 14;
            btt.Text = "=";
            btt.UseVisualStyleBackColor = true;
            btt.Click += btt_Click;
            // 
            // btx
            // 
            btx.Location = new Point(353, 338);
            btx.Name = "btx";
            btx.Size = new Size(94, 29);
            btx.TabIndex = 15;
            btx.Text = "Xóa";
            btx.UseVisualStyleBackColor = true;
            btx.Click += btx_Click;
            // 
            // exit
            // 
            exit.Location = new Point(530, 338);
            exit.Name = "exit";
            exit.Size = new Size(94, 29);
            exit.TabIndex = 16;
            exit.Text = "Thoát";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(exit);
            Controls.Add(btx);
            Controls.Add(btt);
            Controls.Add(tbx2);
            Controls.Add(tbx1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(tbc);
            Controls.Add(tbb);
            Controls.Add(tba);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbb2);
            Controls.Add(cbb1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox cbb1;
        private CheckBox cbb2;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tba;
        private TextBox tbb;
        private TextBox tbc;
        private Label label5;
        private Label label6;
        private TextBox tbx1;
        private TextBox tbx2;
        private Button btt;
        private Button btx;
        private Button exit;
    }
}
