﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventManagementApplication.Models;

namespace EventManagementApplication.Infrastructure
{
    public class EventDbContext:DbContext
    {
        public EventDbContext(DbContextOptions<EventDbContext> options) : base(options)
        {

        }

        public DbSet<EventInfo> Events { get; set; }
    }
}
