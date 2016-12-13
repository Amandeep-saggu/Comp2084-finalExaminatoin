using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FinalExam
{
    public class DatabaseContext:DbContext
    {
        public DbSet<Division> Divisions { get; set; }
        public DbSet<Team> Teams { get; set; }
    }
}