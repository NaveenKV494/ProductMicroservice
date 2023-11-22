using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;

namespace ProductMicroservice.DBContexts
{
    public class ProductContextFactory : IDesignTimeDbContextFactory<ProductContext>
    {
        public ProductContext CreateDbContext(string[] args)
        {
            // Build configuration
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();

            // Get the connection string
            string connectionString = configuration.GetConnectionString("ProductDB");

            // Create options
            var optionsBuilder = new DbContextOptionsBuilder<ProductContext>();
            optionsBuilder.UseSqlServer(connectionString);

            // Return the DbContext
            return new ProductContext(optionsBuilder.Options);
        }
    }
}
