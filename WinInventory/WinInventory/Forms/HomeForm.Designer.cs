namespace WinInventory.Forms
{
    partial class HomeForm
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
            this.BtnGeral = new System.Windows.Forms.Button();
            this.BtnApplications = new System.Windows.Forms.Button();
            this.BtnDevices = new System.Windows.Forms.Button();
            this.BtnDrivers = new System.Windows.Forms.Button();
            this.BtnHardware = new System.Windows.Forms.Button();
            this.BtnSystem = new System.Windows.Forms.Button();
            this.BtnTeste = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnGeral
            // 
            this.BtnGeral.Location = new System.Drawing.Point(124, 38);
            this.BtnGeral.Name = "BtnGeral";
            this.BtnGeral.Size = new System.Drawing.Size(121, 56);
            this.BtnGeral.TabIndex = 0;
            this.BtnGeral.Text = "Geral";
            this.BtnGeral.UseVisualStyleBackColor = true;
            this.BtnGeral.Click += new System.EventHandler(this.BtnGeral_Click);
            // 
            // BtnApplications
            // 
            this.BtnApplications.Location = new System.Drawing.Point(483, 38);
            this.BtnApplications.Name = "BtnApplications";
            this.BtnApplications.Size = new System.Drawing.Size(121, 56);
            this.BtnApplications.TabIndex = 1;
            this.BtnApplications.Text = "Applications";
            this.BtnApplications.UseVisualStyleBackColor = true;
            this.BtnApplications.Click += new System.EventHandler(this.BtnApplications_Click);
            // 
            // BtnDevices
            // 
            this.BtnDevices.Location = new System.Drawing.Point(124, 134);
            this.BtnDevices.Name = "BtnDevices";
            this.BtnDevices.Size = new System.Drawing.Size(121, 56);
            this.BtnDevices.TabIndex = 2;
            this.BtnDevices.Text = "Devices";
            this.BtnDevices.UseVisualStyleBackColor = true;
            this.BtnDevices.Click += new System.EventHandler(this.BtnDevices_Click);
            // 
            // BtnDrivers
            // 
            this.BtnDrivers.Location = new System.Drawing.Point(483, 134);
            this.BtnDrivers.Name = "BtnDrivers";
            this.BtnDrivers.Size = new System.Drawing.Size(121, 56);
            this.BtnDrivers.TabIndex = 3;
            this.BtnDrivers.Text = "Drivers";
            this.BtnDrivers.UseVisualStyleBackColor = true;
            this.BtnDrivers.Click += new System.EventHandler(this.BtnDrivers_Click);
            // 
            // BtnHardware
            // 
            this.BtnHardware.Location = new System.Drawing.Point(124, 230);
            this.BtnHardware.Name = "BtnHardware";
            this.BtnHardware.Size = new System.Drawing.Size(121, 56);
            this.BtnHardware.TabIndex = 4;
            this.BtnHardware.Text = "Hardware";
            this.BtnHardware.UseVisualStyleBackColor = true;
            this.BtnHardware.Click += new System.EventHandler(this.BtnHardware_Click);
            // 
            // BtnSystem
            // 
            this.BtnSystem.Location = new System.Drawing.Point(483, 230);
            this.BtnSystem.Name = "BtnSystem";
            this.BtnSystem.Size = new System.Drawing.Size(121, 56);
            this.BtnSystem.TabIndex = 5;
            this.BtnSystem.Text = "System Info";
            this.BtnSystem.UseVisualStyleBackColor = true;
            this.BtnSystem.Click += new System.EventHandler(this.BtnSystem_Click);
            // 
            // BtnTeste
            // 
            this.BtnTeste.Location = new System.Drawing.Point(124, 333);
            this.BtnTeste.Name = "BtnTeste";
            this.BtnTeste.Size = new System.Drawing.Size(121, 56);
            this.BtnTeste.TabIndex = 6;
            this.BtnTeste.Text = "Tests";
            this.BtnTeste.UseVisualStyleBackColor = true;
            this.BtnTeste.Click += new System.EventHandler(this.BtnTeste_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnTeste);
            this.Controls.Add(this.BtnSystem);
            this.Controls.Add(this.BtnHardware);
            this.Controls.Add(this.BtnDrivers);
            this.Controls.Add(this.BtnDevices);
            this.Controls.Add(this.BtnApplications);
            this.Controls.Add(this.BtnGeral);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button BtnGeral;
        private Button BtnApplications;
        private Button BtnDevices;
        private Button BtnDrivers;
        private Button BtnHardware;
        private Button BtnSystem;
        private Button BtnTeste;
    }
}