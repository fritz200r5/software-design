namespace Task5_CustomDescendingOrder
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
            this.ListBoxResults = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListBoxResults
            // 
            this.ListBoxResults.BackColor = System.Drawing.Color.Silver;
            this.ListBoxResults.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxResults.FormattingEnabled = true;
            this.ListBoxResults.ItemHeight = 25;
            this.ListBoxResults.Location = new System.Drawing.Point(215, 103);
            this.ListBoxResults.Name = "ListBoxResults";
            this.ListBoxResults.Size = new System.Drawing.Size(371, 229);
            this.ListBoxResults.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(775, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "*+Descending Bubble Sorter+*";
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSort.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSort.Location = new System.Drawing.Point(338, 370);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(120, 40);
            this.btnSort.TabIndex = 2;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListBoxResults);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxResults;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSort;
    }
}

