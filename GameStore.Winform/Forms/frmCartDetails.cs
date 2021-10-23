using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GameStore.Winform.Forms
{
    public partial class frmCartDetails : Form
    {
        public frmCartDetails()
        {
            InitializeComponent();
        }

        private void frmCartDetails_Load(object sender, EventArgs e)
        {
            //grdCartList.AutoGenerateColumns = false;
            //grdCartList.DataSource = Database.CartDetailsShow();

            //if (!Database.Cart.IsFinalize)
            //{
            //    lblTotalPrice.ForeColor = Color.OrangeRed;
            //    lblTotalPrice.Text = Database.CartDetailsShow().Sum(c => c.Price).ToString("C") + " - " + "Not Pay !!!";

            //}
            //else
            //{
            //    btnPayout.Visible = false;
            //    lblTotalPrice.ForeColor = Color.DarkGreen;
            //    lblTotalPrice.Text = Database.CartDetailsShow().Sum(c => c.Price).ToString("C") + " - " + " Pay !!!";
            //}

        }

        private void btnPayout_Click(object sender, EventArgs e)
        {
            //Database.Cart.IsFinalize = true;

            //btnPayout.Visible = false;
            //lblTotalPrice.ForeColor = Color.DarkGreen;
            //lblTotalPrice.Text = Database.CartDetailsShow().Sum(c => c.Price).ToString("C") + " - " + " Pay !!!";
        }
    }
}
