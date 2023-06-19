namespace WinInventory.Forms
{
    partial class ViewerForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.tab3 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.iconToolStripButton1 = new FontAwesome.Sharp.IconToolStripButton();
            this.iconDropDownButton1 = new FontAwesome.Sharp.IconDropDownButton();
            this.hardwareBtn = new FontAwesome.Sharp.IconButton();
            this.infoBtn = new FontAwesome.Sharp.IconButton();
            this.devicesBtn = new FontAwesome.Sharp.IconButton();
            this.applicationsBtn = new FontAwesome.Sharp.IconButton();
            this.driversBtn = new FontAwesome.Sharp.IconButton();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tab1);
            this.tabControl.Controls.Add(this.tab2);
            this.tabControl.Controls.Add(this.tab3);
            this.tabControl.Location = new System.Drawing.Point(110, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(538, 26);
            this.tabControl.TabIndex = 2;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tab1
            // 
            this.tab1.Location = new System.Drawing.Point(4, 24);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3);
            this.tab1.Size = new System.Drawing.Size(530, 0);
            this.tab1.TabIndex = 0;
            this.tab1.Text = "tab1";
            this.tab1.UseVisualStyleBackColor = true;
            // 
            // tab2
            // 
            this.tab2.Location = new System.Drawing.Point(4, 24);
            this.tab2.Name = "tab2";
            this.tab2.Padding = new System.Windows.Forms.Padding(3);
            this.tab2.Size = new System.Drawing.Size(530, 0);
            this.tab2.TabIndex = 1;
            this.tab2.Text = "tabPage2";
            this.tab2.UseVisualStyleBackColor = true;
            // 
            // tab3
            // 
            this.tab3.Location = new System.Drawing.Point(4, 24);
            this.tab3.Name = "tab3";
            this.tab3.Size = new System.Drawing.Size(530, 0);
            this.tab3.TabIndex = 2;
            this.tab3.Text = "tabPage1";
            this.tab3.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(110, 36);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(538, 334);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // iconToolStripButton1
            // 
            this.iconToolStripButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconToolStripButton1.IconColor = System.Drawing.Color.Black;
            this.iconToolStripButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconToolStripButton1.Name = "iconToolStripButton1";
            this.iconToolStripButton1.Size = new System.Drawing.Size(23, 23);
            this.iconToolStripButton1.Text = "iconToolStripButton1";
            // 
            // iconDropDownButton1
            // 
            this.iconDropDownButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconDropDownButton1.IconColor = System.Drawing.Color.Black;
            this.iconDropDownButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconDropDownButton1.Name = "iconDropDownButton1";
            this.iconDropDownButton1.Size = new System.Drawing.Size(23, 23);
            this.iconDropDownButton1.Text = "iconDropDownButton1";
            // 
            // hardwareBtn
            // 
            this.hardwareBtn.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hardwareBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.hardwareBtn.IconColor = System.Drawing.Color.Black;
            this.hardwareBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.hardwareBtn.Location = new System.Drawing.Point(29, 36);
            this.hardwareBtn.Name = "hardwareBtn";
            this.hardwareBtn.Size = new System.Drawing.Size(75, 23);
            this.hardwareBtn.TabIndex = 3;
            this.hardwareBtn.Text = "Hardware";
            this.hardwareBtn.UseVisualStyleBackColor = true;
            this.hardwareBtn.Click += new System.EventHandler(this.hardwareBtn_Click);
            // 
            // infoBtn
            // 
            this.infoBtn.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.infoBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.infoBtn.IconColor = System.Drawing.Color.Black;
            this.infoBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.infoBtn.Location = new System.Drawing.Point(29, 65);
            this.infoBtn.Name = "infoBtn";
            this.infoBtn.Size = new System.Drawing.Size(75, 23);
            this.infoBtn.TabIndex = 4;
            this.infoBtn.Text = "System Info";
            this.infoBtn.UseVisualStyleBackColor = true;
            this.infoBtn.Click += new System.EventHandler(this.infoBtn_Click);
            // 
            // devicesBtn
            // 
            this.devicesBtn.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.devicesBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.devicesBtn.IconColor = System.Drawing.Color.Black;
            this.devicesBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.devicesBtn.Location = new System.Drawing.Point(29, 94);
            this.devicesBtn.Name = "devicesBtn";
            this.devicesBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.devicesBtn.Size = new System.Drawing.Size(75, 23);
            this.devicesBtn.TabIndex = 5;
            this.devicesBtn.Text = "Devices";
            this.devicesBtn.UseVisualStyleBackColor = true;
            this.devicesBtn.Click += new System.EventHandler(this.devicesBtn_Click);
            // 
            // applicationsBtn
            // 
            this.applicationsBtn.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.applicationsBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.applicationsBtn.IconColor = System.Drawing.Color.Black;
            this.applicationsBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.applicationsBtn.Location = new System.Drawing.Point(29, 123);
            this.applicationsBtn.Name = "applicationsBtn";
            this.applicationsBtn.Size = new System.Drawing.Size(75, 23);
            this.applicationsBtn.TabIndex = 6;
            this.applicationsBtn.Text = "Applications";
            this.applicationsBtn.UseVisualStyleBackColor = true;
            this.applicationsBtn.Click += new System.EventHandler(this.applicationsBtn_Click);
            // 
            // driversBtn
            // 
            this.driversBtn.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.driversBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.driversBtn.IconColor = System.Drawing.Color.Black;
            this.driversBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.driversBtn.Location = new System.Drawing.Point(29, 152);
            this.driversBtn.Name = "driversBtn";
            this.driversBtn.Size = new System.Drawing.Size(75, 23);
            this.driversBtn.TabIndex = 7;
            this.driversBtn.Text = "Drivers";
            this.driversBtn.UseVisualStyleBackColor = true;
            this.driversBtn.Click += new System.EventHandler(this.driversBtn_Click);
            // 
            // ViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.driversBtn);
            this.Controls.Add(this.applicationsBtn);
            this.Controls.Add(this.devicesBtn);
            this.Controls.Add(this.infoBtn);
            this.Controls.Add(this.hardwareBtn);
            this.Controls.Add(this.tabControl);
            this.Name = "ViewerForm";
            this.Text = "Report Viewer";
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl;
        private TabPage tab1;
        private TabPage tabPage2;
        private FontAwesome.Sharp.IconToolStripButton iconToolStripButton1;
        private FontAwesome.Sharp.IconDropDownButton iconDropDownButton1;
        private FontAwesome.Sharp.IconButton hardwareBtn;
        private FontAwesome.Sharp.IconButton infoBtn;
        private FontAwesome.Sharp.IconButton devicesBtn;
        private FontAwesome.Sharp.IconButton applicationsBtn;
        private FontAwesome.Sharp.IconButton driversBtn;
        private RichTextBox richTextBox1;
        private TabPage tab2;
        private TabPage tab3;
    }
}