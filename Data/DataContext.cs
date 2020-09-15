
using Microsoft.EntityFrameworkCore;
//using cadastrocertoturma.Models;

namespace cadastrocertoturma.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
        : base(options)
        {

        }
        //public DbSet<Turma> Turma{ get; set; }

        //public DbSet<Aluno> Aluno{ get; set; }
    }
}