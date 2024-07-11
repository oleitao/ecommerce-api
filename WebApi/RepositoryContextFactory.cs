using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;
using WebApi.Repository;

namespace WebApi
{
    public class RepositoryContextFactory : IDesignTimeDbContextFactory<RepositoryContext>
    {
        public RepositoryContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            string mySqlConnectionStr = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("ConnectionStrings")["ApiDatabase"];
            var builder = new DbContextOptionsBuilder<RepositoryContext>()
                .UseMySql(mySqlConnectionStr, ServerVersion.AutoDetect(mySqlConnectionStr),
                b => b.MigrationsAssembly("WebApi"));

            return new RepositoryContext(builder.Options);
        }
    }
}
