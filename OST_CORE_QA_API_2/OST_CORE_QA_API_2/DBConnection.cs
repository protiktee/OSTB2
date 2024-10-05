namespace OST_CORE_QA_API_2
{
    public class DBConnection
    {
        public static IConfiguration Configuration { get; set; } 
        public static string ConnString()
        {
            string strConnection = ""; 
            var builder = new ConfigurationBuilder() 
            .SetBasePath(Directory.GetCurrentDirectory()) 
            .AddJsonFile("appsettings.json"); 

            Configuration = builder.Build(); 
            strConnection = Configuration["ConnectionString"];
            return strConnection;

        }
    }
}
