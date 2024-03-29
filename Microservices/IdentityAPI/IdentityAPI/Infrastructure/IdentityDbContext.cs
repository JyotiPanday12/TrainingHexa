﻿using IdentityAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace IdentityAPI.Infrastructure
{
    public class IdentityDbContext:DbContext
    {
        public IdentityDbContext(DbContextOptions<IdentityDbContext> options) : base(options)
        {}

        public DbSet<UserInfo> Users { get; set; }
    }
}
