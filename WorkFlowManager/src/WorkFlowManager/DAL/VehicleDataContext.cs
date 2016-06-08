﻿using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkFlowManager.Models;

namespace WorkFlowManager.DAL
{
    public class VehicleDataContext : DbContext
    {
        // Controller will use
        public DbSet<Vehicle> Vehicles { get; set; }

        public VehicleDataContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            var connectionString = @"Server=tcp:bitrivet.database.windows.net,1433;Data Source=bitrivet.database.windows.net;Initial Catalog=WWLPC;Persist Security Info=False;User ID=BRSADMIN;Password=UPJcpa409$;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ForSqlServerUseIdentityColumns();
        }
    }
}
