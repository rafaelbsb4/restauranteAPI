using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjetoNovo.Repository
{
    public class DataContext : DbContext
    {
        public DataContext() : base("name = DataContext") { }
        protected override void OnModelCreating(DbModelBuilder modelBuilder) { }
        public DbSet<Restaurante> Restaurante { get; set; }
        public DbSet<Pratos> Pratos { get; set; }

    }
}