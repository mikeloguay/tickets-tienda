namespace TiendaArreglos.Client.Wpf.Reporting
{
    partial class Report
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
            this.TicketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticketReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.TicketBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TicketBindingSource
            // 
            this.TicketBindingSource.DataSource = typeof(TiendaArreglos.Client.Model.Ticket);
            // 
            // ticketReportViewer
            // 
            this.ticketReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "TicketsDataSet";
            reportDataSource1.Value = this.TicketBindingSource;
            this.ticketReportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.ticketReportViewer.LocalReport.ReportEmbeddedResource = "TiendaArreglos.Client.Wpf.Reporting.Tickets.rdlc";
            this.ticketReportViewer.Location = new System.Drawing.Point(0, 0);
            this.ticketReportViewer.Name = "ticketReportViewer";
            this.ticketReportViewer.Size = new System.Drawing.Size(284, 262);
            this.ticketReportViewer.TabIndex = 0;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.ticketReportViewer);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TicketBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ticketReportViewer;

        private System.Windows.Forms.BindingSource TicketBindingSource;
    }
}