namespace ObjectSizes
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
            this.components = new System.ComponentModel.Container();
            this.bnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.gbShowSize = new System.Windows.Forms.GroupBox();
            this.rbMBytes = new System.Windows.Forms.RadioButton();
            this.rbKBytes = new System.Windows.Forms.RadioButton();
            this.rbBytes = new System.Windows.Forms.RadioButton();
            this.gbMinShowSize = new System.Windows.Forms.GroupBox();
            this.numMinSizeToShow = new System.Windows.Forms.TextBox();
            this.cbIgnoreSomeSizes = new System.Windows.Forms.CheckBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbFile = new AutoEllipsis.TextBoxEllipsis();
            this.tlvNodes = new BrightIdeasSoftware.TreeListView();
            this.olvName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvObjId = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvSize = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvSizeBar = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.barRenderer1 = new BrightIdeasSoftware.BarRenderer();
            this.gbShowSize.SuspendLayout();
            this.gbMinShowSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlvNodes)).BeginInit();
            this.SuspendLayout();
            // 
            // bnSearch
            // 
            this.bnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnSearch.Location = new System.Drawing.Point(447, 12);
            this.bnSearch.Name = "bnSearch";
            this.bnSearch.Size = new System.Drawing.Size(75, 23);
            this.bnSearch.TabIndex = 1;
            this.bnSearch.Text = "Search";
            this.bnSearch.UseVisualStyleBackColor = true;
            this.bnSearch.Click += new System.EventHandler(this.bnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "File:";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(155, 21);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(33, 13);
            this.lblSize.TabIndex = 8;
            this.lblSize.Text = "Bytes";
            // 
            // gbShowSize
            // 
            this.gbShowSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbShowSize.Controls.Add(this.rbMBytes);
            this.gbShowSize.Controls.Add(this.rbKBytes);
            this.gbShowSize.Controls.Add(this.rbBytes);
            this.gbShowSize.Location = new System.Drawing.Point(12, 421);
            this.gbShowSize.Name = "gbShowSize";
            this.gbShowSize.Size = new System.Drawing.Size(221, 48);
            this.gbShowSize.TabIndex = 9;
            this.gbShowSize.TabStop = false;
            this.gbShowSize.Text = "Show Size in";
            // 
            // rbMBytes
            // 
            this.rbMBytes.AutoSize = true;
            this.rbMBytes.Location = new System.Drawing.Point(151, 19);
            this.rbMBytes.Name = "rbMBytes";
            this.rbMBytes.Size = new System.Drawing.Size(60, 17);
            this.rbMBytes.TabIndex = 2;
            this.rbMBytes.Text = "MBytes";
            this.rbMBytes.UseVisualStyleBackColor = true;
            this.rbMBytes.CheckedChanged += new System.EventHandler(this.rbBytes_CheckedChanged);
            // 
            // rbKBytes
            // 
            this.rbKBytes.AutoSize = true;
            this.rbKBytes.Location = new System.Drawing.Point(75, 19);
            this.rbKBytes.Name = "rbKBytes";
            this.rbKBytes.Size = new System.Drawing.Size(58, 17);
            this.rbKBytes.TabIndex = 1;
            this.rbKBytes.Text = "KBytes";
            this.rbKBytes.UseVisualStyleBackColor = true;
            this.rbKBytes.CheckedChanged += new System.EventHandler(this.rbBytes_CheckedChanged);
            // 
            // rbBytes
            // 
            this.rbBytes.AutoSize = true;
            this.rbBytes.Checked = true;
            this.rbBytes.Location = new System.Drawing.Point(6, 19);
            this.rbBytes.Name = "rbBytes";
            this.rbBytes.Size = new System.Drawing.Size(51, 17);
            this.rbBytes.TabIndex = 0;
            this.rbBytes.TabStop = true;
            this.rbBytes.Text = "Bytes";
            this.rbBytes.UseVisualStyleBackColor = true;
            this.rbBytes.CheckedChanged += new System.EventHandler(this.rbBytes_CheckedChanged);
            // 
            // gbMinShowSize
            // 
            this.gbMinShowSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gbMinShowSize.Controls.Add(this.numMinSizeToShow);
            this.gbMinShowSize.Controls.Add(this.cbIgnoreSomeSizes);
            this.gbMinShowSize.Controls.Add(this.lblSize);
            this.gbMinShowSize.Location = new System.Drawing.Point(322, 421);
            this.gbMinShowSize.Name = "gbMinShowSize";
            this.gbMinShowSize.Size = new System.Drawing.Size(200, 48);
            this.gbMinShowSize.TabIndex = 10;
            this.gbMinShowSize.TabStop = false;
            this.gbMinShowSize.Text = "Don\'t show sizes less than";
            // 
            // numMinSizeToShow
            // 
            this.numMinSizeToShow.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.form1BindingSource, "MinSize", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.numMinSizeToShow.Location = new System.Drawing.Point(30, 18);
            this.numMinSizeToShow.Name = "numMinSizeToShow";
            this.numMinSizeToShow.Size = new System.Drawing.Size(119, 20);
            this.numMinSizeToShow.TabIndex = 10;
            this.numMinSizeToShow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numMinSizeToShow.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numMinSizeToShow_KeyDown);
            this.numMinSizeToShow.Leave += new System.EventHandler(this.numMinSizeToShow_Leave);
            // 
            // cbIgnoreSomeSizes
            // 
            this.cbIgnoreSomeSizes.AutoSize = true;
            this.cbIgnoreSomeSizes.Checked = true;
            this.cbIgnoreSomeSizes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbIgnoreSomeSizes.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.form1BindingSource, "UseMinSize", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbIgnoreSomeSizes.Location = new System.Drawing.Point(9, 22);
            this.cbIgnoreSomeSizes.Name = "cbIgnoreSomeSizes";
            this.cbIgnoreSomeSizes.Size = new System.Drawing.Size(15, 14);
            this.cbIgnoreSomeSizes.TabIndex = 9;
            this.cbIgnoreSomeSizes.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(44, 201);
            this.progressBar1.MarqueeAnimationSpeed = 50;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(441, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 11;
            this.progressBar1.Visible = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(ObjectSizes.MainForm);
            // 
            // tbFile
            // 
            this.tbFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFile.AutoEllipsis = AutoEllipsis.EllipsisFormat.Path;
            this.tbFile.Location = new System.Drawing.Point(44, 12);
            this.tbFile.Name = "tbFile";
            this.tbFile.Size = new System.Drawing.Size(397, 20);
            this.tbFile.TabIndex = 5;
            // 
            // tlvNodes
            // 
            this.tlvNodes.AllColumns.Add(this.olvName);
            this.tlvNodes.AllColumns.Add(this.olvObjId);
            this.tlvNodes.AllColumns.Add(this.olvSize);
            this.tlvNodes.AllColumns.Add(this.olvSizeBar);
            this.tlvNodes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlvNodes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvName,
            this.olvObjId,
            this.olvSize,
            this.olvSizeBar});
            this.tlvNodes.FullRowSelect = true;
            this.tlvNodes.Location = new System.Drawing.Point(12, 40);
            this.tlvNodes.Name = "tlvNodes";
            this.tlvNodes.OwnerDraw = true;
            this.tlvNodes.ShowGroups = false;
            this.tlvNodes.Size = new System.Drawing.Size(510, 375);
            this.tlvNodes.TabIndex = 4;
            this.tlvNodes.UseCompatibleStateImageBehavior = false;
            this.tlvNodes.View = System.Windows.Forms.View.Details;
            this.tlvNodes.VirtualMode = true;
            // 
            // olvName
            // 
            this.olvName.AspectName = "Name";
            this.olvName.CellPadding = null;
            this.olvName.FillsFreeSpace = true;
            this.olvName.IsEditable = false;
            this.olvName.Sortable = false;
            this.olvName.Text = "XML Node";
            // 
            // olvObjId
            // 
            this.olvObjId.AspectName = "ObjID";
            this.olvObjId.CellPadding = null;
            this.olvObjId.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvObjId.IsEditable = false;
            this.olvObjId.Sortable = false;
            this.olvObjId.Text = "ObjID";
            this.olvObjId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvObjId.Width = 50;
            // 
            // olvSize
            // 
            this.olvSize.AspectName = "Size";
            this.olvSize.AspectToStringFormat = "";
            this.olvSize.CellPadding = null;
            this.olvSize.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvSize.IsEditable = false;
            this.olvSize.Sortable = false;
            this.olvSize.Text = "Size (Bytes)";
            this.olvSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvSize.Width = 100;
            // 
            // olvSizeBar
            // 
            this.olvSizeBar.AspectName = "Size";
            this.olvSizeBar.CellPadding = null;
            this.olvSizeBar.IsEditable = false;
            this.olvSizeBar.Renderer = this.barRenderer1;
            this.olvSizeBar.Sortable = false;
            this.olvSizeBar.Text = "";
            this.olvSizeBar.Width = 120;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 481);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.gbMinShowSize);
            this.Controls.Add(this.gbShowSize);
            this.Controls.Add(this.tbFile);
            this.Controls.Add(this.tlvNodes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bnSearch);
            this.MinimumSize = new System.Drawing.Size(470, 520);
            this.Name = "MainForm";
            this.Text = "GetXMLNodeSize";
            this.gbShowSize.ResumeLayout(false);
            this.gbShowSize.PerformLayout();
            this.gbMinShowSize.ResumeLayout(false);
            this.gbMinShowSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlvNodes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bnSearch;
        private System.Windows.Forms.Label label1;
        private BrightIdeasSoftware.TreeListView tlvNodes;
        private BrightIdeasSoftware.OLVColumn olvName;
        private BrightIdeasSoftware.OLVColumn olvSize;
        private AutoEllipsis.TextBoxEllipsis tbFile;
        private BrightIdeasSoftware.OLVColumn olvSizeBar;
        private BrightIdeasSoftware.BarRenderer barRenderer1;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.GroupBox gbShowSize;
        private System.Windows.Forms.RadioButton rbMBytes;
        private System.Windows.Forms.RadioButton rbKBytes;
        private System.Windows.Forms.RadioButton rbBytes;
        private System.Windows.Forms.GroupBox gbMinShowSize;
        private System.Windows.Forms.CheckBox cbIgnoreSomeSizes;
        private BrightIdeasSoftware.OLVColumn olvObjId;
        private System.Windows.Forms.TextBox numMinSizeToShow;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

