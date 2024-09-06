using Microsoft.EntityFrameworkCore;
using WebApplication.Models;

namespace WebApplication.Data
{
    public class WebApplicationContext : DbContext
    {
        public WebApplicationContext(DbContextOptions<WebApplicationContext> options)
            : base(options)
        {
        }
        public DbSet<UsuarioModel> Usuario { get; set; }
    }
}
