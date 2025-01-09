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
            
            new AdEntityTypeConfiguration().Configure(builder.Entity<Ad>());
            new BlockEntityTypeConfiguration().Configure(builder.Entity<Block>());
            new ComplainEntityTypeConfiguration().Configure(builder.Entity<Complain>());
            new ComplainTypeEntityTypeConfiguration().Configure(builder.Entity<ComplainType>());
            new ConfilctPartyEntityTypeConfiguration().Configure(builder.Entity<ConfilctParty>());
            new ContactInfoEntityTypeConfiguration().Configure(builder.Entity<ContactInfo>());
            new FamilyCatgoryEntityTypeConfiguration().Configure(builder.Entity<FamilyCatgory>());
            new FamilyEntityTypeConfiguration().Configure(builder.Entity<Family>());
            new FamilyTypeEntityTypeConfiguration().Configure(builder.Entity<FamilyType>());
            new GroupEntityTypeConfiguration().Configure(builder.Entity<Group>());
            new MemberTypeEntityTypeConfiguration().Configure(builder.Entity<MemberType>());
            new PersonComplainEntityTypeConfiguration().Configure(builder.Entity<PersonComplain>());
            new PersonEntityTypeConfiguration().Configure(builder.Entity<Person>());
            new ProjectCatgoryEntityTypeConfiguration().Configure(builder.Entity<ProjectCatogory>());
            new ProjectEntityTypeConfiguration().Configure(builder.Entity<Project>());
            new ProjectFamilyEntityTypeConfiguration().Configure(builder.Entity<ProjectFamily>());
            new RoleEntityTypeConfiguration().Configure(builder.Entity<Role>());
            new TeamEntityTypeConfiguration().Configure(builder.Entity<Team>());
            new TeamMemberEntityTypeConfiguration().Configure(builder.Entity<TeamMember>());
            new UserEntityTypeConfiguration().Configure(builder.Entity<User>());

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
        DbSet<User> Users { get; set; }
    }
}
