namespace YGeocoder
{
    partial class fmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbCenterPriority = new System.Windows.Forms.CheckBox();
            this.cbGetReverseAddr = new System.Windows.Forms.CheckBox();
            this.lbLang = new System.Windows.Forms.Label();
            this.cbLang = new System.Windows.Forms.ComboBox();
            this.lbCoord = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.btReverseGeo = new System.Windows.Forms.Button();
            this.tbCoordinates = new System.Windows.Forms.TextBox();
            this.btGeo = new System.Windows.Forms.Button();
            this.lbManual = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btStop = new System.Windows.Forms.Button();
            this.dgData = new System.Windows.Forms.DataGridView();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReverseAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Long = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kind = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubAdm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Locality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thoroughfare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Premise = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmStripe = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miCopyAll = new System.Windows.Forms.ToolStripMenuItem();
            this.miCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.miPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.lbAbout = new System.Windows.Forms.Label();
            this.btGeoAll = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btOpen = new System.Windows.Forms.Button();
            this.lbBatch = new System.Windows.Forms.Label();
            this.ssBar = new System.Windows.Forms.StatusStrip();
            this.tsProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.tsStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).BeginInit();
            this.cmStripe.SuspendLayout();
            this.ssBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbCenterPriority);
            this.panel1.Controls.Add(this.cbGetReverseAddr);
            this.panel1.Controls.Add(this.lbLang);
            this.panel1.Controls.Add(this.cbLang);
            this.panel1.Controls.Add(this.lbCoord);
            this.panel1.Controls.Add(this.lbAddress);
            this.panel1.Controls.Add(this.btReverseGeo);
            this.panel1.Controls.Add(this.tbCoordinates);
            this.panel1.Controls.Add(this.btGeo);
            this.panel1.Controls.Add(this.lbManual);
            this.panel1.Controls.Add(this.tbAddress);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(839, 119);
            this.panel1.TabIndex = 11;
            // 
            // cbCenterPriority
            // 
            this.cbCenterPriority.AutoSize = true;
            this.cbCenterPriority.Location = new System.Drawing.Point(101, 97);
            this.cbCenterPriority.Name = "cbCenterPriority";
            this.cbCenterPriority.Size = new System.Drawing.Size(90, 17);
            this.cbCenterPriority.TabIndex = 4;
            this.cbCenterPriority.Text = "Center priority";
            this.cbCenterPriority.UseVisualStyleBackColor = true;
            // 
            // cbGetReverseAddr
            // 
            this.cbGetReverseAddr.AutoSize = true;
            this.cbGetReverseAddr.Location = new System.Drawing.Point(197, 97);
            this.cbGetReverseAddr.Name = "cbGetReverseAddr";
            this.cbGetReverseAddr.Size = new System.Drawing.Size(144, 17);
            this.cbGetReverseAddr.TabIndex = 5;
            this.cbGetReverseAddr.Text = "Request reverse address";
            this.cbGetReverseAddr.UseVisualStyleBackColor = true;
            this.cbGetReverseAddr.Visible = false;
            // 
            // lbLang
            // 
            this.lbLang.AutoSize = true;
            this.lbLang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbLang.Location = new System.Drawing.Point(12, 73);
            this.lbLang.Name = "lbLang";
            this.lbLang.Size = new System.Drawing.Size(40, 17);
            this.lbLang.TabIndex = 21;
            this.lbLang.Text = "Lang";
            // 
            // cbLang
            // 
            this.cbLang.FormattingEnabled = true;
            this.cbLang.Location = new System.Drawing.Point(12, 93);
            this.cbLang.Name = "cbLang";
            this.cbLang.Size = new System.Drawing.Size(83, 21);
            this.cbLang.TabIndex = 3;
            this.cbLang.SelectedIndexChanged += new System.EventHandler(this.cbLang_SelectedIndexChanged);
            // 
            // lbCoord
            // 
            this.lbCoord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCoord.AutoSize = true;
            this.lbCoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCoord.Location = new System.Drawing.Point(668, 30);
            this.lbCoord.Name = "lbCoord";
            this.lbCoord.Size = new System.Drawing.Size(84, 17);
            this.lbCoord.TabIndex = 16;
            this.lbCoord.Text = "Coordinates";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAddress.Location = new System.Drawing.Point(12, 30);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(60, 17);
            this.lbAddress.TabIndex = 15;
            this.lbAddress.Text = "Address";
            // 
            // btReverseGeo
            // 
            this.btReverseGeo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btReverseGeo.Location = new System.Drawing.Point(752, 91);
            this.btReverseGeo.Name = "btReverseGeo";
            this.btReverseGeo.Size = new System.Drawing.Size(75, 23);
            this.btReverseGeo.TabIndex = 7;
            this.btReverseGeo.Text = "<- Reverse";
            this.btReverseGeo.UseVisualStyleBackColor = true;
            this.btReverseGeo.Click += new System.EventHandler(this.btReverseGeo_Click);
            // 
            // tbCoordinates
            // 
            this.tbCoordinates.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCoordinates.Location = new System.Drawing.Point(671, 50);
            this.tbCoordinates.Name = "tbCoordinates";
            this.tbCoordinates.Size = new System.Drawing.Size(156, 20);
            this.tbCoordinates.TabIndex = 2;
            // 
            // btGeo
            // 
            this.btGeo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btGeo.Location = new System.Drawing.Point(671, 91);
            this.btGeo.Name = "btGeo";
            this.btGeo.Size = new System.Drawing.Size(75, 23);
            this.btGeo.TabIndex = 6;
            this.btGeo.Text = "Geocode ->";
            this.btGeo.UseVisualStyleBackColor = true;
            this.btGeo.Click += new System.EventHandler(this.btGeo_Click);
            // 
            // lbManual
            // 
            this.lbManual.AutoSize = true;
            this.lbManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbManual.Location = new System.Drawing.Point(12, 9);
            this.lbManual.Name = "lbManual";
            this.lbManual.Size = new System.Drawing.Size(120, 17);
            this.lbManual.TabIndex = 11;
            this.lbManual.Text = "Single geocode";
            // 
            // tbAddress
            // 
            this.tbAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAddress.Location = new System.Drawing.Point(12, 50);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(653, 20);
            this.tbAddress.TabIndex = 1;
            this.tbAddress.Text = "Москва, Александровский сад";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btStop);
            this.panel2.Controls.Add(this.dgData);
            this.panel2.Controls.Add(this.lbAbout);
            this.panel2.Controls.Add(this.btGeoAll);
            this.panel2.Controls.Add(this.btClear);
            this.panel2.Controls.Add(this.btOpen);
            this.panel2.Controls.Add(this.lbBatch);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 119);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(839, 270);
            this.panel2.TabIndex = 12;
            // 
            // btStop
            // 
            this.btStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btStop.Enabled = false;
            this.btStop.Location = new System.Drawing.Point(752, 222);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(75, 23);
            this.btStop.TabIndex = 12;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // dgData
            // 
            this.dgData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Address,
            this.ReverseAddress,
            this.Lat,
            this.Long,
            this.Distance,
            this.Kind,
            this.Precision,
            this.Country,
            this.Adm,
            this.SubAdm,
            this.Locality,
            this.Thoroughfare,
            this.Premise});
            this.dgData.ContextMenuStrip = this.cmStripe;
            this.dgData.Location = new System.Drawing.Point(15, 23);
            this.dgData.Name = "dgData";
            this.dgData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgData.Size = new System.Drawing.Size(812, 193);
            this.dgData.TabIndex = 8;
            // 
            // Address
            // 
            this.Address.FillWeight = 150F;
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.Width = 300;
            // 
            // ReverseAddress
            // 
            this.ReverseAddress.FillWeight = 150F;
            this.ReverseAddress.HeaderText = "Reverse Address";
            this.ReverseAddress.Name = "ReverseAddress";
            this.ReverseAddress.Width = 300;
            // 
            // Lat
            // 
            this.Lat.HeaderText = "Lat";
            this.Lat.Name = "Lat";
            this.Lat.Width = 80;
            // 
            // Long
            // 
            this.Long.HeaderText = "Long";
            this.Long.Name = "Long";
            this.Long.Width = 80;
            // 
            // Distance
            // 
            this.Distance.HeaderText = "Distance";
            this.Distance.Name = "Distance";
            // 
            // Kind
            // 
            this.Kind.HeaderText = "Kind";
            this.Kind.Name = "Kind";
            // 
            // Precision
            // 
            this.Precision.HeaderText = "Precision";
            this.Precision.Name = "Precision";
            // 
            // Country
            // 
            this.Country.HeaderText = "Country";
            this.Country.Name = "Country";
            // 
            // Adm
            // 
            this.Adm.HeaderText = "Adm";
            this.Adm.Name = "Adm";
            // 
            // SubAdm
            // 
            this.SubAdm.HeaderText = "SubAdm";
            this.SubAdm.Name = "SubAdm";
            // 
            // Locality
            // 
            this.Locality.HeaderText = "Locality";
            this.Locality.Name = "Locality";
            // 
            // Thoroughfare
            // 
            this.Thoroughfare.HeaderText = "Thoroughfare";
            this.Thoroughfare.Name = "Thoroughfare";
            // 
            // Premise
            // 
            this.Premise.HeaderText = "Premise";
            this.Premise.Name = "Premise";
            // 
            // cmStripe
            // 
            this.cmStripe.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miCopyAll,
            this.miCopy,
            this.miPaste});
            this.cmStripe.Name = "cmStripe";
            this.cmStripe.Size = new System.Drawing.Size(120, 70);
            // 
            // miCopyAll
            // 
            this.miCopyAll.Name = "miCopyAll";
            this.miCopyAll.Size = new System.Drawing.Size(119, 22);
            this.miCopyAll.Text = "Copy All";
            this.miCopyAll.Click += new System.EventHandler(this.miCopyAll_Click);
            // 
            // miCopy
            // 
            this.miCopy.Name = "miCopy";
            this.miCopy.Size = new System.Drawing.Size(119, 22);
            this.miCopy.Text = "Copy";
            this.miCopy.Click += new System.EventHandler(this.miCopy_Click);
            // 
            // miPaste
            // 
            this.miPaste.Name = "miPaste";
            this.miPaste.Size = new System.Drawing.Size(119, 22);
            this.miPaste.Text = "Paste";
            this.miPaste.Click += new System.EventHandler(this.miPaste_Click);
            // 
            // lbAbout
            // 
            this.lbAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbAbout.AutoSize = true;
            this.lbAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAbout.Location = new System.Drawing.Point(12, 229);
            this.lbAbout.Name = "lbAbout";
            this.lbAbout.Size = new System.Drawing.Size(35, 13);
            this.lbAbout.TabIndex = 15;
            this.lbAbout.Text = "About";
            this.lbAbout.Click += new System.EventHandler(this.lbAbout_Click);
            // 
            // btGeoAll
            // 
            this.btGeoAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btGeoAll.Location = new System.Drawing.Point(671, 222);
            this.btGeoAll.Name = "btGeoAll";
            this.btGeoAll.Size = new System.Drawing.Size(75, 23);
            this.btGeoAll.TabIndex = 11;
            this.btGeoAll.Text = "Batch";
            this.btGeoAll.UseVisualStyleBackColor = true;
            this.btGeoAll.Click += new System.EventHandler(this.btGeoAll_Click);
            // 
            // btClear
            // 
            this.btClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btClear.Location = new System.Drawing.Point(590, 222);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(75, 23);
            this.btClear.TabIndex = 10;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btOpen
            // 
            this.btOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btOpen.Enabled = false;
            this.btOpen.Location = new System.Drawing.Point(509, 222);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(75, 23);
            this.btOpen.TabIndex = 9;
            this.btOpen.Text = "Open";
            this.btOpen.UseVisualStyleBackColor = true;
            // 
            // lbBatch
            // 
            this.lbBatch.AutoSize = true;
            this.lbBatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbBatch.Location = new System.Drawing.Point(12, 3);
            this.lbBatch.Name = "lbBatch";
            this.lbBatch.Size = new System.Drawing.Size(116, 17);
            this.lbBatch.TabIndex = 11;
            this.lbBatch.Text = "Batch geocode";
            // 
            // ssBar
            // 
            this.ssBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsProgressBar,
            this.tsStatus});
            this.ssBar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.ssBar.Location = new System.Drawing.Point(0, 367);
            this.ssBar.Name = "ssBar";
            this.ssBar.Size = new System.Drawing.Size(839, 22);
            this.ssBar.TabIndex = 18;
            this.ssBar.Text = "statusStrip1";
            // 
            // tsProgressBar
            // 
            this.tsProgressBar.Name = "tsProgressBar";
            this.tsProgressBar.Size = new System.Drawing.Size(200, 16);
            // 
            // tsStatus
            // 
            this.tsStatus.Name = "tsStatus";
            this.tsStatus.Size = new System.Drawing.Size(39, 17);
            this.tsStatus.Text = "Ready";
            this.tsStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 389);
            this.Controls.Add(this.ssBar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(550, 280);
            this.Name = "fmMain";
            this.Text = "YGeocoder";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).EndInit();
            this.cmStripe.ResumeLayout(false);
            this.ssBar.ResumeLayout(false);
            this.ssBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbCoord;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Button btReverseGeo;
        private System.Windows.Forms.TextBox tbCoordinates;
        private System.Windows.Forms.Button btGeo;
        private System.Windows.Forms.Label lbManual;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbAbout;
        private System.Windows.Forms.Button btGeoAll;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.Label lbBatch;
        private System.Windows.Forms.DataGridView dgData;
        private System.Windows.Forms.ContextMenuStrip cmStripe;
        private System.Windows.Forms.ToolStripMenuItem miCopy;
        private System.Windows.Forms.ToolStripMenuItem miPaste;
        private System.Windows.Forms.ToolStripMenuItem miCopyAll;
        private System.Windows.Forms.StatusStrip ssBar;
        private System.Windows.Forms.ToolStripStatusLabel tsStatus;
        private System.Windows.Forms.ToolStripProgressBar tsProgressBar;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Label lbLang;
        private System.Windows.Forms.ComboBox cbLang;
        private System.Windows.Forms.CheckBox cbCenterPriority;
        private System.Windows.Forms.CheckBox cbGetReverseAddr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReverseAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Long;
        private System.Windows.Forms.DataGridViewTextBoxColumn Distance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kind;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precision;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adm;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubAdm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Locality;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thoroughfare;
        private System.Windows.Forms.DataGridViewTextBoxColumn Premise;
    }
}

