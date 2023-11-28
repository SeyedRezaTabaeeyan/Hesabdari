using Hesabdari.DataLayer.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesabdari.App
{
    public partial class frmCustomers : Form
    {
        public frmCustomers()
        {
            InitializeComponent();
        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            BindGrid();
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvCustomers.DataSource = db.CustomerRepository.Search(txtSearch.Text.ToString());
            }
        }

        private void btnRefreshCustomer_Click(object sender, EventArgs e)
        {
            BindGrid();
        }
        void BindGrid()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvCustomers.AutoGenerateColumns = false;
                dgvCustomers.DataSource = db.CustomerRepository.Get();
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow != null)
            {
                string fullName = dgvCustomers.CurrentRow.Cells[1].Value.ToString();
                if (RtlMessageBox.Show($"آیا از حذف {fullName }مطمئن هستید؟", "هشدار", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int customerID = int.Parse(dgvCustomers.CurrentRow.Cells[0].Value.ToString());
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        db.CustomerRepository.Delete(customerID);                        
                    }
                    BindGrid();
                }
            }
            else
            {
                RtlMessageBox.Show("لطفا شخصی را انتخاب کنید");
            }
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            frmAddNewCustomer frmAddNewCustomer = new frmAddNewCustomer();
            frmAddNewCustomer.ShowDialog();
            BindGrid();
            
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow != null)
            {
                frmAddNewCustomer frmEdit = new frmAddNewCustomer();
                frmEdit.customerID = int.Parse(dgvCustomers.CurrentRow.Cells[0].Value.ToString());
                frmEdit.ShowDialog();
                BindGrid();
            }
            else
            {
                MessageBox.Show("لطفا شخصی را انتخاب کنید");
            }
        }
    }
}