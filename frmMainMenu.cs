using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Sales_and_Inventory_System
{
    public partial class frmMainMenu : Form
    {

        public frmMainMenu()
        {
            InitializeComponent();
        }

     
        private void registrationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRegistration frm = new frmRegistration();
            frm.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.Show();
        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistration frm = new frmRegistration();
            frm.Show();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lblUserType.Text == "STORE MANAGER (ADMINISTRATOR)")
            {
                frmProduct frm = new frmProduct();
                frm.lblUserType.Text = lblUserType.Text;
                frm.btnGetData.Enabled = true;
                frm.Show();
            }
            if (lblUserType.Text == "INVENTORY MANAGER")
            {
                frmProduct frm = new frmProduct();
                frm.lblUserType.Text = lblUserType.Text;
                frm.btnGetData.Enabled = false;
                frm.Show();
            }
        }

        private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Notepad.exe");
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void wordpadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Wordpad.exe");
        }

        private void taskManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("TaskMgr.exe");
        }

        private void mSWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Winword.exe");
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategory frm = new frmCategory();
            frm.Show();
        }

        private void companyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSubCategory frm = new frmSubCategory();
            frm.Show();
        }

   
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCategory o1 = new frmCategory();
            o1.Hide();
            frmSubCategory o2 = new frmSubCategory();
            o2.Hide();
            frmProduct o3 = new frmProduct();
            o3.Hide();
            frmRegisteredUsersDetails o4 = new frmRegisteredUsersDetails();
            o4.Hide();
            frmRegistration o5 = new frmRegistration();
            o5.Hide();
            frmProductsRecord2 o9 = new frmProductsRecord2();
            o9.Hide();
            frmSalesRecord o10 = new frmSalesRecord();
            o10.Hide();
            frmStockIN o11=new frmStockIN();
            o11.Hide();
            frmLogin frm = new frmLogin();
            frm.cmbUsertype.SelectedIndex = -1;
            frm.txtUserName.Text = "";
            frm.txtPassword.Text = "";
            frm.ProgressBar1.Visible = false;
            frm.cmbUsertype.Focus();
            frm.Show();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
         lblTime.Text = System.DateTime.Now.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = System.DateTime.Now.ToString();
        }

        private void productsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (lblUserType.Text == "STORE MANAGER (ADMINISTRATOR)")
            {
                frmProduct frm = new frmProduct();
                frm.lblUserType.Text = lblUserType.Text;
                frm.btnGetData.Enabled = true;
                frm.Show();
            }
            if (lblUserType.Text == "INVENTORY MANAGER")
            {
                frmProduct frm = new frmProduct();
                frm.lblUserType.Text = lblUserType.Text;
                frm.btnGetData.Enabled = false;
                frm.Show();
            }
        }

        private void productsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmProductsRecord2 frm = new frmProductsRecord2();
            frm.Show();
        }

     
        private void stockToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (lblUserType.Text == "STORE MANAGER (ADMINISTRATOR)")
            {
                frmStock frm = new frmStock();
                frm.lblUserType.Text = lblUserType.Text;
                frm.btnGetData.Enabled = true;
                frm.Show();
            }
            if (lblUserType.Text == "INVENTORY MANAGER")
            {
                frmStock frm = new frmStock();
                frm.lblUserType.Text = lblUserType.Text;
                frm.btnGetData.Enabled = false;
                frm.Show();
            }
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lblUserType.Text == "STORE MANAGER (ADMINISTRATOR)")
            {
                frmStock frm = new frmStock();
                frm.lblUserType.Text = lblUserType.Text;
                frm.btnGetData.Enabled = true;
                frm.Show();
            }
            if (lblUserType.Text == "INVENTORY MANAGER")
            {
                frmStock frm = new frmStock();
                frm.lblUserType.Text = lblUserType.Text;
                frm.btnGetData.Enabled = false;
                frm.Show();
            }
        }

      

   
        private void invoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lblUserType.Text == "STORE MANAGER (ADMINISTRATOR)")
            {
                frmSales frm = new frmSales();
                frm.lblUserType.Text = lblUserType.Text;
                frm.btnGetData.Enabled = true;
                frm.Show();
            }
            if (lblUserType.Text == "SALES PERSON")
            {
                frmSales frm = new frmSales();
                frm.lblUserType.Text = lblUserType.Text;
                frm.btnGetData.Enabled = false;
                frm.Show();
            }
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lblUserType.Text == "STORE MANAGER (ADMINISTRATOR)")
            {
                frmSales frm = new frmSales();
                frm.lblUserType.Text = lblUserType.Text;
                frm.btnGetData.Enabled = true;
                frm.Show();
            }
            if (lblUserType.Text == "SALES PERSON")
            {
                frmSales frm = new frmSales();
                frm.lblUserType.Text = lblUserType.Text;
                frm.btnGetData.Enabled = false;
                frm.Show();
            }
        }

        private void salesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmSalesRecord frm = new frmSalesRecord();
            frm.Show();
        }

        private void loginDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoginDetails frm = new frmLoginDetails();
            frm.Show();
        }

     
        private void frmMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            
        }

     

        private void stockToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmStockIN frm = new frmStockIN();
            frm.Show();
        }

        private void stockInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStockIN frm = new frmStockIN();
            frm.Show();
        }

      
    }
}
