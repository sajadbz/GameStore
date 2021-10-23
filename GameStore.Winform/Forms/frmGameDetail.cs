using GameStore.Core.Services.Interfaces;
using GameStore.Core.ViewModels.Games;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GameStore.Winform.Forms
{
    public partial class frmGameDetail : Form
    {
        private readonly IGameService _gameService;
        private readonly IGameGroupService _gameGroupService;
        private string _imageName;
        public int CurrentGameId { get; set; }
        public frmGameDetail(IGameService gameService, IGameGroupService gameGroupService)
        {
            InitializeComponent();
            _gameService = gameService;
            _gameGroupService = gameGroupService;
        }

        private void frmCallOfDuty_Load(object sender, EventArgs e)
        {
            cboGroups.DataSource = _gameGroupService.GetGroups();

            if (CurrentGameId != 0)
                LoadGame();
        }

        private void btnAddCart_Click(object sender, EventArgs e)
        {            
            MessageBox.Show($"'game.Name' added to cart.", "Successfuly", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void LoadGame()
        {
            var game = _gameService.GetGameById(CurrentGameId);
            Text = txtName.Text = $"{game.Name} ({game.GroupName})";

            txtName.Text = game.Name;
            this.Text = game.Name;
            txtCPU.Text = game.CPU;
            txtFreeSpace.Text = game.FreeSpace;
            txtGPU.Text = game.GPU;
            txtPlatform.Text = game.Platform;
            txtPrice.Text = game.Price.ToString();
            txtRAM.Text = game.RAM;
            txtYear.Text = game.Year.ToString();
            txtNote.Text = game.Note;
            pbImage.Image = game.Image;
            cboGroups.SelectedValue = game.GroupId;           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CurrentGameId == 0)
            {
                _gameService.AddGame(new GameVm
                {
                    GroupId = (int)cboGroups.SelectedValue,
                    CPU = txtCPU.Text,
                    FreeSpace = txtFreeSpace.Text,
                    GPU = txtCPU.Text,
                    ImageName = _imageName,
                    Name = txtName.Text,
                    Note = txtNote.Text,
                    Platform = txtPlatform.Text,
                    Price = Convert.ToInt32(txtPrice.Text),
                    RAM = txtRAM.Text,
                    Year = Convert.ToInt32(txtYear.Text)
                });
            }
            else
            {                
                //TODO: _gameService.Edit
            }

            DialogResult = DialogResult.OK;
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            if(dialogImage.ShowDialog() == DialogResult.OK)
            {
                _imageName = dialogImage.FileName;
                pbImage.Image = Image.FromFile(dialogImage.FileName);
            }
        }
    }
}
