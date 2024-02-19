using Microsoft.EntityFrameworkCore;

namespace PetshopAPI.Context
{
    public class PetDBContext:DbContext
    {
        public PetDBContext(DbContextOptions<PetDBContext> options) : base(options)
        {
            
        }
        public DbSet<Models.Pet> Pets { get; set; }

        
    }
}
