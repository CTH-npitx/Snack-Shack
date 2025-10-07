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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsp_close = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_manuImport = new System.Windows.Forms.ToolStripButton();
            this.tsb_manuSave = new System.Windows.Forms.ToolStripButton();
            this.col_snaName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_snaPri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_snaIcon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_invent)).BeginInit();
            this.toolStrip1.SuspendLayout();
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
            this.dgv_invent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_invent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_snaName,
            this.col_snaPri,
            this.col_snaIcon});
            this.dgv_invent.Location = new System.Drawing.Point(0, 28);
            this.dgv_invent.MultiSelect = false;
            this.dgv_invent.Name = "dgv_invent";
            this.dgv_invent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_invent.Size = new System.Drawing.Size(543, 235);
            this.dgv_invent.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsp_close,
            this.toolStripSeparator1,
            this.tsb_manuImport,
            this.tsb_manuSave});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsp_close
            // 
            this.tsp_close.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsp_close.Image = ((System.Drawing.Image)(resources.GetObject("tsp_close.Image")));
            this.tsp_close.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsp_close.Name = "tsp_close";
            this.tsp_close.Size = new System.Drawing.Size(40, 22);
            this.tsp_close.Text = "Close";
            this.tsp_close.Click += new System.EventHandler(this.tsb_close);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsb_manuImport
            // 
            this.tsb_manuImport.BackColor = System.Drawing.SystemColors.Control;
            this.tsb_manuImport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsb_manuImport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_manuImport.Image = ((System.Drawing.Image)(resources.GetObject("tsb_manuImport.Image")));
            this.tsb_manuImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_manuImport.Name = "tsb_manuImport";
            this.tsb_manuImport.Size = new System.Drawing.Size(47, 22);
            this.tsb_manuImport.Text = "Import";
            // 
            // tsb_manuSave
            // 
            this.tsb_manuSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_manuSave.Image = ((System.Drawing.Image)(resources.GetObject("tsb_manuSave.Image")));
            this.tsb_manuSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_manuSave.Name = "tsb_manuSave";
            this.tsb_manuSave.Size = new System.Drawing.Size(78, 22);
            this.tsb_manuSave.Text = "Manual Save";
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
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgv_invent);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.frmMain_load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_invent)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dgv_invent;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_manuImport;
        private System.Windows.Forms.ToolStripButton tsb_manuSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsp_close;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_snaName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_snaPri;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_snaIcon;
    }
}

