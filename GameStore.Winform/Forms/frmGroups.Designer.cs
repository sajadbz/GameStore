
namespace GameStore.Winform.Forms
{
    partial class frmGroups
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
            this.components = new System.ComponentModel.Container();
            this.grdList = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GameCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmnEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuForm = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmnAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdList)).BeginInit();
            this.contextMenu.SuspendLayout();
            this.contextMenuForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdList
            // 
            this.grdList.AllowUserToAddRows = false;
            this.grdList.AllowUserToDeleteRows = false;
            this.grdList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Title,
            this.GameCount});
            this.grdList.ContextMenuStrip = this.contextMenu;
            this.grdList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdList.Location = new System.Drawing.Point(0, 77);
            this.grdList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grdList.MultiSelect = false;
            this.grdList.Name = "grdList";
            this.grdList.ReadOnly = true;
            this.grdList.RowHeadersWidth = 51;
            this.grdList.RowTemplate.Height = 25;
            this.grdList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdList.Size = new System.Drawing.Size(325, 235);
            this.grdList.TabIndex = 1;
            this.grdList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.grdList_MouseDown);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Group name";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // GameCount
            // 
            this.GameCount.DataPropertyName = "GameCount";
            this.GameCount.HeaderText = "Game count";
            this.GameCount.MinimumWidth = 6;
            this.GameCount.Name = "GameCount";
            this.GameCount.ReadOnly = true;
            // 
            // contextMenu
            // 
            this.contextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmnEdit,
            this.cmnDelete});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(123, 52);
            // 
            // cmnEdit
            // 
            this.cmnEdit.Name = "cmnEdit";
            this.cmnEdit.Size = new System.Drawing.Size(122, 24);
            this.cmnEdit.Text = "Edit";
            this.cmnEdit.Click += new System.EventHandler(this.cmnEdit_Click);
            // 
            // cmnDelete
            // 
            this.cmnDelete.Name = "cmnDelete";
            this.cmnDelete.Size = new System.Drawing.Size(122, 24);
            this.cmnDelete.Text = "Delete";
            this.cmnDelete.Click += new System.EventHandler(this.cmnDelete_Click);
            // 
            // contextMenuForm
            // 
            this.contextMenuForm.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmnAdd,
            this.cmnHelp});
            this.contextMenuForm.Name = "contextMenuForm";
            this.contextMenuForm.Size = new System.Drawing.Size(111, 52);
            // 
            // cmnAdd
            // 
            this.cmnAdd.Name = "cmnAdd";
            this.cmnAdd.Size = new System.Drawing.Size(110, 24);
            this.cmnAdd.Text = "Add";
            this.cmnAdd.Click += new System.EventHandler(this.cmnAdd_Click);
            // 
            // cmnHelp
            // 
            this.cmnHelp.Name = "cmnHelp";
            this.cmnHelp.Size = new System.Drawing.Size(110, 24);
            this.cmnHelp.Text = "Help";
            // 
            // txtSearch
            // 
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSearch.Location = new System.Drawing.Point(0, 0);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(325, 27);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Enabled = false;
            this.btnPrevious.Location = new System.Drawing.Point(0, 39);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(162, 31);
            this.btnPrevious.TabIndex = 3;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(169, 39);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(155, 31);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // frmGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 312);
            this.ContextMenuStrip = this.contextMenuForm;
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.grdList);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmGroups";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Group list ";
            this.Load += new System.EventHandler(this.frmGroups_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdList)).EndInit();
            this.contextMenu.ResumeLayout(false);
            this.contextMenuForm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView grdList;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem cmnEdit;
        private System.Windows.Forms.ToolStripMenuItem cmnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn GameCount;
        private System.Windows.Forms.ContextMenuStrip contextMenuForm;
        private System.Windows.Forms.ToolStripMenuItem cmnAdd;
        private System.Windows.Forms.ToolStripMenuItem cmnHelp;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
    }
}