
namespace OpticalReaderConfigurator
{
    partial class Connection
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
			this.comboBoxPort = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.buttonApply = new System.Windows.Forms.Button();
			this.comboBoxBoundRate = new System.Windows.Forms.ComboBox();
			this.labelError = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// comboBoxPort
			// 
			this.comboBoxPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.comboBoxPort.Location = new System.Drawing.Point(152, 56);
			this.comboBoxPort.Name = "comboBoxPort";
			this.comboBoxPort.Size = new System.Drawing.Size(121, 32);
			this.comboBoxPort.TabIndex = 1;
			this.comboBoxPort.DropDown += new System.EventHandler(this.comboBoxPort_DropDown);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.label1.ForeColor = System.Drawing.SystemColors.Control;
			this.label1.Location = new System.Drawing.Point(46, 59);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 24);
			this.label1.TabIndex = 3;
			this.label1.Text = "Port";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.label2.ForeColor = System.Drawing.SystemColors.Control;
			this.label2.Location = new System.Drawing.Point(46, 104);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(90, 24);
			this.label2.TabIndex = 4;
			this.label2.Text = "Baud rate";
			// 
			// buttonApply
			// 
			this.buttonApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.buttonApply.Location = new System.Drawing.Point(50, 151);
			this.buttonApply.Name = "buttonApply";
			this.buttonApply.Size = new System.Drawing.Size(121, 33);
			this.buttonApply.TabIndex = 5;
			this.buttonApply.Text = "Apply";
			this.buttonApply.UseVisualStyleBackColor = true;
			this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
			// 
			// comboBoxBoundRate
			// 
			this.comboBoxBoundRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.comboBoxBoundRate.FormattingEnabled = true;
			this.comboBoxBoundRate.Items.AddRange(new object[] {
            "9600",
            "115200",
            "230400",
            "460800",
            "921600"});
			this.comboBoxBoundRate.Location = new System.Drawing.Point(152, 101);
			this.comboBoxBoundRate.Name = "comboBoxBoundRate";
			this.comboBoxBoundRate.Size = new System.Drawing.Size(121, 32);
			this.comboBoxBoundRate.TabIndex = 6;
			this.comboBoxBoundRate.Text = "115200";
			// 
			// labelError
			// 
			this.labelError.AutoSize = true;
			this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.labelError.ForeColor = System.Drawing.Color.Red;
			this.labelError.Location = new System.Drawing.Point(177, 155);
			this.labelError.Name = "labelError";
			this.labelError.Size = new System.Drawing.Size(134, 24);
			this.labelError.TabIndex = 7;
			this.labelError.Text = "PORT ERROR";
			this.labelError.Visible = false;
			// 
			// Connection
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
			this.ClientSize = new System.Drawing.Size(1246, 787);
			this.Controls.Add(this.labelError);
			this.Controls.Add(this.comboBoxBoundRate);
			this.Controls.Add(this.buttonApply);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBoxPort);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Connection";
			this.Text = "Connection";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.ComboBox comboBoxBoundRate;
		private System.Windows.Forms.Label labelError;
	}
}