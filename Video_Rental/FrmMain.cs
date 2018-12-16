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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
         // object of class used for execute the method of the Database class and DataTables class 

        DbClass obj = new DbClass();
        DataTable tbl = new DataTable();
        //Query variable to write the query like insert delete update search etc 
        //Glbal declaration of the variable to use in all the methods using OOPs concept
        String qry = "";
        //Integer variable to get the id of the video rental and customer to do different  type of task like update delete and view
        int Cust_ID = 0, Rental_ID=0, Video_ID=0;
        int CustomerID = 0, RentalID = 0, VideoID = 0;
        // this btn is used to add the customer for booking the movie on rental 
        private void BtnAddCustomer_Click(object sender, EventArgs e)
        {

            try {
                int id = 1;
                //this query is used to get the id of the customer to provide the unique key to the customer for every use 
                qry = "select * from tbCustomer";
                tbl = obj.getRecords(qry);
                if (tbl.Rows.Count > 0)
                {
                    int ct = tbl.Rows.Count - 1;
                    id = Convert.ToInt32(tbl.Rows[ct]["id"]);
                    id++;
                    // After getting the last id ofthe registered customer increment by 1 so the new customer also get the new unique id 
                    qry = "";

                    String CName = Name_txtbox.Text.ToString() + " " + LastName_txtbox.Text.ToString();
                    //insert the customer record in the customer table for future use 
                    qry = "insert into tbCustomer(id,CustName,CustAdr,CustPhone) values(" + id + ",'" + CName + "','" + address_txtbox.Text.ToString() + "','" + phone_txtbox.Text.ToString() + "')";
                    obj.runIDU(qry);
                    MessageBox.Show("Customer Registered");

                 }
                else
                {
                    qry = "";
                    String CName = Name_txtbox.Text.ToString() + " " + LastName_txtbox.Text.ToString();
                   //if he is the first customer then his id start from 1 which is stored in the id variable 
                    qry = "insert into tbCustomer(id,CustName,CustAdr,CustPhone) values(" + id + ",'" + CName+ "','" + address_txtbox.Text.ToString() + "','" + phone_txtbox.Text.ToString() + "')";
                    obj.runIDU(qry);
                    MessageBox.Show("Customer Registered");
                }
                Name_txtbox.Text = "";
                LastName_txtbox.Text = "";
                address_txtbox.Text = "";
                phone_txtbox.Text = "";

                //Reload the whole data grid to view updated record 
                qry = "";
                qry = "select * from tbCustomer";
                tbl = obj.getRecords(qry);
                dgvRecord.DataSource = tbl;

            }
            catch (Exception exception) {
                //error message if there is an error then it will display the error
                MessageBox.Show(exception.Message);
            }
            



        }

        private void btnDelCustomer_Click(object sender, EventArgs e)
        {
            try {
                if (CustomerID >= 1)
                {
                    qry = "";
                    // After getting the id of the customer we can delete the customer from customer id 
                    // if he has a movie on rent then we can't be able to delete the customer record 
                    qry = "select * from tbRental where CID=" + CustomerID + "";
                    tbl = obj.getRecords(qry);
                    if (tbl.Rows.Count > 0)
                    {
                        MessageBox.Show("You Must Have to Return Movie First");
                    }
                    else
                    {

                        // if he didn't have any movie on rent then his record will be deleted using the id 
                        qry = "";
                        qry = "delete from tbCustomer where id=" + CustomerID + "";
                        obj.runIDU(qry);
                        MessageBox.Show("Customer Record is Deleted");

                        // reload the data grid 
                        qry = "";
                        qry = "select * from tbCustomer";
                        tbl = obj.getRecords(qry);
                        dgvRecord.DataSource = tbl;

                        Name_txtbox.Text = "";
                        LastName_txtbox.Text = "";
                        phone_txtbox.Text = "";
                        address_txtbox.Text = "";

                        CustomerID = 0;

                    }
                }
                else {
                        // error message if there is no id in the memory
                    MessageBox.Show("You Have to Select the Data First");
                }   
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnIssue_Click(object sender, EventArgs e)
        {

            try {

                qry = "";
                int id = 1;
                //select qry from rental for id so the unique id is generated 
                qry = "select * from tbRental";
                tbl = obj.getRecords(qry);
                if (tbl.Rows.Count>0) {
                    id =Convert.ToInt32( tbl.Rows[tbl.Rows.Count - 1]["id"]);
                    id = id + 1;
                    // insert the data in the rental table after generating a new id 
                    qry = "insert into tbRental(id,MID,CID,IssueDate,ReturnDate) values(" + id + "," + Convert.ToInt32(txtMID.Text.ToString()) + "," + Convert.ToInt32(txtCID.Text.ToString()) + ",'" + dtpIssue.Value.ToShortDateString() + "','" + dtpReturn.Value.ToShortDateString() + "')";
                    obj.runIDU(qry);

                    // insert data for Video or Movie rental system to counthow much time this video is gone for rent
                    qry = "";
                    qry = "select * from tbVideoCount where VID="+Convert.ToInt32(txtMID.Text.ToString())+"";
                    tbl = obj.getRecords(qry);
                    int VCount = 0;
                    if (tbl.Rows.Count > 0)
                    {
                        VCount = Convert.ToInt32(tbl.Rows[tbl.Rows.Count - 1]["VCount"]);
                        VCount++;
                        qry = "";
                        //update the record of the video afer gettign a new movie on rental 
                        qry = "update tbVideCount set VCount=" + VCount + " where VID="+ Convert.ToInt32(txtMID.Text.ToString()) + "";
                        obj.runIDU(qry);
                    }
                    else {
                        qry = "";
                        //Insert the record of the Video afer gettign a new movie on rental Counting System
                        qry = "insert into tbVideoCount(VID,VCount) values(1,"+Convert.ToInt32(txtMID.Text.ToString())+")";

                        obj.runIDU(qry);
                    }
                    // insert data for Video or Movie rental system to count Ending Area


                    // insert data of Customer for Video or Movie rental system to count the Customer who has booked as much id on rental
                    qry = "";
                    qry = "select * from tbCustomerRentalCount where CID=" + Convert.ToInt32(txtCID.Text.ToString()) + "";
                    tbl = obj.getRecords(qry);
                    int CCount = 0;
                    if (tbl.Rows.Count > 0)
                    {
                        CCount = Convert.ToInt32(tbl.Rows[tbl.Rows.Count - 1]["CCount"]);
                        CCount++;
                        qry = "";
                        qry = "update tbCustomerRentalCount set CCount=" + CCount + " where CID=" + Convert.ToInt32(txtCID.Text.ToString()) + "";
                        obj.runIDU(qry);
                    }
                    else
                    {
                        qry = "";
                        qry = "insert into tbCustomerRentalCount(CID,CCount) values(1," + Convert.ToInt32(txtCID.Text.ToString()) + ")";
                        obj.runIDU(qry);
                    }
                    // insert data for Video or Movie rental system to count Ending Area





                    RentalID = 0;


                    MessageBox.Show("Movie is issued on Rental");


                }
                else {
                   //insert the reocrd in the rental table in the data grid
                    qry = "insert into tbRental(id,MID,CID,IssueDate,ReturnDate) values("+id+","+Convert.ToInt32(txtMID.Text.ToString())+","+Convert.ToInt32(txtCID.Text.ToString())+",'"+dtpIssue.Value.ToShortDateString()+"','"+dtpReturn.Value.ToShortDateString()+"')";
                    obj.runIDU(qry);
                    MessageBox.Show("Movie is issued on Rental");
                }

                txtCID.Text = "";
                txtMID.Text = "";


                /*update the record after giving a movie on rental */

                qry = "";
                qry = "select * from tbRental";
                tbl = obj.getRecords(qry);
                if (tbl.Rows.Count > 0)
                {
                    dgvRecord.DataSource = tbl;
                }




            }
            catch (Exception exception) {
                /* error message block to print the error message */

                MessageBox.Show(exception.Message);
                    
            }


        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            
            try
            {
                
                /* Local variable to calculate the total charges of the rental movie so thus first of all get the
                  cost from the rental table to get the charges of the per day and then calculate the day differnce beteen the
                  rental date and retur date */

                int id = 1, Cost=0,bill=0;
                String diff = "";
                qry = "";
                qry = "select * from tbVideos where id="+Convert.ToInt32(txtMID.Text.ToString())+"";
                tbl = obj.getRecords(qry);
                if (tbl.Rows.Count > 0)
                {
                    Cost = Convert.ToInt32(tbl.Rows[tbl.Rows.Count-1]["VCost"].ToString());

                }
                DateTime Current_date = DateTime.Now;
            

                DateTime Old_date = Convert.ToDateTime(dtpIssue.Value.ToString());

            

                diff = (Current_date - Old_date).TotalDays.ToString();

            
                // converting the roundoff function to get the exact integer value for multiplication
                Double dif = Math.Round(Convert.ToDouble(diff));
            

            bill = Cost * Convert.ToInt32(dif);


            
                /*  when movie is return after getting the money the record will be deleted from the rental 
                   table and display in the  record in the grid */
                qry = "";
               qry = "delete from tbRental where id=" + RentalID + "";
             obj.runIDU(qry);
                
                qry = "";
                qry = "select * from  tbReturn ";
                tbl = obj.getRecords(qry);
                if (tbl.Rows.Count > 0)
                {
                    id = Convert.ToInt32(tbl.Rows[tbl.Rows.Count - 1]["id"]);
                    id++;
                qry = "";
                qry = "insert into tbReturn (id,MID,CID,DateofReturn,Amount) values("+id+","+Convert.ToInt32(txtMID.Text.ToString())+","+Convert.ToInt32(txtCID.Text.ToString())+",'"+Current_date.ToString()+"',"+bill+")";
                obj.runIDU(qry);
                }
                else {
                qry = "";
                qry = "insert into tbReturn (id,MID,CID,DateofReturn,Amount) values(" + id + "," + Convert.ToInt32(txtMID.Text.ToString()) + "," + Convert.ToInt32(txtCID.Text.ToString()) + ",'" + Current_date.ToString() + "'," + bill + ")";
                obj.runIDU(qry);

            }

            MessageBox.Show(" Thanks for using our Services and Your Charges are==$"+bill);

                txtMID.Text = "";
                txtCID.Text = "";
                RentalID = 0;


                /*  reload the data grid   */
                qry = "";
                qry = "select * from tbRental";
                tbl = obj.getRecords(qry);
                if (tbl.Rows.Count > 0)
                {
                    dgvRecord.DataSource = tbl;
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }



        }

        private void DeleteRentedMovie_Click(object sender, EventArgs e)
        {
            
            try
            {
                /* when the record is wrongly entered in the table hen we can delete the whole record of the rental  movie a
                 * after double clicking   on the data grid then the whole record will be visible in the rental part then we can delete 
                 the record using the delete button */
                qry = "";
                qry = "delete from tbRental where id=" + RentalID + "";
                obj.runIDU(qry);
                MessageBox.Show("Rental Video is Deleted");
                Name_txtbox.Text = "";
                LastName_txtbox.Text = "";
                phone_txtbox.Text = "";
                address_txtbox.Text = "";
                RentalID = 0;


                /* reload the data grid after deleting the record from tabel  */
                qry = "";
                qry = "select * from tbRental";
                tbl = obj.getRecords(qry);
                if (tbl.Rows.Count > 0)
                {
                    dgvRecord.DataSource = tbl;
                }

            }
            catch (Exception ex)
            {
                //error message to display if we get an error in execution 
                MessageBox.Show(ex.Message);
            }

        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            try {
                //get the whole record from the table after clicking on the customer tab to get the record of the customer
                qry = "";
                qry = "select * from tbCustomer";
                tbl = obj.getRecords(qry);

                DataTable tblnew = new DataTable();

                if (tbl.Rows.Count > 0) {
                    tblnew.Columns.Add("Customer_id");
                    tblnew.Columns.Add("Customer_Name");
                    tblnew.Columns.Add("Customer_Address");
                    tblnew.Columns.Add("Customer_PhoneNo");
                    //using the statement to pass the record to the Table from the Data table 
                    
                    for (int y = 0; y < tbl.Rows.Count - 1; y++)
                    {
                        DataRow row = tblnew.NewRow();
                        row["Customer_id"] = Convert.ToString(tbl.Rows[y]["ID"]);
                        row["Customer_Name"] = Convert.ToString(tbl.Rows[y]["CustName"]);
                        row["Customer_Address"] = Convert.ToString(tbl.Rows[y]["CustAdr"]);
                        row["Customer_PhoneNo"] = Convert.ToString(tbl.Rows[y]["CustPhone"]);


                        tblnew.Rows.Add(row);

                    }
                    dgvRecord.DataSource = tblnew;
                }
                // give the id to Cust_ID global to verify that we clicked on the customer or not 
                Cust_ID = 1;
                Rental_ID = 0;
                
            }
            catch (Exception except) {
                MessageBox.Show(except.Message);

            }


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (CustomerID >= 1)
                {

                    /* after getting the id from the datagrid after double clicking the ont he customer datagrid
                     * then we can be able to update the record for thus after modification in the boxes we just need to click on the update button 
                     if there is no id is available to the global variable then we can't update the cusotmer record
                     */
                    qry = "";
                    string nm = Name_txtbox.Text.ToString() + " " + LastName_txtbox.Text.ToString();
                    qry = "update tbCustomer set CustName='" + nm + "',CustAdr='" + address_txtbox.Text.ToString() + "',CustPhone='" + phone_txtbox.Text.ToString() + "' where id=" + CustomerID + "";
                    obj.runIDU(qry);
                    MessageBox.Show("Record is Updated");


                    //after updating the reload the data grid to view updated record
                    qry = "";
                    qry = "select * from tbCustomer";
                    tbl = obj.getRecords(qry);
                    dgvRecord.DataSource = tbl;


                    LastName_txtbox.Text = "";
                    Name_txtbox.Text = "";
                    phone_txtbox.Text = "";
                    address_txtbox.Text = "";
                    CustomerID = 0;

                }
                else {
                    //error message if there is no id in the global varaible then it will pop up
                    MessageBox.Show("You Have to Select the Customer from the Data Grid  First then you can do anything" );
                }
            }
            catch (Exception except) {
                //error message if there is an run time error occure in the execution
                MessageBox.Show(except.Message);
            }

        }

        private void DeleteVideo_Click(object sender, EventArgs e)
        {
            try {
                if (VideoID >= 1)
                {
                    qry = "";
                    /* after getting the id from the datagrid after double clicking the on the Vidoe datagrid
                    * then we can be able to Delete the record for thus we just need to click on the delete button 
                    if there is no id is available to the global variable then we can't Delete the Video record
                    */
                    qry = "delete from tbVideos where id=" + VideoID + "";
                    obj.runIDU(qry);
                    MessageBox.Show("Record Is Deleted");
                    txtGenre.Text = "";
                    txtPlot.Text = "";
                    txtTitle.Text = "";

                    txtRating.Text = "";

                    txtCopies.Text = "";
                    txtCost.Text = "";

                    txtYear.Text = "";
                    VideoID = 0;
                    qry = "";
                    // reload the data grid after deleting form the table  
                    qry = "select * from tbVideos";
                    tbl = obj.getRecords(qry);
                    if (tbl.Rows.Count > 0)
                    {
                        dgvRecord.DataSource = tbl;
                    }
                }
                else {
                    //error message if there is no id in the global varaible then it will pop up
                    MessageBox.Show("You Have to Select the Video from Datagrid then you can delete the video ");
                }
                

            }
            catch (Exception except) {
                // if there is an run time error then it will popup the error message 
                MessageBox.Show(except.Message);                    
            }

        }

        private void UpdateMovie_Click(object sender, EventArgs e)
        {
            try {
                if (VideoID >= 1)
                {

                    /* after getting the id from the datagrid after double clicking the on the Vidoe datagrid
             * then we can be able to Update  the record for thus we just need to click on theUpdate button 
             if there is no id is available to the global variable then we can't Update the Video record
             */

                    qry = "";
                    qry = "update tbVideos set Rating=" + Convert.ToInt32(txtRating.Text.ToString()) + ",VTitle='" + txtTitle.Text.ToString() + "',VYear='" + txtYear.Text.ToString() + "',VCost=" + Convert.ToInt32(txtCost.Text.ToString()) + ",VCopy=" + Convert.ToInt32(txtCopies.Text.ToString()) + ",VPlot='" + txtPlot.Text.ToString() + "',VGenre='" + txtGenre.Text.ToString() + "' where id=" + VideoID + "";
                    obj.runIDU(qry);
                    MessageBox.Show("Videos Record is Updated");
                    txtGenre.Text = "";
                    txtPlot.Text = "";
                    txtTitle.Text = "";

                    txtRating.Text = "";

                    txtCopies.Text = "";
                    txtCost.Text = "";

                    txtYear.Text = "";
                    VideoID = 0;

                    qry = "";
                    // reload the data grid after deleting form the table  
                    qry = "select * from tbVideos";
                    tbl = obj.getRecords(qry);
                    if (tbl.Rows.Count > 0)
                    {
                        dgvRecord.DataSource = tbl;
                    }

                }
                else {
                    //error message if there is no id in the global varaible then it will pop up
                    MessageBox.Show("You Have to Select the Video from Datagrid then you can delete the video ");

                }

            }
            catch (Exception except) {
                // if there is an run time error then it will popup the error message 
                MessageBox.Show(except.Message);
            }

        }

        private void txtCopies_TextChanged(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;

            int yr = now.Year;
            int diff = yr-Convert.ToInt32(txtYear.Text.ToString());
           // MessageBox.Show(diff.ToString());
           /*  difference is the local variable that is used toget the difference between currnt 
            *  year and movie launched year if the differnec is between 0 to 5 then charges is 5 dollar other wise 2 dollar */ 
            if (diff >= 5)
            {
                txtCost.Text = "2";
            }
            if(diff>=0 && diff<5) {
                txtCost.Text = "5";
            }
        }

        private void btnRanking_Click(object sender, EventArgs e)
        {
            // this is ued to open the Customer ranking page
            new frmCustomerRanking().ShowDialog();
        }

        private void btnMovies_Click(object sender, EventArgs e)
        {
            // this is ued to open the Movie ranking page
            new frmMovies().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           // this.Close();
           //this is used to exit form the application 
            Application.Exit();
        }

        private void dgvRecord_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvRecord_DoubleClick(object sender, EventArgs e)
        {
            
            /*  these are the global variable that are used to display the when we click on the 
                customer data grid then the customer record will be display in the customer section
                if u cicked on the video section then the video record will be dispay in the video 'section

            if we clicked on the rental grid then the rental record will be display in the rental secion 
            and pass the id to the relevenat global variable 
             */
            if (Cust_ID == 1)
            {
                CustomerID = Convert.ToInt32(dgvRecord.CurrentRow.Cells[0].Value.ToString());
                String[] namedata = dgvRecord.CurrentRow.Cells[1].Value.ToString().Split(' ');
                Name_txtbox.Text = namedata[0];
                LastName_txtbox.Text = namedata[1];
                address_txtbox.Text = dgvRecord.CurrentRow.Cells[2].Value.ToString();
                phone_txtbox.Text = dgvRecord.CurrentRow.Cells[3].Value.ToString();
                // Cust_ID = 0;
            }

            if (Rental_ID == 1)
            {
                //MessageBox.Show(dgvRecord.CurrentRow.Cells[0].Value.ToString());

                RentalID = Convert.ToInt32(dgvRecord.CurrentRow.Cells[0].Value.ToString());
                txtMID.Text = dgvRecord.CurrentRow.Cells[1].Value.ToString();
                txtCID.Text = dgvRecord.CurrentRow.Cells[2].Value.ToString();
                dtpIssue.Text = dgvRecord.CurrentRow.Cells[3].Value.ToString();
                dtpReturn.Text = dgvRecord.CurrentRow.Cells[4].Value.ToString();
                //Rental_ID = 0;

            }
            if (Video_ID == 1)
            {
                //MessageBox.Show(dgvRecord.CurrentRow.Cells[0].Value.ToString());


                VideoID = Convert.ToInt32(dgvRecord.CurrentRow.Cells[0].Value.ToString());
                txtRating.Text = dgvRecord.CurrentRow.Cells[1].Value.ToString();
                txtTitle.Text = dgvRecord.CurrentRow.Cells[2].Value.ToString();
                txtYear.Text = dgvRecord.CurrentRow.Cells[3].Value.ToString();
                txtCost.Text = dgvRecord.CurrentRow.Cells[4].Value.ToString();
                txtCopies.Text = dgvRecord.CurrentRow.Cells[5].Value.ToString();
                txtPlot.Text = dgvRecord.CurrentRow.Cells[6].Value.ToString();
                txtGenre.Text = dgvRecord.CurrentRow.Cells[7].Value.ToString();
                //Video_ID = 0;
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnRental_Click(object sender, EventArgs e)
        {
            try
            {
                

                /* 
                 *  this is rental tab that is used to get the record from the rental table to display in the rental data grid
                 
                 */
                qry = "";
                qry = "select * from tbRental";
                tbl = obj.getRecords(qry);
                DataTable tblnew = new DataTable();
                if (tbl.Rows.Count > 0)
                {
                    tblnew.Columns.Add("Rental_id");
                    tblnew.Columns.Add("Movie_ID");
                    tblnew.Columns.Add("Customer_ID");
                    tblnew.Columns.Add("Issue_Date");
                    tblnew.Columns.Add("Return_Date");
                    //using the statement to pass the record to the Table from the Data table 

                    for (int y = 0; y < tbl.Rows.Count - 1; y++)
                    {
                        DataRow row = tblnew.NewRow();
                        row["Rental_id"] = Convert.ToString(tbl.Rows[y]["ID"]);
                        row["Movie_ID"] = Convert.ToString(tbl.Rows[y]["MID"]);
                        row["Customer_ID"] = Convert.ToString(tbl.Rows[y]["CID"]);
                        row["Issue_Date"] = Convert.ToString(tbl.Rows[y]["IssueDate"]);
                        row["Return_Date"] = Convert.ToString(tbl.Rows[y]["ReturnDate"]);

                      tblnew.Rows.Add(row);

                    }





                    dgvRecord.DataSource = tblnew;
                }
                Rental_ID = 1;

                Cust_ID = 0;
                Video_ID = 0;

            }
            catch (Exception except)
            {
                MessageBox.Show(except.Message);

            }

        }

        private void btnVideos_Click(object sender, EventArgs e)
        {
            try
            {
                /* 
                 *  this is video tab that is used to get the record from the videos table to display in the video data grid
                 
                 */
                qry = "";
                qry = "select * from tbVideos";
                tbl = obj.getRecords(qry);
                DataTable tblnew = new DataTable();
                if (tbl.Rows.Count > 0)
                {
                    tblnew.Columns.Add("Video_id");
                    tblnew.Columns.Add("Ratting");
                    tblnew.Columns.Add("Title");
                    tblnew.Columns.Add("Year");
                    tblnew.Columns.Add("Cost");
                    tblnew.Columns.Add("Copies");
                    tblnew.Columns.Add("Plot");
                    tblnew.Columns.Add("Genre_Info");
                   //using the statement to pass the record to the Table from the Data table 

                    for (int y = 0; y < tbl.Rows.Count - 1; y++)
                    {
                        DataRow row = tblnew.NewRow();
                        row["Video_ID"] = Convert.ToString(tbl.Rows[y]["ID"]);
                        row["Ratting"] = Convert.ToString(tbl.Rows[y]["Rating"]);
                        row["Title"] = Convert.ToString(tbl.Rows[y]["VTitle"]);
                        row["Year"] = Convert.ToString(tbl.Rows[y]["VYear"]);
                        row["Cost"] = Convert.ToString(tbl.Rows[y]["VCost"]);
                        row["Copies"] = Convert.ToString(tbl.Rows[y]["VCopy"]);
                        row["Plot"] = Convert.ToString(tbl.Rows[y]["VPlot"]);
                        row["Genre_Info"] = Convert.ToString(tbl.Rows[y]["VGenre"]);
                        tblnew.Rows.Add(row);

                    }



                    dgvRecord.DataSource = tblnew;
                }
                Video_ID = 1;
                Rental_ID = 0;
                Cust_ID = 0;

            }
            catch (Exception except)
            {
                MessageBox.Show(except.Message);

            }
        }

        private void btnVideoAdd_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                 this is ued to add the record in the video table after filling the whole record we can add the record in the video 
                 table so thus the movie is availabale on rental system .after clicking on the add button we can add the record in the table and also we
                 in the video data grid
                 
                 */
                int id = 1;
                qry = "";
                qry = "select * from tbVideos";
                tbl = obj.getRecords(qry);
                if (tbl.Rows.Count > 0)
                {
                    id = Convert.ToInt32(tbl.Rows[tbl.Rows.Count - 1]["id"]);
                    id++;
                    qry = "";
                    qry = "insert into tbVideos(id,Rating,VTitle,VYear,VCost,VCopy,VPlot,VGenre) values("+id+","+Convert.ToInt32(txtRating.Text.ToString())+",'"+txtTitle.Text.ToString()+"','"+txtYear.Text.ToString()+"',"+Convert.ToInt32(txtCost.Text.ToString())+","+Convert.ToInt32(txtCopies.Text.ToString())+",'"+txtPlot.Text.ToString()+"','"+txtGenre.Text.ToString()+"')";
                    obj.runIDU(qry);
                    MessageBox.Show("Video Record Added in the table");
                }
                else {
                    qry = "";
                    qry = "insert into tbVideos(id,Rating,VTitle,VYear,VCost,VCopy,VPlot,VGenre) values(" + id + "," + Convert.ToInt32(txtRating.Text.ToString()) + ",'" + txtTitle.Text.ToString() + "','" + txtYear.Text.ToString() + "'," + Convert.ToInt32(txtCost.Text.ToString()) + "," + Convert.ToInt32(txtCopies.Text.ToString()) + ",'" + txtPlot.Text.ToString() + "','" + txtGenre.Text.ToString() + "')";
                    obj.runIDU(qry);
                    MessageBox.Show("Video Record Added in the table");
                }
                txtGenre.Text = "";
                txtPlot.Text = "";
                txtTitle.Text = "";
                
                txtRating.Text = "";

                txtCopies.Text = "";
                txtCost.Text = "";

                txtYear.Text = "";
// reload the datagrid of the video so thus the video can be modify or delete
                qry = "";
                qry = "select * from tbVideos";
                tbl = obj.getRecords(qry);
                if (tbl.Rows.Count > 0)
                {
                    dgvRecord.DataSource = tbl;
                }
            }
            catch (Exception except) {
                MessageBox.Show(except.Message);
            }


        }

        private void dgvRecord_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(Cust_ID+"---"+Rental_ID+"---"+Video_ID);

          /*  these are the global variable that are used to display the when we click on the
                customer data grid then the customer record will be display in the customer section
                if u cicked on the video section then the video record will be dispay in the video 'section

            if we clicked on the rental grid then the rental record will be display in the rental secion
            and pass the id to the relevenat global variable
             */
            if (Cust_ID == 1)
            {
                CustomerID = Convert.ToInt32(dgvRecord.CurrentRow.Cells[0].Value.ToString());
                String[] namedata = dgvRecord.CurrentRow.Cells[1].Value.ToString().Split(' ');
                Name_txtbox.Text = namedata[0];
                LastName_txtbox.Text = namedata[1];
                address_txtbox.Text = dgvRecord.CurrentRow.Cells[2].Value.ToString();
                phone_txtbox.Text = dgvRecord.CurrentRow.Cells[3].Value.ToString();
               // Cust_ID = 0;
            }

             if (Rental_ID == 1)
            {
                //MessageBox.Show(dgvRecord.CurrentRow.Cells[0].Value.ToString());

                RentalID = Convert.ToInt32(dgvRecord.CurrentRow.Cells[0].Value.ToString());
                txtMID.Text = dgvRecord.CurrentRow.Cells[1].Value.ToString();
                txtCID.Text = dgvRecord.CurrentRow.Cells[2].Value.ToString();
                dtpIssue.Text = dgvRecord.CurrentRow.Cells[3].Value.ToString();
                dtpReturn.Text = dgvRecord.CurrentRow.Cells[4].Value.ToString();
                //Rental_ID = 0;

            }
            if (Video_ID == 1)
            {
                //MessageBox.Show(dgvRecord.CurrentRow.Cells[0].Value.ToString());

                VideoID = Convert.ToInt32(dgvRecord.CurrentRow.Cells[0].Value.ToString());
                txtRating.Text = dgvRecord.CurrentRow.Cells[1].Value.ToString();
                txtTitle.Text = dgvRecord.CurrentRow.Cells[2].Value.ToString();
                txtYear.Text = dgvRecord.CurrentRow.Cells[3].Value.ToString();
                txtCost.Text = dgvRecord.CurrentRow.Cells[4].Value.ToString();
                txtCopies.Text = dgvRecord.CurrentRow.Cells[5].Value.ToString();
                txtPlot.Text = dgvRecord.CurrentRow.Cells[6].Value.ToString();
                txtGenre.Text = dgvRecord.CurrentRow.Cells[7].Value.ToString();
                //Video_ID = 0;
            }
            
        }
    }
}
