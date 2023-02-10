namespace fromInventory
{
    partial class frmSaleInvoice
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dtInvoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsInvoice = new fromInventory.dsInvoice();
            this.rptViewerSaleInvoice = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.dtInvoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // dtInvoiceBindingSource
            // 
            this.dtInvoiceBindingSource.DataMember = "dtInvoice";
            this.dtInvoiceBindingSource.DataSource = this.dsInvoice;
            // 
            // dsInvoice
            // 
            this.dsInvoice.DataSetName = "dsInvoice";
            this.dsInvoice.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rptViewerSaleInvoice
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dtInvoiceBindingSource;
            this.rptViewerSaleInvoice.LocalReport.DataSources.Add(reportDataSource1);
            this.rptViewerSaleInvoice.LocalReport.ReportEmbeddedResource = "fromInventory.rptSaleInvoice.rdlc";
            this.rptViewerSaleInvoice.Location = new System.Drawing.Point(12, 1);
            this.rptViewerSaleInvoice.Name = "rptViewerSaleInvoice";
            this.rptViewerSaleInvoice.Size = new System.Drawing.Size(742, 404);
            this.rptViewerSaleInvoice.TabIndex = 0;
            this.rptViewerSaleInvoice.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // frmSaleInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 417);
            this.Controls.Add(this.rptViewerSaleInvoice);
            this.Name = "frmSaleInvoice";
            this.Text = "frmSaleInvoice";
            this.Load += new System.EventHandler(this.frmSaleInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtInvoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInvoice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource dtInvoiceBindingSource;
        private dsInvoice dsInvoice;
        public Microsoft.Reporting.WinForms.ReportViewer rptViewerSaleInvoice;
    }
}