using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Sales_and_Inventory_System
{
    public partial class frmLogin : Form
    {
        ConnectionString cs = new ConnectionString();
        frmMainMenu frm = new frmMainMenu();    
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cmbUsertype.Text == "")
            {
                MessageBox.Show("Please select user type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbUsertype.Focus();
                return;
            }
            if (txtUserName.Text == "")
            {
                MessageBox.Show("Please enter user name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserName.Focus();
                return;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Please enter password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return;
            }
            try
            {
                SqlConnection myConnection = default(SqlConnection);
                myConnection = new SqlConnection(cs.DBConn);

                SqlCommand myCommand = default(SqlCommand);

                myCommand = new SqlCommand("SELECT UserType,Username,password FROM Registration WHERE UserType = @usertype AND Username = @username AND password = @UserPassword", myConnection);
                SqlParameter uType = new SqlParameter("@usertype", SqlDbType.NChar);

                SqlParameter uName = new SqlParameter("@username", SqlDbType.NChar);

                SqlParameter uPassword = new SqlParameter("@UserPassword", SqlDbType.NChar);

                uType.Value = cmbUsertype.Text;
                uName.Value = txtUserName.Text;
                uPassword.Value = txtPassword.Text;

                myCommand.Parameters.Add(uType);
                myCommand.Parameters.Add(uName);
                myCommand.Parameters.Add(uPassword);

                myCommand.Connection.Open();

                SqlDataReader myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);

                if (myReader.Read() == true)
                {

                   
                        int i;
                        ProgressBar1.Visible = true;
                        ProgressBar1.Maximum = 5000;
                        ProgressBar1.Minimum = 0;
                        ProgressBar1.Value = 4;
                        ProgressBar1.Step = 1;

                        for (i = 0; i <= 5000; i++)
                        {
                            ProgressBar1.PerformStep();
                        }
                        if (cmbUsertype.Text == "SALES MANAGER")
                    {
                        this.Hide();
                        frm.masterEntryToolStripMenuItem.Enabled = false;
                        frm.categoryToolStripMenuItem.Enabled = false;
                        frm.companyToolStripMenuItem.Enabled = false;
                        frm.productsToolStripMenuItem1.Enabled = false;
                        frm.usersToolStripMenuItem.Enabled = false;
                        frm.registrationToolStripMenuItem1.Enabled = false;
                        frm.loginDetailsToolStripMenuItem.Enabled = false;
                        frm.stockToolStripMenuItem1.Enabled = false;
                        frm.salesToolStripMenuItem.Enabled = false;
                        frm.productsToolStripMenuItem.Enabled = false;
                        frm.productsToolStripMenuItem2.Enabled = false;
                        frm.stockToolStripMenuItem2.Enabled = false;
                        frm.salesToolStripMenuItem1.Enabled = true;
                        frm.registrationToolStripMenuItem.Enabled = false;
                        frm.productToolStripMenuItem.Enabled = false;
                        frm.stockToolStripMenuItem.Enabled = false;
                        frm.invoiceToolStripMenuItem.Enabled = false;
                        frm.stockInToolStripMenuItem.Enabled = false;
                        frm.lblUser.Text = txtUserName.Text;
                        frm.lblUserType.Text = cmbUsertype.Text;
                        frm.usertype.Text = cmbUsertype.Text;
                        frm.Show();
                    }

                        if (cmbUsertype.Text == "STORE MANAGER (ADMINISTRATOR)")
                        {
                            this.Hide();
                            frm.masterEntryToolStripMenuItem.Enabled = true;
                            frm.categoryToolStripMenuItem.Enabled = true;
                            frm.companyToolStripMenuItem.Enabled = true;
                            frm.productsToolStripMenuItem1.Enabled = true;
                            frm.usersToolStripMenuItem.Enabled = true;
                            frm.registrationToolStripMenuItem1.Enabled = true;
                            frm.loginDetailsToolStripMenuItem.Enabled = true;
                            frm.stockToolStripMenuItem1.Enabled = true;
                            frm.salesToolStripMenuItem.Enabled = true;
                            frm.productsToolStripMenuItem.Enabled = true;
                            frm.productsToolStripMenuItem2.Enabled = true;
                            frm.stockToolStripMenuItem2.Enabled = true;
                            frm.salesToolStripMenuItem1.Enabled = true;
                            frm.registrationToolStripMenuItem.Enabled = true;
                            frm.productToolStripMenuItem.Enabled = true;
                            frm.stockToolStripMenuItem.Enabled = true;
                            frm.invoiceToolStripMenuItem.Enabled = true;
                            frm.stockInToolStripMenuItem.Enabled = true;
                            frm.lblUser.Text = txtUserName.Text;
                            frm.lblUserType.Text = cmbUsertype.Text;
                            frm.usertype.Text = cmbUsertype.Text;
                            frm.Show();
                        }

                        if (cmbUsertype.Text == "SALES PERSON")
                        {
                            this.Hide();
                            frm.masterEntryToolStripMenuItem.Enabled = false;
                            frm.categoryToolStripMenuItem.Enabled = false;
                            frm.companyToolStripMenuItem.Enabled = false;
                            frm.productsToolStripMenuItem1.Enabled = false;
                            frm.usersToolStripMenuItem.Enabled = false;
                            frm.registrationToolStripMenuItem1.Enabled = false;
                            frm.loginDetailsToolStripMenuItem.Enabled = false;
                            frm.stockToolStripMenuItem1.Enabled = false;
                            frm.salesToolStripMenuItem.Enabled = true;
                            frm.productsToolStripMenuItem.Enabled = false;
                            frm.productsToolStripMenuItem2.Enabled = true;
                            frm.stockToolStripMenuItem2.Enabled = true;
                            frm.salesToolStripMenuItem1.Enabled = false;
                            frm.registrationToolStripMenuItem.Enabled = false;
                            frm.productToolStripMenuItem.Enabled = false;
                            frm.stockToolStripMenuItem.Enabled =    false;
                            frm.invoiceToolStripMenuItem.Enabled = true;
                            frm.stockInToolStripMenuItem.Enabled = true;
                            frm.lblUser.Text = txtUserName.Text;
                            frm.lblUserType.Text = cmbUsertype.Text;
                            frm.usertype.Text = cmbUsertype.Text;
                            frm.Show();
                        }
                        if (cmbUsertype.Text == "INVENTORY MANAGER")
                        {
                            this.Hide();
                            frm.masterEntryToolStripMenuItem.Enabled = true;
                            frm.categoryToolStripMenuItem.Enabled = false;
                            frm.companyToolStripMenuItem.Enabled = false;
                            frm.productsToolStripMenuItem1.Enabled = true;
                            frm.usersToolStripMenuItem.Enabled = false;
                            frm.registrationToolStripMenuItem1.Enabled = false;
                            frm.loginDetailsToolStripMenuItem.Enabled = false;
                            frm.stockToolStripMenuItem1.Enabled = true;
                            frm.salesToolStripMenuItem.Enabled = false;
                            frm.productsToolStripMenuItem.Enabled = true;
                            frm.productsToolStripMenuItem2.Enabled = true;
                            frm.stockToolStripMenuItem2.Enabled = true;
                            frm.salesToolStripMenuItem1.Enabled = false;
                            frm.registrationToolStripMenuItem.Enabled = false;
                            frm.productToolStripMenuItem.Enabled = true;
                            frm.stockToolStripMenuItem.Enabled = true;
                            frm.invoiceToolStripMenuItem.Enabled = false;
                            frm.stockInToolStripMenuItem.Enabled = true;
                            frm.lblUser.Text = txtUserName.Text;
                            frm.lblUserType.Text = cmbUsertype.Text;
                            frm.usertype.Text = cmbUsertype.Text;
                            frm.Show();
                        }
                    }
                

                else
                {
                    MessageBox.Show("Login Failed...Try again !", "Login Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtUserName.Clear();
                    txtPassword.Clear();
                    txtUserName.Focus();

                }
                if (myConnection.State == ConnectionState.Open)
                {
                    myConnection.Dispose();
                }

              

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {
            ProgressBar1.Visible = false;
            cmbUsertype.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            return;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmChangePassword frm = new frmChangePassword();
            frm.Show();
            frm.txtUserName.Text = "";  
            frm.txtNewPassword.Text = "";
            frm.txtOldPassword.Text = "";
            frm.txtConfirmPassword.Text = "";
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmRecoveryPassword frm = new frmRecoveryPassword();
            frm.txtEmail.Focus();
            frm.Show();
        }
    }
}
