﻿namespace Kursach
{
    partial class Form9
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
            this.ЗаказыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.KursachDataSet = new Kursach.KursachDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ЗаказыTableAdapter = new Kursach.KursachDataSetTableAdapters.ЗаказыTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ЗаказыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KursachDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ЗаказыBindingSource
            // 
            this.ЗаказыBindingSource.DataMember = "Заказы";
            this.ЗаказыBindingSource.DataSource = this.KursachDataSet;
            // 
            // KursachDataSet
            // 
            this.KursachDataSet.DataSetName = "KursachDataSet";
            this.KursachDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ЗаказыBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Kursach.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(20, 60);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(802, 438);
            this.reportViewer1.TabIndex = 0;
            // 
            // ЗаказыTableAdapter
            // 
            this.ЗаказыTableAdapter.ClearBeforeFill = true;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 518);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form9";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Отчет";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ЗаказыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KursachDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ЗаказыBindingSource;
        private KursachDataSet KursachDataSet;
        private KursachDataSetTableAdapters.ЗаказыTableAdapter ЗаказыTableAdapter;
    }
}