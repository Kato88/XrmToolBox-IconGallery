
namespace SirKato.XrmToolBox.IconGallery
{
    partial class IconGalleryControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IconGalleryControl));
            this.btnCopyGuid = new System.Windows.Forms.ToolStrip();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.tssSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tBoxTextFilter = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.cbTypeFilter = new System.Windows.Forms.ToolStripComboBox();
            this.btnApplyFilter = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.btnCopyDisplayName = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.btnCopyName = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lvGallery = new System.Windows.Forms.ListView();
            this.btnSettings = new System.Windows.Forms.ToolStripButton();
            this.btnCopyGuid.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCopyGuid
            // 
            this.btnCopyGuid.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.btnCopyGuid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbClose,
            this.tssSeparator1,
            this.btnSettings,
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.tBoxTextFilter,
            this.toolStripLabel2,
            this.cbTypeFilter,
            this.btnApplyFilter,
            this.toolStripSeparator2,
            this.toolStripLabel3,
            this.btnCopyDisplayName,
            this.toolStripButton3,
            this.btnCopyName});
            this.btnCopyGuid.Location = new System.Drawing.Point(0, 0);
            this.btnCopyGuid.Name = "btnCopyGuid";
            this.btnCopyGuid.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.btnCopyGuid.Size = new System.Drawing.Size(6525, 103);
            this.btnCopyGuid.TabIndex = 4;
            this.btnCopyGuid.Text = "toolStrip1";
            // 
            // tsbClose
            // 
            this.tsbClose.Image = ((System.Drawing.Image)(resources.GetObject("tsbClose.Image")));
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(119, 96);
            this.tsbClose.Text = "Close";
            this.tsbClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // tssSeparator1
            // 
            this.tssSeparator1.Name = "tssSeparator1";
            this.tssSeparator1.Size = new System.Drawing.Size(6, 52);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(111, 45);
            this.toolStripButton1.Text = "Load";
            this.toolStripButton1.Click += new System.EventHandler(this.OnLoadClicked);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 52);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(121, 45);
            this.toolStripLabel1.Text = "Search: ";
            // 
            // tBoxTextFilter
            // 
            this.tBoxTextFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tBoxTextFilter.Name = "tBoxTextFilter";
            this.tBoxTextFilter.Size = new System.Drawing.Size(400, 52);
            this.tBoxTextFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBoxTextFilter_KeyPress);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(96, 45);
            this.toolStripLabel2.Text = "Type: ";
            // 
            // cbTypeFilter
            // 
            this.cbTypeFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbTypeFilter.Items.AddRange(new object[] {
            "All",
            "PNG",
            "JPEG",
            "GIF",
            "SVG",
            "ICO"});
            this.cbTypeFilter.Name = "cbTypeFilter";
            this.cbTypeFilter.Size = new System.Drawing.Size(200, 52);
            this.cbTypeFilter.Text = "All";
            // 
            // btnApplyFilter
            // 
            this.btnApplyFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnApplyFilter.Image")));
            this.btnApplyFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnApplyFilter.Name = "btnApplyFilter";
            this.btnApplyFilter.Size = new System.Drawing.Size(111, 45);
            this.btnApplyFilter.Text = "Filter";
            this.btnApplyFilter.Click += new System.EventHandler(this.btnApplyFilter_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 52);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(123, 45);
            this.toolStripLabel3.Text = "Actions:";
            // 
            // btnCopyDisplayName
            // 
            this.btnCopyDisplayName.Image = ((System.Drawing.Image)(resources.GetObject("btnCopyDisplayName.Image")));
            this.btnCopyDisplayName.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCopyDisplayName.Name = "btnCopyDisplayName";
            this.btnCopyDisplayName.Size = new System.Drawing.Size(294, 45);
            this.btnCopyDisplayName.Text = "Copy Displayname";
            this.btnCopyDisplayName.Click += new System.EventHandler(this.btnCopyDisplayName_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(195, 45);
            this.toolStripButton3.Text = "Copy GUID";
            this.toolStripButton3.Click += new System.EventHandler(this.btnCopyGuid_Click);
            // 
            // btnCopyName
            // 
            this.btnCopyName.Image = ((System.Drawing.Image)(resources.GetObject("btnCopyName.Image")));
            this.btnCopyName.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCopyName.Name = "btnCopyName";
            this.btnCopyName.Size = new System.Drawing.Size(203, 45);
            this.btnCopyName.Text = "Copy Name";
            this.btnCopyName.Click += new System.EventHandler(this.btnCopyName_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lvGallery, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 172);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(6525, 2913);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // lvGallery
            // 
            this.lvGallery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvGallery.HideSelection = false;
            this.lvGallery.Location = new System.Drawing.Point(3, 3);
            this.lvGallery.Name = "lvGallery";
            this.lvGallery.Size = new System.Drawing.Size(6519, 2907);
            this.lvGallery.TabIndex = 1;
            this.lvGallery.UseCompatibleStateImageBehavior = false;
            // 
            // btnSettings
            // 
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(153, 45);
            this.btnSettings.Text = "Settings";
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // IconGalleryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnCopyGuid);
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "IconGalleryControl";
            this.PluginIcon = ((System.Drawing.Icon)(resources.GetObject("$this.PluginIcon")));
            this.Size = new System.Drawing.Size(3915, 1851);
            this.Load += new System.EventHandler(this.MyPluginControl_Load);
            this.btnCopyGuid.ResumeLayout(false);
            this.btnCopyGuid.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip btnCopyGuid;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ToolStripSeparator tssSeparator1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView lvGallery;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tBoxTextFilter;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox cbTypeFilter;
        private System.Windows.Forms.ToolStripButton btnApplyFilter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton btnCopyDisplayName;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton btnCopyName;
        private System.Windows.Forms.ToolStripButton btnSettings;
    }
}
