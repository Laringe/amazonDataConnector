using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace amazonDataConnector.Data {
    public class ApplicationDbContext :IdentityDbContext {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) {
        }
        public DbSet<AmazonDataConnector.Models.AcuOrder> AcuOrder {
            get; set;
        }
    }
}