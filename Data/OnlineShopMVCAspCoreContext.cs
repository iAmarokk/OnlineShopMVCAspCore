﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnlineShopMVCAspCore.Models;

namespace OnlineShopMVCAspCore.Data
{
    public class OnlineShopMVCAspCoreContext : DbContext
    {
        public OnlineShopMVCAspCoreContext (DbContextOptions<OnlineShopMVCAspCoreContext> options)
            : base(options)
        {
        }

        public DbSet<OnlineShopMVCAspCore.Models.Product> Product { get; set; }
    }
}