using System.Data.Entity;

namespace AHSAApp
{
    public class AzureConnectDb : DbContext
    {
        public AzureConnectDb() : base("AzureDatabaseConnect")
        {

        }

    }
}