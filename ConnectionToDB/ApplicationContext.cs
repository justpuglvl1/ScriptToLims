using ConnectionToDB.Models.Dto_models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionToDB
{
    public class ApplicationContext : DbContext
    {
        public DbSet<DescDto> desc { get; set; }
        public DbSet<DocumentRouteStepTDto> doc_route_step_t { get; set; }
        public DbSet<TestOrderLinesDto> test_order_lines { get; set; }
        public DbSet<TestOrderLineTDto> test_order_line_t { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }
        public ApplicationContext() { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=10.241.0.164;Port=5432;Database=limsDB;Username=postgres;Password=KbvcRb,thcnfkm");
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DescDto>().ToTable("desc");
            modelBuilder.Entity<DocumentRouteStepTDto>().ToTable("doc_route_step_t");
            modelBuilder.Entity<TestOrderLinesDto>().ToTable("test_order_lines");
            modelBuilder.Entity<TestOrderLineTDto>().ToTable("test_order_line_t");
        }
    }
}
