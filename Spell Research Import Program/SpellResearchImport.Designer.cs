namespace Spell_Research_Import_Program
{
    partial class SpellResearchImport
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
            this.tbPluginName = new System.Windows.Forms.TextBox();
            this.cbPluginExtension = new System.Windows.Forms.ComboBox();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.msFileTop = new System.Windows.Forms.ToolStripMenuItem();
            this.msFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.msFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.msFileExport = new System.Windows.Forms.ToolStripMenuItem();
            this.itemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.msItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.msItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.msItemClear = new System.Windows.Forms.ToolStripMenuItem();
            this.lbForms = new System.Windows.Forms.ListBox();
            this.tbFormName = new System.Windows.Forms.TextBox();
            this.tbFormID = new System.Windows.Forms.TextBox();
            this.tbFormScroll = new System.Windows.Forms.TextBox();
            this.tbFormTome = new System.Windows.Forms.TextBox();
            this.cbRank = new System.Windows.Forms.ComboBox();
            this.lbArchetypesAssigned = new System.Windows.Forms.ListBox();
            this.lbArchetypesAvailable = new System.Windows.Forms.ListBox();
            this.cbItemType = new System.Windows.Forms.ComboBox();
            this.labelArchetypesAssigned = new System.Windows.Forms.Label();
            this.labelArchetypesAvailable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.exportFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbPluginName
            // 
            this.tbPluginName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPluginName.Location = new System.Drawing.Point(12, 27);
            this.tbPluginName.Name = "tbPluginName";
            this.tbPluginName.Size = new System.Drawing.Size(391, 20);
            this.tbPluginName.TabIndex = 0;
            this.tbPluginName.Text = "PluginName";
            // 
            // cbPluginExtension
            // 
            this.cbPluginExtension.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPluginExtension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPluginExtension.FormattingEnabled = true;
            this.cbPluginExtension.Items.AddRange(new object[] {
            ".esp",
            ".esm"});
            this.cbPluginExtension.Location = new System.Drawing.Point(409, 27);
            this.cbPluginExtension.Name = "cbPluginExtension";
            this.cbPluginExtension.Size = new System.Drawing.Size(63, 21);
            this.cbPluginExtension.TabIndex = 1;
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msFileTop,
            this.itemToolStripMenuItem});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(484, 24);
            this.msMain.TabIndex = 2;
            this.msMain.Text = "msMain";
            // 
            // msFileTop
            // 
            this.msFileTop.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msFileOpen,
            this.msFileSave,
            this.msFileExport});
            this.msFileTop.Name = "msFileTop";
            this.msFileTop.Size = new System.Drawing.Size(37, 20);
            this.msFileTop.Text = "File";
            // 
            // msFileOpen
            // 
            this.msFileOpen.Name = "msFileOpen";
            this.msFileOpen.Size = new System.Drawing.Size(107, 22);
            this.msFileOpen.Text = "Open";
            this.msFileOpen.Click += new System.EventHandler(this.MsFileOpen_Click);
            // 
            // msFileSave
            // 
            this.msFileSave.Name = "msFileSave";
            this.msFileSave.Size = new System.Drawing.Size(107, 22);
            this.msFileSave.Text = "Save";
            this.msFileSave.Click += new System.EventHandler(this.MsFileSave_Click);
            // 
            // msFileExport
            // 
            this.msFileExport.Name = "msFileExport";
            this.msFileExport.Size = new System.Drawing.Size(107, 22);
            this.msFileExport.Text = "Export";
            this.msFileExport.Click += new System.EventHandler(this.MsFileExport_Click);
            // 
            // itemToolStripMenuItem
            // 
            this.itemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msItemSave,
            this.msItemEdit,
            this.msItemDelete,
            this.msItemClear});
            this.itemToolStripMenuItem.Name = "itemToolStripMenuItem";
            this.itemToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.itemToolStripMenuItem.Text = "Item";
            // 
            // msItemSave
            // 
            this.msItemSave.Name = "msItemSave";
            this.msItemSave.Size = new System.Drawing.Size(107, 22);
            this.msItemSave.Text = "Save";
            this.msItemSave.Click += new System.EventHandler(this.MsItemSave_Click);
            // 
            // msItemEdit
            // 
            this.msItemEdit.Name = "msItemEdit";
            this.msItemEdit.Size = new System.Drawing.Size(107, 22);
            this.msItemEdit.Text = "Edit";
            this.msItemEdit.Click += new System.EventHandler(this.MsItemEdit_Click);
            // 
            // msItemDelete
            // 
            this.msItemDelete.Name = "msItemDelete";
            this.msItemDelete.Size = new System.Drawing.Size(107, 22);
            this.msItemDelete.Text = "Delete";
            this.msItemDelete.Click += new System.EventHandler(this.MsItemDelete_Click);
            // 
            // msItemClear
            // 
            this.msItemClear.Name = "msItemClear";
            this.msItemClear.Size = new System.Drawing.Size(107, 22);
            this.msItemClear.Text = "Clear";
            this.msItemClear.Click += new System.EventHandler(this.MsItemClear_Click);
            // 
            // lbForms
            // 
            this.lbForms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbForms.FormattingEnabled = true;
            this.lbForms.Location = new System.Drawing.Point(12, 58);
            this.lbForms.Name = "lbForms";
            this.lbForms.Size = new System.Drawing.Size(145, 394);
            this.lbForms.TabIndex = 3;
            this.lbForms.DoubleClick += new System.EventHandler(this.LbForms_DoubleClick);
            // 
            // tbFormName
            // 
            this.tbFormName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFormName.Location = new System.Drawing.Point(163, 58);
            this.tbFormName.Name = "tbFormName";
            this.tbFormName.Size = new System.Drawing.Size(312, 20);
            this.tbFormName.TabIndex = 4;
            this.tbFormName.Text = "Item Name";
            // 
            // tbFormID
            // 
            this.tbFormID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFormID.Location = new System.Drawing.Point(163, 136);
            this.tbFormID.Name = "tbFormID";
            this.tbFormID.Size = new System.Drawing.Size(100, 20);
            this.tbFormID.TabIndex = 5;
            // 
            // tbFormScroll
            // 
            this.tbFormScroll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFormScroll.Location = new System.Drawing.Point(375, 136);
            this.tbFormScroll.Name = "tbFormScroll";
            this.tbFormScroll.Size = new System.Drawing.Size(100, 20);
            this.tbFormScroll.TabIndex = 6;
            // 
            // tbFormTome
            // 
            this.tbFormTome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFormTome.Location = new System.Drawing.Point(269, 136);
            this.tbFormTome.Name = "tbFormTome";
            this.tbFormTome.Size = new System.Drawing.Size(100, 20);
            this.tbFormTome.TabIndex = 7;
            // 
            // cbRank
            // 
            this.cbRank.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRank.FormattingEnabled = true;
            this.cbRank.Items.AddRange(new object[] {
            "Novice",
            "Apprentice",
            "Adept",
            "Expert",
            "Master",
            "Legendary"});
            this.cbRank.Location = new System.Drawing.Point(354, 96);
            this.cbRank.Name = "cbRank";
            this.cbRank.Size = new System.Drawing.Size(121, 21);
            this.cbRank.TabIndex = 8;
            // 
            // lbArchetypesAssigned
            // 
            this.lbArchetypesAssigned.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbArchetypesAssigned.FormattingEnabled = true;
            this.lbArchetypesAssigned.Location = new System.Drawing.Point(163, 175);
            this.lbArchetypesAssigned.Name = "lbArchetypesAssigned";
            this.lbArchetypesAssigned.Size = new System.Drawing.Size(151, 277);
            this.lbArchetypesAssigned.TabIndex = 9;
            this.lbArchetypesAssigned.DoubleClick += new System.EventHandler(this.LbArchetypesAssigned_DoubleClick);
            // 
            // lbArchetypesAvailable
            // 
            this.lbArchetypesAvailable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbArchetypesAvailable.FormattingEnabled = true;
            this.lbArchetypesAvailable.Location = new System.Drawing.Point(320, 175);
            this.lbArchetypesAvailable.Name = "lbArchetypesAvailable";
            this.lbArchetypesAvailable.Size = new System.Drawing.Size(155, 277);
            this.lbArchetypesAvailable.TabIndex = 10;
            this.lbArchetypesAvailable.DoubleClick += new System.EventHandler(this.LbArchetypesAvailable_DoubleClick);
            // 
            // cbItemType
            // 
            this.cbItemType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbItemType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbItemType.FormattingEnabled = true;
            this.cbItemType.Items.AddRange(new object[] {
            "Spell",
            "Undiscoverable Spell",
            "Ingredient",
            "Unique Artifact",
            "Breakable Artifact",
            "Mundane Artifact",
            "Alchemical Effect"});
            this.cbItemType.Location = new System.Drawing.Point(163, 96);
            this.cbItemType.Name = "cbItemType";
            this.cbItemType.Size = new System.Drawing.Size(185, 21);
            this.cbItemType.TabIndex = 11;
            // 
            // labelArchetypesAssigned
            // 
            this.labelArchetypesAssigned.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelArchetypesAssigned.AutoSize = true;
            this.labelArchetypesAssigned.Location = new System.Drawing.Point(160, 159);
            this.labelArchetypesAssigned.Name = "labelArchetypesAssigned";
            this.labelArchetypesAssigned.Size = new System.Drawing.Size(109, 13);
            this.labelArchetypesAssigned.TabIndex = 12;
            this.labelArchetypesAssigned.Text = "Archetypes Assigned:";
            // 
            // labelArchetypesAvailable
            // 
            this.labelArchetypesAvailable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelArchetypesAvailable.AutoSize = true;
            this.labelArchetypesAvailable.Location = new System.Drawing.Point(317, 159);
            this.labelArchetypesAvailable.Name = "labelArchetypesAvailable";
            this.labelArchetypesAvailable.Size = new System.Drawing.Size(109, 13);
            this.labelArchetypesAvailable.TabIndex = 13;
            this.labelArchetypesAvailable.Text = "Archetypes Available:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Item Form ID:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tome Form ID:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Scroll Form ID:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Item Type:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(354, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Item Rank:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Comma-Seperated Files (*.csv)|*.csv|All Files|*.*";
            this.openFileDialog1.InitialDirectory = "C:\\\\";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "csv";
            this.saveFileDialog1.Filter = "Comma-Seperated Files (*.csv)|*.csv|All Files|*.*";
            this.saveFileDialog1.InitialDirectory = "C:\\\\";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveFileDialog_FileOk);
            // 
            // exportFileDialog1
            // 
            this.exportFileDialog1.DefaultExt = "psc";
            this.exportFileDialog1.Filter = "Papyrus Source Code (*.psc)|*.psc|All Files|*.*";
            this.exportFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.ExportFileDialog1_FileOk);
            // 
            // SpellResearchImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelArchetypesAvailable);
            this.Controls.Add(this.labelArchetypesAssigned);
            this.Controls.Add(this.cbItemType);
            this.Controls.Add(this.lbArchetypesAvailable);
            this.Controls.Add(this.lbArchetypesAssigned);
            this.Controls.Add(this.cbRank);
            this.Controls.Add(this.tbFormTome);
            this.Controls.Add(this.tbFormScroll);
            this.Controls.Add(this.tbFormID);
            this.Controls.Add(this.tbFormName);
            this.Controls.Add(this.lbForms);
            this.Controls.Add(this.cbPluginExtension);
            this.Controls.Add(this.tbPluginName);
            this.Controls.Add(this.msMain);
            this.MainMenuStrip = this.msMain;
            this.MaximumSize = new System.Drawing.Size(1000, 1015);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "SpellResearchImport";
            this.Text = "Spell Research Import Program";
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPluginName;
        private System.Windows.Forms.ComboBox cbPluginExtension;
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem msFileTop;
        private System.Windows.Forms.ToolStripMenuItem msFileOpen;
        private System.Windows.Forms.ToolStripMenuItem msFileSave;
        private System.Windows.Forms.ToolStripMenuItem msFileExport;
        private System.Windows.Forms.ListBox lbForms;
        private System.Windows.Forms.TextBox tbFormName;
        private System.Windows.Forms.TextBox tbFormID;
        private System.Windows.Forms.TextBox tbFormScroll;
        private System.Windows.Forms.TextBox tbFormTome;
        private System.Windows.Forms.ComboBox cbRank;
        private System.Windows.Forms.ListBox lbArchetypesAssigned;
        private System.Windows.Forms.ListBox lbArchetypesAvailable;
        private System.Windows.Forms.ComboBox cbItemType;
        private System.Windows.Forms.ToolStripMenuItem itemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msItemSave;
        private System.Windows.Forms.ToolStripMenuItem msItemEdit;
        private System.Windows.Forms.ToolStripMenuItem msItemDelete;
        private System.Windows.Forms.Label labelArchetypesAssigned;
        private System.Windows.Forms.Label labelArchetypesAvailable;
        private System.Windows.Forms.ToolStripMenuItem msItemClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.SaveFileDialog exportFileDialog1;
    }
}

