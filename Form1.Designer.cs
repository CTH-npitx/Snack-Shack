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
            this.label3 = new System.Windows.Forms.Label();
            this.nud_snackQuantity = new System.Windows.Forms.NumericUpDown();
            this.bttn_snackImage = new System.Windows.Forms.Button();
            this.txt_imagePath = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud_snackPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_snackQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Snack Name";
            // 
            // txt_snackName
            // 
            this.txt_snackName.Location = new System.Drawing.Point(76, 67);
            this.txt_snackName.Name = "txt_snackName";
            this.txt_snackName.Size = new System.Drawing.Size(100, 20);
            this.txt_snackName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 92);
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
            this.nud_snackPrice.Location = new System.Drawing.Point(76, 90);
            this.nud_snackPrice.Name = "nud_snackPrice";
            this.nud_snackPrice.Size = new System.Drawing.Size(120, 20);
            this.nud_snackPrice.TabIndex = 3;
            this.nud_snackPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantity";
            // 
            // nud_snackQuantity
            // 
            this.nud_snackQuantity.Location = new System.Drawing.Point(76, 116);
            this.nud_snackQuantity.Name = "nud_snackQuantity";
            this.nud_snackQuantity.Size = new System.Drawing.Size(120, 20);
            this.nud_snackQuantity.TabIndex = 5;
            this.nud_snackQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bttn_snackImage
            // 
            this.bttn_snackImage.Location = new System.Drawing.Point(12, 12);
            this.bttn_snackImage.Name = "bttn_snackImage";
            this.bttn_snackImage.Size = new System.Drawing.Size(75, 23);
            this.bttn_snackImage.TabIndex = 6;
            this.bttn_snackImage.Text = "Image";
            this.bttn_snackImage.UseVisualStyleBackColor = true;
            // 
            // txt_imagePath
            // 
            this.txt_imagePath.Location = new System.Drawing.Point(94, 12);
            this.txt_imagePath.Name = "txt_imagePath";
            this.txt_imagePath.Size = new System.Drawing.Size(100, 20);
            this.txt_imagePath.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_imagePath);
            this.Controls.Add(this.bttn_snackImage);
            this.Controls.Add(this.nud_snackQuantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nud_snackPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_snackName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nud_snackPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_snackQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_snackName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nud_snackPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nud_snackQuantity;
        private System.Windows.Forms.Button bttn_snackImage;
        private System.Windows.Forms.TextBox txt_imagePath;
    }
}

