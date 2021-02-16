using System;
using System.Data.Entity;

namespace Todo_List.Model
{
    class TDListDBContext : DbContext
    {
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Task> Tasks { get; set; }
    }
}
