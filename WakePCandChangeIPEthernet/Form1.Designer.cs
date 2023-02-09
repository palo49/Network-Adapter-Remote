namespace WakePCandChangeIPEthernet
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cmbAdapters = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.txtIPv4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSubnetMask = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGateway = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblIPv4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSubnet = new System.Windows.Forms.Label();
            this.lblGateway = new System.Windows.Forms.Label();
            this.btnChangeDHCP = new System.Windows.Forms.Button();
            this.lblRemoteTitle = new System.Windows.Forms.Label();
            this.lblRemoteState = new System.Windows.Forms.Label();
            this.bgWorkerRemote = new System.ComponentModel.BackgroundWorker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbAdapters
            // 
            this.cmbAdapters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            this.cmbAdapters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAdapters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAdapters.ForeColor = System.Drawing.Color.White;
            this.cmbAdapters.FormattingEnabled = true;
            this.cmbAdapters.Location = new System.Drawing.Point(14, 32);
            this.cmbAdapters.Name = "cmbAdapters";
            this.cmbAdapters.Size = new System.Drawing.Size(218, 26);
            this.cmbAdapters.TabIndex = 1;
            this.cmbAdapters.SelectedIndexChanged += new System.EventHandler(this.cmbAdapters_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Network adapters:";
            // 
            // btnChange
            // 
            this.btnChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            this.btnChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChange.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(108)))), ((int)(((byte)(77)))));
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnChange.ForeColor = System.Drawing.Color.White;
            this.btnChange.Location = new System.Drawing.Point(810, 12);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(178, 43);
            this.btnChange.TabIndex = 3;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // txtIPv4
            // 
            this.txtIPv4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            this.txtIPv4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIPv4.ForeColor = System.Drawing.Color.White;
            this.txtIPv4.Location = new System.Drawing.Point(274, 31);
            this.txtIPv4.Name = "txtIPv4";
            this.txtIPv4.ReadOnly = true;
            this.txtIPv4.Size = new System.Drawing.Size(218, 24);
            this.txtIPv4.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(274, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Change IPv4 to:";
            // 
            // txtSubnetMask
            // 
            this.txtSubnetMask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            this.txtSubnetMask.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubnetMask.ForeColor = System.Drawing.Color.White;
            this.txtSubnetMask.Location = new System.Drawing.Point(274, 79);
            this.txtSubnetMask.Name = "txtSubnetMask";
            this.txtSubnetMask.ReadOnly = true;
            this.txtSubnetMask.Size = new System.Drawing.Size(218, 24);
            this.txtSubnetMask.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(274, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Change subnet mask to:";
            // 
            // txtGateway
            // 
            this.txtGateway.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            this.txtGateway.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGateway.ForeColor = System.Drawing.Color.White;
            this.txtGateway.Location = new System.Drawing.Point(274, 127);
            this.txtGateway.Name = "txtGateway";
            this.txtGateway.ReadOnly = true;
            this.txtGateway.Size = new System.Drawing.Size(218, 24);
            this.txtGateway.TabIndex = 4;
            this.txtGateway.TextChanged += new System.EventHandler(this.txtGateway_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(274, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Change gateway to:";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(108)))), ((int)(((byte)(77)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(810, 495);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(178, 43);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(14, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Actual value:";
            // 
            // lblIPv4
            // 
            this.lblIPv4.AutoSize = true;
            this.lblIPv4.ForeColor = System.Drawing.Color.White;
            this.lblIPv4.Location = new System.Drawing.Point(14, 106);
            this.lblIPv4.Name = "lblIPv4";
            this.lblIPv4.Size = new System.Drawing.Size(36, 18);
            this.lblIPv4.TabIndex = 2;
            this.lblIPv4.Text = "IPv4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(14, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "IPv4";
            // 
            // lblSubnet
            // 
            this.lblSubnet.AutoSize = true;
            this.lblSubnet.ForeColor = System.Drawing.Color.White;
            this.lblSubnet.Location = new System.Drawing.Point(14, 133);
            this.lblSubnet.Name = "lblSubnet";
            this.lblSubnet.Size = new System.Drawing.Size(54, 18);
            this.lblSubnet.TabIndex = 2;
            this.lblSubnet.Text = "Subnet";
            // 
            // lblGateway
            // 
            this.lblGateway.AutoSize = true;
            this.lblGateway.ForeColor = System.Drawing.Color.White;
            this.lblGateway.Location = new System.Drawing.Point(14, 161);
            this.lblGateway.Name = "lblGateway";
            this.lblGateway.Size = new System.Drawing.Size(66, 18);
            this.lblGateway.TabIndex = 2;
            this.lblGateway.Text = "Gateway";
            // 
            // btnChangeDHCP
            // 
            this.btnChangeDHCP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangeDHCP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            this.btnChangeDHCP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeDHCP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(108)))), ((int)(((byte)(77)))));
            this.btnChangeDHCP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeDHCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnChangeDHCP.ForeColor = System.Drawing.Color.White;
            this.btnChangeDHCP.Location = new System.Drawing.Point(810, 61);
            this.btnChangeDHCP.Name = "btnChangeDHCP";
            this.btnChangeDHCP.Size = new System.Drawing.Size(178, 43);
            this.btnChangeDHCP.TabIndex = 3;
            this.btnChangeDHCP.Text = "Change to dhcp";
            this.btnChangeDHCP.UseVisualStyleBackColor = false;
            this.btnChangeDHCP.Click += new System.EventHandler(this.btnChangeDHCP_Click);
            // 
            // lblRemoteTitle
            // 
            this.lblRemoteTitle.AutoSize = true;
            this.lblRemoteTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRemoteTitle.ForeColor = System.Drawing.Color.White;
            this.lblRemoteTitle.Location = new System.Drawing.Point(14, 269);
            this.lblRemoteTitle.Name = "lblRemoteTitle";
            this.lblRemoteTitle.Size = new System.Drawing.Size(136, 18);
            this.lblRemoteTitle.TabIndex = 6;
            this.lblRemoteTitle.Text = "Server/PC status";
            // 
            // lblRemoteState
            // 
            this.lblRemoteState.AutoSize = true;
            this.lblRemoteState.ForeColor = System.Drawing.Color.White;
            this.lblRemoteState.Location = new System.Drawing.Point(14, 296);
            this.lblRemoteState.Name = "lblRemoteState";
            this.lblRemoteState.Size = new System.Drawing.Size(42, 18);
            this.lblRemoteState.TabIndex = 2;
            this.lblRemoteState.Text = "State";
            // 
            // bgWorkerRemote
            // 
            this.bgWorkerRemote.WorkerSupportsCancellation = true;
            this.bgWorkerRemote.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorkerRemote_DoWork);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(-2, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1007, 2);
            this.label7.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(-2, 480);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(1007, 2);
            this.label8.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(-2, 548);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1007, 2);
            this.label9.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(-2, -1);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(1007, 2);
            this.label10.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(0, -8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(2, 564);
            this.label11.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(998, -8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(2, 564);
            this.label12.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblRemoteTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtGateway);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSubnetMask);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIPv4);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnChangeDHCP);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.lblGateway);
            this.Controls.Add(this.lblSubnet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblIPv4);
            this.Controls.Add(this.lblRemoteState);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbAdapters);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1000, 550);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Local data server network";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbAdapters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.TextBox txtIPv4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSubnetMask;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGateway;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblIPv4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSubnet;
        private System.Windows.Forms.Label lblGateway;
        private System.Windows.Forms.Button btnChangeDHCP;
        private System.Windows.Forms.Label lblRemoteTitle;
        private System.Windows.Forms.Label lblRemoteState;
        private System.ComponentModel.BackgroundWorker bgWorkerRemote;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

