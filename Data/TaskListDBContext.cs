using System;
using System.Collections.Generic;
using System.Linq;
using firstApi.models;
using Microsoft.EntityFrameworkCore;

namespace firstApi.Data
{
  public class TaskListDBContext : DbContext
  {
    public TaskListDBContext(DbContextOptions<TaskListDBContext> options)
    {
    }

    public DbSet<UsersModel> Users { get; set; }
    public DbSet<TasksModel> Tasks { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);
    }
  }

}