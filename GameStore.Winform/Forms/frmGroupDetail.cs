using GameStore.Core.Services.Interfaces;
using System;
using System.Windows.Forms;

namespace GameStore.Winform.Forms
{
    public partial class frmGroupDetail : Form
    {
        public int CurrentGroupId { get; set; }
        private readonly IGameGroupService _gameGroupService;
        public frmGroupDetail(IGameGroupService gameGroupService)
        {
            InitializeComponent();
            _gameGroupService = gameGroupService;
        }
        private void frmGroupDetail_Load(object sender, EventArgs e)
        {
            if(CurrentGroupId != 0)
            {
                var vm = _gameGroupService.GetGroupById(CurrentGroupId);
                txtTitle.Text = vm.Title;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CurrentGroupId == 0)
            {
                _gameGroupService.AddGroup(new Core.ViewModels.Games.GameGroupVm
                {
                    Title = txtTitle.Text
                });
            }
            else
            {
                _gameGroupService.EditGroup(new Core.ViewModels.Games.GameGroupVm
                {
                    Id = CurrentGroupId,
                    Title = txtTitle.Text
                });
            }
            DialogResult = DialogResult.OK;
        }

        
    }
}
