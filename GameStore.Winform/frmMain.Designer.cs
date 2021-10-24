
namespace GameStore.Winform
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbGames = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboGameGroups = new System.Windows.Forms.ComboBox();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.mnAddGame = new System.Windows.Forms.ToolStripMenuItem();
            this.mnAddGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCart = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTimer = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbGames
            // 
            this.gbGames.BackColor = System.Drawing.Color.Transparent;
            this.gbGames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbGames.Location = new System.Drawing.Point(11, 112);
            this.gbGames.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbGames.Name = "gbGames";
            this.gbGames.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbGames.Size = new System.Drawing.Size(762, 466);
            this.gbGames.TabIndex = 0;
            this.gbGames.TabStop = false;
            this.gbGames.Text = "Games";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(32, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Game Store";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboGameGroups);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(11, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(762, 99);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(458, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Choose Group :";
            // 
            // cboGameGroups
            // 
            this.cboGameGroups.BackColor = System.Drawing.Color.White;
            this.cboGameGroups.DisplayMember = "Title";
            this.cboGameGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGameGroups.FormattingEnabled = true;
            this.cboGameGroups.Location = new System.Drawing.Point(567, 48);
            this.cboGameGroups.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboGameGroups.Name = "cboGameGroups";
            this.cboGameGroups.Size = new System.Drawing.Size(187, 28);
            this.cboGameGroups.TabIndex = 3;
            this.cboGameGroups.ValueMember = "Id";
            this.cboGameGroups.SelectedIndexChanged += new System.EventHandler(this.cboGameGroups_SelectedIndexChanged);
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.Color.Transparent;
            this.mainMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnAddGame,
            this.mnAddGroup,
            this.mnCart,
            this.lblTimer});
            this.mainMenu.Location = new System.Drawing.Point(11, 578);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(0);
            this.mainMenu.Size = new System.Drawing.Size(762, 29);
            this.mainMenu.TabIndex = 4;
            this.mainMenu.Text = "mainMenu";
            // 
            // mnAddGame
            // 
            this.mnAddGame.BackColor = System.Drawing.Color.White;
            this.mnAddGame.Margin = new System.Windows.Forms.Padding(0, 5, 5, 0);
            this.mnAddGame.Name = "mnAddGame";
            this.mnAddGame.Size = new System.Drawing.Size(93, 24);
            this.mnAddGame.Text = "Add game";
            this.mnAddGame.Click += new System.EventHandler(this.mnAddGame_Click);
            // 
            // mnAddGroup
            // 
            this.mnAddGroup.BackColor = System.Drawing.Color.White;
            this.mnAddGroup.Margin = new System.Windows.Forms.Padding(0, 5, 5, 0);
            this.mnAddGroup.Name = "mnAddGroup";
            this.mnAddGroup.Size = new System.Drawing.Size(70, 24);
            this.mnAddGroup.Text = "Groups";
            this.mnAddGroup.Click += new System.EventHandler(this.mnAddGroup_Click);
            // 
            // mnCart
            // 
            this.mnCart.BackColor = System.Drawing.Color.White;
            this.mnCart.Margin = new System.Windows.Forms.Padding(0, 5, 5, 0);
            this.mnCart.Name = "mnCart";
            this.mnCart.Size = new System.Drawing.Size(50, 24);
            this.mnCart.Text = "Cart";
            this.mnCart.Click += new System.EventHandler(this.mnCart_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = false;
            this.lblTimer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTimer.ForeColor = System.Drawing.Color.White;
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.ShowShortcutKeys = false;
            this.lblTimer.Size = new System.Drawing.Size(400, 24);
            this.lblTimer.Text = "timer";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GameStore.Winform.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 620);
            this.Controls.Add(this.gbGames);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(11, 13, 11, 13);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Store";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGames;
        //private System.Windows.Forms.Button btnGame1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboGameGroups;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnAddGame;
        private System.Windows.Forms.ToolStripMenuItem mnCart;
        private System.Windows.Forms.ToolStripMenuItem mnAddGroup;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem lblTimer;
        //private System.Windows.Forms.Button btnGame2;
        //private System.Windows.Forms.Button button6;
        //private System.Windows.Forms.Button button7;
        //private System.Windows.Forms.Button button5;
        //private System.Windows.Forms.Button button1;
        //private System.Windows.Forms.Button button2;
        //private System.Windows.Forms.Button button3;
        //private System.Windows.Forms.Button button4;
    }
}

