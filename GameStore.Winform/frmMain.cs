using GameStore.Core.Services.Interfaces;
using GameStore.Core.ViewModels.Games;
using GameStore.Winform.Forms;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GameStore.Winform
{
    public partial class frmMain : Form
    {
        private readonly IGameGroupService _gameGroupService;
        private readonly IGameService _gameService;
        public frmMain(IGameGroupService gameGroupService, IGameService gameService)
        {
            InitializeComponent();
            _gameGroupService = gameGroupService;
            _gameService = gameService;
            lblTimer.Text = DateTime.Now.ToString("F");
        }
        
        private void btnGame_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                //var frm = new frmGameDetail();
                var frm = Program.ServiceProvider.GetService<frmGameDetail>();
                frm.CurrentGameId = int.Parse(button.Tag.ToString());
                frm.ShowDialog();
            }
        }        

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadGroupComboBox();
        }
        private void LoadGroupComboBox()
        {
            var result = new List<GameGroupVm>();
            result.Add(new GameGroupVm { Id = 0, Title = "Choose any group" });
            result.AddRange(_gameGroupService.GetGroups());
            cboGameGroups.DataSource = result;
        }

        private void cboGameGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            gbGames.Controls.Clear();
            var groupId = Convert.ToInt32(cboGameGroups.SelectedValue);
            if (groupId != 0)
            {
                int x = 12, y = 22;
                foreach (var game in _gameService.GetGames(groupId))
                {
                    Button buttonTemp = new Button();
                    buttonTemp.Text = game.Name;
                    buttonTemp.BackgroundImage = game.Image;
                    buttonTemp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    buttonTemp.Cursor = System.Windows.Forms.Cursors.Hand;
                    buttonTemp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    buttonTemp.Location = new System.Drawing.Point(x, y);
                    buttonTemp.Name = $"button{game.Id}";
                    buttonTemp.Size = new System.Drawing.Size(200, 100);
                    buttonTemp.TabIndex = (int)game.Id;
                    buttonTemp.Tag = game.Id;
                    buttonTemp.UseVisualStyleBackColor = true;
                    buttonTemp.Click += new System.EventHandler(this.btnGame_Click);

                    x += 203;
                    if (game.Id % 3 == 0)
                    {
                        y += 103;
                        x = 12;
                    }

                    this.gbGames.Controls.Add(buttonTemp);

                }                
            }

        }

        private void mnAddGame_Click(object sender, EventArgs e)
        {
            if (Program.ServiceProvider.GetService<frmGameDetail>().ShowDialog() == DialogResult.OK)
                cboGameGroups.SelectedIndex = 0;
        }

        private void mnAddGroup_Click(object sender, EventArgs e)
        {
            frmGroups frm = Program.ServiceProvider.GetService<frmGroups>();
            frm.ShowDialog();
            LoadGroupComboBox();
        }

        private void mnCart_Click(object sender, EventArgs e)
        {
            new frmCartDetails().ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString("F");
        }
    }
}
