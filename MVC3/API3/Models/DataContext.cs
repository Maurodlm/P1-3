using System.Data.Entity;

namespace API3.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<API3.Models.Product> Products { get; set; }
    }
}