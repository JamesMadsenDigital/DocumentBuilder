namespace DocumentBuilder.Forms
{
    partial class Form_LogViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_LogViewer));
            this.List_Logs = new System.Windows.Forms.ListBox();
            this.Button_ClearLogs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // List_Logs
            // 
            this.List_Logs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.List_Logs.FormattingEnabled = true;
            this.List_Logs.Location = new System.Drawing.Point(12, 12);
            this.List_Logs.Name = "List_Logs";
            this.List_Logs.Size = new System.Drawing.Size(1042, 498);
            this.List_Logs.TabIndex = 0;
            // 
            // Button_ClearLogs
            // 
            this.Button_ClearLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_ClearLogs.Location = new System.Drawing.Point(864, 527);
            this.Button_ClearLogs.Name = "Button_ClearLogs";
            this.Button_ClearLogs.Size = new System.Drawing.Size(190, 28);
            this.Button_ClearLogs.TabIndex = 1;
            this.Button_ClearLogs.Text = "Clear Logs";
            this.Button_ClearLogs.UseVisualStyleBackColor = true;
            this.Button_ClearLogs.Click += new System.EventHandler(this.Button_ClearLogs_Click);
            // 
            // Form_LogViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 567);
            this.Controls.Add(this.Button_ClearLogs);
            this.Controls.Add(this.List_Logs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_LogViewer";
            this.Text = "Log Viewer";
            this.Load += new System.EventHandler(this.Form_LogViewer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox List_Logs;
        private System.Windows.Forms.Button Button_ClearLogs;
    }
}