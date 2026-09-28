namespace tesst
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            dss = new ComboBox();
            Toan = new CheckBox();
            Van = new CheckBox();
            dk = new Button();
            ds = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.Font = new Font("Segoe UI", 30F);
            textBox1.ForeColor = Color.IndianRed;
            textBox1.Location = new Point(60, 12);
            textBox1.MaximumSize = new Size(10000000, 500);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(647, 72);
            textBox1.TabIndex = 0;
            textBox1.Text = "ĐĂNG KÝ MÔN THỂ THAO";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Control;
            textBox2.Location = new Point(78, 127);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 1;
            textBox2.Text = "Vận động viên";
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Control;
            textBox3.Location = new Point(78, 192);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 2;
            textBox3.Text = "Thời gian đăng kí";
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.Control;
            textBox4.Location = new Point(290, 127);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(448, 27);
            textBox4.TabIndex = 3;
            // 
            // dss
            // 
            dss.FormattingEnabled = true;
            dss.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            dss.Location = new Point(447, 256);
            dss.Name = "dss";
            dss.Size = new Size(151, 28);
            dss.TabIndex = 4;
            dss.Text = "Chọn số tiết";
            dss.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Toan
            // 
            Toan.AutoSize = true;
            Toan.Location = new Point(612, 209);
            Toan.Name = "Toan";
            Toan.Size = new Size(63, 24);
            Toan.TabIndex = 5;
            Toan.Text = "Toán";
            Toan.UseVisualStyleBackColor = true;
            Toan.CheckedChanged += Toan_CheckedChanged;
            // 
            // Van
            // 
            Van.AutoSize = true;
            Van.Location = new Point(612, 256);
            Van.Name = "Van";
            Van.Size = new Size(62, 24);
            Van.TabIndex = 6;
            Van.Text = "MCK";
            Van.UseVisualStyleBackColor = true;
            Van.CheckedChanged += Van_CheckedChanged;
            // 
            // dk
            // 
            dk.Location = new Point(600, 312);
            dk.Name = "dk";
            dk.Size = new Size(94, 29);
            dk.TabIndex = 7;
            dk.Text = "Đăng ký";
            dk.UseVisualStyleBackColor = true;
            dk.Click += dk_Click;
            // 
            // ds
            // 
            ds.FormattingEnabled = true;
            ds.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            ds.Location = new Point(447, 205);
            ds.Name = "ds";
            ds.Size = new Size(151, 28);
            ds.TabIndex = 8;
            ds.Text = "Chọn số tiết";
            ds.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(78, 242);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 9;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimePicker1);
            Controls.Add(ds);
            Controls.Add(dk);
            Controls.Add(Van);
            Controls.Add(Toan);
            Controls.Add(dss);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private ComboBox dss;
        private CheckBox Toan;
        private CheckBox Van;
        private Button dk;
        private ComboBox ds;
        private DateTimePicker dateTimePicker1;
    }
}
