using BulkyBook.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BulkyBook.DataAccess;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    public DbSet<Category> Categories { get; set; }

}

