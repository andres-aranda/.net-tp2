namespace Academia.UI.Desktop.Reportes
{
    partial class Reporte
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
            this.rptReport = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptReport
            // 
            this.rptReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptReport.LocalReport.ReportEmbeddedResource = "Academia.UI.Desktop.Reportes.ReportMaterias.rdlc";
            this.rptReport.Location = new System.Drawing.Point(0, 0);
            this.rptReport.Margin = new System.Windows.Forms.Padding(2);
            this.rptReport.Name = "rptReport";
            this.rptReport.ServerReport.BearerToken = null;
            this.rptReport.Size = new System.Drawing.Size(600, 366);
            this.rptReport.TabIndex = 0;
            this.rptReport.Load += new System.EventHandler(this.rptReport_Load);
            // 
            // Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.rptReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Reporte";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Reporte";
            this.Load += new System.EventHandler(this.Reporte_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer rptReport;
    }
}