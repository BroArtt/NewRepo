using BrovkoChatApi.Entities;
using System;
using System.Data.Entity;

namespace BrovkoChatApi.Contexts
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base() { }

        public DbSet<Group> Groups { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Message> Messages { get; set; }
    }
}
