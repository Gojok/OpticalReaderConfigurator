
namespace OpticalReaderConfigurator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonLog = new System.Windows.Forms.Button();
            this.labelConnInfo = new System.Windows.Forms.Label();
            this.buttonPhoto = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonWanSettings = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelUp = new System.Windows.Forms.Panel();
            this.pictureBoxHide = new System.Windows.Forms.PictureBox();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Goldenrod;
            this.panel1.Controls.Add(this.buttonLog);
            this.panel1.Controls.Add(this.labelConnInfo);
            this.panel1.Controls.Add(this.buttonPhoto);
            this.panel1.Controls.Add(this.buttonConnect);
            this.panel1.Controls.Add(this.buttonWanSettings);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 823);
            this.panel1.TabIndex = 0;
            // 
            // buttonLog
            // 
            this.buttonLog.FlatAppearance.BorderSize = 0;
            this.buttonLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.buttonLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.buttonLog.Location = new System.Drawing.Point(0, 221);
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.Size = new System.Drawing.Size(206, 52);
            this.buttonLog.TabIndex = 5;
            this.buttonLog.Text = "Log";
            this.buttonLog.UseVisualStyleBackColor = true;
            this.buttonLog.Click += new System.EventHandler(this.buttonLog_Click);
            // 
            // labelConnInfo
            // 
            this.labelConnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelConnInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelConnInfo.ForeColor = System.Drawing.Color.Red;
            this.labelConnInfo.Location = new System.Drawing.Point(0, 778);
            this.labelConnInfo.Name = "labelConnInfo";
            this.labelConnInfo.Size = new System.Drawing.Size(206, 45);
            this.labelConnInfo.TabIndex = 4;
            this.labelConnInfo.Text = "Disconnect";
            this.labelConnInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonPhoto
            // 
            this.buttonPhoto.FlatAppearance.BorderSize = 0;
            this.buttonPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.buttonPhoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.buttonPhoto.Location = new System.Drawing.Point(0, 123);
            this.buttonPhoto.Name = "buttonPhoto";
            this.buttonPhoto.Size = new System.Drawing.Size(206, 52);
            this.buttonPhoto.TabIndex = 3;
            this.buttonPhoto.Text = "Photo";
            this.buttonPhoto.UseVisualStyleBackColor = true;
            this.buttonPhoto.Click += new System.EventHandler(this.buttonPhoto_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.FlatAppearance.BorderSize = 0;
            this.buttonConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.buttonConnect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.buttonConnect.Location = new System.Drawing.Point(0, 74);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(206, 52);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonWanSettings
            // 
            this.buttonWanSettings.FlatAppearance.BorderSize = 0;
            this.buttonWanSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWanSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.buttonWanSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.buttonWanSettings.Location = new System.Drawing.Point(0, 172);
            this.buttonWanSettings.Name = "buttonWanSettings";
            this.buttonWanSettings.Size = new System.Drawing.Size(206, 52);
            this.buttonWanSettings.TabIndex = 1;
            this.buttonWanSettings.Text = "WAN settings";
            this.buttonWanSettings.UseVisualStyleBackColor = true;
            this.buttonWanSettings.Click += new System.EventHandler(this.buttonWanSettings_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::OpticalReaderConfigurator.Properties.Resources._15664539013432;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelUp
            // 
            this.panelUp.BackColor = System.Drawing.Color.Goldenrod;
            this.panelUp.Controls.Add(this.pictureBoxHide);
            this.panelUp.Controls.Add(this.pictureBoxClose);
            this.panelUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUp.Location = new System.Drawing.Point(206, 0);
            this.panelUp.Name = "panelUp";
            this.panelUp.Size = new System.Drawing.Size(1246, 36);
            this.panelUp.TabIndex = 1;
            this.panelUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelUp_MouseDown);
            // 
            // pictureBoxHide
            // 
            this.pictureBoxHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxHide.Image = global::OpticalReaderConfigurator.Properties.Resources.icon_minimizar;
            this.pictureBoxHide.Location = new System.Drawing.Point(1185, 4);
            this.pictureBoxHide.Name = "pictureBoxHide";
            this.pictureBoxHide.Size = new System.Drawing.Size(26, 26);
            this.pictureBoxHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxHide.TabIndex = 1;
            this.pictureBoxHide.TabStop = false;
            this.pictureBoxHide.Click += new System.EventHandler(this.pictureBoxHide_Click);
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxClose.Image = global::OpticalReaderConfigurator.Properties.Resources.icon_cerrar2;
            this.pictureBoxClose.Location = new System.Drawing.Point(1217, 4);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(26, 26);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxClose.TabIndex = 0;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(206, 36);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1246, 787);
            this.panelContent.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1452, 823);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelUp);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelUp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelUp;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonWanSettings;
        private System.Windows.Forms.Button buttonPhoto;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.PictureBox pictureBoxHide;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Label labelConnInfo;
        private System.Windows.Forms.Button buttonLog;
    }
}