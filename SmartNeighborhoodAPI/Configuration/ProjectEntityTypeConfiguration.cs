namespace OurProjectSmartNeiborhood.Configuration
{
    public class ProjectEntityTypeConfiguration:IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder
                .HasMany(PF => PF.ProjectFamilies)
                .WithOne();

            builder
                .HasOne(PC => PC.ProjectCatogory)
                .WithMany();

            builder
                .HasMany(T => T.Teams)
                .WithOne()
                .HasForeignKey(a => a.ProjectId);
       
            builder
               .Property(P => P.Proiorty)
               .HasMaxLength(10);
           
        }
    }
}
