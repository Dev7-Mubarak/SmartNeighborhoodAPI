using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using SmartNeighborhoodAPI.Entites;


namespace SmartNeighborhoodAPI
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);


            //var adminRoleId = Guid.NewGuid().ToString();

            //builder.Entity<IdentityRole>().HasData(
            //    new IdentityRole { Id = adminRoleId, Name = "Admin", NormalizedName = "ADMIN" },
            //    new IdentityRole { Id = Guid.NewGuid().ToString(), Name = "BlockManager", NormalizedName = "BLOCKMANAGER" },
            //    new IdentityRole { Id = Guid.NewGuid().ToString(), Name = "User", NormalizedName = "USER" }
            //);

            //var adminUserId = Guid.NewGuid().ToString();

            //var adminUser = new IdentityUser
            //{
            //    Id = adminUserId,
            //    UserName = "Admin",
            //    NormalizedUserName = "ADMIN",
            //    Email = "admin@example.com",
            //    NormalizedEmail = "ADMIN@EXAMPLE.COM",
            //    EmailConfirmed = true,
            //    PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "Admin@123")
            //};

            //builder.Entity<IdentityUser>().HasData(adminUser);

            //builder.Entity<IdentityUserRole<string>>().HasData(
            //    new IdentityUserRole<string>
            //    {
            //        UserId = adminUserId,
            //        RoleId = adminRoleId
            //    }
            //);
        }
        public DbSet<Block> Blocks { get; set; }
        public DbSet<ContactInfo> ContactInfos { get; set; }
        public DbSet<Family> Families { get; set; }
        public DbSet<FamilyCatgory> FamilyCatgories { get; set; }
        public DbSet<FamilyMember> FamilyMembers { get; set; }
        public DbSet<MemberType> MemberTypes { get; set; }
        public DbSet<Person> People { get; set; }
    }
}
