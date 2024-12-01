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
            this.lblSubnet = new System.Windows.Forms.Label();
            this.lblGateway = new System.Windows.Forms.Label();
            this.btnChangeDHCP = new System.Windows.Forms.Button();
            this.lblRemoteTitle = new System.Windows.Forms.Label();
            this.lblRemoteState = new System.Windows.Forms.Label();
            this.bgWorkerRemote = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnReloadInfo = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSubnetDefault = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbAdapters
            // 
            this.cmbAdapters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.cmbAdapters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAdapters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAdapters.ForeColor = System.Drawing.Color.Black;
            this.cmbAdapters.FormattingEnabled = true;
            this.cmbAdapters.Location = new System.Drawing.Point(14, 32);
            this.cmbAdapters.Name = "cmbAdapters";
            this.cmbAdapters.Size = new System.Drawing.Size(218, 23);
            this.cmbAdapters.TabIndex = 1;
            this.cmbAdapters.SelectedIndexChanged += new System.EventHandler(this.cmbAdapters_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Network adapters:";
            // 
            // btnChange
            // 
            this.btnChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.btnChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChange.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(108)))), ((int)(((byte)(77)))));
            this.btnChange.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(108)))), ((int)(((byte)(77)))));
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnChange.Location = new System.Drawing.Point(394, 10);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(178, 43);
            this.btnChange.TabIndex = 3;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // txtIPv4
            // 
            this.txtIPv4.BackColor = System.Drawing.Color.Ivory;
            this.txtIPv4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIPv4.ForeColor = System.Drawing.Color.Black;
            this.txtIPv4.Location = new System.Drawing.Point(14, 224);
            this.txtIPv4.Name = "txtIPv4";
            this.txtIPv4.ReadOnly = true;
            this.txtIPv4.Size = new System.Drawing.Size(218, 21);
            this.txtIPv4.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(14, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Change IPv4 to:";
            // 
            // txtSubnetMask
            // 
            this.txtSubnetMask.BackColor = System.Drawing.Color.Ivory;
            this.txtSubnetMask.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubnetMask.ForeColor = System.Drawing.Color.Black;
            this.txtSubnetMask.Location = new System.Drawing.Point(14, 272);
            this.txtSubnetMask.Name = "txtSubnetMask";
            this.txtSubnetMask.ReadOnly = true;
            this.txtSubnetMask.Size = new System.Drawing.Size(218, 21);
            this.txtSubnetMask.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(14, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Change subnet mask to:";
            // 
            // txtGateway
            // 
            this.txtGateway.BackColor = System.Drawing.Color.Ivory;
            this.txtGateway.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGateway.ForeColor = System.Drawing.Color.Black;
            this.txtGateway.Location = new System.Drawing.Point(14, 320);
            this.txtGateway.Name = "txtGateway";
            this.txtGateway.ReadOnly = true;
            this.txtGateway.Size = new System.Drawing.Size(218, 21);
            this.txtGateway.TabIndex = 4;
            this.txtGateway.TextChanged += new System.EventHandler(this.txtGateway_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(14, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Change gateway to:";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(108)))), ((int)(((byte)(77)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(108)))), ((int)(((byte)(77)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnClose.Location = new System.Drawing.Point(394, 376);
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
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(14, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Actual value:";
            // 
            // lblIPv4
            // 
            this.lblIPv4.AutoSize = true;
            this.lblIPv4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lblIPv4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIPv4.ForeColor = System.Drawing.Color.DimGray;
            this.lblIPv4.Location = new System.Drawing.Point(84, 108);
            this.lblIPv4.Name = "lblIPv4";
            this.lblIPv4.Size = new System.Drawing.Size(33, 13);
            this.lblIPv4.TabIndex = 2;
            this.lblIPv4.Text = "IPv4";
            // 
            // lblSubnet
            // 
            this.lblSubnet.AutoSize = true;
            this.lblSubnet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lblSubnet.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSubnet.ForeColor = System.Drawing.Color.DimGray;
            this.lblSubnet.Location = new System.Drawing.Point(84, 134);
            this.lblSubnet.Name = "lblSubnet";
            this.lblSubnet.Size = new System.Drawing.Size(47, 13);
            this.lblSubnet.TabIndex = 2;
            this.lblSubnet.Text = "Subnet";
            // 
            // lblGateway
            // 
            this.lblGateway.AutoSize = true;
            this.lblGateway.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lblGateway.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblGateway.ForeColor = System.Drawing.Color.DimGray;
            this.lblGateway.Location = new System.Drawing.Point(84, 161);
            this.lblGateway.Name = "lblGateway";
            this.lblGateway.Size = new System.Drawing.Size(57, 13);
            this.lblGateway.TabIndex = 2;
            this.lblGateway.Text = "Gateway";
            // 
            // btnChangeDHCP
            // 
            this.btnChangeDHCP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangeDHCP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.btnChangeDHCP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeDHCP.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(108)))), ((int)(((byte)(77)))));
            this.btnChangeDHCP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(108)))), ((int)(((byte)(77)))));
            this.btnChangeDHCP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeDHCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnChangeDHCP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnChangeDHCP.Location = new System.Drawing.Point(394, 65);
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
            this.lblRemoteTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.lblRemoteTitle.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRemoteTitle.ForeColor = System.Drawing.Color.Black;
            this.lblRemoteTitle.Location = new System.Drawing.Point(14, 371);
            this.lblRemoteTitle.Name = "lblRemoteTitle";
            this.lblRemoteTitle.Size = new System.Drawing.Size(91, 13);
            this.lblRemoteTitle.TabIndex = 6;
            this.lblRemoteTitle.Text = "Remote status";
            // 
            // lblRemoteState
            // 
            this.lblRemoteState.AutoSize = true;
            this.lblRemoteState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.lblRemoteState.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRemoteState.ForeColor = System.Drawing.Color.Black;
            this.lblRemoteState.Location = new System.Drawing.Point(14, 398);
            this.lblRemoteState.Name = "lblRemoteState";
            this.lblRemoteState.Size = new System.Drawing.Size(38, 13);
            this.lblRemoteState.TabIndex = 2;
            this.lblRemoteState.Text = "State";
            // 
            // bgWorkerRemote
            // 
            this.bgWorkerRemote.WorkerSupportsCancellation = true;
            this.bgWorkerRemote.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorkerRemote_DoWork);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.panel1.Controls.Add(this.panel12);
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 435);
            this.panel1.TabIndex = 7;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.panel12.Controls.Add(this.btnSubnetDefault);
            this.panel12.Location = new System.Drawing.Point(3, 189);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(378, 172);
            this.panel12.TabIndex = 1;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.panel11.Controls.Add(this.btnReloadInfo);
            this.panel11.Controls.Add(this.label8);
            this.panel11.Controls.Add(this.label7);
            this.panel11.Controls.Add(this.label6);
            this.panel11.Controls.Add(this.lblIPv4);
            this.panel11.Controls.Add(this.lblSubnet);
            this.panel11.Controls.Add(this.lblGateway);
            this.panel11.Location = new System.Drawing.Point(3, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(378, 190);
            this.panel11.TabIndex = 0;
            // 
            // btnReloadInfo
            // 
            this.btnReloadInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReloadInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.btnReloadInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReloadInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.btnReloadInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReloadInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnReloadInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnReloadInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnReloadInfo.Image")));
            this.btnReloadInfo.Location = new System.Drawing.Point(93, 75);
            this.btnReloadInfo.Margin = new System.Windows.Forms.Padding(0);
            this.btnReloadInfo.Name = "btnReloadInfo";
            this.btnReloadInfo.Size = new System.Drawing.Size(23, 23);
            this.btnReloadInfo.TabIndex = 9;
            this.btnReloadInfo.UseVisualStyleBackColor = false;
            this.btnReloadInfo.Click += new System.EventHandler(this.btnReloadInfo_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(10, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Gateway:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(11, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Subnet:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(13, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "IPv4:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.panel2.Location = new System.Drawing.Point(378, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(212, 435);
            this.panel2.TabIndex = 8;
            // 
            // btnSubnetDefault
            // 
            this.btnSubnetDefault.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubnetDefault.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.btnSubnetDefault.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubnetDefault.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(108)))), ((int)(((byte)(77)))));
            this.btnSubnetDefault.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(108)))), ((int)(((byte)(77)))));
            this.btnSubnetDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubnetDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSubnetDefault.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnSubnetDefault.Location = new System.Drawing.Point(237, 82);
            this.btnSubnetDefault.Name = "btnSubnetDefault";
            this.btnSubnetDefault.Size = new System.Drawing.Size(65, 24);
            this.btnSubnetDefault.TabIndex = 9;
            this.btnSubnetDefault.Text = "Default";
            this.btnSubnetDefault.UseVisualStyleBackColor = false;
            this.btnSubnetDefault.Click += new System.EventHandler(this.btnSubnetDefault_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(584, 431);
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
            this.Controls.Add(this.lblRemoteState);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbAdapters);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 470);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adapter settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
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
        private System.Windows.Forms.Label lblSubnet;
        private System.Windows.Forms.Label lblGateway;
        private System.Windows.Forms.Button btnChangeDHCP;
        private System.Windows.Forms.Label lblRemoteTitle;
        private System.Windows.Forms.Label lblRemoteState;
        private System.ComponentModel.BackgroundWorker bgWorkerRemote;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnReloadInfo;
        private System.Windows.Forms.Button btnSubnetDefault;
    }
}

