using ExAngularJs.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ExAngularJs.Context
{
    public class TesteContext: DbContext 
    {
        public TesteContext()
            : base("DefaultConnection")
        {
        }


        public DbSet<Usuario> Usuario { get; set; }


    }
}