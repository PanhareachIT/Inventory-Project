namespace fromInventory
{
    partial class ImportForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dtpImportDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSupID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbSupName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRelation = new System.Windows.Forms.TextBox();
            this.ប្រភេទទំនិញ = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbProType = new System.Windows.Forms.ComboBox();
            this.cmbProName = new System.Windows.Forms.ComboBox();
            this.txtProCode = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnNewSup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Khmer OS Battambang", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "លេខសម្គាល់ការនាំចូល";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(178, 39);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dtpImportDate
            // 
            this.dtpImportDate.CustomFormat = "dd//MM//yyyy";
            this.dtpImportDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpImportDate.Location = new System.Drawing.Point(178, 80);
            this.dtpImportDate.Name = "dtpImportDate";
            this.dtpImportDate.Size = new System.Drawing.Size(139, 20);
            this.dtpImportDate.TabIndex = 2;
            this.dtpImportDate.ValueChanged += new System.EventHandler(this.dtpImportDate_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Khmer OS Battambang", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "កាលបរិឆ្ឆេទនាំចូល";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Khmer OS Battambang", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "ឈ្មោះប្រភពផ្គត់ផ្គង់";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtSupID
            // 
            this.txtSupID.Location = new System.Drawing.Point(178, 123);
            this.txtSupID.Multiline = true;
            this.txtSupID.Name = "txtSupID";
            this.txtSupID.Size = new System.Drawing.Size(139, 20);
            this.txtSupID.TabIndex = 1;
            this.txtSupID.TextChanged += new System.EventHandler(this.txtSupID_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Khmer OS Battambang", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "លេខសម្គាល់ប្រភពផ្គត់ផ្គង់";
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // cmbSupName
            // 
            this.cmbSupName.FormattingEnabled = true;
            this.cmbSupName.Location = new System.Drawing.Point(179, 158);
            this.cmbSupName.Name = "cmbSupName";
            this.cmbSupName.Size = new System.Drawing.Size(138, 21);
            this.cmbSupName.TabIndex = 3;
            this.cmbSupName.SelectedIndexChanged += new System.EventHandler(this.cmbimportID_SelectedIndexChanged);
            this.cmbSupName.SelectionChangeCommitted += new System.EventHandler(this.cmbimportID_SelectionChangeCommitted);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Khmer OS Battambang", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(345, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "លេខសម្គាល់ការនាំចូល";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtRelation
            // 
            this.txtRelation.Location = new System.Drawing.Point(511, 39);
            this.txtRelation.Multiline = true;
            this.txtRelation.Name = "txtRelation";
            this.txtRelation.Size = new System.Drawing.Size(138, 61);
            this.txtRelation.TabIndex = 1;
            this.txtRelation.TextChanged += new System.EventHandler(this.txtRelation_TextChanged);
            // 
            // ប្រភេទទំនិញ
            // 
            this.ប្រភេទទំនិញ.AutoSize = true;
            this.ប្រភេទទំនិញ.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ប្រភេទទំនិញ.Location = new System.Drawing.Point(25, 211);
            this.ប្រភេទទំនិញ.Name = "ប្រភេទទំនិញ";
            this.ប្រភេទទំនិញ.Size = new System.Drawing.Size(95, 29);
            this.ប្រភេទទំនិញ.TabIndex = 0;
            this.ប្រភេទទំនិញ.Text = "ប្រភេទទំនិញ";
            this.ប្រភេទទំនិញ.Click += new System.EventHandler(this.ប្រភេទទំនិញ_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(173, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 29);
            this.label7.TabIndex = 0;
            this.label7.Text = "លេខកូដទំនិញ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(330, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 29);
            this.label8.TabIndex = 0;
            this.label8.Text = "ឈ្មោះទំនិញ";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(456, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 29);
            this.label9.TabIndex = 0;
            this.label9.Text = "បរិមាណ";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(577, 484);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 29);
            this.label10.TabIndex = 0;
            this.label10.Text = "តម្លៃសរុប";
            this.label10.Click += new System.EventHandler(this.label8_Click);
            // 
            // cmbProType
            // 
            this.cmbProType.FormattingEnabled = true;
            this.cmbProType.Location = new System.Drawing.Point(30, 245);
            this.cmbProType.Name = "cmbProType";
            this.cmbProType.Size = new System.Drawing.Size(121, 21);
            this.cmbProType.TabIndex = 5;
            this.cmbProType.SelectedIndexChanged += new System.EventHandler(this.cmbProType_SelectedIndexChanged);
            // 
            // cmbProName
            // 
            this.cmbProName.FormattingEnabled = true;
            this.cmbProName.Location = new System.Drawing.Point(335, 247);
            this.cmbProName.Name = "cmbProName";
            this.cmbProName.Size = new System.Drawing.Size(104, 21);
            this.cmbProName.TabIndex = 5;
            this.cmbProName.SelectedIndexChanged += new System.EventHandler(this.cmbProName_SelectedIndexChanged);
            this.cmbProName.SelectionChangeCommitted += new System.EventHandler(this.cmbProName_SelectionChangeCommitted);
            // 
            // txtProCode
            // 
            this.txtProCode.Location = new System.Drawing.Point(178, 245);
            this.txtProCode.Multiline = true;
            this.txtProCode.Name = "txtProCode";
            this.txtProCode.Size = new System.Drawing.Size(121, 20);
            this.txtProCode.TabIndex = 1;
            this.txtProCode.TextChanged += new System.EventHandler(this.txtProCode_TextChanged);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(461, 248);
            this.txtQuantity.Multiline = true;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(102, 20);
            this.txtQuantity.TabIndex = 1;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(655, 484);
            this.txtTotalPrice.Multiline = true;
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(67, 20);
            this.txtTotalPrice.TabIndex = 1;
            this.txtTotalPrice.TextChanged += new System.EventHandler(this.txtTotalPrice_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(564, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "តម្លៃ";
            this.label6.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(569, 248);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(80, 20);
            this.txtPrice.TabIndex = 1;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(30, 284);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(705, 193);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(660, 248);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "button1";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // button3
            // 
            this.button3.Image = global::fromInventory.Properties.Resources.icons8_plus_math_16;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(659, 220);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 26);
            this.button3.TabIndex = 4;
            this.button3.Text = "add Item";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::fromInventory.Properties.Resources.icons8_plus_math_16;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(659, 106);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(59, 26);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::fromInventory.Properties.Resources.icons8_plus_math_16;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(659, 74);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(59, 26);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Image = global::fromInventory.Properties.Resources.icons8_plus_math_16;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(659, 39);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(59, 26);
            this.btnNew.TabIndex = 4;
            this.btnNew.Text = "New";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.UseVisualStyleBackColor = true;
           
            // 
            // btnNewSup
            // 
            this.btnNewSup.Image = global::fromInventory.Properties.Resources.icons8_plus_math_16;
            this.btnNewSup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewSup.Location = new System.Drawing.Point(349, 123);
            this.btnNewSup.Name = "btnNewSup";
            this.btnNewSup.Size = new System.Drawing.Size(109, 26);
            this.btnNewSup.TabIndex = 4;
            this.btnNewSup.Text = "New Supplier";
            this.btnNewSup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewSup.UseVisualStyleBackColor = true;
            
            // 
            // ImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 522);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.cmbProName);
            this.Controls.Add(this.cmbProType);
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
            this.Controls.Add(this.txtProCode);
            this.Controls.Add(this.txtSupID);
            this.Controls.Add(this.txtRelation);
            this.Controls.Add(this.textBox1);
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
            this.Name = "ImportForm";
            this.Text = "ImportForm";
            this.Load += new System.EventHandler(this.ImportForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dtpImportDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSupID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbSupName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRelation;
        private System.Windows.Forms.Button btnNewSup;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label ប្រភេទទំនិញ;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbProType;
        private System.Windows.Forms.ComboBox cmbProName;
        private System.Windows.Forms.TextBox txtProCode;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnDelete;
    }
}