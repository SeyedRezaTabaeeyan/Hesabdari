using Hesabdari.DataLayer;
using Hesabdari.DataLayer.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValidationComponents;

namespace Hesabdari.App
{
    public partial class frmAddNewCustomer : Form
    {
        public int customerID = 0;
        public frmAddNewCustomer()
        {
            InitializeComponent();
        }

        private void frmAddNewCustomer_Load(object sender, EventArgs e)
        {
            if (customerID != 0)
            {
                using(UnitOfWork db=new UnitOfWork())
                {
                    this.Text = "ویرایش شخص";
                    btnSave.Text = "اعمال تغییرات";
                    Customers customer = db.CustomerRepository.GetByID(customerID);
                    txtName.Text = customer.FullName;
                    txtMobile.Text = customer.Mobile;
                    txtEmail.Text = customer.Email;
                    txtAddress.Text = customer.Address;
                    pcCustomer.ImageLocation = Application.StartupPath + "/Images/" + customer.CustomerImage;
                }
                
            }
            
        }

        private void btnSelectPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pcCustomer.ImageLocation = openFile.FileName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))           
            {
                string ImageName = Guid.NewGuid().ToString()+Path.GetExtension(pcCustomer.ImageLocation);
                string path = Application.StartupPath + "/Image/";
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                pcCustomer.Image.Save(path + ImageName);
                Customers customer = new Customers()
                {
                    FullName = txtName.Text,
                    Mobile = txtMobile.Text,
                    Email = txtEmail.Text,
                    Address = txtAddress.Text,
                    CustomerImage = ImageName
                };
                using(UnitOfWork db=new UnitOfWork())
                {
                    if (customerID == 0)
                    {
                        db.CustomerRepository.Insert(customer);
                    }
                    else
                    {
                        customer.CustomerID = customerID;
                        db.CustomerRepository.Update(customer);
                    }
                }
                DialogResult = DialogResult.OK;
            }
            
            
        }
    }
}
