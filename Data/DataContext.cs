
using cadastrocertoturma.Models;
using Microsoft.EntityFrameworkCore;
//using cadastrocertoturma.Models;

namespace cadastrocertoturma.Data
{
    public class DataContext : DbContext
    {
        //colocar sql server aqui 5:47 minutos
        public DataContext(DbContextOptions<DataContext> options)
        : base(options)
        {

        }
        public DbSet<Turma> Turma{ get; set; }

        public DbSet<Aluno> Aluno{ get; set; }
        public object Alunos { get; internal set; }
    }
}