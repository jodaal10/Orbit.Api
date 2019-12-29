using Microsoft.EntityFrameworkCore;
using Orbit.DM.Database;
using Orbit.DM.Database.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Orbit.DM.Database.Context
{
    public class OrbitDbContext: DbContext
    {
        public OrbitDbContext()
        {
        }

        public OrbitDbContext(DbContextOptions<OrbitDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Student> Student { get; set; }
    }
}
