namespace WinInventory.Forms
{
    partial class InitialForm
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
            this.childrenFormArea = new System.Windows.Forms.Panel();
            this.childFormLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ReportBtn = new FontAwesome.Sharp.IconButton();
            this.ViewerBtn = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // childrenFormArea
            // 
            this.childrenFormArea.Location = new System.Drawing.Point(114, 53);
            this.childrenFormArea.Name = "childrenFormArea";
            this.childrenFormArea.Size = new System.Drawing.Size(686, 397);
            this.childrenFormArea.TabIndex = 0;
            // 
            // childFormLabel
            // 
            this.childFormLabel.AutoSize = true;
            this.childFormLabel.Location = new System.Drawing.Point(133, 19);
            this.childFormLabel.Name = "childFormLabel";
            this.childFormLabel.Size = new System.Drawing.Size(38, 15);
            this.childFormLabel.TabIndex = 0;
            this.childFormLabel.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 54);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ReportBtn
            // 
            this.ReportBtn.BackColor = System.Drawing.Color.Transparent;
            this.ReportBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReportBtn.FlatAppearance.BorderSize = 0;
            this.ReportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReportBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ReportBtn.IconColor = System.Drawing.Color.Black;
            this.ReportBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ReportBtn.Location = new System.Drawing.Point(0, 128);
            this.ReportBtn.Name = "ReportBtn";
            this.ReportBtn.Size = new System.Drawing.Size(115, 49);
            this.ReportBtn.TabIndex = 2;
            this.ReportBtn.Text = "Report Generator";
            this.ReportBtn.UseMnemonic = false;
            this.ReportBtn.UseVisualStyleBackColor = false;
            this.ReportBtn.Click += new System.EventHandler(this.ReportBtn_Click);
            // 
            // ViewerBtn
            // 
            this.ViewerBtn.BackColor = System.Drawing.Color.Transparent;
            this.ViewerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewerBtn.FlatAppearance.BorderSize = 0;
            this.ViewerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewerBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ViewerBtn.IconColor = System.Drawing.Color.Black;
            this.ViewerBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ViewerBtn.Location = new System.Drawing.Point(1, 183);
            this.ViewerBtn.Name = "ViewerBtn";
            this.ViewerBtn.Size = new System.Drawing.Size(114, 49);
            this.ViewerBtn.TabIndex = 3;
            this.ViewerBtn.Text = "View Report";
            this.ViewerBtn.UseMnemonic = false;
            this.ViewerBtn.UseVisualStyleBackColor = false;
            this.ViewerBtn.Click += new System.EventHandler(this.ViewerBtn_Click);
            // 
            // InitialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.childFormLabel);
            this.Controls.Add(this.ViewerBtn);
            this.Controls.Add(this.ReportBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.childrenFormArea);
            this.Name = "InitialForm";
            this.Text = "InitialForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel childrenFormArea;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton ReportBtn;
        private FontAwesome.Sharp.IconButton ViewerBtn;
        private Label childFormLabel;
    }
}