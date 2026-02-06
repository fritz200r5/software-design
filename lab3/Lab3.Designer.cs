namespace lab3
{
    partial class Lab3
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
            bookListbox = new ListBox();
            btnShowInfo = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // bookListbox
            // 
            bookListbox.FormattingEnabled = true;
            bookListbox.ItemHeight = 15;
            bookListbox.Location = new Point(12, 78);
            bookListbox.Margin = new Padding(3, 2, 3, 2);
            bookListbox.Name = "bookListbox";
            bookListbox.Size = new Size(816, 289);
            bookListbox.TabIndex = 0;
            // 
            // btnShowInfo
            // 
            btnShowInfo.FlatAppearance.BorderColor = Color.FromArgb(255, 255, 192);
            btnShowInfo.FlatAppearance.BorderSize = 10;
            btnShowInfo.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 128);
            btnShowInfo.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btnShowInfo.Location = new Point(364, 383);
            btnShowInfo.Margin = new Padding(3, 2, 3, 2);
            btnShowInfo.Name = "btnShowInfo";
            btnShowInfo.Size = new Size(113, 38);
            btnShowInfo.TabIndex = 1;
            btnShowInfo.Text = "Show Info";
            btnShowInfo.UseVisualStyleBackColor = true;
            btnShowInfo.Click += btnShowInfo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SansSerif", 20F, FontStyle.Bold);
            label1.Location = new Point(313, 24);
            label1.Name = "label1";
            label1.Size = new Size(235, 31);
            label1.TabIndex = 2;
            label1.Text = "Library Inventory";
            // 
            // Lab3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(840, 453);
            Controls.Add(label1);
            Controls.Add(btnShowInfo);
            Controls.Add(bookListbox);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Lab3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox bookListbox;
        private Button btnShowInfo;
        private Label label1;
    }
}
