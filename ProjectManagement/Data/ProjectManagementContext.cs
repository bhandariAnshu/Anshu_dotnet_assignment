using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectManagement.Models;

namespace ProjectManagement.Data
{
    public class ProjectManagementContext : DbContext
    {
        public ProjectManagementContext (DbContextOptions<ProjectManagementContext> options)
            : base(options)
        {
        }

        public DbSet<ProjectManagement.Models.Projects> Projects { get; set; } = default!;
    }
}
