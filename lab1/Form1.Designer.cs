namespace lab1
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
            Sort = new Button();
            listBoxResults = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // Sort
            // 
            Sort.BackColor = SystemColors.AppWorkspace;
            Sort.Location = new Point(346, 382);
            Sort.Name = "Sort";
            Sort.Size = new Size(102, 36);
            Sort.TabIndex = 0;
            Sort.Text = "Sort";
            Sort.UseVisualStyleBackColor = false;
            Sort.Click += btnSort_Click;
            // 
            // listBoxResults
            // 
            listBoxResults.BackColor = SystemColors.InactiveCaption;
            listBoxResults.ItemHeight = 15;
            listBoxResults.Location = new Point(195, 108);
            listBoxResults.Name = "listBoxResults";
            listBoxResults.Size = new Size(382, 229);
            listBoxResults.TabIndex = 0;
            listBoxResults.SelectedIndexChanged += listBoxResults_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(283, 32);
            label1.Name = "label1";
            label1.Size = new Size(210, 37);
            label1.TabIndex = 1;
            label1.Text = "Number Sorter";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(listBoxResults);
            Controls.Add(Sort);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Sort;
        private ListBox listBoxResults;
        private Label label1;
    }
}
