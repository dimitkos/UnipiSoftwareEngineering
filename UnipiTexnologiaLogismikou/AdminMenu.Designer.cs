﻿namespace UnipiTexnologiaLogismikou
{
    partial class AdminMenu
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
            this.dbbutton = new System.Windows.Forms.Button();
            this.commentbutton = new System.Windows.Forms.Button();
            this.progressbutton = new System.Windows.Forms.Button();
            this.reportbutton = new System.Windows.Forms.Button();
            this.finalgradebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dbbutton
            // 
            this.dbbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dbbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dbbutton.Location = new System.Drawing.Point(98, 145);
            this.dbbutton.Name = "dbbutton";
            this.dbbutton.Size = new System.Drawing.Size(75, 23);
            this.dbbutton.TabIndex = 0;
            this.dbbutton.Text = "database";
            this.dbbutton.UseVisualStyleBackColor = true;
            this.dbbutton.Click += new System.EventHandler(this.dbbutton_Click_1);
            // 
            // commentbutton
            // 
            this.commentbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.commentbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.commentbutton.Location = new System.Drawing.Point(235, 145);
            this.commentbutton.Name = "commentbutton";
            this.commentbutton.Size = new System.Drawing.Size(75, 23);
            this.commentbutton.TabIndex = 1;
            this.commentbutton.Text = "comment";
            this.commentbutton.UseVisualStyleBackColor = true;
            // 
            // progressbutton
            // 
            this.progressbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.progressbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.progressbutton.Location = new System.Drawing.Point(384, 145);
            this.progressbutton.Name = "progressbutton";
            this.progressbutton.Size = new System.Drawing.Size(75, 23);
            this.progressbutton.TabIndex = 2;
            this.progressbutton.Text = "progress";
            this.progressbutton.UseVisualStyleBackColor = true;
            // 
            // reportbutton
            // 
            this.reportbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reportbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reportbutton.Location = new System.Drawing.Point(527, 145);
            this.reportbutton.Name = "reportbutton";
            this.reportbutton.Size = new System.Drawing.Size(75, 23);
            this.reportbutton.TabIndex = 3;
            this.reportbutton.Text = "reporting";
            this.reportbutton.UseVisualStyleBackColor = true;
            this.reportbutton.Click += new System.EventHandler(this.reportbutton_Click);
            // 
            // finalgradebutton
            // 
            this.finalgradebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.finalgradebutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.finalgradebutton.Location = new System.Drawing.Point(640, 145);
            this.finalgradebutton.Name = "finalgradebutton";
            this.finalgradebutton.Size = new System.Drawing.Size(87, 23);
            this.finalgradebutton.TabIndex = 4;
            this.finalgradebutton.Text = "Add final grade";
            this.finalgradebutton.UseVisualStyleBackColor = true;
            this.finalgradebutton.Click += new System.EventHandler(this.finalgradebutton_Click);
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.finalgradebutton);
            this.Controls.Add(this.reportbutton);
            this.Controls.Add(this.progressbutton);
            this.Controls.Add(this.commentbutton);
            this.Controls.Add(this.dbbutton);
            this.Name = "AdminMenu";
            this.Text = "AdminMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dbbutton;
        private System.Windows.Forms.Button commentbutton;
        private System.Windows.Forms.Button progressbutton;
        private System.Windows.Forms.Button reportbutton;
        private System.Windows.Forms.Button finalgradebutton;
    }
}