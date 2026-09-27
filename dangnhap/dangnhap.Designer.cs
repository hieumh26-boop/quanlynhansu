namespace dangnhap
{
    partial class formdangnhap
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
            btc = new Button();
            tbtdn = new TextBox();
            tbmk = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            laqmk = new LinkLabel();
            cbamk = new CheckBox();
            btttkm = new Button();
            SuspendLayout();
            // 
            // btc
            // 
            btc.Location = new Point(230, 203);
            btc.Name = "btc";
            btc.Size = new Size(94, 29);
            btc.TabIndex = 0;
            btc.Text = "đăng nhập";
            btc.UseVisualStyleBackColor = true;
            btc.Click += btc_Click;
            // 
            // tbtdn
            // 
            tbtdn.Location = new Point(230, 102);
            tbtdn.Name = "tbtdn";
            tbtdn.Size = new Size(270, 27);
            tbtdn.TabIndex = 2;
            tbtdn.TextChanged += tbtdn_TextChanged;
            // 
            // tbmk
            // 
            tbmk.Location = new Point(230, 154);
            tbmk.Name = "tbmk";
            tbmk.Size = new Size(270, 27);
            tbmk.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(230, 9);
            label1.Name = "label1";
            label1.Size = new Size(288, 46);
            label1.TabIndex = 4;
            label1.Text = "Đăng nhập QLSV";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(116, 109);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 5;
            label2.Text = "tên đăng nhập:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(122, 161);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 6;
            label3.Text = "mật khẩu:";
            // 
            // button1
            // 
            button1.Location = new Point(406, 203);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "Thoát";
            button1.UseVisualStyleBackColor = true;
            // 
            // laqmk
            // 
            laqmk.AutoSize = true;
            laqmk.Location = new Point(313, 250);
            laqmk.Name = "laqmk";
            laqmk.Size = new Size(107, 20);
            laqmk.TabIndex = 8;
            laqmk.TabStop = true;
            laqmk.Text = "quên mật khẩu";
            // 
            // cbamk
            // 
            cbamk.Appearance = Appearance.Button;
            cbamk.AutoSize = true;
            cbamk.FlatStyle = FlatStyle.Flat;
            cbamk.Image =global::quanlynhansu.Properties.Resources.mătdong;
            cbamk.Location = new Point(516, 156);
            cbamk.Name = "cbamk";
            cbamk.Size = new Size(36, 36);
            cbamk.TabIndex = 10;
            cbamk.UseVisualStyleBackColor = true;
            cbamk.CheckedChanged += cbamk_CheckedChanged;
            // 
            // btttkm
            // 
            btttkm.Location = new Point(230, 288);
            btttkm.Name = "btttkm";
            btttkm.Size = new Size(175, 29);
            btttkm.TabIndex = 11;
            btttkm.Text = "Tạo tài khoản mới";
            btttkm.UseVisualStyleBackColor = true;
            btttkm.Click += btttkm_Click;
            // 
            // formdangnhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(btttkm);
            Controls.Add(cbamk);
            Controls.Add(laqmk);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbmk);
            Controls.Add(tbtdn);
            Controls.Add(btc);
            Name = "formdangnhap";
            Text = "đăng nhập";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btc;
        private TextBox tbtdn;
        private TextBox tbmk;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private LinkLabel laqmk;
        private CheckBox cbamk;
        private Button btttkm;
    }
}
