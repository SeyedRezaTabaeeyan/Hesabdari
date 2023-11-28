using Hesabdari.DataLayer;
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
using ValidationComponents;

namespace Hesabdari.App
{
    public partial class frmLogin : Form
    {
        public int loginID = 0;        
        public frmLogin()
        {
            InitializeComponent();
        }        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                using (UnitOfWork db=new UnitOfWork())
                {  
                    //ورود کاربر
                    if (loginID == 0)
                    {
                        Login login = db.LoginRepository.Get(l => l.UserName == txtUsername.Text && l.Password == txtPassword.Text).FirstOrDefault();
                        if (login != null)
                        {
                            loginID = login.LoginID;
                            DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            MessageBox.Show("اطلاعات وارد شده صحیح نیست دوباره تلاش کنید");
                        }
                    }
                    //افزودن یا ویرایش کاربر
                    else
                    {                        
                        //نام کاربری انتخاب شده تکراری نباشد 
                        if ( !db.LoginRepository.Get(l => l.UserName == txtUsername.Text&&l.LoginID!=loginID).Any())
                        {                            
                            //افزودن کاربر
                            if (loginID == -1)
                            {
                                Login login = new Login()
                                {
                                    LoginID = loginID,
                                    UserName = txtUsername.Text,
                                    Password = txtPassword.Text,
                                    IsAdmin = false
                                };                                
                                db.LoginRepository.Insert(login);
                            }
                            //ویرایش کاربر
                            else
                            {
                                Login login = db.LoginRepository.GetByID(loginID);
                                login.UserName = txtUsername.Text;
                                login.Password = txtPassword.Text;
                            }                            
                            DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            MessageBox.Show("نام کاربری قابل انتخاب نیست دوباره تلاش کنید");
                        }
                    }
                }
            }            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            switch (loginID)
            {
                case 0:
                    btnGuest.Visible = true;
                    break;
                case -1:
                    this.Text = "ایجاد کاربر";
                    btnLogin.Text = "ثبت";
                    break;
                default:
                    this.Text = "ویرایش کاربر";
                    btnLogin.Text = "اعمال تغییرات";
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        var login = db.LoginRepository.GetByID(loginID);
                        txtUsername.Text = login.UserName;
                        txtUsername.Text = login.UserName;
                    }
                    break;
            }            
        }
        private void btnGuest_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
