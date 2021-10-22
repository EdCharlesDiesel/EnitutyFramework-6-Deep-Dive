using System.Data.Entity;

namespace CodeFirst
{
    public class PlutoContext : DbContext
    {
        public PlutoContext(): base("name=CodeFirstConnectioString")
        {

        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}
