﻿namespace snackShack
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
            this.dgv_invent = new System.Windows.Forms.DataGridView();
            this.col_snaName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_snaPri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_snaIcon = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgv_inputUI = new System.Windows.Forms.DataGridView();
            this.dgv_snackName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_SnackPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_snackIcon = new System.Windows.Forms.DataGridViewImageColumn();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_invent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inputUI)).BeginInit();
            this.menuStrip1.SuspendLayout();
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
            // dgv_inputUI
            // 
            this.dgv_inputUI.AllowUserToAddRows = false;
            this.dgv_inputUI.AllowUserToDeleteRows = false;
            this.dgv_inputUI.AllowUserToResizeColumns = false;
            this.dgv_inputUI.AllowUserToResizeRows = false;
            this.dgv_inputUI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_inputUI.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgv_inputUI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_inputUI.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_snackName,
            this.dgv_SnackPrice,
            this.dgv_snackIcon});
            this.dgv_inputUI.Location = new System.Drawing.Point(496, 24);
            this.dgv_inputUI.MultiSelect = false;
            this.dgv_inputUI.Name = "dgv_inputUI";
            this.dgv_inputUI.RowHeadersVisible = false;
            this.dgv_inputUI.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_inputUI.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_inputUI.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgv_inputUI.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_inputUI.Size = new System.Drawing.Size(304, 151);
            this.dgv_inputUI.TabIndex = 8;
            this.dgv_inputUI.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_inputUI_CellClick);
            // 
            // dgv_snackName
            // 
            this.dgv_snackName.HeaderText = "Snack Name";
            this.dgv_snackName.Name = "dgv_snackName";
            this.dgv_snackName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dgv_SnackPrice
            // 
            this.dgv_SnackPrice.HeaderText = "Snack Price";
            this.dgv_SnackPrice.Name = "dgv_SnackPrice";
            this.dgv_SnackPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_SnackPrice.Width = 99;
            // 
            // dgv_snackIcon
            // 
            this.dgv_snackIcon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgv_snackIcon.HeaderText = "Snack Icon";
            this.dgv_snackIcon.Name = "dgv_snackIcon";
            this.dgv_snackIcon.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_snackIcon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.btn_appClose);
            // 
            // manualSaveToolStripMenuItem
            // 
            this.manualSaveToolStripMenuItem.Name = "manualSaveToolStripMenuItem";
            this.manualSaveToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.manualSaveToolStripMenuItem.Text = "Manual Save";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.manualSaveToolStripMenuItem,
            this.addToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.btn_addItem_Click);
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_inputUI);
            this.Controls.Add(this.dgv_invent);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.frmMain_load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_invent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inputUI)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dgv_invent;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_snaName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_snaPri;
        private System.Windows.Forms.DataGridViewImageColumn col_snaIcon;
        private System.Windows.Forms.DataGridView dgv_inputUI;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualSaveToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_snackName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_SnackPrice;
        private System.Windows.Forms.DataGridViewImageColumn dgv_snackIcon;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
    }
}

