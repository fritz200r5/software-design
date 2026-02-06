using System.Drawing;
using System.Windows.Forms;

namespace Task4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Sort = new System.Windows.Forms.Button();
            this.listBoxResults = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Sort
            // 
            this.Sort.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Sort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sort.Location = new System.Drawing.Point(297, 324);
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(97, 38);
            this.Sort.TabIndex = 0;
            this.Sort.Text = "Sort";
            this.Sort.UseVisualStyleBackColor = false;
            // 
            // listBoxResults
            // 
            this.listBoxResults.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listBoxResults.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxResults.ItemHeight = 30;
            this.listBoxResults.Location = new System.Drawing.Point(167, 94);
            this.listBoxResults.Name = "listBoxResults";
            this.listBoxResults.Size = new System.Drawing.Size(328, 184);
            this.listBoxResults.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(226, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number Sorter";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxResults);
            this.Controls.Add(this.Sort);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Sort;
        private ListBox listBoxResults;
        private Label label1;
    }
}
