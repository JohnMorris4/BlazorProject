using BlazorProject.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorProject.Data;

public class ApplicationDbContext : Microsoft.EntityFrameworkCore.DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }

    public DbSet<Person> Persons { get; set; }
    public DbSet<Employee> Employees { get; set; }
}