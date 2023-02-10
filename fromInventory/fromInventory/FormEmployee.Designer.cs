namespace fromInventory
{
    partial class FormEmployee
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.radioBoy = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPos = new System.Windows.Forms.TextBox();
            this.radioGirl = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.តួរនាទី = new System.Windows.Forms.Label();
            this.dtpWord = new System.Windows.Forms.DateTimePicker();
            this.mtbPhone = new System.Windows.Forms.MaskedTextBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 62);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Turquoise;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(737, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "ព័ត៍មានរបស់បុគ្គលិក";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "ឈ្មោះ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(108, 77);
            this.txtNum.Multiline = true;
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(143, 34);
            this.txtNum.TabIndex = 0;
            this.txtNum.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 27);
            this.label4.TabIndex = 1;
            this.label4.Text = "អត្តលេខ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(108, 121);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(143, 34);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // radioBoy
            // 
            this.radioBoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBoy.Location = new System.Drawing.Point(181, 161);
            this.radioBoy.Name = "radioBoy";
            this.radioBoy.Size = new System.Drawing.Size(70, 32);
            this.radioBoy.TabIndex = 3;
            this.radioBoy.TabStop = true;
            this.radioBoy.Text = "ប";
            this.radioBoy.UseVisualStyleBackColor = true;
            this.radioBoy.CheckedChanged += new System.EventHandler(this.radioBoy_CheckedChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 27);
            this.label5.TabIndex = 1;
            this.label5.Text = "ថ្ងៃកំណើត";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtPos
            // 
            this.txtPos.Location = new System.Drawing.Point(108, 225);
            this.txtPos.Multiline = true;
            this.txtPos.Name = "txtPos";
            this.txtPos.Size = new System.Drawing.Size(143, 34);
            this.txtPos.TabIndex = 5;
            this.txtPos.TextChanged += new System.EventHandler(this.txtPos_TextChanged);
            // 
            // radioGirl
            // 
            this.radioGirl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioGirl.Location = new System.Drawing.Point(108, 161);
            this.radioGirl.Name = "radioGirl";
            this.radioGirl.Size = new System.Drawing.Size(70, 32);
            this.radioGirl.TabIndex = 2;
            this.radioGirl.TabStop = true;
            this.radioGirl.Text = "ស";
            this.radioGirl.UseVisualStyleBackColor = true;
            this.radioGirl.CheckedChanged += new System.EventHandler(this.radioGirl_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 27);
            this.label3.TabIndex = 1;
            this.label3.Text = "ភេទ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(271, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 27);
            this.label6.TabIndex = 1;
            this.label6.Text = "អាសយដ្ឋាន";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(364, 81);
            this.txtSalary.Multiline = true;
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(143, 34);
            this.txtSalary.TabIndex = 6;
            this.txtSalary.TextChanged += new System.EventHandler(this.txtSalary_TextChanged);
            this.txtSalary.Enter += new System.EventHandler(this.txtSalary_Enter);
            this.txtSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalary_KeyPress);
            this.txtSalary.Leave += new System.EventHandler(this.txtSalary_Leave);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(271, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 27);
            this.label7.TabIndex = 1;
            this.label7.Text = "ប្រាក់ខែ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(367, 123);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(143, 67);
            this.txtAddress.TabIndex = 7;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(271, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 27);
            this.label8.TabIndex = 1;
            this.label8.Text = "ថ្ងៃចូលធ្វើការ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(268, 236);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 27);
            this.label10.TabIndex = 1;
            this.label10.Text = "លេខទូរស័ព្ធ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // តួរនាទី
            // 
            this.តួរនាទី.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.តួរនាទី.Location = new System.Drawing.Point(12, 232);
            this.តួរនាទី.Name = "តួរនាទី";
            this.តួរនាទី.Size = new System.Drawing.Size(77, 27);
            this.តួរនាទី.TabIndex = 1;
            this.តួរនាទី.Text = "តួរនាទី";
            this.តួរនាទី.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.តួរនាទី.Click += new System.EventHandler(this.តួរនាទី_Click);
            // 
            // dtpWord
            // 
            this.dtpWord.CustomFormat = "dd/MM/yy";
            this.dtpWord.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpWord.Location = new System.Drawing.Point(364, 196);
            this.dtpWord.Name = "dtpWord";
            this.dtpWord.Size = new System.Drawing.Size(143, 20);
            this.dtpWord.TabIndex = 8;
            this.dtpWord.ValueChanged += new System.EventHandler(this.dtpWord_ValueChanged);
            // 
            // mtbPhone
            // 
            this.mtbPhone.Location = new System.Drawing.Point(364, 236);
            this.mtbPhone.Mask = "(000) 000-000";
            this.mtbPhone.Name = "mtbPhone";
            this.mtbPhone.Size = new System.Drawing.Size(143, 20);
            this.mtbPhone.TabIndex = 9;
            this.mtbPhone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbPhone_MaskInputRejected);
            // 
            // dtpDOB
            // 
            this.dtpDOB.CustomFormat = "dd/MM/yy";
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOB.Location = new System.Drawing.Point(108, 196);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(143, 20);
            this.dtpDOB.TabIndex = 4;
            this.dtpDOB.ValueChanged += new System.EventHandler(this.dtpDOB_ValueChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(0, 324);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(737, 44);
            this.txtSearch.TabIndex = 10;
            this.txtSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 374);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(737, 162);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.Tag = "*";
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(568, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Image = global::fromInventory.Properties.Resources.icons8_sign_language_c_48;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(468, 266);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(98, 52);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnNew
            // 
            this.btnNew.Image = global::fromInventory.Properties.Resources.icons8_sign_language_c_48;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(4, 265);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(98, 52);
            this.btnNew.TabIndex = 6;
            this.btnNew.Tag = "*";
            this.btnNew.Text = "New";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::fromInventory.Properties.Resources.icons8_sign_language_c_48;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(605, 266);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(98, 52);
            this.btnClose.TabIndex = 6;
            this.btnClose.Tag = "*";
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::fromInventory.Properties.Resources.icons8_sign_language_c_48;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(250, 266);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(98, 52);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::fromInventory.Properties.Resources.icons8_sign_language_c_48;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(364, 266);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 52);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::fromInventory.Properties.Resources.icons8_sign_language_c_48;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(123, 266);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 52);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button1
            // 
            this.button1.Image = global::fromInventory.Properties.Resources.icons8_sign_language_c_48;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(568, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 52);
            this.button1.TabIndex = 6;
            this.button1.Text = "btnBroswer";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(738, 548);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mtbPhone);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.dtpWord);
            this.Controls.Add(this.radioGirl);
            this.Controls.Add(this.radioBoy);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPos);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.តួរនាទី);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "FormEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.FormEmployee_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RadioButton radioBoy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPos;
        private System.Windows.Forms.RadioButton radioGirl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label តួរនាទី;
        private System.Windows.Forms.DateTimePicker dtpWord;
        private System.Windows.Forms.MaskedTextBox mtbPhone;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

