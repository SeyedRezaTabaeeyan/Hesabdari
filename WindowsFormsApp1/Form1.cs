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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbltxtDateText.Text = txtDate.Text; 
        }

        private void btnConvert2_Click(object sender, EventArgs e)
        {
            try
            {
                lblConvertToDateTime.Text = Convert.ToDateTime(txtDate.Text).ToString();
            }
            catch (Exception)
            {
                lblConvertToDateTime.Text = "Error";
            }
            
        }

        private void btnConvert3_Click(object sender, EventArgs e)
        {
            try
            {
                lblToShamsi.Text = Convert.ToDateTime(txtDate.Text).ToShamsi();
            }
            catch (Exception)
            {
                lblToShamsi.Text = "Error";
            }
            
        }
    }
}
