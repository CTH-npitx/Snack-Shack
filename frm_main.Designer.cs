namespace snackShack
{
    partial class frm_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv_invent = new System.Windows.Forms.DataGridView();
            this.col_snaName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_snaPri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_snaIcon = new System.Windows.Forms.DataGridViewImageColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_invent)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.manualSaveToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // manualSaveToolStripMenuItem
            // 
            this.manualSaveToolStripMenuItem.Name = "manualSaveToolStripMenuItem";
            this.manualSaveToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.manualSaveToolStripMenuItem.Text = "Manual Save";
            // 
            // dgv_invent
            // 
            this.dgv_invent.AllowUserToAddRows = false;
            this.dgv_invent.AllowUserToDeleteRows = false;
            this.dgv_invent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_invent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_snaName,
            this.col_snaPri,
            this.col_snaIcon});
            this.dgv_invent.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgv_invent.Location = new System.Drawing.Point(0, 24);
            this.dgv_invent.MultiSelect = false;
            this.dgv_invent.Name = "dgv_invent";
            this.dgv_invent.RowHeadersVisible = false;
            this.dgv_invent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_invent.Size = new System.Drawing.Size(397, 404);
            this.dgv_invent.TabIndex = 3;
            this.dgv_invent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_invent_CellContentClick);
            // 
            // col_snaName
            // 
            this.col_snaName.HeaderText = "Name of Snack";
            this.col_snaName.Name = "col_snaName";
            // 
            // col_snaPri
            // 
            this.col_snaPri.HeaderText = "Price of Snack";
            this.col_snaPri.Name = "col_snaPri";
            // 
            // col_snaIcon
            // 
            this.col_snaIcon.HeaderText = "Icon of Snack";
            this.col_snaIcon.Name = "col_snaIcon";
            this.col_snaIcon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_snaIcon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_invent);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.frmMain_load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_invent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualSaveToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgv_invent;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_snaName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_snaPri;
        private System.Windows.Forms.DataGridViewImageColumn col_snaIcon;
    }
}

