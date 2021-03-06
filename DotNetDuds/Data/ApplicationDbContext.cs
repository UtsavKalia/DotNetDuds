﻿using System;
using System.Collections.Generic;
using System.Text;
using DotNetDuds.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DotNetDuds.Data
{
    // this is our autogenerated databse connection class
    public class ApplicationDbContext : IdentityDbContext
    {
        // refrence the data modl classes
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        // override the onmodel method - fix bug in the identity framework
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
