using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Video_Rental
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtName.Text.ToString().Equals("") && txtPassword.Text.ToString().Equals("")) {
                MessageBox.Show("Fill User Name and Password First");
            }
            else{
                String qry = "Select * from tbAdmin where  AUsrName='"+txtName.Text.ToString()+"' and APassword='"+txtPassword.Text.ToString()+"'";
                DbClass obj = new DbClass();
                DataTable dt = new DataTable();
                dt = obj.getRecords(qry);
                if (dt.Rows.Count > 0)
                {
                    this.Hide();
                    new FrmMain().ShowDialog();
                }
                else {
                    MessageBox.Show("Invalid User Name and Password");
                }

            }



        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            new frmRegister().ShowDialog();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
