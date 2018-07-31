namespace Checkout
{
    partial class Pos
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
            this.btnScan = new System.Windows.Forms.Button();
            this.txtSku = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstItems = new System.Windows.Forms.ListView();
            this.colSku = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnTotal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(308, 39);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(154, 71);
            this.btnScan.TabIndex = 0;
            this.btnScan.Text = "SCAN";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnScan_MouseClick);
            // 
            // txtSku
            // 
            this.txtSku.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtSku.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSku.Location = new System.Drawing.Point(196, 39);
            this.txtSku.MaxLength = 1;
            this.txtSku.Name = "txtSku";
            this.txtSku.Size = new System.Drawing.Size(71, 71);
            this.txtSku.TabIndex = 1;
            this.txtSku.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSku.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 64);
            this.label1.TabIndex = 2;
            this.label1.Text = "SKU";
            // 
            // lstItems
            // 
            this.lstItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSku,
            this.colCost});
            this.lstItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstItems.Location = new System.Drawing.Point(540, 39);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(209, 290);
            this.lstItems.TabIndex = 4;
            this.lstItems.UseCompatibleStateImageBehavior = false;
            this.lstItems.View = System.Windows.Forms.View.Details;
            // 
            // colSku
            // 
            this.colSku.Text = "SKU";
            // 
            // colCost
            // 
            this.colCost.Text = "COST";
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(56, 258);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(406, 71);
            this.btnTotal.TabIndex = 5;
            this.btnTotal.Text = "CALCULATE TOTAL";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // Pos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 358);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.lstItems);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSku);
            this.Controls.Add(this.btnScan);
            this.Name = "Pos";
            this.Text = "Checkout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnScan;
        internal System.Windows.Forms.TextBox txtSku;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstItems;
        private System.Windows.Forms.ColumnHeader colSku;
        private System.Windows.Forms.ColumnHeader colCost;
        private System.Windows.Forms.Button btnTotal;
    }
}

