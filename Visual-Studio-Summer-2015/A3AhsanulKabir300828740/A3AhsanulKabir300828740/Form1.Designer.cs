namespace A3AhsanulKabir300828740
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
            this.label_LogName = new System.Windows.Forms.Label();
            this.label_LogItem = new System.Windows.Forms.Label();
            this.label_LogContent = new System.Windows.Forms.Label();
            this.radiobtn_Add = new System.Windows.Forms.RadioButton();
            this.radiobtn_Remove = new System.Windows.Forms.RadioButton();
            this.listbox_LogContent = new System.Windows.Forms.ListBox();
            this.textbox_LogName = new System.Windows.Forms.TextBox();
            this.textbox_LogItem = new System.Windows.Forms.TextBox();
            this.button_Process = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_LogName
            // 
            this.label_LogName.AutoSize = true;
            this.label_LogName.Location = new System.Drawing.Point(51, 40);
            this.label_LogName.Name = "label_LogName";
            this.label_LogName.Size = new System.Drawing.Size(56, 13);
            this.label_LogName.TabIndex = 0;
            this.label_LogName.Text = "Log Name";
            this.label_LogName.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_LogItem
            // 
            this.label_LogItem.AutoSize = true;
            this.label_LogItem.Location = new System.Drawing.Point(51, 82);
            this.label_LogItem.Name = "label_LogItem";
            this.label_LogItem.Size = new System.Drawing.Size(48, 13);
            this.label_LogItem.TabIndex = 1;
            this.label_LogItem.Text = "Log Item";
            // 
            // label_LogContent
            // 
            this.label_LogContent.AutoSize = true;
            this.label_LogContent.Location = new System.Drawing.Point(51, 183);
            this.label_LogContent.Name = "label_LogContent";
            this.label_LogContent.Size = new System.Drawing.Size(65, 13);
            this.label_LogContent.TabIndex = 2;
            this.label_LogContent.Text = "Log Content";
            // 
            // radiobtn_Add
            // 
            this.radiobtn_Add.AutoSize = true;
            this.radiobtn_Add.Location = new System.Drawing.Point(54, 133);
            this.radiobtn_Add.Name = "radiobtn_Add";
            this.radiobtn_Add.Size = new System.Drawing.Size(44, 17);
            this.radiobtn_Add.TabIndex = 3;
            this.radiobtn_Add.TabStop = true;
            this.radiobtn_Add.Text = "Add";
            this.radiobtn_Add.UseVisualStyleBackColor = true;
            this.radiobtn_Add.CheckedChanged += new System.EventHandler(this.radiobtn_Add_CheckedChanged);
            this.radiobtn_Add.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radiobtn_Add_MouseClick);
            // 
            // radiobtn_Remove
            // 
            this.radiobtn_Remove.AutoSize = true;
            this.radiobtn_Remove.Location = new System.Drawing.Point(151, 133);
            this.radiobtn_Remove.Name = "radiobtn_Remove";
            this.radiobtn_Remove.Size = new System.Drawing.Size(65, 17);
            this.radiobtn_Remove.TabIndex = 4;
            this.radiobtn_Remove.TabStop = true;
            this.radiobtn_Remove.Text = "Remove";
            this.radiobtn_Remove.UseVisualStyleBackColor = true;
            this.radiobtn_Remove.CheckedChanged += new System.EventHandler(this.radiobtn_Remove_CheckedChanged);
            // 
            // listbox_LogContent
            // 
            this.listbox_LogContent.FormattingEnabled = true;
            this.listbox_LogContent.Items.AddRange(new object[] {
            "Test1",
            "Test2"});
            this.listbox_LogContent.Location = new System.Drawing.Point(151, 183);
            this.listbox_LogContent.Name = "listbox_LogContent";
            this.listbox_LogContent.Size = new System.Drawing.Size(120, 95);
            this.listbox_LogContent.TabIndex = 5;
            // 
            // textbox_LogName
            // 
            this.textbox_LogName.Location = new System.Drawing.Point(151, 40);
            this.textbox_LogName.Name = "textbox_LogName";
            this.textbox_LogName.Size = new System.Drawing.Size(120, 20);
            this.textbox_LogName.TabIndex = 6;
            this.textbox_LogName.Text = "My Log";
            // 
            // textbox_LogItem
            // 
            this.textbox_LogItem.Location = new System.Drawing.Point(151, 82);
            this.textbox_LogItem.Name = "textbox_LogItem";
            this.textbox_LogItem.Size = new System.Drawing.Size(120, 20);
            this.textbox_LogItem.TabIndex = 7;
            this.textbox_LogItem.TextChanged += new System.EventHandler(this.textbox_LogItem_TextChanged);
            // 
            // button_Process
            // 
            this.button_Process.Location = new System.Drawing.Point(54, 297);
            this.button_Process.Name = "button_Process";
            this.button_Process.Size = new System.Drawing.Size(75, 23);
            this.button_Process.TabIndex = 8;
            this.button_Process.Text = "Process";
            this.button_Process.UseVisualStyleBackColor = true;
            this.button_Process.Click += new System.EventHandler(this.button_Process_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 343);
            this.Controls.Add(this.button_Process);
            this.Controls.Add(this.textbox_LogItem);
            this.Controls.Add(this.textbox_LogName);
            this.Controls.Add(this.listbox_LogContent);
            this.Controls.Add(this.radiobtn_Remove);
            this.Controls.Add(this.radiobtn_Add);
            this.Controls.Add(this.label_LogContent);
            this.Controls.Add(this.label_LogItem);
            this.Controls.Add(this.label_LogName);
            this.Name = "Form1";
            this.Text = "String Log Handler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_LogName;
        private System.Windows.Forms.Label label_LogItem;
        private System.Windows.Forms.Label label_LogContent;
        private System.Windows.Forms.RadioButton radiobtn_Add;
        private System.Windows.Forms.RadioButton radiobtn_Remove;
        private System.Windows.Forms.ListBox listbox_LogContent;
        private System.Windows.Forms.TextBox textbox_LogName;
        private System.Windows.Forms.TextBox textbox_LogItem;
        private System.Windows.Forms.Button button_Process;
    }
}

