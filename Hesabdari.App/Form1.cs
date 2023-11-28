
using Hesabdari.Business;
using Hesabdari.DataLayer.Context;
using Hesabdari.Utility.Convertor;
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
    public partial class Form1 : Form
    {
        public int loginID;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            frmCustomers frmCustomers = new frmCustomers();
            frmCustomers.ShowDialog();
        }

        private void btnNewTransaction_Click(object sender, EventArgs e)
        {
            frmNewTransaction frmNewTransaction = new frmNewTransaction();
            frmNewTransaction.ShowDialog();
            Reporting();
        }

        private void btnEditLogin_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.loginID = loginID;
            frmLogin.ShowDialog();
            if (frmLogin.DialogResult == DialogResult.OK)
            {
                Application.Restart();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.Hide();
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();
            if (frmLogin.DialogResult == DialogResult.OK)
            {   
                this.Show();
                loginID = frmLogin.loginID;
                if (loginID != 0)
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        var login = db.LoginRepository.GetByID(loginID);
                        lblWelcome.Text = $"  {login.UserName} خوش آمدید !";
                        btnEditLogin.Visible = true;
                        if (login.IsAdmin)
                        {
                            btnAddLogin.Visible = true;
                            lblISAdmin.Text = "سطح دسترسی : ادمین  ";
                        }
                    }
                }                
                Reporting();
            }
            else
            {
                Application.Exit();
            }
        }
        void Reporting()
        {
            var report = Report.ReportMonth();
            lblFromDate.Text = report.FromShamsiDate;
            lblToDate.Text = report.ToShamsiDate;
            lblSumReceive.Text = report.SumReceive.ToString();
            lblSumPay.Text = report.SumPay.ToString();
            lblRemaining.Text = report.Remaining.ToString();
        }

        private void btnAddLogin_Click(object sender, EventArgs e)
        {            
            frmLogin frmLogin = new frmLogin();
            frmLogin.loginID = -1;
            frmLogin.ShowDialog();  
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToShamsi();
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            frmReporting frmReportingMix = new frmReporting();            
            frmReportingMix.ShowDialog();
        }
    }
}
