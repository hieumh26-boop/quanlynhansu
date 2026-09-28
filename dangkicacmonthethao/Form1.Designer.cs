namespace dangkicacmonthethao
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ndk = new ComboBox();
            dk = new DateTimePicker();
            label5 = new Label();
            box1 = new ListBox();
            box2 = new ListBox();
            ctt = new Button();
            ctp = new Button();
            btp = new Button();
            btt = new Button();
            label6 = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(123, 9);
            label1.Name = "label1";
            label1.Size = new Size(509, 46);
            label1.TabIndex = 0;
            label1.Text = "ĐĂNG KÍ CÁC MÔN THỂ THAO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(205, 55);
            label2.Name = "label2";
            label2.Size = new Size(328, 35);
            label2.TabIndex = 1;
            label2.Text = "Trần Văn Hiếu-75DCTT21333";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 99);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 2;
            label3.Text = "Vận động viên:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 135);
            label4.Name = "label4";
            label4.Size = new Size(130, 20);
            label4.TabIndex = 3;
            label4.Text = "Thời gian đăng ký:";
            // 
            // ndk
            // 
            ndk.FormattingEnabled = true;
            ndk.Items.AddRange(new object[] { "Trần Văn Hiếu", "Trần Thị Hiếu", "Nghiêm Vũ Hoàng Hiếu" });
            ndk.Location = new Point(125, 93);
            ndk.Name = "ndk";
            ndk.Size = new Size(273, 28);
            ndk.TabIndex = 4;
            // 
            // dk
            // 
            dk.Location = new Point(148, 135);
            dk.Name = "dk";
            dk.Size = new Size(250, 27);
            dk.TabIndex = 5;
            dk.ValueChanged += dk_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 185);
            label5.Name = "label5";
            label5.Size = new Size(239, 23);
            label5.TabIndex = 6;
            label5.Text = "Danh sách các môn thể thao:";
            // 
            // box1
            // 
            box1.FormattingEnabled = true;
            box1.Items.AddRange(new object[] { "Bóng chuyền", "Bóng đá", "Cầu lông", "Tennis", "Bơi", "chay bo" });
            box1.Location = new Point(12, 211);
            box1.Name = "box1";
            box1.SelectionMode = SelectionMode.MultiSimple;
            box1.Size = new Size(153, 164);
            box1.TabIndex = 7;
            box1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // box2
            // 
            box2.FormattingEnabled = true;
            box2.Items.AddRange(new object[] { "" });
            box2.Location = new Point(384, 211);
            box2.Name = "box2";
            box2.Size = new Size(149, 164);
            box2.TabIndex = 8;
            box2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // ctt
            // 
            ctt.BackColor = SystemColors.ActiveBorder;
            ctt.FlatStyle = FlatStyle.Popup;
            ctt.Location = new Point(233, 211);
            ctt.Name = "ctt";
            ctt.Size = new Size(94, 29);
            ctt.TabIndex = 9;
            ctt.Text = ">>";
            ctt.UseVisualStyleBackColor = false;
            ctt.Click += ctt_Click;
            // 
            // ctp
            // 
            ctp.BackColor = SystemColors.AppWorkspace;
            ctp.FlatStyle = FlatStyle.Flat;
            ctp.Location = new Point(233, 255);
            ctp.Name = "ctp";
            ctp.Size = new Size(94, 29);
            ctp.TabIndex = 10;
            ctp.Text = ">";
            ctp.UseVisualStyleBackColor = false;
            ctp.Click += ctp_Click;
            // 
            // btp
            // 
            btp.BackColor = SystemColors.ActiveBorder;
            btp.FlatStyle = FlatStyle.Flat;
            btp.Location = new Point(233, 301);
            btp.Name = "btp";
            btp.Size = new Size(94, 29);
            btp.TabIndex = 11;
            btp.Text = "<";
            btp.UseVisualStyleBackColor = false;
            btp.Click += btp_Click;
            // 
            // btt
            // 
            btt.BackColor = SystemColors.AppWorkspace;
            btt.FlatStyle = FlatStyle.Flat;
            btt.Location = new Point(233, 346);
            btt.Name = "btt";
            btt.Size = new Size(94, 29);
            btt.TabIndex = 12;
            btt.Text = "<<";
            btt.UseVisualStyleBackColor = false;
            btt.Click += btt_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 388);
            label6.Name = "label6";
            label6.Size = new Size(119, 20);
            label6.TabIndex = 13;
            label6.Text = "Kết quả đăng ký:";
            label6.Click += label6_Click;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(12, 411);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(521, 102);
            textBox1.TabIndex = 14;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveBorder;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(221, 531);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 16;
            button2.Text = "Hủy";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveBorder;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(402, 531);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 17;
            button3.Text = "Thoát";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(48, 531);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 15;
            button1.Text = "Đăng ký";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 574);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(btt);
            Controls.Add(btp);
            Controls.Add(ctp);
            Controls.Add(ctt);
            Controls.Add(box2);
            Controls.Add(box1);
            Controls.Add(label5);
            Controls.Add(dk);
            Controls.Add(ndk);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox ndk;
        private DateTimePicker dk;
        private Label label5;
        private ListBox box1;
        private ListBox box2;
        private Button ctt;
        private Button ctp;
        private Button btp;
        private Button btt;
        private Label label6;
        private TextBox textBox1;
        private Button button2;
        private Button button3;
        private Button button1;
    }
}
