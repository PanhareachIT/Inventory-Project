namespace fromInventory
{
    partial class FromImport2
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.cmbProName = new System.Windows.Forms.ComboBox();
            this.cmbCate = new System.Windows.Forms.ComboBox();
            this.cmbSupName = new System.Windows.Forms.ComboBox();
            this.dtpImportDate = new System.Windows.Forms.DateTimePicker();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtProID = new System.Windows.Forms.TextBox();
            this.txtSupID = new System.Windows.Forms.TextBox();
            this.txtSupContact = new System.Windows.Forms.TextBox();
            this.txtImpID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ប្រភេទទំនិញ = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnNewSup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::fromInventory.Properties.Resources.icons8_plus_math_16;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(687, 214);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 36;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(57, 250);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(705, 193);
            this.listView1.TabIndex = 35;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // cmbProName
            // 
            this.cmbProName.FormattingEnabled = true;
            this.cmbProName.Location = new System.Drawing.Point(362, 213);
            this.cmbProName.Name = "cmbProName";
            this.cmbProName.Size = new System.Drawing.Size(104, 21);
            this.cmbProName.TabIndex = 34;
            this.cmbProName.SelectionChangeCommitted += new System.EventHandler(this.cmbProName_SelectionChangeCommitted);
            // 
            // cmbCate
            // 
            this.cmbCate.FormattingEnabled = true;
            this.cmbCate.Location = new System.Drawing.Point(57, 211);
            this.cmbCate.Name = "cmbCate";
            this.cmbCate.Size = new System.Drawing.Size(121, 21);
            this.cmbCate.TabIndex = 33;
            this.cmbCate.TextChanged += new System.EventHandler(this.cmbCate_TextChanged);
            // 
            // cmbSupName
            // 
            this.cmbSupName.FormattingEnabled = true;
            this.cmbSupName.Location = new System.Drawing.Point(206, 124);
            this.cmbSupName.Name = "cmbSupName";
            this.cmbSupName.Size = new System.Drawing.Size(138, 21);
            this.cmbSupName.TabIndex = 27;
            this.cmbSupName.SelectionChangeCommitted += new System.EventHandler(this.cmbSupName_SelectionChangeCommitted);
            // 
            // dtpImportDate
            // 
            this.dtpImportDate.CustomFormat = "dd//MM//yyyy";
            this.dtpImportDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpImportDate.Location = new System.Drawing.Point(205, 46);
            this.dtpImportDate.Name = "dtpImportDate";
            this.dtpImportDate.Size = new System.Drawing.Size(139, 20);
            this.dtpImportDate.TabIndex = 26;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(596, 214);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(80, 20);
            this.txtPrice.TabIndex = 24;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(682, 450);
            this.txtTotalPrice.Multiline = true;
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(67, 20);
            this.txtTotalPrice.TabIndex = 23;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(488, 214);
            this.txtQuantity.Multiline = true;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(102, 20);
            this.txtQuantity.TabIndex = 25;
            // 
            // txtProID
            // 
            this.txtProID.Location = new System.Drawing.Point(206, 211);
            this.txtProID.Multiline = true;
            this.txtProID.Name = "txtProID";
            this.txtProID.Size = new System.Drawing.Size(121, 20);
            this.txtProID.TabIndex = 22;
            this.txtProID.TextChanged += new System.EventHandler(this.txtProID_TextChanged);
            // 
            // txtSupID
            // 
            this.txtSupID.Location = new System.Drawing.Point(205, 89);
            this.txtSupID.Multiline = true;
            this.txtSupID.Name = "txtSupID";
            this.txtSupID.Size = new System.Drawing.Size(139, 20);
            this.txtSupID.TabIndex = 21;
            // 
            // txtSupContact
            // 
            this.txtSupContact.Location = new System.Drawing.Point(538, 5);
            this.txtSupContact.Multiline = true;
            this.txtSupContact.Name = "txtSupContact";
            this.txtSupContact.Size = new System.Drawing.Size(138, 61);
            this.txtSupContact.TabIndex = 20;
            // 
            // txtImpID
            // 
            this.txtImpID.Location = new System.Drawing.Point(206, 11);
            this.txtImpID.Multiline = true;
            this.txtImpID.Name = "txtImpID";
            this.txtImpID.Size = new System.Drawing.Size(139, 20);
            this.txtImpID.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Khmer OS Battambang", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "កាលបរិឆ្ឆេទនាំចូល";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Khmer OS Battambang", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "លេខសម្គាល់ប្រភពផ្គត់ផ្គង់";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Khmer OS Battambang", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "ឈ្មោះប្រភពផ្គត់ផ្គង់";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Khmer OS Battambang", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(372, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "លេខទំនាក់ទំនង";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(483, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 29);
            this.label9.TabIndex = 13;
            this.label9.Text = "បរិមាណ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(200, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 29);
            this.label7.TabIndex = 12;
            this.label7.Text = "លេខកូដទំនិញ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(591, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "តម្លៃ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(604, 450);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 29);
            this.label10.TabIndex = 10;
            this.label10.Text = "តម្លៃសរុប";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(357, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 29);
            this.label8.TabIndex = 9;
            this.label8.Text = "ឈ្មោះទំនិញ";
            // 
            // ប្រភេទទំនិញ
            // 
            this.ប្រភេទទំនិញ.AutoSize = true;
            this.ប្រភេទទំនិញ.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ប្រភេទទំនិញ.Location = new System.Drawing.Point(52, 177);
            this.ប្រភេទទំនិញ.Name = "ប្រភេទទំនិញ";
            this.ប្រភេទទំនិញ.Size = new System.Drawing.Size(95, 29);
            this.ប្រភេទទំនិញ.TabIndex = 18;
            this.ប្រភេទទំនិញ.Text = "ប្រភេទទំនិញ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Khmer OS Battambang", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "លេខសម្គាល់ការនាំចូល";
            // 
            // button3
            // 
            this.button3.Image = global::fromInventory.Properties.Resources.icons8_plus_math_16;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(686, 186);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 26);
            this.button3.TabIndex = 32;
            this.button3.Text = "add Item";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::fromInventory.Properties.Resources.icons8_plus_math_16;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(686, 72);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(59, 26);
            this.btnClose.TabIndex = 31;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Image = global::fromInventory.Properties.Resources.icons8_plus_math_16;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(686, 40);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(59, 26);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Image = global::fromInventory.Properties.Resources.icons8_plus_math_16;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(686, 5);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(59, 26);
            this.btnNew.TabIndex = 29;
            this.btnNew.Text = "New";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnNewSup
            // 
            this.btnNewSup.Image = global::fromInventory.Properties.Resources.icons8_plus_math_16;
            this.btnNewSup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewSup.Location = new System.Drawing.Point(376, 89);
            this.btnNewSup.Name = "btnNewSup";
            this.btnNewSup.Size = new System.Drawing.Size(109, 26);
            this.btnNewSup.TabIndex = 28;
            this.btnNewSup.Text = "New Supplier";
            this.btnNewSup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewSup.UseVisualStyleBackColor = true;
            this.btnNewSup.Click += new System.EventHandler(this.btnNewSup_Click);
            // 
            // FromImport2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 478);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.cmbProName);
            this.Controls.Add(this.cmbCate);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnNewSup);
            this.Controls.Add(this.cmbSupName);
            this.Controls.Add(this.dtpImportDate);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtProID);
            this.Controls.Add(this.txtSupID);
            this.Controls.Add(this.txtSupContact);
            this.Controls.Add(this.txtImpID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ប្រភេទទំនិញ);
            this.Controls.Add(this.label1);
            this.Name = "FromImport2";
            this.Text = "FromImport2";
            this.Load += new System.EventHandler(this.FromImport2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ComboBox cmbProName;
        private System.Windows.Forms.ComboBox cmbCate;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnNewSup;
        private System.Windows.Forms.ComboBox cmbSupName;
        private System.Windows.Forms.DateTimePicker dtpImportDate;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtProID;
        private System.Windows.Forms.TextBox txtSupID;
        private System.Windows.Forms.TextBox txtSupContact;
        private System.Windows.Forms.TextBox txtImpID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label ប្រភេទទំនិញ;
        private System.Windows.Forms.Label label1;
    }
}