using AxosCarAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AxosCarAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options)
        {

        }

        //
        public DbSet<Car> Cars { get; set; }
    }
}
