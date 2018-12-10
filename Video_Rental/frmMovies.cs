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
    public partial class frmMovies : Form
    {
        public frmMovies()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmMain().ShowDialog();
        }

        private void frmMovies_Load(object sender, EventArgs e)
        {



            try
            {
                DbClass obj = new DbClass();
                String qry = "";
                int y = 0;
                qry = "select * from tbVideoCount ORDER BY  VCount DESC";
                DataTable tbl = new DataTable();

                DataTable tblnew = new DataTable();

                tbl = obj.getRecords(qry);
                if (tbl.Rows.Count > 0)
                {
                    tblnew.Columns.Add("Movie_id");
                    tblnew.Columns.Add("No_of_Times");
                    for (y = 0; y < tbl.Rows.Count - 1; y++)
                    {
                        DataRow row = tblnew.NewRow();
                        row["Movie_id"] = Convert.ToString(tbl.Rows[y]["VID"]);
                        row["No_of_Times"] = Convert.ToString(tbl.Rows[y]["VCount"]);
                        tblnew.Rows.Add(row);
                    }
                    dataGridView1.DataSource = tblnew;

                }
            }
            catch (Exception except)
            {
                MessageBox.Show(except.Message);
            }






        }
    }
}
