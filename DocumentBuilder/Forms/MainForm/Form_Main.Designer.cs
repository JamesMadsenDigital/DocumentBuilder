namespace DocumentBuilder.Forms
{
    partial class Form_Main
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
            this.MenuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.MenuItem_File = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_NewBasicDocument = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_NewResume = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.ListItem_ShowDocumentation = new System.Windows.Forms.ToolStripMenuItem();
            this.ListItem_ViewLogs = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_About = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.Button_OpenFile = new System.Windows.Forms.Button();
            this.Text_InputFilePath = new System.Windows.Forms.TextBox();
            this.RichText_Editor = new System.Windows.Forms.RichTextBox();
            this.Label_View = new System.Windows.Forms.Label();
            this.ProgressBar_BuildDocument = new System.Windows.Forms.ProgressBar();
            this.Button_Export = new System.Windows.Forms.Button();
            this.RichText_Viewer = new System.Windows.Forms.RichTextBox();
            this.Button_PrintComponents = new System.Windows.Forms.Button();
            this.MenuStrip_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip_Main
            // 
            this.MenuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_File,
            this.MenuItem_Help,
            this.MenuItem_About});
            this.MenuStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip_Main.Name = "MenuStrip_Main";
            this.MenuStrip_Main.Size = new System.Drawing.Size(1633, 24);
            this.MenuStrip_Main.TabIndex = 0;
            this.MenuStrip_Main.Text = "Main Menu Strip";
            // 
            // MenuItem_File
            // 
            this.MenuItem_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.MenuItem_Open});
            this.MenuItem_File.Name = "MenuItem_File";
            this.MenuItem_File.Size = new System.Drawing.Size(37, 20);
            this.MenuItem_File.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_NewBasicDocument,
            this.MenuItem_NewResume});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.newToolStripMenuItem.Text = "New...";
            // 
            // MenuItem_NewBasicDocument
            // 
            this.MenuItem_NewBasicDocument.Name = "MenuItem_NewBasicDocument";
            this.MenuItem_NewBasicDocument.Size = new System.Drawing.Size(160, 22);
            this.MenuItem_NewBasicDocument.Text = "Basic Document";
            // 
            // MenuItem_NewResume
            // 
            this.MenuItem_NewResume.Name = "MenuItem_NewResume";
            this.MenuItem_NewResume.Size = new System.Drawing.Size(160, 22);
            this.MenuItem_NewResume.Text = "Resume";
            // 
            // MenuItem_Open
            // 
            this.MenuItem_Open.Name = "MenuItem_Open";
            this.MenuItem_Open.Size = new System.Drawing.Size(112, 22);
            this.MenuItem_Open.Text = "Open...";
            // 
            // MenuItem_Help
            // 
            this.MenuItem_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ListItem_ShowDocumentation,
            this.ListItem_ViewLogs});
            this.MenuItem_Help.Name = "MenuItem_Help";
            this.MenuItem_Help.Size = new System.Drawing.Size(44, 20);
            this.MenuItem_Help.Text = "Help";
            // 
            // ListItem_ShowDocumentation
            // 
            this.ListItem_ShowDocumentation.Name = "ListItem_ShowDocumentation";
            this.ListItem_ShowDocumentation.Size = new System.Drawing.Size(157, 22);
            this.ListItem_ShowDocumentation.Text = "Documentation";
            // 
            // ListItem_ViewLogs
            // 
            this.ListItem_ViewLogs.Name = "ListItem_ViewLogs";
            this.ListItem_ViewLogs.Size = new System.Drawing.Size(157, 22);
            this.ListItem_ViewLogs.Text = "View Logs";
            this.ListItem_ViewLogs.Click += new System.EventHandler(this.ListItem_ViewLogs_Click);
            // 
            // MenuItem_About
            // 
            this.MenuItem_About.Name = "MenuItem_About";
            this.MenuItem_About.Size = new System.Drawing.Size(52, 20);
            this.MenuItem_About.Text = "About";
            this.MenuItem_About.Click += new System.EventHandler(this.MenuItem_About_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Button_PrintComponents);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.Button_OpenFile);
            this.splitContainer1.Panel1.Controls.Add(this.Text_InputFilePath);
            this.splitContainer1.Panel1.Controls.Add(this.RichText_Editor);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Label_View);
            this.splitContainer1.Panel2.Controls.Add(this.ProgressBar_BuildDocument);
            this.splitContainer1.Panel2.Controls.Add(this.Button_Export);
            this.splitContainer1.Panel2.Controls.Add(this.RichText_Viewer);
            this.splitContainer1.Size = new System.Drawing.Size(1633, 1019);
            this.splitContainer1.SplitterDistance = 801;
            this.splitContainer1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Edit";
            // 
            // Button_OpenFile
            // 
            this.Button_OpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_OpenFile.Location = new System.Drawing.Point(762, 36);
            this.Button_OpenFile.Name = "Button_OpenFile";
            this.Button_OpenFile.Size = new System.Drawing.Size(34, 20);
            this.Button_OpenFile.TabIndex = 2;
            this.Button_OpenFile.Text = "...";
            this.Button_OpenFile.UseVisualStyleBackColor = true;
            // 
            // Text_InputFilePath
            // 
            this.Text_InputFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Text_InputFilePath.Location = new System.Drawing.Point(3, 36);
            this.Text_InputFilePath.Name = "Text_InputFilePath";
            this.Text_InputFilePath.ReadOnly = true;
            this.Text_InputFilePath.Size = new System.Drawing.Size(753, 20);
            this.Text_InputFilePath.TabIndex = 1;
            // 
            // RichText_Editor
            // 
            this.RichText_Editor.AcceptsTab = true;
            this.RichText_Editor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RichText_Editor.BackColor = System.Drawing.SystemColors.Window;
            this.RichText_Editor.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RichText_Editor.Location = new System.Drawing.Point(3, 68);
            this.RichText_Editor.Name = "RichText_Editor";
            this.RichText_Editor.Size = new System.Drawing.Size(793, 893);
            this.RichText_Editor.TabIndex = 0;
            this.RichText_Editor.Text = "";
            this.RichText_Editor.TextChanged += new System.EventHandler(this.Editor_TextChanged);
            // 
            // Label_View
            // 
            this.Label_View.AutoSize = true;
            this.Label_View.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_View.Location = new System.Drawing.Point(3, 9);
            this.Label_View.Name = "Label_View";
            this.Label_View.Size = new System.Drawing.Size(36, 16);
            this.Label_View.TabIndex = 4;
            this.Label_View.Text = "View";
            // 
            // ProgressBar_BuildDocument
            // 
            this.ProgressBar_BuildDocument.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgressBar_BuildDocument.Location = new System.Drawing.Point(3, 36);
            this.ProgressBar_BuildDocument.Name = "ProgressBar_BuildDocument";
            this.ProgressBar_BuildDocument.Size = new System.Drawing.Size(820, 19);
            this.ProgressBar_BuildDocument.TabIndex = 5;
            // 
            // Button_Export
            // 
            this.Button_Export.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Export.Location = new System.Drawing.Point(641, 974);
            this.Button_Export.Name = "Button_Export";
            this.Button_Export.Size = new System.Drawing.Size(174, 32);
            this.Button_Export.TabIndex = 4;
            this.Button_Export.Text = "Export";
            this.Button_Export.UseVisualStyleBackColor = true;
            // 
            // RichText_Viewer
            // 
            this.RichText_Viewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RichText_Viewer.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RichText_Viewer.Location = new System.Drawing.Point(3, 68);
            this.RichText_Viewer.Name = "RichText_Viewer";
            this.RichText_Viewer.ReadOnly = true;
            this.RichText_Viewer.Size = new System.Drawing.Size(820, 893);
            this.RichText_Viewer.TabIndex = 0;
            this.RichText_Viewer.Text = "";
            // 
            // Button_PrintComponents
            // 
            this.Button_PrintComponents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_PrintComponents.Location = new System.Drawing.Point(613, 974);
            this.Button_PrintComponents.Name = "Button_PrintComponents";
            this.Button_PrintComponents.Size = new System.Drawing.Size(174, 32);
            this.Button_PrintComponents.TabIndex = 6;
            this.Button_PrintComponents.Text = "Print Components";
            this.Button_PrintComponents.UseVisualStyleBackColor = true;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1633, 1043);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.MenuStrip_Main);
            this.MainMenuStrip = this.MenuStrip_Main;
            this.Name = "Form_Main";
            this.Text = "Document Builder";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.MenuStrip_Main.ResumeLayout(false);
            this.MenuStrip_Main.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_File;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Help;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_About;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_NewBasicDocument;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_NewResume;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Open;
        private System.Windows.Forms.ToolStripMenuItem ListItem_ShowDocumentation;
        private System.Windows.Forms.ToolStripMenuItem ListItem_ViewLogs;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox RichText_Editor;
        private System.Windows.Forms.RichTextBox RichText_Viewer;
        private System.Windows.Forms.TextBox Text_InputFilePath;
        private System.Windows.Forms.Button Button_OpenFile;
        private System.Windows.Forms.Button Button_Export;
        private System.Windows.Forms.ProgressBar ProgressBar_BuildDocument;
        private System.Windows.Forms.Label Label_View;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_PrintComponents;
    }
}

