namespace TerrariaUSaveEditor
{
    partial class ItemEditor
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.NudItemId = new System.Windows.Forms.NumericUpDown();
            this.NudAmount = new System.Windows.Forms.NumericUpDown();
            this.TxtItemName = new System.Windows.Forms.TextBox();
            this.CbPrefix = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.UrlLblItems = new System.Windows.Forms.LinkLabel();
            this.UrlLblPrefixes = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.NudItemId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // NudItemId
            // 
            this.NudItemId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NudItemId.Location = new System.Drawing.Point(86, 3);
            this.NudItemId.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.NudItemId.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.NudItemId.Name = "NudItemId";
            this.NudItemId.Size = new System.Drawing.Size(142, 20);
            this.NudItemId.TabIndex = 0;
            this.NudItemId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NudItemId.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.NudItemId.ValueChanged += new System.EventHandler(this.NudItemId_ValueChanged);
            // 
            // NudAmount
            // 
            this.NudAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NudAmount.Location = new System.Drawing.Point(86, 82);
            this.NudAmount.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.NudAmount.Name = "NudAmount";
            this.NudAmount.Size = new System.Drawing.Size(142, 20);
            this.NudAmount.TabIndex = 3;
            this.NudAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NudAmount.ThousandsSeparator = true;
            this.NudAmount.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // TxtItemName
            // 
            this.TxtItemName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtItemName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TxtItemName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TxtItemName.Location = new System.Drawing.Point(86, 29);
            this.TxtItemName.Name = "TxtItemName";
            this.TxtItemName.Size = new System.Drawing.Size(142, 20);
            this.TxtItemName.TabIndex = 1;
            this.TxtItemName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtItemName_KeyDown);
            // 
            // CbPrefix
            // 
            this.CbPrefix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CbPrefix.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CbPrefix.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CbPrefix.FormattingEnabled = true;
            this.CbPrefix.Location = new System.Drawing.Point(86, 55);
            this.CbPrefix.Name = "CbPrefix";
            this.CbPrefix.Size = new System.Drawing.Size(142, 21);
            this.CbPrefix.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Prefix:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Amount:";
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSave.Location = new System.Drawing.Point(154, 108);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(74, 23);
            this.BtnSave.TabIndex = 4;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // UrlLblItems
            // 
            this.UrlLblItems.AutoSize = true;
            this.UrlLblItems.Location = new System.Drawing.Point(5, 118);
            this.UrlLblItems.Name = "UrlLblItems";
            this.UrlLblItems.Size = new System.Drawing.Size(32, 13);
            this.UrlLblItems.TabIndex = 8;
            this.UrlLblItems.TabStop = true;
            this.UrlLblItems.Text = "Items";
            this.UrlLblItems.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.UrlLblItems_LinkClicked);
            // 
            // UrlLblPrefixes
            // 
            this.UrlLblPrefixes.AutoSize = true;
            this.UrlLblPrefixes.Location = new System.Drawing.Point(43, 118);
            this.UrlLblPrefixes.Name = "UrlLblPrefixes";
            this.UrlLblPrefixes.Size = new System.Drawing.Size(44, 13);
            this.UrlLblPrefixes.TabIndex = 9;
            this.UrlLblPrefixes.TabStop = true;
            this.UrlLblPrefixes.Text = "Prefixes";
            this.UrlLblPrefixes.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.UrlLblPrefixes_LinkClicked);
            // 
            // ItemEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UrlLblPrefixes);
            this.Controls.Add(this.UrlLblItems);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbPrefix);
            this.Controls.Add(this.TxtItemName);
            this.Controls.Add(this.NudAmount);
            this.Controls.Add(this.NudItemId);
            this.Name = "ItemEditor";
            this.Size = new System.Drawing.Size(231, 141);
            ((System.ComponentModel.ISupportInitialize)(this.NudItemId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NudItemId;
        private System.Windows.Forms.NumericUpDown NudAmount;
        private System.Windows.Forms.TextBox TxtItemName;
        private System.Windows.Forms.ComboBox CbPrefix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.LinkLabel UrlLblItems;
        private System.Windows.Forms.LinkLabel UrlLblPrefixes;
    }
}
