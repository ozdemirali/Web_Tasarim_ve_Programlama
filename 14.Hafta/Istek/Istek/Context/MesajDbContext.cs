using Istek.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Istek.Context
{
    public class MesajDbContext:DbContext
    {
        public MesajDbContext():base("MesajDBConnectionString")
        {

        }

        public DbSet<Mesaj> Mesajs { get; set; }
    }
}