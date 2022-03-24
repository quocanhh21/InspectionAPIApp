namespace InspectionAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Inspection> Inspection { get; set; }
        public DbSet<InspectionType> InspectionType { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<User> Users { get; set; }


    }
}
