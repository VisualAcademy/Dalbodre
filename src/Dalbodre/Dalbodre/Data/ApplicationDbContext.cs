using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Dalbodre.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
    }
}
