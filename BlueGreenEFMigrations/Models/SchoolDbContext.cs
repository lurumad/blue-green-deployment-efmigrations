using System.Data.Entity;

namespace BlueGreenEFMigrations.Models
{
    public class SchoolDbContext : DbContext
    {
        public IDbSet<Subject> Subjects { get; set; }
    }
}