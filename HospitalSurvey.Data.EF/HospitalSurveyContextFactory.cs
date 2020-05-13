using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace HospitalSurvey.Data.EF
{


    public class HospitalSurveyContextFactory : IDesignTimeDbContextFactory<HospitalSurveyDbContext>
    {
        public HospitalSurveyDbContext CreateDbContext(string[] args)
        {
            /* Read current folder and get connection string in appsettings.json file */

            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsetting.json")
                .Build();


            var connectionString = configuration.GetConnectionString("mamEduDb");

            var optionsBuilder = new DbContextOptionsBuilder<HospitalSurveyDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new HospitalSurveyDbContext(optionsBuilder.Options);
        }
    }
}
