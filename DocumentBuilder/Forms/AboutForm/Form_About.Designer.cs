namespace DocumentBuilder.Forms
{
    partial class Form_About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_About));
            this.Label_DocumentBuilder = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Label_CreatedBy = new System.Windows.Forms.Label();
            this.Label_License = new System.Windows.Forms.Label();
            this.Link_GitHub = new System.Windows.Forms.LinkLabel();
            this.Link_Portfolio = new System.Windows.Forms.LinkLabel();
            this.Image_Icon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Image_Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_DocumentBuilder
            // 
            this.Label_DocumentBuilder.AutoSize = true;
            this.Label_DocumentBuilder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_DocumentBuilder.Location = new System.Drawing.Point(172, 11);
            this.Label_DocumentBuilder.Name = "Label_DocumentBuilder";
            this.Label_DocumentBuilder.Size = new System.Drawing.Size(182, 25);
            this.Label_DocumentBuilder.TabIndex = 0;
            this.Label_DocumentBuilder.Text = "Document Builder";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Version 1.0";
            // 
            // Label_CreatedBy
            // 
            this.Label_CreatedBy.AutoSize = true;
            this.Label_CreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_CreatedBy.Location = new System.Drawing.Point(174, 62);
            this.Label_CreatedBy.Name = "Label_CreatedBy";
            this.Label_CreatedBy.Size = new System.Drawing.Size(132, 13);
            this.Label_CreatedBy.TabIndex = 2;
            this.Label_CreatedBy.Text = "Created by James Madsen";
            // 
            // Label_License
            // 
            this.Label_License.AutoSize = true;
            this.Label_License.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_License.Location = new System.Drawing.Point(174, 170);
            this.Label_License.Name = "Label_License";
            this.Label_License.Size = new System.Drawing.Size(151, 13);
            this.Label_License.TabIndex = 3;
            this.Label_License.Text = "Distributed Under MIT License";
            // 
            // Link_GitHub
            // 
            this.Link_GitHub.AutoSize = true;
            this.Link_GitHub.Location = new System.Drawing.Point(174, 91);
            this.Link_GitHub.Name = "Link_GitHub";
            this.Link_GitHub.Size = new System.Drawing.Size(64, 13);
            this.Link_GitHub.TabIndex = 4;
            this.Link_GitHub.TabStop = true;
            this.Link_GitHub.Text = "github.com/";
            this.Link_GitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_GitHub_LinkClicked);
            // 
            // Link_Portfolio
            // 
            this.Link_Portfolio.AutoSize = true;
            this.Link_Portfolio.Location = new System.Drawing.Point(174, 110);
            this.Link_Portfolio.Name = "Link_Portfolio";
            this.Link_Portfolio.Size = new System.Drawing.Size(126, 13);
            this.Link_Portfolio.TabIndex = 5;
            this.Link_Portfolio.TabStop = true;
            this.Link_Portfolio.Text = "jamesmadsendigital.com/";
            this.Link_Portfolio.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_Portfolio_LinkClicked);
            // 
            // Image_Icon
            // 
            this.Image_Icon.Image = ((System.Drawing.Image)(resources.GetObject("Image_Icon.Image")));
            this.Image_Icon.Location = new System.Drawing.Point(-12, 12);
            this.Image_Icon.Name = "Image_Icon";
            this.Image_Icon.Size = new System.Drawing.Size(189, 179);
            this.Image_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Image_Icon.TabIndex = 6;
            this.Image_Icon.TabStop = false;
            // 
            // Form_About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 203);
            this.Controls.Add(this.Link_Portfolio);
            this.Controls.Add(this.Link_GitHub);
            this.Controls.Add(this.Label_License);
            this.Controls.Add(this.Label_CreatedBy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Label_DocumentBuilder);
            this.Controls.Add(this.Image_Icon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_About";
            this.Text = "About Document Builder";
            ((System.ComponentModel.ISupportInitialize)(this.Image_Icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_DocumentBuilder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label_CreatedBy;
        private System.Windows.Forms.Label Label_License;
        private System.Windows.Forms.LinkLabel Link_GitHub;
        private System.Windows.Forms.LinkLabel Link_Portfolio;
        private System.Windows.Forms.PictureBox Image_Icon;
    }
}