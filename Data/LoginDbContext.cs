namespace Loginpagegit.Data;

using Microsoft.EntityFrameworkCore;
using Loginpagegit.Models;

public class LoginDbContext : DbContext
{
    public LoginDbContext(DbContextOptions options) : base(options)
    { }

    public DbSet<LoginAPIDb> LoginAPIDb { get; set; }


}
