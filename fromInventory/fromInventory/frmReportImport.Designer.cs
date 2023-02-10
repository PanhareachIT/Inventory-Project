namespace fromInventory
{
    partial class frmReportImport
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
            this.components = new System.ComponentModel.Container();
            this.dsInvoice = new fromInventory.dsInvoice();
            this.dtInvoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.dsInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInvoiceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dsInvoice
            // 
            this.dsInvoice.DataSetName = "dsInvoice";
            this.dsInvoice.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtInvoiceBindingSource
            // 
            this.dtInvoiceBindingSource.DataMember = "dtInvoice";
            this.dtInvoiceBindingSource.DataSource = this.dsInvoice;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "fromInventory.rptImport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(751, 416);
            this.reportViewer1.TabIndex = 1;
            // 
            // frmReportImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 416);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReportImport";
            this.Text = "frmReportImport";
            this.Load += new System.EventHandler(this.frmReportImport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInvoiceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource dtInvoiceBindingSource;
        private dsInvoice dsInvoice;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}