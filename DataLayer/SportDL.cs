using System.Data;
using System.Data.SqlClient;
using DataLayer.Utility;
using DataLayer.ServiceReference1;

namespace SportsClub.DataLayer
{
    public class SportDL
    {
        public DataTable GetSportsList()
        {
            DataSet ds = new DataSet();
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Connection.ConnectionString();
                SqlCommand cmd = new SqlCommand("Select * from Sports",con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds, "Sport");
            }
            return ds.Tables["Sport"];

        }

        public DataTable GetSportsList(string continent)
        {
            SportServiceClient client = new SportServiceClient("BasicHttpBindingDemo");
            DataTable dt = client.GetSportsList(continent);
            return dt;
        }
    }
}
