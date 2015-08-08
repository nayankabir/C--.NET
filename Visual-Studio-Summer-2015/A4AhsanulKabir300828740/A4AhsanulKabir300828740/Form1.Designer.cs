namespace A4AhsanulKabir300828740
{
    partial class Form1
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
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.btnReport = new System.Windows.Forms.Button();
            this.lblSelect = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblSort = new System.Windows.Forms.Label();
            this.rbPrice = new System.Windows.Forms.RadioButton();
            this.rbYear = new System.Windows.Forms.RadioButton();
            this.lbxReport = new System.Windows.Forms.ListBox();
            this.table1BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.assignment4DataSetFinal = new A4AhsanulKabir300828740.Assignment4DataSetFinal();
            this.table1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.assignment4DataSet = new A4AhsanulKabir300828740.Assignment4DataSet();
            this.table1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_1TableAdapter = new A4AhsanulKabir300828740.Assignment4DataSetTableAdapters.Table_1TableAdapter();
            this.assignment4DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assignment4DataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.assignment4DataSetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.table_1TableAdapter1 = new A4AhsanulKabir300828740.Assignment4DataSetFinalTableAdapters.Table_1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignment4DataSetFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignment4DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignment4DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignment4DataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignment4DataSetBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(101, 70);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 20);
            this.txtTitle.TabIndex = 0;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(101, 107);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(100, 20);
            this.txtAuthor.TabIndex = 1;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(49, 143);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(152, 23);
            this.btnReport.TabIndex = 2;
            this.btnReport.Text = "Generate Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Location = new System.Drawing.Point(43, 13);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(161, 13);
            this.lblSelect.TabIndex = 3;
            this.lblSelect.Text = "Selection Criteria (Empty for ALL)";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(46, 70);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Title";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(46, 107);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(38, 13);
            this.lblAuthor.TabIndex = 5;
            this.lblAuthor.Text = "Author";
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.Location = new System.Drawing.Point(247, 13);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(44, 13);
            this.lblSort.TabIndex = 6;
            this.lblSort.Text = "Sort By:";
            // 
            // rbPrice
            // 
            this.rbPrice.AutoSize = true;
            this.rbPrice.Location = new System.Drawing.Point(250, 66);
            this.rbPrice.Name = "rbPrice";
            this.rbPrice.Size = new System.Drawing.Size(49, 17);
            this.rbPrice.TabIndex = 7;
            this.rbPrice.TabStop = true;
            this.rbPrice.Text = "Price";
            this.rbPrice.UseVisualStyleBackColor = true;
            // 
            // rbYear
            // 
            this.rbYear.AutoSize = true;
            this.rbYear.Location = new System.Drawing.Point(250, 107);
            this.rbYear.Name = "rbYear";
            this.rbYear.Size = new System.Drawing.Size(102, 17);
            this.rbYear.TabIndex = 8;
            this.rbYear.TabStop = true;
            this.rbYear.Text = "Publication Year";
            this.rbYear.UseVisualStyleBackColor = true;
            // 
            // lbxReport
            // 
            this.lbxReport.FormattingEnabled = true;
            this.lbxReport.Location = new System.Drawing.Point(46, 185);
            this.lbxReport.Name = "lbxReport";
            this.lbxReport.Size = new System.Drawing.Size(289, 82);
            this.lbxReport.TabIndex = 9;
            // 
            // table1BindingSource2
            // 
            this.table1BindingSource2.DataMember = "Table_1";
            this.table1BindingSource2.DataSource = this.assignment4DataSetFinal;
            // 
            // assignment4DataSetFinal
            // 
            this.assignment4DataSetFinal.DataSetName = "Assignment4DataSetFinal";
            this.assignment4DataSetFinal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table1BindingSource1
            // 
            this.table1BindingSource1.DataMember = "Table_1";
            this.table1BindingSource1.DataSource = this.assignment4DataSet;
            // 
            // assignment4DataSet
            // 
            this.assignment4DataSet.DataSetName = "Assignment4DataSet";
            this.assignment4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table1BindingSource
            // 
            this.table1BindingSource.DataMember = "Table_1";
            this.table1BindingSource.DataSource = this.assignment4DataSet;
            // 
            // table_1TableAdapter
            // 
            this.table_1TableAdapter.ClearBeforeFill = true;
            // 
            // assignment4DataSetBindingSource
            // 
            this.assignment4DataSetBindingSource.DataSource = this.assignment4DataSet;
            this.assignment4DataSetBindingSource.Position = 0;
            // 
            // assignment4DataSetBindingSource1
            // 
            this.assignment4DataSetBindingSource1.DataSource = this.assignment4DataSet;
            this.assignment4DataSetBindingSource1.Position = 0;
            // 
            // assignment4DataSetBindingSource2
            // 
            this.assignment4DataSetBindingSource2.DataSource = this.assignment4DataSet;
            this.assignment4DataSetBindingSource2.Position = 0;
            // 
            // table_1TableAdapter1
            // 
            this.table_1TableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 304);
            this.Controls.Add(this.lbxReport);
            this.Controls.Add(this.rbYear);
            this.Controls.Add(this.rbPrice);
            this.Controls.Add(this.lblSort);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtTitle);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Book Report";
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignment4DataSetFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignment4DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignment4DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignment4DataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignment4DataSetBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.RadioButton rbPrice;
        private System.Windows.Forms.RadioButton rbYear;
        private System.Windows.Forms.ListBox lbxReport;
        private Assignment4DataSet assignment4DataSet;
        private System.Windows.Forms.BindingSource table1BindingSource;
        private Assignment4DataSetTableAdapters.Table_1TableAdapter table_1TableAdapter;
        private System.Windows.Forms.BindingSource assignment4DataSetBindingSource;
        private System.Windows.Forms.BindingSource table1BindingSource1;
        private System.Windows.Forms.BindingSource assignment4DataSetBindingSource1;
        private System.Windows.Forms.BindingSource assignment4DataSetBindingSource2;
        private Assignment4DataSetFinal assignment4DataSetFinal;
        private System.Windows.Forms.BindingSource table1BindingSource2;
        private Assignment4DataSetFinalTableAdapters.Table_1TableAdapter table_1TableAdapter1;
    }
}

