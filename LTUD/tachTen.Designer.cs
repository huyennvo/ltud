namespace LTUD
{
    partial class tachTen
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtHT = new System.Windows.Forms.TextBox();
            this.btnkq = new System.Windows.Forms.Label();
            this.btnTachHoTen = new System.Windows.Forms.Button();
            this.btnTachDem = new System.Windows.Forms.Button();
            this.btnTachDemTen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.lblkq = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Họ tên:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtHT
            // 
            this.txtHT.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtHT.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHT.Location = new System.Drawing.Point(230, 28);
            this.txtHT.Name = "txtHT";
            this.txtHT.Size = new System.Drawing.Size(226, 46);
            this.txtHT.TabIndex = 1;
            // 
            // btnkq
            // 
            this.btnkq.AutoSize = true;
            this.btnkq.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnkq.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkq.Location = new System.Drawing.Point(92, 267);
            this.btnkq.Name = "btnkq";
            this.btnkq.Size = new System.Drawing.Size(0, 39);
            this.btnkq.TabIndex = 5;
            this.btnkq.Click += new System.EventHandler(this.btnkq_Click);
            // 
            // btnTachHoTen
            // 
            this.btnTachHoTen.Location = new System.Drawing.Point(58, 125);
            this.btnTachHoTen.Name = "btnTachHoTen";
            this.btnTachHoTen.Size = new System.Drawing.Size(182, 46);
            this.btnTachHoTen.TabIndex = 6;
            this.btnTachHoTen.Text = "Tách Họ Đệm";
            this.btnTachHoTen.UseVisualStyleBackColor = true;
            this.btnTachHoTen.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTachDem
            // 
            this.btnTachDem.Location = new System.Drawing.Point(306, 125);
            this.btnTachDem.Name = "btnTachDem";
            this.btnTachDem.Size = new System.Drawing.Size(182, 46);
            this.btnTachDem.TabIndex = 7;
            this.btnTachDem.Text = "Tách Đệm";
            this.btnTachDem.UseVisualStyleBackColor = true;
            this.btnTachDem.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnTachDemTen
            // 
            this.btnTachDemTen.Location = new System.Drawing.Point(554, 125);
            this.btnTachDemTen.Name = "btnTachDemTen";
            this.btnTachDemTen.Size = new System.Drawing.Size(182, 46);
            this.btnTachDemTen.TabIndex = 8;
            this.btnTachDemTen.Text = "Tách Đệm và Tên";
            this.btnTachDemTen.UseVisualStyleBackColor = true;
            this.btnTachDemTen.Click += new System.EventHandler(this.btnTachDemTen_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 9;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(682, 378);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 48);
            this.button4.TabIndex = 10;
            this.button4.Text = "Đóng";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblkq
            // 
            this.lblkq.AutoSize = true;
            this.lblkq.Location = new System.Drawing.Point(381, 267);
            this.lblkq.Name = "lblkq";
            this.lblkq.Size = new System.Drawing.Size(21, 20);
            this.lblkq.TabIndex = 11;
            this.lblkq.Text = "...";
            this.lblkq.Click += new System.EventHandler(this.lblkq_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(346, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "Kết quả";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tachTen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblkq);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTachDemTen);
            this.Controls.Add(this.btnTachDem);
            this.Controls.Add(this.btnTachHoTen);
            this.Controls.Add(this.btnkq);
            this.Controls.Add(this.txtHT);
            this.Controls.Add(this.label1);
            this.Name = "tachTen";
            this.Text = "tachTen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHT;
        private System.Windows.Forms.Label btnkq;
        private System.Windows.Forms.Button btnTachHoTen;
        private System.Windows.Forms.Button btnTachDem;
        private System.Windows.Forms.Button btnTachDemTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblkq;
        private System.Windows.Forms.Label label2;
    }
}