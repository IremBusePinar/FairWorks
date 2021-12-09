using Model.FW.Entity;
using Model.FW.Map;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.FW.Context
{
   public class AppDbContext:DbContext
    {
        public AppDbContext()
        {
            Database.Connection.ConnectionString = @"server=ATPPC064\SQLEXPRESS;database=FairWorksDB;trusted_connection=true;";
        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<CompanyUser> CompanyUsers { get; set; }
        public DbSet<CompanyUserRole> CompanyUserRoles { get; set; }
        public DbSet<CompanyUserAndRole> CompanyUserAndRoles { get; set; }

        public DbSet<Fair> Fairs { get; set; }
        public DbSet<Salloon> Salloons { get; set; }
        public DbSet<Sector> Sectors { get; set; }
        public DbSet<Stand> Stands { get; set; }
        public DbSet<FairParticipant> FairParticipants { get; set; }
        public DbSet<Visitor> Visitors { get; set; }
        public DbSet<Log> Logs { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CompanyMap());
            modelBuilder.Configurations.Add(new CompanyUserMap());
            modelBuilder.Configurations.Add(new CompanyUserAndRoleMap());
            modelBuilder.Configurations.Add(new CompanyUserRoleMap());
            modelBuilder.Configurations.Add(new FairMap());
            modelBuilder.Configurations.Add(new SalloonMap());
            modelBuilder.Configurations.Add(new SectorMap());
            modelBuilder.Configurations.Add(new StandMap());
            modelBuilder.Configurations.Add(new FairParticipantMap());
            modelBuilder.Configurations.Add(new VisitorMap());
           

            base.OnModelCreating(modelBuilder);
        }

    }
}
