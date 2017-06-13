using ServiceLayer.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceLayer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class SportService : ISportService
    {
        public DataTable GetSportsList()
        {
            throw new NotImplementedException();
        }

        public DataTable GetSportsList(string continent)
        {
            DataSet ds = new DataSet();
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Connection.ConnectionString();
                SqlCommand cmd = new SqlCommand(String.Format("Select * from Sport where ContinentName = '{0}'", continent), con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds, "Sport");
            }
            return ds.Tables["Sport"];
        }
    }
}
