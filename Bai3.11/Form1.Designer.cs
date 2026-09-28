namespace Bai3._11
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
            label5 = new Label();
            tbht = new TextBox();
            nt = new DateTimePicker();
            cbhv = new ComboBox();
            nam = new RadioButton();
            nu = new RadioButton();
            cbdk = new CheckBox();
            btdk = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 78);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 0;
            label1.Text = "ngày sinh";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 131);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 1;
            label2.Text = "trình độ học vấn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(82, 228);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 2;
            label3.Text = "đăng ký học";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(82, 186);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 3;
            label4.Text = "giới tính";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(82, 30);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 4;
            label5.Text = "họ tên";
            // 
            // tbht
            // 
            tbht.Location = new Point(214, 28);
            tbht.Name = "tbht";
            tbht.Size = new Size(125, 27);
            tbht.TabIndex = 5;
            tbht.TextChanged += tbht_TextChanged;
            // 
            // nt
            // 
            nt.Location = new Point(214, 78);
            nt.Name = "nt";
            nt.Size = new Size(250, 27);
            nt.TabIndex = 6;
            // 
            // cbhv
            // 
            cbhv.FormattingEnabled = true;
            cbhv.Items.AddRange(new object[] { "thạc sĩ ", "tiến sĩ", "viên sinh" });
            cbhv.Location = new Point(214, 128);
            cbhv.Name = "cbhv";
            cbhv.Size = new Size(151, 28);
            cbhv.TabIndex = 7;
            // 
            // nam
            // 
            nam.AutoSize = true;
            nam.Location = new Point(213, 184);
            nam.Name = "nam";
            nam.Size = new Size(59, 24);
            nam.TabIndex = 8;
            nam.TabStop = true;
            nam.Text = "nam";
            nam.UseVisualStyleBackColor = true;
            // 
            // nu
            // 
            nu.AutoSize = true;
            nu.Location = new Point(318, 182);
            nu.Name = "nu";
            nu.Size = new Size(47, 24);
            nu.TabIndex = 9;
            nu.TabStop = true;
            nu.Text = "nữ";
            nu.UseVisualStyleBackColor = true;
            // 
            // cbdk
            // 
            cbdk.AutoSize = true;
            cbdk.ForeColor = SystemColors.ControlText;
            cbdk.Location = new Point(222, 232);
            cbdk.Name = "cbdk";
            cbdk.Size = new Size(80, 24);
            cbdk.TabIndex = 10;
            cbdk.Text = "đăng kí";
            cbdk.UseVisualStyleBackColor = true;
            // 
            // btdk
            // 
            btdk.Location = new Point(299, 319);
            btdk.Name = "btdk";
            btdk.Size = new Size(94, 29);
            btdk.TabIndex = 11;
            btdk.Text = "đăng kí";
            btdk.UseVisualStyleBackColor = true;
            btdk.Click += btdk_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btdk);
            Controls.Add(cbdk);
            Controls.Add(nu);
            Controls.Add(nam);
            Controls.Add(cbhv);
            Controls.Add(nt);
            Controls.Add(tbht);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tbht;
        private DateTimePicker nt;
        private ComboBox cbhv;
        private RadioButton nam;
        private RadioButton nu;
        private CheckBox cbdk;
        private Button btdk;
    }
}
