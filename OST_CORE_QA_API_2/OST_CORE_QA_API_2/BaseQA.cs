using System.Data;
using System.Data.SqlClient;

namespace OST_CORE_QA_API_2
{
    public class BaseQA
    {
        public static DataTable ListQuestions()
        { 
            DataTable dt = new DataTable();

            string ConnectionString = DBConnection.ConnString();
            SqlConnection mcn = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand();  

            cmd.Connection = mcn;
            cmd.CommandText = "dbo.udspQA_LstQuestions";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.Add(new SqlParameter("@MakeBy", "Protik"));
            cmd.CommandTimeout = 0;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
    }
}
