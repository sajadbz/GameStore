using GameStore.Core.Services.Interfaces;
using GameStore.Core.ViewModels.Games;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace GameStore.Winform.Forms
{
    public partial class frmGroups : Form
    {
        private readonly IGameGroupService _gameGroupService;
        private static int _page = 1;
        private const int _pageSize = 3;
        public frmGroups(IGameGroupService gameGroupService)
        {
            InitializeComponent();
            _gameGroupService = gameGroupService;            
        }


        private void frmGroups_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void LoadGrid(string title = "")
        {
            grdList.AutoGenerateColumns = false;
            grdList.DataSource = _gameGroupService.FilterGroups(new FilterGroup
            {
                Title = title,
                Page = _page,
                PageSize = _pageSize
            });
            //if (string.IsNullOrEmpty(title))
            //    grdList.DataSource = _gameGroupService.GetGroups();
            //else
            //    grdList.DataSource = _gameGroupService.SearchGroups(title);


        }

        private void cmnAdd_Click(object sender, EventArgs e)
        {
            if (Program.ServiceProvider.GetService<frmGroupDetail>().ShowDialog() == DialogResult.OK)
                LoadGrid();
        }

        private void cmnEdit_Click(object sender, EventArgs e)
        {
            if (grdList.RowCount > 0 && grdList.SelectedRows.Count == 1)
            {
                var frm = Program.ServiceProvider.GetService<frmGroupDetail>();
                frm.CurrentGroupId = (int)grdList.SelectedRows[0].Cells[0].Value;
                var title = grdList.SelectedRows[0].Cells[1].Value;
                frm.btnSave.Text = "Edit";
                frm.Text = $"Edit {title}";
                if (frm.ShowDialog() == DialogResult.OK)
                    LoadGrid();
            }

        }

        private void grdList_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = grdList.HitTest(e.X, e.Y);
                grdList.ClearSelection();
                grdList.Rows[hti.RowIndex].Selected = true;
            }
        }

        private void cmnDelete_Click(object sender, EventArgs e)
        {
            if (grdList.RowCount > 0 && grdList.SelectedRows.Count == 1)
            {

                var id = (int)grdList.SelectedRows[0].Cells[0].Value;
                var title = grdList.SelectedRows[0].Cells[1].Value;
                var count = (int)grdList.SelectedRows[0].Cells[2].Value;
                if (count > 0)
                    MessageBox.Show("You cant remove this group cause of relation with games.", "Delete");

                else if (MessageBox.Show("Are you sure ?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _gameGroupService.DeleteGroup(id);
                    LoadGrid();
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadGrid(txtSearch.Text);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            var count = _gameGroupService.CountGroups();
            var totalPage = count / _pageSize;
            if (_page != totalPage)
            {
                _page += 1;
                LoadGrid();
            }
            if (_page == totalPage)
                btnNext.Enabled = false;

            btnPrevious.Enabled = true;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (_page > 1)
            {
                _page -= 1;
                LoadGrid();
            }
            if (_page == 1)
                btnPrevious.Enabled = false;

            btnNext.Enabled = true;
        }
    }
}
