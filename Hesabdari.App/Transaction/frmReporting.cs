using Hesabdari.Business;
using Hesabdari.DataLayer.Context;
using Hesabdari.Utility.Convertor;
using Hesabdari.ViewModels;
using Stimulsoft.Base;
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
    public partial class frmReporting : Form
    {
        public int TypeID;
        List<ReportingViewModel> data;
        List<ReportBalanceViewModel> dataBalance;
        public frmReporting()
        {
            InitializeComponent();
        }

        private void frmReporting_Load(object sender, EventArgs e)
        {             
            List<CustomerNameIDViewModel> List = new List<CustomerNameIDViewModel>()
            {
                new CustomerNameIDViewModel
                {
                    CustomerID=0,
                    FullName="انتخاب کنید"
                }
            };
            using(UnitOfWork db=new UnitOfWork())
            {
                List.AddRange(db.CustomerRepository.GetNameIDCustomers(""));
                cbCustomer.DataSource = List;
                cbCustomer.DisplayMember = "FullName";
                cbCustomer.ValueMember = "CustomerID";
            }            
        }

        void BindGridFilter()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                DateTime? startDate, endtDate;
                dgvTransaction.AutoGenerateColumns = false;
                dgvBalance.AutoGenerateColumns = false;
                int customerID = (int)cbCustomer.SelectedValue;
                if (rbReceive.Checked) TypeID = 1;
                if (rbPay.Checked) TypeID = 2;
                if (RbAll.Checked || !(rbPay.Checked || rbReceive.Checked)) TypeID = 0;
                try
                { 
                    startDate = DateConvertor.ToMiladi(txtFromDate.Text);
                }
                catch
                {
                    startDate = null;
                }
                try
                {
                    endtDate = DateConvertor.ToMiladi(txtToDate.Text);
                }
                catch
                {
                    endtDate = null;
                }

                data = db.TransactionRepository.
                    GetAllReportingByFilter(TypeID, customerID, startDate, endtDate);
                dataBalance = Report.ReportComPlex(customerID, startDate, endtDate);
                
                dgvTransaction.DataSource = data;
                dgvBalance.DataSource = dataBalance;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BindGridFilter();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvTransaction.CurrentRow != null)
            {
                frmNewTransaction frmEditTransaction = new frmNewTransaction();               
                frmEditTransaction.TransactionID = int.Parse(dgvTransaction.CurrentRow.Cells[0].Value.ToString());
                frmEditTransaction.ShowDialog();
                BindGridFilter();
            }
            else
            {
                MessageBox.Show("لطفا یک سطر را انتخاب کنید");
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTransaction.CurrentRow != null)
            {
                if (RtlMessageBox.Show("آیا از حذف این تراکنش مطمئن هستید؟", "هشدار", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using(UnitOfWork db=new UnitOfWork())
                    {
                        int TransactionID = int.Parse(dgvTransaction.CurrentRow.Cells[0].Value.ToString());
                        db.TransactionRepository.Delete(TransactionID);
                    }
                    BindGridFilter();
                }

            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            BindGridFilter();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {                       
            stiReport1.Load(Application.StartupPath + "/Report.mrt");
            stiReport1.RegBusinessObject("dt", data);
            stiReport1.RegBusinessObject("dtComplex",dataBalance);
            stiReport1.Show();
        }
    }
}