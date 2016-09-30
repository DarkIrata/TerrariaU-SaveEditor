namespace TerrariaUSaveEditor
{
    partial class MainForm
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Quick Bar");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Inventory");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Ammunition");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Money");
            this.TopMenu = new System.Windows.Forms.MenuStrip();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.CharTab = new System.Windows.Forms.TabPage();
            this.lblAbout = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCaution = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CBoxDifficulty = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnFemale = new System.Windows.Forms.Button();
            this.lblNameError = new System.Windows.Forms.Label();
            this.BtnMale = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PanelColorShoes = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.PanelColorPants = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.PanelColorUnderShirt = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.PanelColorShirt = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.PanelColorEye = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.PanelColorBody = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.PanelColorHair = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.InvTab = new System.Windows.Forms.TabPage();
            this.InventoryTree = new System.Windows.Forms.TreeView();
            this.Editor = new TerrariaUSaveEditor.ItemEditor();
            this.TopMenu.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.CharTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.InvTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopMenu
            // 
            this.TopMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.TopMenu.Location = new System.Drawing.Point(0, 0);
            this.TopMenu.Name = "TopMenu";
            this.TopMenu.Size = new System.Drawing.Size(554, 24);
            this.TopMenu.TabIndex = 0;
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(50, 24);
            this.TxtName.MaxLength = 16;
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(136, 20);
            this.TxtName.TabIndex = 0;
            this.TxtName.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.CharTab);
            this.TabControl.Controls.Add(this.InvTab);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 24);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(554, 342);
            this.TabControl.TabIndex = 2;
            // 
            // CharTab
            // 
            this.CharTab.Controls.Add(this.lblAbout);
            this.CharTab.Controls.Add(this.pictureBox1);
            this.CharTab.Controls.Add(this.lblCaution);
            this.CharTab.Controls.Add(this.groupBox2);
            this.CharTab.Controls.Add(this.groupBox1);
            this.CharTab.Location = new System.Drawing.Point(4, 22);
            this.CharTab.Name = "CharTab";
            this.CharTab.Padding = new System.Windows.Forms.Padding(3);
            this.CharTab.Size = new System.Drawing.Size(546, 316);
            this.CharTab.TabIndex = 0;
            this.CharTab.Text = "Character";
            this.CharTab.UseVisualStyleBackColor = true;
            // 
            // lblAbout
            // 
            this.lblAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAbout.AutoSize = true;
            this.lblAbout.Location = new System.Drawing.Point(62, 284);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(288, 26);
            this.lblAbout.TabIndex = 11;
            this.lblAbout.Text = "TerrariaU Save Editor by DarkIrata - https://ipmix.de/\r\nSource: https://github.co" +
    "m/DarkIrata/TerrariaU-SaveEditor";
            this.lblAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 260);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lblCaution
            // 
            this.lblCaution.ForeColor = System.Drawing.Color.DarkRed;
            this.lblCaution.Location = new System.Drawing.Point(6, 129);
            this.lblCaution.Name = "lblCaution";
            this.lblCaution.Size = new System.Drawing.Size(351, 33);
            this.lblCaution.TabIndex = 9;
            this.lblCaution.Text = "CAUTION: By using this tool you can corrupt your save. It\'s alway good to have a " +
    "backup file.";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.CBoxDifficulty);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.TxtName);
            this.groupBox2.Controls.Add(this.BtnFemale);
            this.groupBox2.Controls.Add(this.lblNameError);
            this.groupBox2.Controls.Add(this.BtnMale);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(351, 120);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Main";
            // 
            // CBoxDifficulty
            // 
            this.CBoxDifficulty.FormattingEnabled = true;
            this.CBoxDifficulty.Location = new System.Drawing.Point(50, 50);
            this.CBoxDifficulty.Name = "CBoxDifficulty";
            this.CBoxDifficulty.Size = new System.Drawing.Size(136, 21);
            this.CBoxDifficulty.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(-2, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Difficulty:";
            // 
            // BtnFemale
            // 
            this.BtnFemale.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.BtnFemale.ForeColor = System.Drawing.Color.Magenta;
            this.BtnFemale.Location = new System.Drawing.Point(84, 74);
            this.BtnFemale.Name = "BtnFemale";
            this.BtnFemale.Size = new System.Drawing.Size(28, 28);
            this.BtnFemale.TabIndex = 5;
            this.BtnFemale.Text = "♀";
            this.BtnFemale.UseVisualStyleBackColor = true;
            this.BtnFemale.Click += new System.EventHandler(this.BtnSetGender_Click);
            // 
            // lblNameError
            // 
            this.lblNameError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNameError.Location = new System.Drawing.Point(188, 16);
            this.lblNameError.Name = "lblNameError";
            this.lblNameError.Size = new System.Drawing.Size(157, 36);
            this.lblNameError.TabIndex = 2;
            this.lblNameError.Text = "..";
            this.lblNameError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnMale
            // 
            this.BtnMale.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.BtnMale.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BtnMale.Location = new System.Drawing.Point(50, 74);
            this.BtnMale.Name = "BtnMale";
            this.BtnMale.Size = new System.Drawing.Size(28, 28);
            this.BtnMale.TabIndex = 4;
            this.BtnMale.Text = "♂";
            this.BtnMale.UseVisualStyleBackColor = true;
            this.BtnMale.Click += new System.EventHandler(this.BtnSetGender_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gender:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.PanelColorShoes);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.PanelColorPants);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.PanelColorUnderShirt);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.PanelColorShirt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.PanelColorEye);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.PanelColorBody);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.PanelColorHair);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(363, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 210);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Colors";
            // 
            // PanelColorShoes
            // 
            this.PanelColorShoes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelColorShoes.Location = new System.Drawing.Point(70, 178);
            this.PanelColorShoes.Name = "PanelColorShoes";
            this.PanelColorShoes.Size = new System.Drawing.Size(101, 20);
            this.PanelColorShoes.TabIndex = 20;
            this.PanelColorShoes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PanelColorX_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Shoes:";
            // 
            // PanelColorPants
            // 
            this.PanelColorPants.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelColorPants.Location = new System.Drawing.Point(70, 152);
            this.PanelColorPants.Name = "PanelColorPants";
            this.PanelColorPants.Size = new System.Drawing.Size(101, 20);
            this.PanelColorPants.TabIndex = 18;
            this.PanelColorPants.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PanelColorX_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Pants:";
            // 
            // PanelColorUnderShirt
            // 
            this.PanelColorUnderShirt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelColorUnderShirt.Location = new System.Drawing.Point(70, 126);
            this.PanelColorUnderShirt.Name = "PanelColorUnderShirt";
            this.PanelColorUnderShirt.Size = new System.Drawing.Size(101, 20);
            this.PanelColorUnderShirt.TabIndex = 16;
            this.PanelColorUnderShirt.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PanelColorX_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Undershirt:";
            // 
            // PanelColorShirt
            // 
            this.PanelColorShirt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelColorShirt.Location = new System.Drawing.Point(70, 100);
            this.PanelColorShirt.Name = "PanelColorShirt";
            this.PanelColorShirt.Size = new System.Drawing.Size(101, 20);
            this.PanelColorShirt.TabIndex = 14;
            this.PanelColorShirt.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PanelColorX_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Shirt:";
            // 
            // PanelColorEye
            // 
            this.PanelColorEye.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelColorEye.Location = new System.Drawing.Point(70, 74);
            this.PanelColorEye.Name = "PanelColorEye";
            this.PanelColorEye.Size = new System.Drawing.Size(101, 20);
            this.PanelColorEye.TabIndex = 12;
            this.PanelColorEye.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PanelColorX_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Eye:";
            // 
            // PanelColorBody
            // 
            this.PanelColorBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelColorBody.Location = new System.Drawing.Point(70, 48);
            this.PanelColorBody.Name = "PanelColorBody";
            this.PanelColorBody.Size = new System.Drawing.Size(101, 20);
            this.PanelColorBody.TabIndex = 10;
            this.PanelColorBody.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PanelColorX_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Body:";
            // 
            // PanelColorHair
            // 
            this.PanelColorHair.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelColorHair.Location = new System.Drawing.Point(70, 22);
            this.PanelColorHair.Name = "PanelColorHair";
            this.PanelColorHair.Size = new System.Drawing.Size(101, 20);
            this.PanelColorHair.TabIndex = 8;
            this.PanelColorHair.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PanelColorX_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hair:";
            // 
            // InvTab
            // 
            this.InvTab.Controls.Add(this.Editor);
            this.InvTab.Controls.Add(this.InventoryTree);
            this.InvTab.Location = new System.Drawing.Point(4, 22);
            this.InvTab.Name = "InvTab";
            this.InvTab.Padding = new System.Windows.Forms.Padding(3);
            this.InvTab.Size = new System.Drawing.Size(546, 316);
            this.InvTab.TabIndex = 1;
            this.InvTab.Text = "Inventory";
            this.InvTab.UseVisualStyleBackColor = true;
            // 
            // InventoryTree
            // 
            this.InventoryTree.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InventoryTree.Dock = System.Windows.Forms.DockStyle.Left;
            this.InventoryTree.FullRowSelect = true;
            this.InventoryTree.Location = new System.Drawing.Point(3, 3);
            this.InventoryTree.Name = "InventoryTree";
            treeNode1.Name = "Bar";
            treeNode1.Text = "Quick Bar";
            treeNode2.Name = "Inv";
            treeNode2.Text = "Inventory";
            treeNode3.Name = "Ammo";
            treeNode3.Text = "Ammunition";
            treeNode4.Name = "Money";
            treeNode4.Text = "Money";
            this.InventoryTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            this.InventoryTree.Size = new System.Drawing.Size(244, 310);
            this.InventoryTree.TabIndex = 0;
            this.InventoryTree.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.InventoryTree_NodeMouseDoubleClick);
            // 
            // Editor
            // 
            this.Editor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Editor.Location = new System.Drawing.Point(253, 6);
            this.Editor.Name = "Editor";
            this.Editor.Size = new System.Drawing.Size(285, 152);
            this.Editor.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(554, 366);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.TopMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.TopMenu;
            this.MinimumSize = new System.Drawing.Size(570, 317);
            this.Name = "MainForm";
            this.Text = "TerrariaU Save Editor v0.6.2";
            this.TopMenu.ResumeLayout(false);
            this.TopMenu.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.CharTab.ResumeLayout(false);
            this.CharTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.InvTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip TopMenu;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage CharTab;
        private System.Windows.Forms.Label lblNameError;
        private System.Windows.Forms.TabPage InvTab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnFemale;
        private System.Windows.Forms.Button BtnMale;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel PanelColorBody;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel PanelColorHair;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel PanelColorShoes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel PanelColorPants;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel PanelColorUnderShirt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel PanelColorShirt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel PanelColorEye;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox CBoxDifficulty;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TreeView InventoryTree;
        private ItemEditor Editor;
        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCaution;
    }
}

