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
    public partial class frmCustomerRanking : Form
    {
        public frmCustomerRanking()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmMain().ShowDialog();
        }

        private void frmCustomerRanking_Load(object sender, EventArgs e)
        {
            try
            {
                //objet of DBClass and DataTable Class 
                DbClass obj = new DbClass();
                DataTable tblnew = new DataTable();
                //LocalVariable to access the 
                String qry = "";
                int y = 0;
                //select the Data from the Table and then pass it to the Data Table 
                qry = "select * from tbCustomerRentalCount ORDER BY  CCount DESC";
                DataTable tbl = new DataTable();
                tbl = obj.getRecords(qry);
                if (tbl.Rows.Count > 0)
                {
                    tblnew.Columns.Add("Customer_id");
                    tblnew.Columns.Add("No_of_Times");
                    //using the statement to pass the record to the Table from the Data table 
                        DataRow row = tblnew.NewRow();
                        row["Customer_id"] = Convert.ToString(tbl.Rows[0]["CID"]);
                        row["No_of_Times"] = Convert.ToString(tbl.Rows[0]["CCount"]);
                        tblnew.Rows.Add(row);
                   
                   

                }
                // Pass the DAta to Data Grid view to Display
                dataGridView1.DataSource = tblnew;
            }
            catch (Exception except)
            {
                MessageBox.Show(except.Message);
            }





        }
    }
}
