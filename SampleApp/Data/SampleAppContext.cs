﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SampleApp.Models;

namespace SampleApp.Data
{
    public class SampleAppContext : DbContext
    {
        public SampleAppContext (DbContextOptions<SampleAppContext> options)
            : base(options)
        {
        }

        public DbSet<SampleApp.Models.Movie> Movie { get; set; } = default!;
    }
}
