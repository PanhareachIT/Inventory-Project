namespace fromInventory
{
    partial class frmRptEmpList
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rptViewerEmpList = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsEmployee = new fromInventory.dsEmployee();
            this.dtEmployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dsEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEmployeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rptViewerEmpList
            // 
            reportDataSource1.Name = "dsEmpList";
            reportDataSource1.Value = this.dtEmployeeBindingSource;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.dtEmployeeBindingSource;
            this.rptViewerEmpList.LocalReport.DataSources.Add(reportDataSource1);
            this.rptViewerEmpList.LocalReport.DataSources.Add(reportDataSource2);
            this.rptViewerEmpList.LocalReport.ReportEmbeddedResource = "fromInventory.rptEmpList.rdlc";
            this.rptViewerEmpList.Location = new System.Drawing.Point(2, 3);
            this.rptViewerEmpList.Name = "rptViewerEmpList";
            this.rptViewerEmpList.Size = new System.Drawing.Size(699, 411);
            this.rptViewerEmpList.TabIndex = 0;
            // 
            // dsEmployee
            // 
            this.dsEmployee.DataSetName = "dsEmployee";
            this.dsEmployee.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtEmployeeBindingSource
            // 
            this.dtEmployeeBindingSource.DataMember = "dtEmployee";
            this.dtEmployeeBindingSource.DataSource = this.dsEmployee;
            // 
            // frmRptEmpList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 411);
            this.Controls.Add(this.rptViewerEmpList);
            this.Name = "frmRptEmpList";
            this.Text = "frmRptEmpList";
            this.Load += new System.EventHandler(this.frmRptEmpList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEmployeeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer rptViewerEmpList;
        private System.Windows.Forms.BindingSource dtEmployeeBindingSource;
        private dsEmployee dsEmployee;

    }
}