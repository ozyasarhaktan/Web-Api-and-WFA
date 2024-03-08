namespace WindowsFormsApp1
{
    partial class Form2
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
            if(disposing && (components != null))
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
            this.btnSave = new System.Windows.Forms.Button();
            this.lbl_ProductName = new System.Windows.Forms.Label();
            this.txt_ProductName = new System.Windows.Forms.TextBox();
            this.txt_UnitPrice = new System.Windows.Forms.TextBox();
            this.lbl_ProductUnitPrice = new System.Windows.Forms.Label();
            this.lbl_UnitsInStock = new System.Windows.Forms.Label();
            this.txt_UnitsInStock = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.MintCream;
            this.btnSave.Location = new System.Drawing.Point(89, 304);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(321, 65);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "SUBMIT";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbl_ProductName
            // 
            this.lbl_ProductName.AutoSize = true;
            this.lbl_ProductName.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ProductName.Location = new System.Drawing.Point(47, 52);
            this.lbl_ProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ProductName.Name = "lbl_ProductName";
            this.lbl_ProductName.Size = new System.Drawing.Size(143, 28);
            this.lbl_ProductName.TabIndex = 1;
            this.lbl_ProductName.Text = "Product Name";
            // 
            // txt_ProductName
            // 
            this.txt_ProductName.Location = new System.Drawing.Point(210, 52);
            this.txt_ProductName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_ProductName.Name = "txt_ProductName";
            this.txt_ProductName.Size = new System.Drawing.Size(254, 34);
            this.txt_ProductName.TabIndex = 2;
            // 
            // txt_UnitPrice
            // 
            this.txt_UnitPrice.Location = new System.Drawing.Point(210, 128);
            this.txt_UnitPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_UnitPrice.Name = "txt_UnitPrice";
            this.txt_UnitPrice.Size = new System.Drawing.Size(254, 34);
            this.txt_UnitPrice.TabIndex = 4;
            // 
            // lbl_ProductUnitPrice
            // 
            this.lbl_ProductUnitPrice.AutoSize = true;
            this.lbl_ProductUnitPrice.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ProductUnitPrice.Location = new System.Drawing.Point(84, 128);
            this.lbl_ProductUnitPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ProductUnitPrice.Name = "lbl_ProductUnitPrice";
            this.lbl_ProductUnitPrice.Size = new System.Drawing.Size(106, 28);
            this.lbl_ProductUnitPrice.TabIndex = 3;
            this.lbl_ProductUnitPrice.Text = " Unit Price";
            // 
            // lbl_UnitsInStock
            // 
            this.lbl_UnitsInStock.AutoSize = true;
            this.lbl_UnitsInStock.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_UnitsInStock.Location = new System.Drawing.Point(53, 204);
            this.lbl_UnitsInStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_UnitsInStock.Name = "lbl_UnitsInStock";
            this.lbl_UnitsInStock.Size = new System.Drawing.Size(139, 28);
            this.lbl_UnitsInStock.TabIndex = 5;
            this.lbl_UnitsInStock.Text = "Units In Stock";
            // 
            // txt_UnitsInStock
            // 
            this.txt_UnitsInStock.Location = new System.Drawing.Point(210, 205);
            this.txt_UnitsInStock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_UnitsInStock.Name = "txt_UnitsInStock";
            this.txt_UnitsInStock.Size = new System.Drawing.Size(254, 34);
            this.txt_UnitsInStock.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(82, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 38);
            this.label1.TabIndex = 7;
            this.label1.Text = "PRODUCT ADD && UPDATE FORM";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.txt_UnitsInStock);
            this.panel1.Controls.Add(this.lbl_UnitsInStock);
            this.panel1.Controls.Add(this.txt_UnitPrice);
            this.panel1.Controls.Add(this.lbl_ProductUnitPrice);
            this.panel1.Controls.Add(this.txt_ProductName);
            this.panel1.Controls.Add(this.lbl_ProductName);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Location = new System.Drawing.Point(31, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 446);
            this.panel1.TabIndex = 8;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 627);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbl_ProductName;
        private System.Windows.Forms.TextBox txt_ProductName;
        private System.Windows.Forms.TextBox txt_UnitPrice;
        private System.Windows.Forms.Label lbl_ProductUnitPrice;
        private System.Windows.Forms.Label lbl_UnitsInStock;
        private System.Windows.Forms.TextBox txt_UnitsInStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}