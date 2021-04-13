using Furion.DatabaseAccessor;
using Microsoft.EntityFrameworkCore;


namespace detectingsystem.EntityFramework.Core
{
    [AppDbContext("detectingsystem", DbProvider.Sqlite)]
    public class DefaultDbContext : AppDbContext<DefaultDbContext>
    {
        
        public DefaultDbContext(DbContextOptions<DefaultDbContext> options) : base(options)
        {


        }
    }
}