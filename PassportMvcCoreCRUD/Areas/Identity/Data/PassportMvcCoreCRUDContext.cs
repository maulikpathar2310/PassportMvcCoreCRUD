using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PassportMvcCoreCRUD.Areas.Identity.Data;
using PassportMvcCoreCRUD.Models;

namespace PassportMvcCoreCRUD.Areas.Identity.Data;

public class PassportMvcCoreCRUDContext : IdentityDbContext<PassportMvcCoreCRUDUser>
{
    public PassportMvcCoreCRUDContext(DbContextOptions<PassportMvcCoreCRUDContext> options)
        : base(options)
    {
    }
    public virtual DbSet<Pass1> s1 { get; set; }
    public virtual DbSet<Pass2> s2 { get; set; }
    public virtual DbSet<Pass3> s3 { get; set; }
    public virtual DbSet<Pass4> s4 { get; set; }
    public virtual DbSet<Pass5> s5 { get; set; }
    public virtual DbSet<Pass6> s6 { get; set; }
    public virtual DbSet<Pass7> s7 { get; set; }
    public virtual DbSet<Pass8> s8 { get; set; }
    public virtual DbSet<Pass9> s9 { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
