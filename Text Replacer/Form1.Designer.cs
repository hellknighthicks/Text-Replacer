namespace Text_Replacer
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
            this.template_Button = new System.Windows.Forms.Button();
            this.templatepath = new System.Windows.Forms.TextBox();
            this.template_textBox = new System.Windows.Forms.RichTextBox();
            this.CSV_textBox = new System.Windows.Forms.RichTextBox();
            this.CSV_Button = new System.Windows.Forms.Button();
            this.CSVpath = new System.Windows.Forms.TextBox();
            this.itemnumbers_checkbox = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.info = new Infragistics.Win.Misc.UltraButton();
            this.preview_button = new Infragistics.Win.Misc.UltraButton();
            this.produce_window = new Infragistics.Win.Misc.UltraButton();
            this.produce_file_button = new Infragistics.Win.Misc.UltraButton();
            this.output_box = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.itemnumbers_checkbox)).BeginInit();
            this.SuspendLayout();
            // 
            // template_Button
            // 
            this.template_Button.Location = new System.Drawing.Point(15, 41);
            this.template_Button.Name = "template_Button";
            this.template_Button.Size = new System.Drawing.Size(130, 23);
            this.template_Button.TabIndex = 0;
            this.template_Button.Text = "Open a Template";
            this.template_Button.UseVisualStyleBackColor = true;
            this.template_Button.Click += new System.EventHandler(this.LoadTemplate_ButtonClick);
            // 
            // templatepath
            // 
            this.templatepath.Location = new System.Drawing.Point(15, 15);
            this.templatepath.Name = "templatepath";
            this.templatepath.ReadOnly = true;
            this.templatepath.Size = new System.Drawing.Size(435, 20);
            this.templatepath.TabIndex = 1;
            // 
            // template_textBox
            // 
            this.template_textBox.AcceptsTab = true;
            this.template_textBox.Location = new System.Drawing.Point(15, 75);
            this.template_textBox.Name = "template_textBox";
            this.template_textBox.Size = new System.Drawing.Size(435, 394);
            this.template_textBox.TabIndex = 2;
            this.template_textBox.Text = "";
            this.template_textBox.WordWrap = false;
            // 
            // CSV_textBox
            // 
            this.CSV_textBox.AcceptsTab = true;
            this.CSV_textBox.Location = new System.Drawing.Point(468, 75);
            this.CSV_textBox.Name = "CSV_textBox";
            this.CSV_textBox.Size = new System.Drawing.Size(456, 394);
            this.CSV_textBox.TabIndex = 3;
            this.CSV_textBox.Text = "";
            this.CSV_textBox.WordWrap = false;
            // 
            // CSV_Button
            // 
            this.CSV_Button.Location = new System.Drawing.Point(468, 41);
            this.CSV_Button.Name = "CSV_Button";
            this.CSV_Button.Size = new System.Drawing.Size(152, 23);
            this.CSV_Button.TabIndex = 4;
            this.CSV_Button.Text = "Import Values (CSV)";
            this.CSV_Button.UseVisualStyleBackColor = true;
            this.CSV_Button.Click += new System.EventHandler(this.LoadCSV_ButtonClick);
            // 
            // CSVpath
            // 
            this.CSVpath.Location = new System.Drawing.Point(468, 15);
            this.CSVpath.Name = "CSVpath";
            this.CSVpath.ReadOnly = true;
            this.CSVpath.Size = new System.Drawing.Size(456, 20);
            this.CSVpath.TabIndex = 5;
            // 
            // itemnumbers_checkbox
            // 
            this.itemnumbers_checkbox.Location = new System.Drawing.Point(950, 3);
            this.itemnumbers_checkbox.Name = "itemnumbers_checkbox";
            this.itemnumbers_checkbox.Size = new System.Drawing.Size(120, 20);
            this.itemnumbers_checkbox.TabIndex = 6;
            this.itemnumbers_checkbox.Text = "Item Numbers";
            // 
            // info
            // 
            this.info.Location = new System.Drawing.Point(950, 454);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(101, 23);
            this.info.TabIndex = 7;
            this.info.Text = "Info";
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // preview_button
            // 
            this.preview_button.Location = new System.Drawing.Point(950, 75);
            this.preview_button.Name = "preview_button";
            this.preview_button.Size = new System.Drawing.Size(101, 23);
            this.preview_button.TabIndex = 8;
            this.preview_button.Text = "Show Preview";
            this.preview_button.Click += new System.EventHandler(this.preview_button_Click);
            // 
            // produce_window
            // 
            this.produce_window.Location = new System.Drawing.Point(950, 104);
            this.produce_window.Name = "produce_window";
            this.produce_window.Size = new System.Drawing.Size(101, 23);
            this.produce_window.TabIndex = 9;
            this.produce_window.Text = "Produce";
            this.produce_window.Click += new System.EventHandler(this.produce_window_Click);
            // 
            // produce_file_button
            // 
            this.produce_file_button.Location = new System.Drawing.Point(950, 133);
            this.produce_file_button.Name = "produce_file_button";
            this.produce_file_button.Size = new System.Drawing.Size(101, 23);
            this.produce_file_button.TabIndex = 10;
            this.produce_file_button.Text = "Produce File";
            this.produce_file_button.Click += new System.EventHandler(this.produce_file_button_Click);
            // 
            // output_box
            // 
            this.output_box.Location = new System.Drawing.Point(15, 484);
            this.output_box.Name = "output_box";
            this.output_box.Size = new System.Drawing.Size(1036, 206);
            this.output_box.TabIndex = 11;
            this.output_box.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 711);
            this.Controls.Add(this.output_box);
            this.Controls.Add(this.produce_file_button);
            this.Controls.Add(this.produce_window);
            this.Controls.Add(this.preview_button);
            this.Controls.Add(this.info);
            this.Controls.Add(this.itemnumbers_checkbox);
            this.Controls.Add(this.CSVpath);
            this.Controls.Add(this.CSV_Button);
            this.Controls.Add(this.CSV_textBox);
            this.Controls.Add(this.template_textBox);
            this.Controls.Add(this.templatepath);
            this.Controls.Add(this.template_Button);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.itemnumbers_checkbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button template_Button;
        private System.Windows.Forms.TextBox templatepath;
        private System.Windows.Forms.RichTextBox template_textBox;
        private System.Windows.Forms.RichTextBox CSV_textBox;
        private System.Windows.Forms.Button CSV_Button;
        private System.Windows.Forms.TextBox CSVpath;
        private Infragistics.Win.UltraWinEditors.UltraCheckEditor itemnumbers_checkbox;
        private Infragistics.Win.Misc.UltraButton info;
        private Infragistics.Win.Misc.UltraButton preview_button;
        private Infragistics.Win.Misc.UltraButton produce_window;
        private Infragistics.Win.Misc.UltraButton produce_file_button;
        private System.Windows.Forms.RichTextBox output_box;
    }
}

