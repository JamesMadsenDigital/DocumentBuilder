namespace DocumentBuilder.Forms
{
    partial class Form_Export
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Export));
            this.Button_Export = new System.Windows.Forms.Button();
            this.Button_CancelExport = new System.Windows.Forms.Button();
            this.Group_ExportSettings = new System.Windows.Forms.GroupBox();
            this.Label_ExportAs = new System.Windows.Forms.Label();
            this.List_ExportAs = new System.Windows.Forms.ComboBox();
            this.Check_Overwrite = new System.Windows.Forms.CheckBox();
            this.Check_CreateDirectory = new System.Windows.Forms.CheckBox();
            this.Button_SelectExportDirectory = new System.Windows.Forms.Button();
            this.Check_OpenAfterExport = new System.Windows.Forms.CheckBox();
            this.Text_ExportLocation = new System.Windows.Forms.TextBox();
            this.Label_ExportLocation = new System.Windows.Forms.Label();
            this.Text_DocumentName = new System.Windows.Forms.TextBox();
            this.Label_DocumentName = new System.Windows.Forms.Label();
            this.Label_ExportPages = new System.Windows.Forms.Label();
            this.CheckList_ExportPages = new System.Windows.Forms.CheckedListBox();
            this.Group_ExportSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button_Export
            // 
            this.Button_Export.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Export.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Export.Location = new System.Drawing.Point(603, 480);
            this.Button_Export.Name = "Button_Export";
            this.Button_Export.Size = new System.Drawing.Size(174, 32);
            this.Button_Export.TabIndex = 5;
            this.Button_Export.Text = "Export";
            this.Button_Export.UseVisualStyleBackColor = true;
            this.Button_Export.Click += new System.EventHandler(this.Button_Export_Click);
            // 
            // Button_CancelExport
            // 
            this.Button_CancelExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_CancelExport.Location = new System.Drawing.Point(423, 480);
            this.Button_CancelExport.Name = "Button_CancelExport";
            this.Button_CancelExport.Size = new System.Drawing.Size(174, 32);
            this.Button_CancelExport.TabIndex = 6;
            this.Button_CancelExport.Text = "Cancel";
            this.Button_CancelExport.UseVisualStyleBackColor = true;
            this.Button_CancelExport.Click += new System.EventHandler(this.Button_CancelExport_Click);
            // 
            // Group_ExportSettings
            // 
            this.Group_ExportSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Group_ExportSettings.Controls.Add(this.Label_ExportAs);
            this.Group_ExportSettings.Controls.Add(this.List_ExportAs);
            this.Group_ExportSettings.Controls.Add(this.Check_Overwrite);
            this.Group_ExportSettings.Controls.Add(this.Check_CreateDirectory);
            this.Group_ExportSettings.Controls.Add(this.Button_SelectExportDirectory);
            this.Group_ExportSettings.Controls.Add(this.Check_OpenAfterExport);
            this.Group_ExportSettings.Controls.Add(this.Text_ExportLocation);
            this.Group_ExportSettings.Controls.Add(this.Label_ExportLocation);
            this.Group_ExportSettings.Controls.Add(this.Text_DocumentName);
            this.Group_ExportSettings.Controls.Add(this.Label_DocumentName);
            this.Group_ExportSettings.Controls.Add(this.Label_ExportPages);
            this.Group_ExportSettings.Controls.Add(this.CheckList_ExportPages);
            this.Group_ExportSettings.Location = new System.Drawing.Point(12, 12);
            this.Group_ExportSettings.Name = "Group_ExportSettings";
            this.Group_ExportSettings.Size = new System.Drawing.Size(763, 452);
            this.Group_ExportSettings.TabIndex = 7;
            this.Group_ExportSettings.TabStop = false;
            // 
            // Label_ExportAs
            // 
            this.Label_ExportAs.AutoSize = true;
            this.Label_ExportAs.Location = new System.Drawing.Point(3, 373);
            this.Label_ExportAs.Name = "Label_ExportAs";
            this.Label_ExportAs.Size = new System.Drawing.Size(55, 13);
            this.Label_ExportAs.TabIndex = 12;
            this.Label_ExportAs.Text = "Export As:";
            // 
            // List_ExportAs
            // 
            this.List_ExportAs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.List_ExportAs.FormattingEnabled = true;
            this.List_ExportAs.Items.AddRange(new object[] {
            "Text File (.txt)"});
            this.List_ExportAs.Location = new System.Drawing.Point(6, 389);
            this.List_ExportAs.Name = "List_ExportAs";
            this.List_ExportAs.Size = new System.Drawing.Size(751, 21);
            this.List_ExportAs.TabIndex = 11;
            // 
            // Check_Overwrite
            // 
            this.Check_Overwrite.AutoSize = true;
            this.Check_Overwrite.Checked = true;
            this.Check_Overwrite.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Check_Overwrite.Location = new System.Drawing.Point(6, 340);
            this.Check_Overwrite.Name = "Check_Overwrite";
            this.Check_Overwrite.Size = new System.Drawing.Size(141, 17);
            this.Check_Overwrite.TabIndex = 10;
            this.Check_Overwrite.Text = "Overwrite existing pages";
            this.Check_Overwrite.UseVisualStyleBackColor = true;
            // 
            // Check_CreateDirectory
            // 
            this.Check_CreateDirectory.AutoSize = true;
            this.Check_CreateDirectory.Checked = true;
            this.Check_CreateDirectory.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Check_CreateDirectory.Location = new System.Drawing.Point(6, 294);
            this.Check_CreateDirectory.Name = "Check_CreateDirectory";
            this.Check_CreateDirectory.Size = new System.Drawing.Size(133, 17);
            this.Check_CreateDirectory.TabIndex = 9;
            this.Check_CreateDirectory.Text = "Create output directory";
            this.Check_CreateDirectory.UseVisualStyleBackColor = true;
            // 
            // Button_SelectExportDirectory
            // 
            this.Button_SelectExportDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_SelectExportDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_SelectExportDirectory.Location = new System.Drawing.Point(717, 268);
            this.Button_SelectExportDirectory.Name = "Button_SelectExportDirectory";
            this.Button_SelectExportDirectory.Size = new System.Drawing.Size(40, 20);
            this.Button_SelectExportDirectory.TabIndex = 8;
            this.Button_SelectExportDirectory.Text = "...";
            this.Button_SelectExportDirectory.UseVisualStyleBackColor = true;
            this.Button_SelectExportDirectory.Click += new System.EventHandler(this.Button_SelectExportDirectory_Click);
            // 
            // Check_OpenAfterExport
            // 
            this.Check_OpenAfterExport.AutoSize = true;
            this.Check_OpenAfterExport.Checked = true;
            this.Check_OpenAfterExport.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Check_OpenAfterExport.Location = new System.Drawing.Point(6, 317);
            this.Check_OpenAfterExport.Name = "Check_OpenAfterExport";
            this.Check_OpenAfterExport.Size = new System.Drawing.Size(170, 17);
            this.Check_OpenAfterExport.TabIndex = 6;
            this.Check_OpenAfterExport.Text = "Open output folder after export";
            this.Check_OpenAfterExport.UseVisualStyleBackColor = true;
            // 
            // Text_ExportLocation
            // 
            this.Text_ExportLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Text_ExportLocation.Location = new System.Drawing.Point(6, 268);
            this.Text_ExportLocation.Name = "Text_ExportLocation";
            this.Text_ExportLocation.Size = new System.Drawing.Size(705, 20);
            this.Text_ExportLocation.TabIndex = 5;
            this.Text_ExportLocation.TextChanged += new System.EventHandler(this.Text_ExportLocation_TextChanged);
            // 
            // Label_ExportLocation
            // 
            this.Label_ExportLocation.AutoSize = true;
            this.Label_ExportLocation.Location = new System.Drawing.Point(3, 252);
            this.Label_ExportLocation.Name = "Label_ExportLocation";
            this.Label_ExportLocation.Size = new System.Drawing.Size(56, 13);
            this.Label_ExportLocation.TabIndex = 4;
            this.Label_ExportLocation.Text = "Export To:";
            // 
            // Text_DocumentName
            // 
            this.Text_DocumentName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Text_DocumentName.Location = new System.Drawing.Point(6, 207);
            this.Text_DocumentName.Name = "Text_DocumentName";
            this.Text_DocumentName.Size = new System.Drawing.Size(751, 20);
            this.Text_DocumentName.TabIndex = 3;
            this.Text_DocumentName.TextChanged += new System.EventHandler(this.Text_DocumentName_TextChanged);
            // 
            // Label_DocumentName
            // 
            this.Label_DocumentName.AutoSize = true;
            this.Label_DocumentName.Location = new System.Drawing.Point(3, 191);
            this.Label_DocumentName.Name = "Label_DocumentName";
            this.Label_DocumentName.Size = new System.Drawing.Size(90, 13);
            this.Label_DocumentName.TabIndex = 2;
            this.Label_DocumentName.Text = "Document Name:";
            // 
            // Label_ExportPages
            // 
            this.Label_ExportPages.AutoSize = true;
            this.Label_ExportPages.Location = new System.Drawing.Point(6, 13);
            this.Label_ExportPages.Name = "Label_ExportPages";
            this.Label_ExportPages.Size = new System.Drawing.Size(73, 13);
            this.Label_ExportPages.TabIndex = 1;
            this.Label_ExportPages.Text = "Export Pages:";
            // 
            // CheckList_ExportPages
            // 
            this.CheckList_ExportPages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckList_ExportPages.FormattingEnabled = true;
            this.CheckList_ExportPages.Location = new System.Drawing.Point(6, 29);
            this.CheckList_ExportPages.Name = "CheckList_ExportPages";
            this.CheckList_ExportPages.Size = new System.Drawing.Size(751, 139);
            this.CheckList_ExportPages.TabIndex = 0;
            // 
            // Form_Export
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 527);
            this.Controls.Add(this.Group_ExportSettings);
            this.Controls.Add(this.Button_CancelExport);
            this.Controls.Add(this.Button_Export);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Export";
            this.Text = "Export Document";
            this.Group_ExportSettings.ResumeLayout(false);
            this.Group_ExportSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_Export;
        private System.Windows.Forms.Button Button_CancelExport;
        private System.Windows.Forms.GroupBox Group_ExportSettings;
        private System.Windows.Forms.CheckedListBox CheckList_ExportPages;
        private System.Windows.Forms.Label Label_ExportPages;
        private System.Windows.Forms.Label Label_DocumentName;
        private System.Windows.Forms.TextBox Text_DocumentName;
        private System.Windows.Forms.TextBox Text_ExportLocation;
        private System.Windows.Forms.Label Label_ExportLocation;
        private System.Windows.Forms.CheckBox Check_OpenAfterExport;
        private System.Windows.Forms.Button Button_SelectExportDirectory;
        private System.Windows.Forms.CheckBox Check_CreateDirectory;
        private System.Windows.Forms.CheckBox Check_Overwrite;
        private System.Windows.Forms.ComboBox List_ExportAs;
        private System.Windows.Forms.Label Label_ExportAs;
    }
}