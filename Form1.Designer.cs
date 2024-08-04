namespace CSHARP_TinhTong
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
            sodau = new TextBox();
            socuoi = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            tong = new TextBox();
            Tich = new TextBox();
            Tongchan = new TextBox();
            Tongle = new TextBox();
            tinh = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 128, 0);
            label1.Font = new Font("Vladimir Script", 19.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(292, 47);
            label1.Name = "label1";
            label1.Size = new Size(720, 65);
            label1.TabIndex = 0;
            label1.Text = "TÍNH TOÁN TRÊN DÃY SỐ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 192, 192);
            label2.Font = new Font("Tahoma", 13F);
            label2.Location = new Point(52, 195);
            label2.Name = "label2";
            label2.Size = new Size(345, 42);
            label2.TabIndex = 1;
            label2.Text = "Giới hạn của dãy số :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 192, 192);
            label3.Font = new Font("Tahoma", 12F);
            label3.Location = new Point(450, 198);
            label3.Name = "label3";
            label3.Size = new Size(192, 39);
            label3.TabIndex = 2;
            label3.Text = "Số bắt đầu :";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(255, 192, 192);
            label4.Font = new Font("Tahoma", 12F);
            label4.Location = new Point(907, 202);
            label4.Name = "label4";
            label4.Size = new Size(199, 39);
            label4.TabIndex = 2;
            label4.Text = "Số kết thúc :";
            // 
            // sodau
            // 
            sodau.BackColor = Color.IndianRed;
            sodau.Font = new Font("Tahoma", 12F);
            sodau.Location = new Point(650, 195);
            sodau.Name = "sodau";
            sodau.Size = new Size(199, 46);
            sodau.TabIndex = 3;
            // 
            // socuoi
            // 
            socuoi.BackColor = Color.IndianRed;
            socuoi.Font = new Font("Tahoma", 12F);
            socuoi.Location = new Point(1082, 195);
            socuoi.Name = "socuoi";
            socuoi.Size = new Size(200, 46);
            socuoi.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 13F);
            label5.ForeColor = Color.FromArgb(192, 0, 0);
            label5.Location = new Point(74, 349);
            label5.Name = "label5";
            label5.Size = new Size(160, 42);
            label5.TabIndex = 4;
            label5.Text = "Kết quả :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Cyan;
            label6.Font = new Font("Tahoma", 12F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(74, 451);
            label6.Name = "label6";
            label6.Size = new Size(208, 39);
            label6.TabIndex = 2;
            label6.Text = "Tổng các số :";
            label6.Click += label3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Cyan;
            label7.Font = new Font("Tahoma", 12F);
            label7.Location = new Point(74, 534);
            label7.Name = "label7";
            label7.Size = new Size(195, 39);
            label7.TabIndex = 2;
            label7.Text = "Tích các số :";
            label7.Click += label3_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Cyan;
            label8.Font = new Font("Tahoma", 12F);
            label8.Location = new Point(74, 610);
            label8.Name = "label8";
            label8.Size = new Size(286, 39);
            label8.TabIndex = 2;
            label8.Text = "Tổng các số chẵn :";
            label8.Click += label3_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Cyan;
            label9.Font = new Font("Tahoma", 12F);
            label9.Location = new Point(74, 694);
            label9.Name = "label9";
            label9.Size = new Size(242, 39);
            label9.TabIndex = 2;
            label9.Text = "Tổng các số lẻ :";
            label9.Click += label3_Click;
            // 
            // tong
            // 
            tong.BackColor = Color.Maroon;
            tong.Font = new Font("Tahoma", 12F);
            tong.Location = new Point(486, 444);
            tong.Name = "tong";
            tong.Size = new Size(387, 46);
            tong.TabIndex = 3;
            // 
            // Tich
            // 
            Tich.BackColor = Color.Maroon;
            Tich.Font = new Font("Tahoma", 12F);
            Tich.Location = new Point(486, 534);
            Tich.Name = "Tich";
            Tich.Size = new Size(387, 46);
            Tich.TabIndex = 3;
            // 
            // Tongchan
            // 
            Tongchan.BackColor = Color.Maroon;
            Tongchan.Font = new Font("Tahoma", 12F);
            Tongchan.Location = new Point(486, 603);
            Tongchan.Name = "Tongchan";
            Tongchan.Size = new Size(387, 46);
            Tongchan.TabIndex = 3;
            // 
            // Tongle
            // 
            Tongle.BackColor = Color.Maroon;
            Tongle.Font = new Font("Tahoma", 12F);
            Tongle.Location = new Point(486, 687);
            Tongle.Name = "Tongle";
            Tongle.Size = new Size(387, 46);
            Tongle.TabIndex = 3;
            // 
            // tinh
            // 
            tinh.BackColor = Color.FromArgb(0, 192, 192);
            tinh.Font = new Font("Tahoma", 13F);
            tinh.Location = new Point(589, 785);
            tinh.Name = "tinh";
            tinh.Size = new Size(150, 46);
            tinh.TabIndex = 5;
            tinh.Text = "TÍNH";
            tinh.UseVisualStyleBackColor = false;
            tinh.Click += tinh_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1319, 853);
            Controls.Add(tinh);
            Controls.Add(label5);
            Controls.Add(socuoi);
            Controls.Add(Tongle);
            Controls.Add(Tongchan);
            Controls.Add(Tich);
            Controls.Add(tong);
            Controls.Add(sodau);
            Controls.Add(label4);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
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
        private TextBox sodau;
        private TextBox socuoi;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox tong;
        private TextBox Tich;
        private TextBox Tongchan;
        private TextBox Tongle;
        private Button tinh;
    }
}
