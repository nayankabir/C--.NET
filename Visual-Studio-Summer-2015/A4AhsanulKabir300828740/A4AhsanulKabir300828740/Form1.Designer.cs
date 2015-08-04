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
            this.inputTxtBox_Title = new System.Windows.Forms.TextBox();
            this.inputTxtBox_Author = new System.Windows.Forms.TextBox();
            this.btn_generateReport = new System.Windows.Forms.Button();
            this.label_selectionCriteria = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radiobtn_Price = new System.Windows.Forms.RadioButton();
            this.radioBtn_PublicationYr = new System.Windows.Forms.RadioButton();
            this.outputListBox_Report = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // inputTxtBox_Title
            // 
            this.inputTxtBox_Title.Location = new System.Drawing.Point(101, 70);
            this.inputTxtBox_Title.Name = "inputTxtBox_Title";
            this.inputTxtBox_Title.Size = new System.Drawing.Size(100, 20);
            this.inputTxtBox_Title.TabIndex = 0;
            // 
            // inputTxtBox_Author
            // 
            this.inputTxtBox_Author.Location = new System.Drawing.Point(101, 107);
            this.inputTxtBox_Author.Name = "inputTxtBox_Author";
            this.inputTxtBox_Author.Size = new System.Drawing.Size(100, 20);
            this.inputTxtBox_Author.TabIndex = 1;
            // 
            // btn_generateReport
            // 
            this.btn_generateReport.Location = new System.Drawing.Point(49, 143);
            this.btn_generateReport.Name = "btn_generateReport";
            this.btn_generateReport.Size = new System.Drawing.Size(152, 23);
            this.btn_generateReport.TabIndex = 2;
            this.btn_generateReport.Text = "Generate Report";
            this.btn_generateReport.UseVisualStyleBackColor = true;
            // 
            // label_selectionCriteria
            // 
            this.label_selectionCriteria.AutoSize = true;
            this.label_selectionCriteria.Location = new System.Drawing.Point(43, 13);
            this.label_selectionCriteria.Name = "label_selectionCriteria";
            this.label_selectionCriteria.Size = new System.Drawing.Size(161, 13);
            this.label_selectionCriteria.TabIndex = 3;
            this.label_selectionCriteria.Text = "Selection Criteria (Empty for ALL)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Author";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sort By:";
            // 
            // radiobtn_Price
            // 
            this.radiobtn_Price.AutoSize = true;
            this.radiobtn_Price.Location = new System.Drawing.Point(250, 66);
            this.radiobtn_Price.Name = "radiobtn_Price";
            this.radiobtn_Price.Size = new System.Drawing.Size(49, 17);
            this.radiobtn_Price.TabIndex = 7;
            this.radiobtn_Price.TabStop = true;
            this.radiobtn_Price.Text = "Price";
            this.radiobtn_Price.UseVisualStyleBackColor = true;
            // 
            // radioBtn_PublicationYr
            // 
            this.radioBtn_PublicationYr.AutoSize = true;
            this.radioBtn_PublicationYr.Location = new System.Drawing.Point(250, 107);
            this.radioBtn_PublicationYr.Name = "radioBtn_PublicationYr";
            this.radioBtn_PublicationYr.Size = new System.Drawing.Size(102, 17);
            this.radioBtn_PublicationYr.TabIndex = 8;
            this.radioBtn_PublicationYr.TabStop = true;
            this.radioBtn_PublicationYr.Text = "Publication Year";
            this.radioBtn_PublicationYr.UseVisualStyleBackColor = true;
            // 
            // outputListBox_Report
            // 
            this.outputListBox_Report.FormattingEnabled = true;
            this.outputListBox_Report.Location = new System.Drawing.Point(46, 185);
            this.outputListBox_Report.Name = "outputListBox_Report";
            this.outputListBox_Report.Size = new System.Drawing.Size(289, 82);
            this.outputListBox_Report.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 304);
            this.Controls.Add(this.outputListBox_Report);
            this.Controls.Add(this.radioBtn_PublicationYr);
            this.Controls.Add(this.radiobtn_Price);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_selectionCriteria);
            this.Controls.Add(this.btn_generateReport);
            this.Controls.Add(this.inputTxtBox_Author);
            this.Controls.Add(this.inputTxtBox_Title);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Book Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTxtBox_Title;
        private System.Windows.Forms.TextBox inputTxtBox_Author;
        private System.Windows.Forms.Button btn_generateReport;
        private System.Windows.Forms.Label label_selectionCriteria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radiobtn_Price;
        private System.Windows.Forms.RadioButton radioBtn_PublicationYr;
        private System.Windows.Forms.ListBox outputListBox_Report;
    }
}

