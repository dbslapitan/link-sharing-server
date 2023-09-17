using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LinkSharing.API.Database
{
    public class LinkSharingAuthDbContext : IdentityDbContext
    {
        public LinkSharingAuthDbContext(DbContextOptions<LinkSharingAuthDbContext> options) : base(options)
        {
        }
    }
}
