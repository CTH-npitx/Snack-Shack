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
            this.dgv_invent = new System.Windows.Forms.DataGridView();
            this.col_snaName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_snaPri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_snaIcon = new System.Windows.Forms.DataGridViewImageColumn();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.num_snackCost = new System.Windows.Forms.NumericUpDown();
            this.picBox_icon = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_nameInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.editModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_invent)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_snackCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_icon)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.dgv_invent.ReadOnly = true;
            this.dgv_invent.RowHeadersVisible = false;
            this.dgv_invent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_invent.Size = new System.Drawing.Size(397, 404);
            this.dgv_invent.TabIndex = 3;
            // 
            // col_snaName
            // 
            this.col_snaName.HeaderText = "Name of Snack";
            this.col_snaName.Name = "col_snaName";
            this.col_snaName.ReadOnly = true;
            // 
            // col_snaPri
            // 
            this.col_snaPri.HeaderText = "Price of Snack";
            this.col_snaPri.Name = "col_snaPri";
            this.col_snaPri.ReadOnly = true;
            // 
            // col_snaIcon
            // 
            this.col_snaIcon.HeaderText = "Icon of Snack";
            this.col_snaIcon.Name = "col_snaIcon";
            this.col_snaIcon.ReadOnly = true;
            this.col_snaIcon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_snaIcon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            this.addToolStripMenuItem,
            this.editModeToolStripMenuItem});
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
            // num_snackCost
            // 
            this.num_snackCost.DecimalPlaces = 2;
            this.num_snackCost.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.num_snackCost.Location = new System.Drawing.Point(55, 45);
            this.num_snackCost.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_snackCost.Name = "num_snackCost";
            this.num_snackCost.Size = new System.Drawing.Size(75, 20);
            this.num_snackCost.TabIndex = 4;
            // 
            // picBox_icon
            // 
            this.picBox_icon.InitialImage = ((System.Drawing.Image)(resources.GetObject("picBox_icon.InitialImage")));
            this.picBox_icon.Location = new System.Drawing.Point(171, 36);
            this.picBox_icon.Name = "picBox_icon";
            this.picBox_icon.Size = new System.Drawing.Size(100, 50);
            this.picBox_icon.TabIndex = 5;
            this.picBox_icon.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_nameInput);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.num_snackCost);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.picBox_icon);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(526, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 103);
            this.panel1.TabIndex = 6;
            // 
            // txt_nameInput
            // 
            this.txt_nameInput.Location = new System.Drawing.Point(44, 6);
            this.txt_nameInput.Name = "txt_nameInput";
            this.txt_nameInput.Size = new System.Drawing.Size(100, 20);
            this.txt_nameInput.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Icon";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cost";
            // 
            // editModeToolStripMenuItem
            // 
            this.editModeToolStripMenuItem.Name = "editModeToolStripMenuItem";
            this.editModeToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.editModeToolStripMenuItem.Text = "Edit Mode";
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
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
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_snackCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_icon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualSaveToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown num_snackCost;
        private System.Windows.Forms.PictureBox picBox_icon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nameInput;
        private System.Windows.Forms.ToolStripMenuItem editModeToolStripMenuItem;
    }
}

