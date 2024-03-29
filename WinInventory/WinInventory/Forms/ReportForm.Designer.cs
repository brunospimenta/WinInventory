﻿namespace WinInventory.Forms
{
    partial class ReportForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnGeral
            // 
            this.BtnGeral.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnGeral.Location = new System.Drawing.Point(126, 47);
            this.BtnGeral.Name = "BtnGeral";
            this.BtnGeral.Size = new System.Drawing.Size(103, 46);
            this.BtnGeral.TabIndex = 0;
            this.BtnGeral.Text = "Geral";
            this.BtnGeral.UseVisualStyleBackColor = true;
            this.BtnGeral.Click += new System.EventHandler(this.BtnGeral_Click);
            // 
            // BtnApplications
            // 
            this.BtnApplications.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnApplications.Location = new System.Drawing.Point(449, 47);
            this.BtnApplications.Name = "BtnApplications";
            this.BtnApplications.Size = new System.Drawing.Size(103, 46);
            this.BtnApplications.TabIndex = 1;
            this.BtnApplications.Text = "Applications";
            this.BtnApplications.UseVisualStyleBackColor = true;
            this.BtnApplications.Click += new System.EventHandler(this.BtnApplications_Click);
            // 
            // BtnDevices
            // 
            this.BtnDevices.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDevices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDevices.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnDevices.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.BtnDevices.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnDevices.Location = new System.Drawing.Point(126, 110);
            this.BtnDevices.Name = "BtnDevices";
            this.BtnDevices.Size = new System.Drawing.Size(103, 46);
            this.BtnDevices.TabIndex = 2;
            this.BtnDevices.Text = "Devices";
            this.BtnDevices.UseVisualStyleBackColor = true;
            this.BtnDevices.Click += new System.EventHandler(this.BtnDevices_Click);
            // 
            // BtnDrivers
            // 
            this.BtnDrivers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDrivers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDrivers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnDrivers.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.BtnDrivers.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnDrivers.Location = new System.Drawing.Point(449, 110);
            this.BtnDrivers.Name = "BtnDrivers";
            this.BtnDrivers.Size = new System.Drawing.Size(103, 46);
            this.BtnDrivers.TabIndex = 3;
            this.BtnDrivers.Text = "Drivers";
            this.BtnDrivers.UseVisualStyleBackColor = true;
            this.BtnDrivers.Click += new System.EventHandler(this.BtnDrivers_Click);
            // 
            // BtnHardware
            // 
            this.BtnHardware.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnHardware.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnHardware.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnHardware.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.BtnHardware.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnHardware.Location = new System.Drawing.Point(126, 182);
            this.BtnHardware.Name = "BtnHardware";
            this.BtnHardware.Size = new System.Drawing.Size(103, 46);
            this.BtnHardware.TabIndex = 4;
            this.BtnHardware.Text = "Hardware";
            this.BtnHardware.UseVisualStyleBackColor = true;
            this.BtnHardware.Click += new System.EventHandler(this.BtnHardware_Click);
            // 
            // BtnSystem
            // 
            this.BtnSystem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSystem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSystem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnSystem.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.BtnSystem.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSystem.Location = new System.Drawing.Point(449, 182);
            this.BtnSystem.Name = "BtnSystem";
            this.BtnSystem.Size = new System.Drawing.Size(103, 46);
            this.BtnSystem.TabIndex = 5;
            this.BtnSystem.Text = "System Info";
            this.BtnSystem.UseVisualStyleBackColor = true;
            this.BtnSystem.Click += new System.EventHandler(this.BtnSystem_Click);
            // 
            // BtnTeste
            // 
            this.BtnTeste.BackColor = System.Drawing.Color.Transparent;
            this.BtnTeste.Location = new System.Drawing.Point(280, 264);
            this.BtnTeste.Name = "BtnTeste";
            this.BtnTeste.Size = new System.Drawing.Size(103, 46);
            this.BtnTeste.TabIndex = 6;
            this.BtnTeste.Text = "Tests";
            this.BtnTeste.UseVisualStyleBackColor = false;
            this.BtnTeste.Click += new System.EventHandler(this.BtnTeste_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.button1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(126, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Geral";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnGeral_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.button2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(449, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 46);
            this.button2.TabIndex = 1;
            this.button2.Text = "Applications";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BtnApplications_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 339);
            this.Controls.Add(this.BtnTeste);
            this.Controls.Add(this.BtnSystem);
            this.Controls.Add(this.BtnHardware);
            this.Controls.Add(this.BtnDrivers);
            this.Controls.Add(this.BtnDevices);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnApplications);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnGeral);
            this.Name = "ReportForm";
            this.Text = "Report Generator";
            this.Load += new System.EventHandler(this.ReportForm_Load);
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
        private Button button1;
        private Button button2;
    }
}