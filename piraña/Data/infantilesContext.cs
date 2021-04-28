using Microsoft.EntityFrameworkCore;
using piraña.Models;

namespace piraña.Data
{
    public class infantilesContext : DbContext
    {
        public DbSet<Usuario> infantiles { get; set; }
        public  infantilesContext(DbContextOptions dco) : base(dco){
            
        }
    }
}