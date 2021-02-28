using financeiro_service.Core.Geral;
using Microsoft.EntityFrameworkCore;

namespace entities.repository
{
    public class EFAppContext : DbContext
    {
        public EFAppContext(DbContextOptions<EFAppContext> options)
          : base(options)
        { }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }

}
