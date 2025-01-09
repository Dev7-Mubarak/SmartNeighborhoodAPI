

using OurProjectSmartNeiborhood.Entites;

namespace OurProjectSmartNeiborhood.Configuration
{
    public class UserEntityTypeConfiguration:IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder
                .HasMany(PC => PC.PersonComplains)
                .WithOne();

            builder
                .HasMany(C => C.Complains)
                .WithOne()
                .HasForeignKey(a => a.UserId);

            builder
                .HasOne(R => R.Role)
                .WithMany(U => U.Users);

            builder
                .HasMany(AD => AD.Ads)
                .WithOne()
                .HasForeignKey(a => a.UserId);
                
            builder
               .Property(P => P.Password)
               .HasMaxLength(50);
               
        }
    }
}
