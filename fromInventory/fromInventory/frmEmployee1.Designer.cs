namespace fromInventory
{
    partial class frmEmployee1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.mtbPhone = new System.Windows.Forms.MaskedTextBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.dtpWord = new System.Windows.Forms.DateTimePicker();
            this.radioGirl = new System.Windows.Forms.RadioButton();
            this.radioBoy = new System.Windows.Forms.RadioButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPos = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.តួរនាទី = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 361);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(737, 162);
            this.dataGridView1.TabIndex = 41;
            this.dataGridView1.Tag = "*";
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(20, 311);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(737, 44);
            this.txtSearch.TabIndex = 40;
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // mtbPhone
            // 
            this.mtbPhone.Location = new System.Drawing.Point(384, 223);
            this.mtbPhone.Mask = "(000) 000-000";
            this.mtbPhone.Name = "mtbPhone";
            this.mtbPhone.Size = new System.Drawing.Size(143, 20);
            this.mtbPhone.TabIndex = 39;
            // 
            // dtpDOB
            // 
            this.dtpDOB.CustomFormat = "dd/MM/yy";
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOB.Location = new System.Drawing.Point(128, 183);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(143, 20);
            this.dtpDOB.TabIndex = 26;
            // 
            // dtpWord
            // 
            this.dtpWord.CustomFormat = "dd/MM/yy";
            this.dtpWord.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpWord.Location = new System.Drawing.Point(384, 183);
            this.dtpWord.Name = "dtpWord";
            this.dtpWord.Size = new System.Drawing.Size(143, 20);
            this.dtpWord.TabIndex = 38;
            // 
            // radioGirl
            // 
            this.radioGirl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioGirl.Location = new System.Drawing.Point(128, 148);
            this.radioGirl.Name = "radioGirl";
            this.radioGirl.Size = new System.Drawing.Size(70, 32);
            this.radioGirl.TabIndex = 24;
            this.radioGirl.TabStop = true;
            this.radioGirl.Text = "ស";
            this.radioGirl.UseVisualStyleBackColor = true;
            // 
            // radioBoy
            // 
            this.radioBoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBoy.Location = new System.Drawing.Point(201, 148);
            this.radioBoy.Name = "radioBoy";
            this.radioBoy.Size = new System.Drawing.Size(70, 32);
            this.radioBoy.TabIndex = 25;
            this.radioBoy.TabStop = true;
            this.radioBoy.Text = "ប";
            this.radioBoy.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(128, 108);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(143, 34);
            this.txtName.TabIndex = 22;
            // 
            // txtPos
            // 
            this.txtPos.Location = new System.Drawing.Point(128, 212);
            this.txtPos.Multiline = true;
            this.txtPos.Name = "txtPos";
            this.txtPos.Size = new System.Drawing.Size(143, 34);
            this.txtPos.TabIndex = 27;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(387, 110);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(143, 67);
            this.txtAddress.TabIndex = 36;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(384, 68);
            this.txtSalary.Multiline = true;
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(143, 34);
            this.txtSalary.TabIndex = 28;
            this.txtSalary.Enter += new System.EventHandler(this.txtSalary_Enter);
            this.txtSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalary_KeyPress);
            this.txtSalary.Leave += new System.EventHandler(this.txtSalary_Leave);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(128, 64);
            this.txtNum.Multiline = true;
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(143, 34);
            this.txtNum.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(291, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 27);
            this.label7.TabIndex = 21;
            this.label7.Text = "ប្រាក់ខែ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(288, 223);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 27);
            this.label10.TabIndex = 20;
            this.label10.Text = "លេខទូរស័ព្ធ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(291, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 27);
            this.label8.TabIndex = 19;
            this.label8.Text = "ថ្ងៃចូលធ្វើការ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(291, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 27);
            this.label6.TabIndex = 18;
            this.label6.Text = "អាសយដ្ឋាន";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 27);
            this.label4.TabIndex = 17;
            this.label4.Text = "អត្តលេខ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // តួរនាទី
            // 
            this.តួរនាទី.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.តួរនាទី.Location = new System.Drawing.Point(32, 219);
            this.តួរនាទី.Name = "តួរនាទី";
            this.តួរនាទី.Size = new System.Drawing.Size(77, 27);
            this.តួរនាទី.TabIndex = 16;
            this.តួរនាទី.Text = "តួរនាទី";
            this.តួរនាទី.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 27);
            this.label5.TabIndex = 15;
            this.label5.Text = "ថ្ងៃកំណើត";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 27);
            this.label3.TabIndex = 14;
            this.label3.Text = "ភេទ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 27);
            this.label2.TabIndex = 23;
            this.label2.Text = "ឈ្មោះ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(20, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 62);
            this.panel1.TabIndex = 12;
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
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(588, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Image = global::fromInventory.Properties.Resources.icons8_sign_language_c_48;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(497, 253);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(98, 52);
            this.btnPrint.TabIndex = 35;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnNew
            // 
            this.btnNew.Image = global::fromInventory.Properties.Resources.icons8_sign_language_c_48;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(24, 252);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(98, 52);
            this.btnNew.TabIndex = 34;
            this.btnNew.Tag = "*";
            this.btnNew.Text = "New";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Image = global::fromInventory.Properties.Resources.icons8_sign_language_c_48;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(625, 253);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(98, 52);
            this.btnClose.TabIndex = 33;
            this.btnClose.Tag = "*";
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::fromInventory.Properties.Resources.icons8_sign_language_c_48;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(270, 253);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(98, 52);
            this.btnEdit.TabIndex = 32;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::fromInventory.Properties.Resources.icons8_sign_language_c_48;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(384, 253);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 52);
            this.btnDelete.TabIndex = 31;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::fromInventory.Properties.Resources.icons8_sign_language_c_48;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(143, 253);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 52);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button1
            // 
            this.button1.Image = global::fromInventory.Properties.Resources.icons8_sign_language_c_48;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(588, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 52);
            this.button1.TabIndex = 29;
            this.button1.Text = "btnBroswer";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmEmployee1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 522);
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
            this.Name = "frmEmployee1";
            this.Text = "frmEmployee1";
            this.Load += new System.EventHandler(this.frmEmployee1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox mtbPhone;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.DateTimePicker dtpWord;
        private System.Windows.Forms.RadioButton radioGirl;
        private System.Windows.Forms.RadioButton radioBoy;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPos;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label តួរនាទី;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}