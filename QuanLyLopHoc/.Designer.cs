
namespace QuanLyLopHoc
{
    partial class HocVien
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dgvTV = new System.Windows.Forms.DataGridView();
            this.HV_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HV_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HV_PHONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HV_EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dpDob = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ho ten ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ngay sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "dia chi";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(204, 55);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(207, 20);
            this.txtName.TabIndex = 3;
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(204, 132);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(207, 20);
            this.txtAdd.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(84, 185);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "them";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(218, 185);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "sua";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(364, 185);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "xoa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(503, 185);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "quay lai";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dgvTV
            // 
            this.dgvTV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HV_ID,
            this.HV_NAME,
            this.HV_PHONE,
            this.HV_EMAIL});
            this.dgvTV.Location = new System.Drawing.Point(84, 244);
            this.dgvTV.Name = "dgvTV";
            this.dgvTV.Size = new System.Drawing.Size(645, 182);
            this.dgvTV.TabIndex = 10;
            this.dgvTV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTV_Click);
            this.dgvTV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTV_CellContentClick);
            // 
            // HV_ID
            // 
            this.HV_ID.DataPropertyName = "HV_ID";
            this.HV_ID.HeaderText = "ID";
            this.HV_ID.Name = "HV_ID";
            // 
            // HV_NAME
            // 
            this.HV_NAME.DataPropertyName = "HV_NAME";
            this.HV_NAME.HeaderText = "NAME";
            this.HV_NAME.Name = "HV_NAME";
            // 
            // HV_PHONE
            // 
            this.HV_PHONE.DataPropertyName = "HV_DOB";
            this.HV_PHONE.HeaderText = "DOB";
            this.HV_PHONE.Name = "HV_PHONE";
            // 
            // HV_EMAIL
            // 
            this.HV_EMAIL.DataPropertyName = "HV_ADD";
            this.HV_EMAIL.HeaderText = "ADD";
            this.HV_EMAIL.Name = "HV_EMAIL";
            // 
            // dpDob
            // 
            this.dpDob.Location = new System.Drawing.Point(204, 94);
            this.dpDob.Name = "dpDob";
            this.dpDob.Size = new System.Drawing.Size(200, 20);
            this.dpDob.TabIndex = 11;
            // 
            // HocVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dpDob);
            this.Controls.Add(this.dgvTV);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HocVien";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgvTV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HV_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn HV_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn HV_PHONE;
        private System.Windows.Forms.DataGridViewTextBoxColumn HV_EMAIL;
        private System.Windows.Forms.DateTimePicker dpDob;
    }
}

