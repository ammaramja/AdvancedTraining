using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ValidationsNauthenNauthoNdatabase.Models
{
    public class LoginContext:DbContext
    {
        public DbSet<LoginSubmit> ListOfUsers { get; set;}
    }
}