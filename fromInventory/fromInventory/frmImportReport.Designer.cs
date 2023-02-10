namespace fromInventory
{
    partial class frmImportReport
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
            this.cmbEmp = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpstart = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmpSup = new System.Windows.Forms.ComboBox();
            this.dtpStop = new System.Windows.Forms.DateTimePicker();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Khmer OS System", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(778, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "របាយការណ៍នាំចូល";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(5, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbEmp
            // 
            this.cmbEmp.FormattingEnabled = true;
            this.cmbEmp.Location = new System.Drawing.Point(141, 97);
            this.cmbEmp.Name = "cmbEmp";
            this.cmbEmp.Size = new System.Drawing.Size(121, 21);
            this.cmbEmp.TabIndex = 3;
            this.cmbEmp.SelectionChangeCommitted += new System.EventHandler(this.cmbEmp_SelectionChangeCommitted);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(141, 142);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(428, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "ប្រភពផ្គត់​ផ្គង់";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(5, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "ឈ្មោះបុគ្គលិត";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpstart
            // 
            this.dtpstart.CustomFormat = " ";
            this.dtpstart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpstart.Location = new System.Drawing.Point(141, 142);
            this.dtpstart.Name = "dtpstart";
            this.dtpstart.Size = new System.Drawing.Size(121, 20);
            this.dtpstart.TabIndex = 5;
            this.dtpstart.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(5, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "ចាប់​ពីថ្ងៃ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(428, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "ដល់ថ្ងៃ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Click += new System.EventHandler(this.label5_Click);
            // 
            // cmpSup
            // 
            this.cmpSup.FormattingEnabled = true;
            this.cmpSup.Location = new System.Drawing.Point(586, 97);
            this.cmpSup.Name = "cmpSup";
            this.cmpSup.Size = new System.Drawing.Size(121, 21);
            this.cmpSup.TabIndex = 3;
            this.cmpSup.SelectedIndexChanged += new System.EventHandler(this.cmpSup_SelectedIndexChanged);
            // 
            // dtpStop
            // 
            this.dtpStop.CustomFormat = " ";
            this.dtpStop.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStop.Location = new System.Drawing.Point(586, 142);
            this.dtpStop.Name = "dtpStop";
            this.dtpStop.Size = new System.Drawing.Size(121, 20);
            this.dtpStop.TabIndex = 5;
            this.dtpStop.ValueChanged += new System.EventHandler(this.dtpStop_ValueChanged);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(750, 143);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(91, 23);
            this.btnShow.TabIndex = 6;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(750, 445);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(91, 23);
            this.btnPreview.TabIndex = 6;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(750, 95);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(91, 23);
            this.btnNew.TabIndex = 6;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(750, 191);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(91, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = " Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(13, 207);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(694, 250);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // frmImportReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 486);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.dtpStop);
            this.Controls.Add(this.dtpstart);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmpSup);
            this.Controls.Add(this.cmbEmp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmImportReport";
            this.Text = "frmImportReport";
            this.Load += new System.EventHandler(this.frmImportReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbEmp;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpstart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmpSup;
        private System.Windows.Forms.DateTimePicker dtpStop;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListView listView1;
    }
}