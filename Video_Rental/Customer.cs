using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Video_Rental
{
    class Customer
    {

        /* 
      object of all classes with data base connectivity with connection string COn is object for SQLConnection Class 
      Constr is string variable who provide the connection string that is used to connectivity and Command is also object
      of sqlcommand class that is used for database query with regarding function

         */


        SqlConnection con;
        String Constr = "Data Source=LAPTOP-NI9FNBTG\\SQLEXPRESS02;Initial Catalog=dbVideo;Integrated Security=True";
        SqlCommand command;
        SqlDataReader reader;

        //  void method that is used to add the data in the video table using the global object and global vaiables
        public void addVideo(String qry)
        {
            con = new SqlConnection(Constr);
            con.Open();


            command = new SqlCommand(qry, con);
            int y = command.ExecuteNonQuery();

            con.Close();
        }
        // another method that is used to getthe record from the database  with DAtatable object and return the whole data from the table 
        public DataTable loadData()
        {
            DataTable tbl = new DataTable();

            con = new SqlConnection(Constr);

            con.Open();
            command = new SqlCommand("select * from tbCustomer", con);

            reader = command.ExecuteReader();



            tbl.Load(reader);

            con.Close();

            return tbl;
        }
        // this is another method with argument that is used to delete the record from the table using ID  of the Customer from the table .
        public void delVideo(int CustID)
        {
            con = new SqlConnection(Constr);
            con.Open();
            command = new SqlCommand("select * from tbCustomer where CID="+ CustID + "", con);
            int y = command.ExecuteNonQuery();

            con.Close();

        }


    }
}
