namespace bai3._3
{
    partial class formdangnhapcs
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
            btdn = new Button();
            label1 = new Label();
            label2 = new Label();
            tbten = new TextBox();
            tbmk = new TextBox();
            SuspendLayout();
            // 
            // btdn
            // 
            btdn.Location = new Point(332, 212);
            btdn.Name = "btdn";
            btdn.Size = new Size(94, 29);
            btdn.TabIndex = 0;
            btdn.Text = "đăng nhập";
            btdn.UseVisualStyleBackColor = true;
            btdn.Click += btdn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(250, 64);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 1;
            label1.Text = "tên đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(239, 134);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 2;
            label2.Text = "mật khẩu";
            // 
            // tbten
            // 
            tbten.Location = new Point(352, 61);
            tbten.Name = "tbten";
            tbten.Size = new Size(125, 27);
            tbten.TabIndex = 3;
            // 
            // tbmk
            // 
            tbmk.Location = new Point(348, 131);
            tbmk.Name = "tbmk";
            tbmk.Size = new Size(125, 27);
            tbmk.TabIndex = 4;
            // 
            // formdangnhapcs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbmk);
            Controls.Add(tbten);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btdn);
            Name = "formdangnhapcs";
            Text = "formdangnhapcs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btdn;
        private Label label1;
        private Label label2;
        private TextBox tbten;
        private TextBox tbmk;
    }
}