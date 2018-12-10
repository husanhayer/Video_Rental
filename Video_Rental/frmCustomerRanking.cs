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
                DbClass obj = new DbClass();
                DataTable tblnew = new DataTable();
                String qry = "";
                int y = 0;
                qry = "select * from tbCustomerRentalCount ORDER BY  CCount DESC";
                DataTable tbl = new DataTable();
                tbl = obj.getRecords(qry);
                if (tbl.Rows.Count > 0)
                {
                    tblnew.Columns.Add("Customer_id");
                    tblnew.Columns.Add("No_of_Times");
                    for (y = 0; y < tbl.Rows.Count - 1; y++)
                    {
                        DataRow row = tblnew.NewRow();
                        row["Customer_id"] = Convert.ToString(tbl.Rows[y]["CID"]);
                        row["No_of_Times"] = Convert.ToString(tbl.Rows[y]["CCount"]);
                        tblnew.Rows.Add(row);
                    }
                   

                }
                dataGridView1.DataSource = tblnew;
            }
            catch (Exception except)
            {
                MessageBox.Show(except.Message);
            }





        }
    }
}
