using Hesabdari.DataLayer;
using Hesabdari.DataLayer.Context;
using Hesabdari.Utility.Convertor;
using Hesabdari.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValidationComponents;

namespace Hesabdari.App
{
    public partial class frmNewTransaction : Form
    {
        public int TransactionID = 0;
        public frmNewTransaction()
        {
            InitializeComponent();
        }

        private void frmNewTransaction_Load(object sender, EventArgs e)
        {
            using(UnitOfWork db=new UnitOfWork())
            {
                dgvCustomers.DataSource = db.CustomerRepository.GetNameIDCustomers("");                
                if (TransactionID != 0)
                {
                    this.Text = "ویرایش تراکنش";
                    btnSave.Text = "اعمال تغییرات";
                    ReportingViewModel reporting = db.TransactionRepository.GetReportingByID(TransactionID);
                    txtname.Text = reporting.Fullname;
                    rbPay.Checked = (reporting.TypeTitle=="هزینه")?true:false;
                    rbReceive.Checked = (reporting.TypeTitle == "درآمد") ? true : false;
                    txtDate.Text = reporting.DateTime;
                    txtAmount.Value = reporting.Amount;
                    txtDescription.Text = reporting.Description;

                }                
            }           
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvCustomers.DataSource = db.CustomerRepository
                    .GetNameIDCustomers(txtFilter.Text);
            }
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtname.Text = dgvCustomers.CurrentCell.Value.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components)&&(rbReceive.Checked||rbPay.Checked))
            {
                using(UnitOfWork db=new UnitOfWork())
                {
                    Transaction transaction = new Transaction()
                    {
                        CustomerID = int.Parse(dgvCustomers.CurrentRow.Cells[0].Value.ToString()),
                        TypeID = rbReceive.Checked ? 1 : 2,
                        Amount = int.Parse(txtAmount.Value.ToString()),
                        DateTime = DateConvertor.ToMiladi(txtDate.Text),
                        Description = txtDescription.Text
                    };

                    if (TransactionID == 0)
                    {
                        db.TransactionRepository.Insert(transaction);                        
                    }
                    else
                    {
                        transaction.ID = TransactionID;
                        db.TransactionRepository.Update(transaction);
                    }
                    
                }                
                DialogResult = DialogResult.OK;
            }
        }
    }
}
