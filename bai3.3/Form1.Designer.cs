namespace bai3._3
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
            dssv = new DataGridView();
            masv = new DataGridViewTextBoxColumn();
            tensv = new DataGridViewTextBoxColumn();
            tuoi = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dssv).BeginInit();
            SuspendLayout();
            // 
            // dssv
            // 
            dssv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dssv.Columns.AddRange(new DataGridViewColumn[] { masv, tensv, tuoi });
            dssv.Location = new Point(100, 126);
            dssv.Name = "dssv";
            dssv.RowHeadersWidth = 51;
            dssv.Size = new Size(428, 188);
            dssv.TabIndex = 0;
            dssv.CellContentClick += dssv_CellContentClick_1;
            // 
            // masv
            // 
            masv.HeaderText = "mã sinh viên";
            masv.MinimumWidth = 6;
            masv.Name = "masv";
            masv.Width = 125;
            // 
            // tensv
            // 
            tensv.HeaderText = "Tên sinh viên";
            tensv.MinimumWidth = 6;
            tensv.Name = "tensv";
            tensv.Width = 125;
            // 
            // tuoi
            // 
            tuoi.HeaderText = "tuổi";
            tuoi.MinimumWidth = 6;
            tuoi.Name = "tuoi";
            tuoi.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dssv);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dssv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dssv;
        private DataGridViewTextBoxColumn masv;
        private DataGridViewTextBoxColumn tensv;
        private DataGridViewTextBoxColumn tuoi;
    }
}
