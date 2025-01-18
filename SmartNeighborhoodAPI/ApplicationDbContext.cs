using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace SmartNeighborhoodAPI
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
           

            var adminRoleId = Guid.NewGuid().ToString();

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = adminRoleId, Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Id = Guid.NewGuid().ToString(), Name = "BlockManager", NormalizedName = "BLOCKMANAGER" },
                new IdentityRole { Id = Guid.NewGuid().ToString(), Name = "User", NormalizedName = "USER" }
            );

            var adminUserId = Guid.NewGuid().ToString();

            var adminUser = new IdentityUser
            {
                Id = adminUserId,
                UserName = "Admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@example.com",
                NormalizedEmail = "ADMIN@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "Admin@123")
            };

            builder.Entity<IdentityUser>().HasData(adminUser);

            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    UserId = adminUserId,
                    RoleId = adminRoleId
                }
            );
        }
        DbSet<Ad> Ads { get; set; }

        DbSet<Block> Blocks { get; set; }
        DbSet<Complain> Complains { get; set; }
        DbSet<ComplainType> ComplainTypes { get; set; }
        DbSet<ConfilctParty> ConfilctParties { get; set; }
        DbSet<ContactInfo> ContactInfos { get; set; }
        DbSet<Family> Families { get; set; }
        DbSet<FamilyCatgory> FamilyCatgories { get; set; }
        DbSet<FamilyMember> FamilyMembers { get; set; }
        DbSet<Group> Groups { get; set; }
        DbSet<MemberType> MemberTypes { get; set; }
        DbSet<Person> People { get; set; }
        DbSet<PersonComplain> PersonComplains { get; set; }
        DbSet<Project> Projects { get; set; }
        DbSet<ProjectCatogory> ProjectCatogories { get; set; }
        DbSet<ProjectFamily> ProjectFamilies { get; set; }
        DbSet<Role> Roles { get; set; }
        DbSet<Team> Teams { get; set; }
        DbSet<TeamMember> TeamMembers { get; set; }
    }
}
