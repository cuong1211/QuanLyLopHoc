
namespace QuanLyLopHoc
{
    partial class Main
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
            this.btnHV = new System.Windows.Forms.Button();
            this.btnGV = new System.Windows.Forms.Button();
            this.btnLH = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHV
            // 
            this.btnHV.Location = new System.Drawing.Point(102, 141);
            this.btnHV.Name = "btnHV";
            this.btnHV.Size = new System.Drawing.Size(75, 23);
            this.btnHV.TabIndex = 0;
            this.btnHV.Text = "HocVien";
            this.btnHV.UseVisualStyleBackColor = true;
            this.btnHV.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGV
            // 
            this.btnGV.Location = new System.Drawing.Point(316, 141);
            this.btnGV.Name = "btnGV";
            this.btnGV.Size = new System.Drawing.Size(75, 23);
            this.btnGV.TabIndex = 1;
            this.btnGV.Text = "GiaoVien";
            this.btnGV.UseVisualStyleBackColor = true;
            this.btnGV.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnLH
            // 
            this.btnLH.Location = new System.Drawing.Point(513, 141);
            this.btnLH.Name = "btnLH";
            this.btnLH.Size = new System.Drawing.Size(75, 23);
            this.btnLH.TabIndex = 2;
            this.btnLH.Text = "LopHoc";
            this.btnLH.UseVisualStyleBackColor = true;
            this.btnLH.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "QUAN LY LOP HOC";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLH);
            this.Controls.Add(this.btnGV);
            this.Controls.Add(this.btnHV);
            this.Name = "Main";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHV;
        private System.Windows.Forms.Button btnGV;
        private System.Windows.Forms.Button btnLH;
        private System.Windows.Forms.Label label1;
    }
}