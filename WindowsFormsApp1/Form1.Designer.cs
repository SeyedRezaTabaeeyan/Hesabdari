
namespace WindowsFormsApp1
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
            this.txtDate = new System.Windows.Forms.MaskedTextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lbltxtDateText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblConvertToDateTime = new System.Windows.Forms.Label();
            this.btnConvert2 = new System.Windows.Forms.Button();
            this.btnConvert3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblToShamsi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(12, 37);
            this.txtDate.Mask = "0000/00/00";
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(100, 20);
            this.txtDate.TabIndex = 0;
            this.txtDate.ValidatingType = typeof(System.DateTime);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(330, 95);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 1;
            this.btnConvert.Text = "تبدیل";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbltxtDateText
            // 
            this.lbltxtDateText.AutoSize = true;
            this.lbltxtDateText.Location = new System.Drawing.Point(137, 95);
            this.lbltxtDateText.Name = "lbltxtDateText";
            this.lbltxtDateText.Size = new System.Drawing.Size(65, 13);
            this.lbltxtDateText.TabIndex = 2;
            this.lbltxtDateText.Text = "txtDate.Text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "txtDate.Text";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Convert.ToDateTime";
            // 
            // lblConvertToDateTime
            // 
            this.lblConvertToDateTime.AutoSize = true;
            this.lblConvertToDateTime.Location = new System.Drawing.Point(137, 140);
            this.lblConvertToDateTime.Name = "lblConvertToDateTime";
            this.lblConvertToDateTime.Size = new System.Drawing.Size(106, 13);
            this.lblConvertToDateTime.TabIndex = 4;
            this.lblConvertToDateTime.Text = "Convert.ToDateTime";
            // 
            // btnConvert2
            // 
            this.btnConvert2.Location = new System.Drawing.Point(330, 135);
            this.btnConvert2.Name = "btnConvert2";
            this.btnConvert2.Size = new System.Drawing.Size(75, 23);
            this.btnConvert2.TabIndex = 7;
            this.btnConvert2.Text = "تبدیل";
            this.btnConvert2.UseVisualStyleBackColor = true;
            this.btnConvert2.Click += new System.EventHandler(this.btnConvert2_Click);
            // 
            // btnConvert3
            // 
            this.btnConvert3.Location = new System.Drawing.Point(327, 175);
            this.btnConvert3.Name = "btnConvert3";
            this.btnConvert3.Size = new System.Drawing.Size(75, 23);
            this.btnConvert3.TabIndex = 10;
            this.btnConvert3.Text = "تبدیل";
            this.btnConvert3.UseVisualStyleBackColor = true;
            this.btnConvert3.Click += new System.EventHandler(this.btnConvert3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "ToShamsi";
            // 
            // lblToShamsi
            // 
            this.lblToShamsi.AutoSize = true;
            this.lblToShamsi.Location = new System.Drawing.Point(134, 180);
            this.lblToShamsi.Name = "lblToShamsi";
            this.lblToShamsi.Size = new System.Drawing.Size(54, 13);
            this.lblToShamsi.TabIndex = 8;
            this.lblToShamsi.Text = "ToShamsi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.btnConvert3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblToShamsi);
            this.Controls.Add(this.btnConvert2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblConvertToDateTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbltxtDateText);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtDate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtDate;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lbltxtDateText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblConvertToDateTime;
        private System.Windows.Forms.Button btnConvert2;
        private System.Windows.Forms.Button btnConvert3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblToShamsi;
    }
}

