
namespace GameStore.Winform.Forms
{
    partial class frmCartDetails
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
            this.grdCartList = new System.Windows.Forms.DataGridView();
            this.btnPayout = new System.Windows.Forms.Button();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.GameName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdCartList)).BeginInit();
            this.SuspendLayout();
            // 
            // grdCartList
            // 
            this.grdCartList.AllowUserToAddRows = false;
            this.grdCartList.AllowUserToDeleteRows = false;
            this.grdCartList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdCartList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCartList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GameName,
            this.Price});
            this.grdCartList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCartList.Location = new System.Drawing.Point(0, 0);
            this.grdCartList.Name = "grdCartList";
            this.grdCartList.ReadOnly = true;
            this.grdCartList.RowTemplate.Height = 25;
            this.grdCartList.Size = new System.Drawing.Size(347, 450);
            this.grdCartList.TabIndex = 0;
            // 
            // btnPayout
            // 
            this.btnPayout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnPayout.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPayout.Location = new System.Drawing.Point(0, 385);
            this.btnPayout.Name = "btnPayout";
            this.btnPayout.Size = new System.Drawing.Size(347, 65);
            this.btnPayout.TabIndex = 1;
            this.btnPayout.Text = "Pay";
            this.btnPayout.UseVisualStyleBackColor = true;
            this.btnPayout.Click += new System.EventHandler(this.btnPayout_Click);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTotalPrice.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalPrice.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblTotalPrice.Location = new System.Drawing.Point(0, 337);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(347, 48);
            this.lblTotalPrice.TabIndex = 2;
            this.lblTotalPrice.Text = "Total";
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameName
            // 
            this.GameName.DataPropertyName = "Name";
            this.GameName.HeaderText = "Name";
            this.GameName.Name = "GameName";
            this.GameName.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // frmCartDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 450);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.btnPayout);
            this.Controls.Add(this.grdCartList);
            this.Name = "frmCartDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cart details";
            this.Load += new System.EventHandler(this.frmCartDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCartList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdCartList;
        private System.Windows.Forms.Button btnPayout;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn GameName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}