using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CrudDemo
{
    internal class clsDataAccess
    {
        //Connecting to local sql
        private SqlConnection Cn = new SqlConnection("server=.;Integrated security=true; Connection timeout=5; database=TSQL; Application Name=CrudDemo");

        public int ProductInsert(string productname, int supplierid, int categoryid, decimal unitprice, bool discontinued)
        {
            //Define connection types
            SqlCommand Cm = new SqlCommand();
            Cm.Connection = Cn;
            Cm.CommandType = CommandType.StoredProcedure;
            Cm.CommandText = "Production.ProductsInsert";

            //Parameters

            //Faster
            Cm.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, true, 0,0, "", DataRowVersion.Current, null));

            Cm.Parameters.Add(new SqlParameter("@ProductName", SqlDbType.NVarChar, 40, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Current, productname));

            //Shortcut
            Cm.Parameters.AddWithValue("@supplierid", supplierid);
            Cm.Parameters.AddWithValue("@categoryid", categoryid);
            Cm.Parameters.AddWithValue("@unitprice", unitprice);
            Cm.Parameters.AddWithValue("@discontinued", discontinued);

            try
            {
                //Checking if connection is already opened
                if(Cn.State == ConnectionState.Closed) { Cn.Open(); }
            
                Cm.ExecuteNonQuery();

                Cn.Close();

                return Convert.ToInt32(Cm.Parameters["@RETURN_VALUE"].Value);
            }
            catch(Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }

        }
    }
}
