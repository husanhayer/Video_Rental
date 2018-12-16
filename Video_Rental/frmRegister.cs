using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_Rental
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // close th Application 
            Application.Exit();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try {
                // if all the text box is not filled then the if block will be execute and display the error message that you have to fill all the text boxes
                if (txtName.Text.ToString().Equals("") && txtAge.Text.ToString().Equals("") && txtUsrName.Text.ToString().Equals("") && txtPassword.Text.ToString().Equals(""))
                {
                    MessageBox.Show("Fill All Details First");
                }
                else {
                    //if the condition is flase then the else block will be execute and enter the record int he database table 
                    DbClass obj = new DbClass();
                    String qry = "insert into tbAdmin(AName,AAge,AUsrName,APassword) values('" + txtName.Text.ToString() + "','" + txtAge.Text.ToString() + "','" + txtUsrName.Text.ToString() + "','" + txtPassword.Text.ToString() + "')";
                    obj.runIDU(qry);
                    MessageBox.Show("You Are Registered");
                    // after inserting the reord in the database then the form will close and login will be open 
                    this.Hide();
                    new FrmLogin().ShowDialog();
                }

                
            }
            catch (Exception exception) {
                MessageBox.Show(exception.Message);
            }



        }
    }
}
