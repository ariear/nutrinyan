using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace NutriNyan.Models
{
    /// <summary>
    /// Store the connection string, ensure that it is a stand alone class
    /// in the namespace
    /// </summary>
    public static class ConnectionString
        {
            public static readonly string connectionString = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build().GetConnectionString("DefaultConnection") // Get deafultconnection from appsettings.json
                ?? "Host=localhost;Port=5432;User Id=postgres;Password=password;Database=nutrinyan"; // Default connection string
        }
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {

        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();

            optionsBuilder.UseNpgsql(ConnectionString.connectionString);

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}
