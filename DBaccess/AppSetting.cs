using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Entity.Core.EntityClient;

namespace QuanLyCafe.DBaccess
{
    public class AppSetting
    {
        Configuration config;
        public AppSetting()
        {
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        }
        public string getConnectionString(string key)
        {
            return config.ConnectionStrings.ConnectionStrings[key].ConnectionString;
        }
        public void setConnectionString(string key, string value)
        {
            config.ConnectionStrings.ConnectionStrings[key].ConnectionString = value;
            config.ConnectionStrings.ConnectionStrings[key].ProviderName = "System.Data.SqlClient";
            config.Save(ConfigurationSaveMode.Modified);
        }
        public string getConnectionString(string dataSource, string initialCatalog, string username, string password)
        {
            // Specify the provider name, server and database.
            string providerName = "System.Data.SqlClient";
            //providerName = "System.Data.EntityClient";

            // Initialize the connection string builder for the
            // underlying provider.
            SqlConnectionStringBuilder sqlBuilder =
                new SqlConnectionStringBuilder();

            // Set the properties for the data source.
            sqlBuilder.DataSource = dataSource;
            sqlBuilder.InitialCatalog = initialCatalog;
            sqlBuilder.PersistSecurityInfo = true;
            sqlBuilder.MultipleActiveResultSets = true;
            sqlBuilder.UserID = username;
            sqlBuilder.Password = password;

            // Build the SqlConnection connection string.
            string providerString = sqlBuilder.ToString();

            // Initialize the EntityConnectionStringBuilder.
            EntityConnectionStringBuilder entityBuilder =
                new EntityConnectionStringBuilder();

            //Set the provider name.
            entityBuilder.Provider = providerName;

            // Set the provider-specific connection string.
            entityBuilder.ProviderConnectionString = providerString;

            // Set the Metadata location.
            entityBuilder.Metadata =  @"res://*/MyDatabase.QuanLyCafeDBContext.csdl|
                                        res://*/MyDatabase.QuanLyCafeDBContext.ssdl|
                                        res://*/MyDatabase.QuanLyCafeDBContext.msl";
            return entityBuilder.ToString();
        }
    }
}
