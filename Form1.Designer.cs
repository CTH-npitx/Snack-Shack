namespace snackShack
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_snackName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nud_snackPrice = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nud_snackPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Snack Name";
            // 
            // txt_snackName
            // 
            this.txt_snackName.Location = new System.Drawing.Point(76, 12);
            this.txt_snackName.Name = "txt_snackName";
            this.txt_snackName.Size = new System.Drawing.Size(100, 20);
            this.txt_snackName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Snack Price";
            // 
            // nud_snackPrice
            // 
            this.nud_snackPrice.DecimalPlaces = 2;
            this.nud_snackPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nud_snackPrice.Location = new System.Drawing.Point(76, 35);
            this.nud_snackPrice.Name = "nud_snackPrice";
            this.nud_snackPrice.Size = new System.Drawing.Size(120, 20);
            this.nud_snackPrice.TabIndex = 3;
            this.nud_snackPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nud_snackPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_snackName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nud_snackPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_snackName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nud_snackPrice;
    }
}

