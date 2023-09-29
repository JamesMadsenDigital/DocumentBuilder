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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.MenuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.MenuItem_File = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_NewFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.ListItem_ShowDocumentation = new System.Windows.Forms.ToolStripMenuItem();
            this.ListItem_ViewLogs = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_About = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Group_EditorControls = new System.Windows.Forms.GroupBox();
            this.Text_InputFilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RichText_Editor = new System.Windows.Forms.RichTextBox();
            this.Text_Viewer = new System.Windows.Forms.TextBox();
            this.Group_ViewControls = new System.Windows.Forms.GroupBox();
            this.Label_PageNumber = new System.Windows.Forms.Label();
            this.Number_Page = new System.Windows.Forms.NumericUpDown();
            this.Label_View = new System.Windows.Forms.Label();
            this.Button_Export = new System.Windows.Forms.Button();
            this.Label_ViewerFontSize = new System.Windows.Forms.Label();
            this.Number_FontSize = new System.Windows.Forms.NumericUpDown();
            this.MenuStrip_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.Group_EditorControls.SuspendLayout();
            this.Group_ViewControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Number_Page)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Number_FontSize)).BeginInit();
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
            this.MenuItem_NewFile,
            this.MenuItem_Open,
            this.MenuItem_Save,
            this.MenuItem_SaveAs});
            this.MenuItem_File.Name = "MenuItem_File";
            this.MenuItem_File.Size = new System.Drawing.Size(37, 20);
            this.MenuItem_File.Text = "File";
            // 
            // MenuItem_NewFile
            // 
            this.MenuItem_NewFile.Name = "MenuItem_NewFile";
            this.MenuItem_NewFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.MenuItem_NewFile.Size = new System.Drawing.Size(195, 22);
            this.MenuItem_NewFile.Text = "New";
            // 
            // MenuItem_Open
            // 
            this.MenuItem_Open.Name = "MenuItem_Open";
            this.MenuItem_Open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.MenuItem_Open.Size = new System.Drawing.Size(195, 22);
            this.MenuItem_Open.Text = "Open";
            this.MenuItem_Open.Click += new System.EventHandler(this.MenuItem_Open_Click);
            // 
            // MenuItem_Save
            // 
            this.MenuItem_Save.Name = "MenuItem_Save";
            this.MenuItem_Save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.MenuItem_Save.Size = new System.Drawing.Size(195, 22);
            this.MenuItem_Save.Text = "Save";
            this.MenuItem_Save.Click += new System.EventHandler(this.MenuItem_Save_Click);
            // 
            // MenuItem_SaveAs
            // 
            this.MenuItem_SaveAs.Name = "MenuItem_SaveAs";
            this.MenuItem_SaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.MenuItem_SaveAs.Size = new System.Drawing.Size(195, 22);
            this.MenuItem_SaveAs.Text = "Save As...";
            this.MenuItem_SaveAs.Click += new System.EventHandler(this.MenuItem_SaveAs_Click);
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
            this.ListItem_ShowDocumentation.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.ListItem_ShowDocumentation.Size = new System.Drawing.Size(199, 22);
            this.ListItem_ShowDocumentation.Text = "Documentation";
            this.ListItem_ShowDocumentation.Click += new System.EventHandler(this.ListItem_ShowDocumentation_Click);
            // 
            // ListItem_ViewLogs
            // 
            this.ListItem_ViewLogs.Name = "ListItem_ViewLogs";
            this.ListItem_ViewLogs.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.ListItem_ViewLogs.Size = new System.Drawing.Size(199, 22);
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
            this.splitContainer1.Panel1.Controls.Add(this.Group_EditorControls);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.RichText_Editor);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Text_Viewer);
            this.splitContainer1.Panel2.Controls.Add(this.Group_ViewControls);
            this.splitContainer1.Panel2.Controls.Add(this.Label_View);
            this.splitContainer1.Panel2.Controls.Add(this.Button_Export);
            this.splitContainer1.Size = new System.Drawing.Size(1633, 1019);
            this.splitContainer1.SplitterDistance = 801;
            this.splitContainer1.TabIndex = 1;
            // 
            // Group_EditorControls
            // 
            this.Group_EditorControls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Group_EditorControls.Controls.Add(this.Text_InputFilePath);
            this.Group_EditorControls.Location = new System.Drawing.Point(3, 28);
            this.Group_EditorControls.Name = "Group_EditorControls";
            this.Group_EditorControls.Size = new System.Drawing.Size(793, 41);
            this.Group_EditorControls.TabIndex = 7;
            this.Group_EditorControls.TabStop = false;
            // 
            // Text_InputFilePath
            // 
            this.Text_InputFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Text_InputFilePath.Location = new System.Drawing.Point(8, 14);
            this.Text_InputFilePath.Name = "Text_InputFilePath";
            this.Text_InputFilePath.ReadOnly = true;
            this.Text_InputFilePath.Size = new System.Drawing.Size(779, 20);
            this.Text_InputFilePath.TabIndex = 1;
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
            // RichText_Editor
            // 
            this.RichText_Editor.AcceptsTab = true;
            this.RichText_Editor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RichText_Editor.BackColor = System.Drawing.SystemColors.Window;
            this.RichText_Editor.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RichText_Editor.Location = new System.Drawing.Point(3, 75);
            this.RichText_Editor.Name = "RichText_Editor";
            this.RichText_Editor.Size = new System.Drawing.Size(793, 886);
            this.RichText_Editor.TabIndex = 0;
            this.RichText_Editor.Text = "";
            this.RichText_Editor.TextChanged += new System.EventHandler(this.Editor_TextChanged);
            // 
            // Text_Viewer
            // 
            this.Text_Viewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Text_Viewer.Font = new System.Drawing.Font("Cascadia Mono", 9F);
            this.Text_Viewer.Location = new System.Drawing.Point(3, 75);
            this.Text_Viewer.Multiline = true;
            this.Text_Viewer.Name = "Text_Viewer";
            this.Text_Viewer.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Text_Viewer.Size = new System.Drawing.Size(820, 886);
            this.Text_Viewer.TabIndex = 7;
            this.Text_Viewer.WordWrap = false;
            // 
            // Group_ViewControls
            // 
            this.Group_ViewControls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Group_ViewControls.Controls.Add(this.Label_ViewerFontSize);
            this.Group_ViewControls.Controls.Add(this.Number_FontSize);
            this.Group_ViewControls.Controls.Add(this.Label_PageNumber);
            this.Group_ViewControls.Controls.Add(this.Number_Page);
            this.Group_ViewControls.Location = new System.Drawing.Point(3, 28);
            this.Group_ViewControls.Name = "Group_ViewControls";
            this.Group_ViewControls.Size = new System.Drawing.Size(820, 41);
            this.Group_ViewControls.TabIndex = 6;
            this.Group_ViewControls.TabStop = false;
            // 
            // Label_PageNumber
            // 
            this.Label_PageNumber.AutoSize = true;
            this.Label_PageNumber.Location = new System.Drawing.Point(6, 16);
            this.Label_PageNumber.Name = "Label_PageNumber";
            this.Label_PageNumber.Size = new System.Drawing.Size(32, 13);
            this.Label_PageNumber.TabIndex = 6;
            this.Label_PageNumber.Text = "Page";
            // 
            // Number_Page
            // 
            this.Number_Page.Location = new System.Drawing.Point(43, 13);
            this.Number_Page.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Number_Page.Name = "Number_Page";
            this.Number_Page.Size = new System.Drawing.Size(54, 20);
            this.Number_Page.TabIndex = 5;
            this.Number_Page.ValueChanged += new System.EventHandler(this.Number_Page_ValueChanged);
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
            // Label_ViewerFontSize
            // 
            this.Label_ViewerFontSize.AutoSize = true;
            this.Label_ViewerFontSize.Location = new System.Drawing.Point(128, 16);
            this.Label_ViewerFontSize.Name = "Label_ViewerFontSize";
            this.Label_ViewerFontSize.Size = new System.Drawing.Size(51, 13);
            this.Label_ViewerFontSize.TabIndex = 8;
            this.Label_ViewerFontSize.Text = "Font Size";
            // 
            // Number_FontSize
            // 
            this.Number_FontSize.Location = new System.Drawing.Point(184, 13);
            this.Number_FontSize.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.Number_FontSize.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.Number_FontSize.Name = "Number_FontSize";
            this.Number_FontSize.Size = new System.Drawing.Size(54, 20);
            this.Number_FontSize.TabIndex = 7;
            this.Number_FontSize.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.Number_FontSize.ValueChanged += new System.EventHandler(this.Number_FontSize_ValueChanged);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1633, 1043);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.MenuStrip_Main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
            this.Group_EditorControls.ResumeLayout(false);
            this.Group_EditorControls.PerformLayout();
            this.Group_ViewControls.ResumeLayout(false);
            this.Group_ViewControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Number_Page)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Number_FontSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_File;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Help;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_About;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_NewFile;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Open;
        private System.Windows.Forms.ToolStripMenuItem ListItem_ShowDocumentation;
        private System.Windows.Forms.ToolStripMenuItem ListItem_ViewLogs;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox RichText_Editor;
        private System.Windows.Forms.TextBox Text_InputFilePath;
        private System.Windows.Forms.Button Button_Export;
        private System.Windows.Forms.Label Label_View;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Number_Page;
        private System.Windows.Forms.GroupBox Group_ViewControls;
        private System.Windows.Forms.Label Label_PageNumber;
        private System.Windows.Forms.GroupBox Group_EditorControls;
        private System.Windows.Forms.TextBox Text_Viewer;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Save;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_SaveAs;
        private System.Windows.Forms.Label Label_ViewerFontSize;
        private System.Windows.Forms.NumericUpDown Number_FontSize;
    }
}

