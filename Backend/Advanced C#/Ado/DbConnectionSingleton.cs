using System.Data;
using Microsoft.Data.SqlClient;

namespace Ado
{
    public sealed class DbConnectionSingleton
    {
        private static readonly Lazy<DbConnectionSingleton> instance =
            new Lazy<DbConnectionSingleton>(() => new DbConnectionSingleton());

        private SqlConnection connection;

        private string connectionString =
            "Server=HOSSAM;Database=Hossam;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";
        // private constructor
        private DbConnectionSingleton()
        {
            connection = new SqlConnection(connectionString);
        }

        // public instance
        public static DbConnectionSingleton Instance
        {
            get { return instance.Value; }
        }

        public SqlConnection GetConnection()
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();

            return connection;
        }
    }
}