﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sale_Web_Mvc.Models;

namespace Sale_Web_Mvc.Data
{
    public class Sale_Web_MvcContext : DbContext
    {
        public Sale_Web_MvcContext (DbContextOptions<Sale_Web_MvcContext> options)
            : base(options)
        {
        }

        public DbSet<Sale_Web_Mvc.Models.Department> Department { get; set; }
    }
}
