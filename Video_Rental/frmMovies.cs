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
                // object of databse class to acces the data from tables 
                DbClass obj = new DbClass();
                DataTable tbl = new DataTable();
                DataTable tblnew = new DataTable();


                String qry = "";
                int y = 0;
                qry = "select * from tbVideoCount ORDER BY  VCount DESC";
                
                tbl = obj.getRecords(qry);
                if (tbl.Rows.Count > 0)
                {
                    //create the column in the datattable  
                    tblnew.Columns.Add("Movie_id");
                    tblnew.Columns.Add("No_of_Times");
                    //pass the record to the table to display in the grid
                        DataRow row = tblnew.NewRow();
                        row["Movie_id"] = Convert.ToString(tbl.Rows[0]["VID"]);
                        row["No_of_Times"] = Convert.ToString(tbl.Rows[0]["VCount"]);
                        tblnew.Rows.Add(row);
                    
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
