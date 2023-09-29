namespace DocumentBuilder.Forms.ExportForm
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
            this.Check_OpenAfterExport = new System.Windows.Forms.CheckBox();
            this.Text_ExportLocation = new System.Windows.Forms.TextBox();
            this.Label_ExportLocation = new System.Windows.Forms.Label();
            this.Text_DocumentName = new System.Windows.Forms.TextBox();
            this.Label_DocumentName = new System.Windows.Forms.Label();
            this.Label_ExportPages = new System.Windows.Forms.Label();
            this.CheckList_ExportPages = new System.Windows.Forms.CheckedListBox();
            this.Button_SelectExportDirectory = new System.Windows.Forms.Button();
            this.Group_ExportSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button_Export
            // 
            this.Button_Export.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Export.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Export.Location = new System.Drawing.Point(603, 368);
            this.Button_Export.Name = "Button_Export";
            this.Button_Export.Size = new System.Drawing.Size(174, 32);
            this.Button_Export.TabIndex = 5;
            this.Button_Export.Text = "Export";
            this.Button_Export.UseVisualStyleBackColor = true;
            // 
            // Button_CancelExport
            // 
            this.Button_CancelExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_CancelExport.Location = new System.Drawing.Point(423, 368);
            this.Button_CancelExport.Name = "Button_CancelExport";
            this.Button_CancelExport.Size = new System.Drawing.Size(174, 32);
            this.Button_CancelExport.TabIndex = 6;
            this.Button_CancelExport.Text = "Cancel";
            this.Button_CancelExport.UseVisualStyleBackColor = true;
            // 
            // Group_ExportSettings
            // 
            this.Group_ExportSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.Group_ExportSettings.Size = new System.Drawing.Size(763, 340);
            this.Group_ExportSettings.TabIndex = 7;
            this.Group_ExportSettings.TabStop = false;
            // 
            // Check_OpenAfterExport
            // 
            this.Check_OpenAfterExport.AutoSize = true;
            this.Check_OpenAfterExport.Location = new System.Drawing.Point(6, 294);
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
            // Button_SelectExportDirectory
            // 
            this.Button_SelectExportDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_SelectExportDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_SelectExportDirectory.Location = new System.Drawing.Point(717, 268);
            this.Button_SelectExportDirectory.Name = "Button_SelectExportDirectory";
            this.Button_SelectExportDirectory.Size = new System.Drawing.Size(40, 20);
            this.Button_SelectExportDirectory.TabIndex = 8;
            this.Button_SelectExportDirectory.Text = "...";
            this.Button_SelectExportDirectory.UseVisualStyleBackColor = true;
            // 
            // Form_Export
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 415);
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
    }
}