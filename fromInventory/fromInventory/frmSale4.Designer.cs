namespace fromInventory
{
    partial class frmSale4
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
            this.label11 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.cmbCate = new System.Windows.Forms.ComboBox();
            this.cmbProName = new System.Windows.Forms.ComboBox();
            this.cmbCusName = new System.Windows.Forms.ComboBox();
            this.dtpsaleDate = new System.Windows.Forms.DateTimePicker();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtProID = new System.Windows.Forms.TextBox();
            this.txtCusID = new System.Windows.Forms.TextBox();
            this.txtCusContact = new System.Windows.Forms.TextBox();
            this.txtSaleInvoice = new System.Windows.Forms.TextBox();
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
            this.btnButoon = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnNewSup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(33, 169);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(705, 50);
            this.label11.TabIndex = 126;
            this.label11.Text = "ព័ត៍មានទំនិញ";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(38, 303);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(705, 193);
            this.listView1.TabIndex = 125;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // cmbCate
            // 
            this.cmbCate.FormattingEnabled = true;
            this.cmbCate.Location = new System.Drawing.Point(543, 261);
            this.cmbCate.Name = "cmbCate";
            this.cmbCate.Size = new System.Drawing.Size(104, 21);
            this.cmbCate.TabIndex = 124;
            this.cmbCate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbCate_KeyPress);
            this.cmbCate.Leave += new System.EventHandler(this.cmbCate_Leave);
            // 
            // cmbProName
            // 
            this.cmbProName.FormattingEnabled = true;
            this.cmbProName.Location = new System.Drawing.Point(176, 262);
            this.cmbProName.Name = "cmbProName";
            this.cmbProName.Size = new System.Drawing.Size(121, 21);
            this.cmbProName.TabIndex = 123;
            this.cmbProName.SelectionChangeCommitted += new System.EventHandler(this.cmbProName_SelectionChangeCommitted);
            // 
            // cmbCusName
            // 
            this.cmbCusName.FormattingEnabled = true;
            this.cmbCusName.Location = new System.Drawing.Point(187, 131);
            this.cmbCusName.Name = "cmbCusName";
            this.cmbCusName.Size = new System.Drawing.Size(138, 21);
            this.cmbCusName.TabIndex = 116;
            this.cmbCusName.SelectionChangeCommitted += new System.EventHandler(this.cmbCusName_SelectionChangeCommitted);
            // 
            // dtpsaleDate
            // 
            this.dtpsaleDate.CustomFormat = "dd//MM//yyyy";
            this.dtpsaleDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpsaleDate.Location = new System.Drawing.Point(186, 53);
            this.dtpsaleDate.Name = "dtpsaleDate";
            this.dtpsaleDate.Size = new System.Drawing.Size(139, 20);
            this.dtpsaleDate.TabIndex = 115;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(449, 262);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(80, 20);
            this.txtPrice.TabIndex = 113;
            this.txtPrice.Enter += new System.EventHandler(this.txtPrice_Enter);
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            this.txtPrice.Leave += new System.EventHandler(this.txtPrice_Leave);
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(667, 502);
            this.txtTotalPrice.Multiline = true;
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(67, 20);
            this.txtTotalPrice.TabIndex = 112;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(325, 262);
            this.txtQuantity.Multiline = true;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(102, 20);
            this.txtQuantity.TabIndex = 114;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // txtProID
            // 
            this.txtProID.Location = new System.Drawing.Point(38, 263);
            this.txtProID.Multiline = true;
            this.txtProID.Name = "txtProID";
            this.txtProID.Size = new System.Drawing.Size(121, 20);
            this.txtProID.TabIndex = 111;
            this.txtProID.TextChanged += new System.EventHandler(this.txtProID_TextChanged);
            // 
            // txtCusID
            // 
            this.txtCusID.Location = new System.Drawing.Point(187, 91);
            this.txtCusID.Multiline = true;
            this.txtCusID.Name = "txtCusID";
            this.txtCusID.Size = new System.Drawing.Size(139, 20);
            this.txtCusID.TabIndex = 110;
            // 
            // txtCusContact
            // 
            this.txtCusContact.Location = new System.Drawing.Point(509, 16);
            this.txtCusContact.Multiline = true;
            this.txtCusContact.Name = "txtCusContact";
            this.txtCusContact.Size = new System.Drawing.Size(138, 61);
            this.txtCusContact.TabIndex = 109;
            // 
            // txtSaleInvoice
            // 
            this.txtSaleInvoice.Location = new System.Drawing.Point(186, 12);
            this.txtSaleInvoice.Multiline = true;
            this.txtSaleInvoice.Name = "txtSaleInvoice";
            this.txtSaleInvoice.Size = new System.Drawing.Size(139, 20);
            this.txtSaleInvoice.TabIndex = 108;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Khmer OS Battambang", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 24);
            this.label2.TabIndex = 106;
            this.label2.Text = "កាលបរិឆ្ឆេទលក់";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Khmer OS Battambang", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 24);
            this.label4.TabIndex = 105;
            this.label4.Text = "លេខសម្គាល់អតិថជន";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Khmer OS Battambang", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 24);
            this.label3.TabIndex = 104;
            this.label3.Text = "ឈ្មោះអថិជន";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Khmer OS Battambang", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(369, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 24);
            this.label5.TabIndex = 103;
            this.label5.Text = "ទំនាក់​ទំនង";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(320, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 29);
            this.label9.TabIndex = 102;
            this.label9.Text = "បរិមាណ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(538, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 29);
            this.label7.TabIndex = 101;
            this.label7.Text = "ប្រភេទទំនិញ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(444, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 29);
            this.label6.TabIndex = 100;
            this.label6.Text = "តម្លៃ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(585, 496);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 29);
            this.label10.TabIndex = 99;
            this.label10.Text = "តម្លៃសរុប";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(171, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 29);
            this.label8.TabIndex = 98;
            this.label8.Text = "ឈ្មោះទំនិញ";
            // 
            // ប្រភេទទំនិញ
            // 
            this.ប្រភេទទំនិញ.AutoSize = true;
            this.ប្រភេទទំនិញ.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ប្រភេទទំនិញ.Location = new System.Drawing.Point(33, 225);
            this.ប្រភេទទំនិញ.Name = "ប្រភេទទំនិញ";
            this.ប្រភេទទំនិញ.Size = new System.Drawing.Size(107, 29);
            this.ប្រភេទទំនិញ.TabIndex = 107;
            this.ប្រភេទទំនិញ.Text = "លេខកូដទំនិញ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Khmer OS Battambang", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 97;
            this.label1.Text = "លេខវិក័យបត្រ";
            // 
            // btnButoon
            // 
            this.btnButoon.Image = global::fromInventory.Properties.Resources.icons8_plus_math_16;
            this.btnButoon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnButoon.Location = new System.Drawing.Point(663, 254);
            this.btnButoon.Name = "btnButoon";
            this.btnButoon.Size = new System.Drawing.Size(71, 26);
            this.btnButoon.TabIndex = 122;
            this.btnButoon.Text = "Remove";
            this.btnButoon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnButoon.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Image = global::fromInventory.Properties.Resources.icons8_plus_math_16;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(658, 222);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 26);
            this.button3.TabIndex = 121;
            this.button3.Text = "add Item";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::fromInventory.Properties.Resources.icons8_plus_math_16;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(667, 79);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(59, 26);
            this.btnClose.TabIndex = 120;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Image = global::fromInventory.Properties.Resources.icons8_plus_math_16;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(667, 47);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(59, 26);
            this.btnSave.TabIndex = 119;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Image = global::fromInventory.Properties.Resources.icons8_plus_math_16;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(667, 12);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(59, 26);
            this.btnNew.TabIndex = 118;
            this.btnNew.Text = "New";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnNewSup
            // 
            this.btnNewSup.Image = global::fromInventory.Properties.Resources.icons8_plus_math_16;
            this.btnNewSup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewSup.Location = new System.Drawing.Point(373, 93);
            this.btnNewSup.Name = "btnNewSup";
            this.btnNewSup.Size = new System.Drawing.Size(109, 26);
            this.btnNewSup.TabIndex = 117;
            this.btnNewSup.Text = "New Customer";
            this.btnNewSup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewSup.UseVisualStyleBackColor = true;
            this.btnNewSup.Click += new System.EventHandler(this.btnNewSup_Click);
            // 
            // frmSale4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 531);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.cmbCate);
            this.Controls.Add(this.cmbProName);
            this.Controls.Add(this.btnButoon);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnNewSup);
            this.Controls.Add(this.cmbCusName);
            this.Controls.Add(this.dtpsaleDate);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtProID);
            this.Controls.Add(this.txtCusID);
            this.Controls.Add(this.txtCusContact);
            this.Controls.Add(this.txtSaleInvoice);
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
            this.Name = "frmSale4";
            this.Text = "frmSale4";
            this.Load += new System.EventHandler(this.frmSale4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ComboBox cmbCate;
        private System.Windows.Forms.ComboBox cmbProName;
        private System.Windows.Forms.Button btnButoon;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnNewSup;
        private System.Windows.Forms.ComboBox cmbCusName;
        private System.Windows.Forms.DateTimePicker dtpsaleDate;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtProID;
        private System.Windows.Forms.TextBox txtCusID;
        private System.Windows.Forms.TextBox txtCusContact;
        private System.Windows.Forms.TextBox txtSaleInvoice;
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