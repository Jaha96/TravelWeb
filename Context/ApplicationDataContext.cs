using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TravelWeb.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace TravelWeb.Context
{
    public class ApplicationDataContext : IdentityDbContext<AppUser>
    {
        public ApplicationDataContext()
            : base("DefaultConnection")
        { }

        public System.Data.Entity.DbSet<AppUser> AppUsers { get; set; }
    }
}