
namespace Hesabdari.App
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.txtDropDown = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnEditLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblWelcome = new System.Windows.Forms.ToolStripLabel();
            this.lblISAdmin = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnCustomers = new System.Windows.Forms.ToolStripButton();
            this.btnNewTransaction = new System.Windows.Forms.ToolStripButton();
            this.btnReport = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.lblToDate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRemaining = new System.Windows.Forms.Label();
            this.lblSumPay = new System.Windows.Forms.Label();
            this.lblSumReceive = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtDropDown,
            this.lblWelcome,
            this.lblISAdmin});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // txtDropDown
            // 
            this.txtDropDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.txtDropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEditLogin,
            this.btnAddLogin,
            this.btnExit});
            this.txtDropDown.Image = ((System.Drawing.Image)(resources.GetObject("txtDropDown.Image")));
            this.txtDropDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.txtDropDown.Name = "txtDropDown";
            this.txtDropDown.Size = new System.Drawing.Size(63, 22);
            this.txtDropDown.Text = "تنظیمات";
            // 
            // btnEditLogin
            // 
            this.btnEditLogin.Name = "btnEditLogin";
            this.btnEditLogin.Size = new System.Drawing.Size(178, 22);
            this.btnEditLogin.Text = "تنظیمات ورود";
            this.btnEditLogin.Visible = false;
            this.btnEditLogin.Click += new System.EventHandler(this.btnEditLogin_Click);
            // 
            // btnAddLogin
            // 
            this.btnAddLogin.Name = "btnAddLogin";
            this.btnAddLogin.Size = new System.Drawing.Size(178, 22);
            this.btnAddLogin.Text = "ایجاد کاربر جدید";
            this.btnAddLogin.Visible = false;
            this.btnAddLogin.Click += new System.EventHandler(this.btnAddLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(178, 22);
            this.btnExit.Text = "خروج از حساب کاربری";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(114, 22);
            this.lblWelcome.Text = "کاربر عزیز خوش آمدید";
            // 
            // lblISAdmin
            // 
            this.lblISAdmin.Name = "lblISAdmin";
            this.lblISAdmin.Size = new System.Drawing.Size(112, 22);
            this.lblISAdmin.Text = "سطح دسترسی : عادی";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCustomers,
            this.btnNewTransaction,
            this.btnReport});
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(784, 62);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnCustomers
            // 
            this.btnCustomers.Image = global::Hesabdari.App.Properties.Resources._1371476468_preferences_contact_list;
            this.btnCustomers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCustomers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(71, 59);
            this.btnCustomers.Text = "طرف حساب";
            this.btnCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnNewTransaction
            // 
            this.btnNewTransaction.Image = global::Hesabdari.App.Properties.Resources._1371476499_todo_list;
            this.btnNewTransaction.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNewTransaction.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewTransaction.Name = "btnNewTransaction";
            this.btnNewTransaction.Size = new System.Drawing.Size(72, 59);
            this.btnNewTransaction.Text = "تراکنش جدید";
            this.btnNewTransaction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNewTransaction.Click += new System.EventHandler(this.btnNewTransaction_Click);
            // 
            // btnReport
            // 
            this.btnReport.Image = global::Hesabdari.App.Properties.Resources.servicesCosts;
            this.btnReport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(45, 59);
            this.btnReport.Text = "گزارش ";
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblDate,
            this.lblTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 439);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblDate
            // 
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(31, 17);
            this.lblDate.Text = "تاریخ";
            // 
            // lblTime
            // 
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(38, 17);
            this.lblTime.Text = "ساعت";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblFromDate);
            this.groupBox1.Controls.Add(this.lblToDate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblRemaining);
            this.groupBox1.Controls.Add(this.lblSumPay);
            this.groupBox1.Controls.Add(this.lblSumReceive);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(494, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 232);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "گزارش این ماه";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(212, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "تا تاریخ :";
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Location = new System.Drawing.Point(70, 26);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(39, 13);
            this.lblFromDate.TabIndex = 8;
            this.lblFromDate.Text = "اول ماه";
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Location = new System.Drawing.Point(70, 59);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(39, 13);
            this.lblToDate.TabIndex = 7;
            this.lblToDate.Text = "آخر ماه";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "از تاریخ :";
            // 
            // lblRemaining
            // 
            this.lblRemaining.AutoSize = true;
            this.lblRemaining.Location = new System.Drawing.Point(70, 171);
            this.lblRemaining.Name = "lblRemaining";
            this.lblRemaining.Size = new System.Drawing.Size(30, 13);
            this.lblRemaining.TabIndex = 5;
            this.lblRemaining.Text = "مانده";
            // 
            // lblSumPay
            // 
            this.lblSumPay.AutoSize = true;
            this.lblSumPay.Location = new System.Drawing.Point(70, 133);
            this.lblSumPay.Name = "lblSumPay";
            this.lblSumPay.Size = new System.Drawing.Size(82, 13);
            this.lblSumPay.TabIndex = 4;
            this.lblSumPay.Text = "جمع پرداختی ها";
            // 
            // lblSumReceive
            // 
            this.lblSumReceive.AutoSize = true;
            this.lblSumReceive.Location = new System.Drawing.Point(70, 96);
            this.lblSumReceive.Name = "lblSumReceive";
            this.lblSumReceive.Size = new System.Drawing.Size(79, 13);
            this.lblSumReceive.TabIndex = 3;
            this.lblSumReceive.Text = "جمع دریافتی ها";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "مانده : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "پرداختی ها :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "دریافتی ها :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hesabdari.App.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(12, 147);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(307, 269);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "حسابداری شخصی من";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton txtDropDown;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnCustomers;
        private System.Windows.Forms.ToolStripButton btnNewTransaction;
        private System.Windows.Forms.ToolStripButton btnReport;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem btnEditLogin;
        private System.Windows.Forms.ToolStripMenuItem btnAddLogin;
        private System.Windows.Forms.ToolStripMenuItem btnExit;
        private System.Windows.Forms.ToolStripLabel lblWelcome;
        private System.Windows.Forms.ToolStripLabel lblISAdmin;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblDate;
        private System.Windows.Forms.ToolStripStatusLabel lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblRemaining;
        private System.Windows.Forms.Label lblSumPay;
        private System.Windows.Forms.Label lblSumReceive;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.Label label4;
    }
}

