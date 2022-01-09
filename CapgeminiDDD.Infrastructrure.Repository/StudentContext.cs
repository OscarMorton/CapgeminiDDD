using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapgeminiDDD.Common.Model;
using CapgeminiDDD.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CapgeminiDDD.Infrastructrure.Repository
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> Student { get; set; }
        public IConfiguration configuration;

        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        {
            configuration = ConfigurationHelper.InitConfiguration();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(configuration.GetConnectionString("DbConnection"));
                //  optionsBuilder.UseSqlServer("Server=localhost\\SQLDEVELOPER;Database=Bag;Trusted_Connection=True;");
            }
        }
    }
}