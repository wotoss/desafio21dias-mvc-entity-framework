using Microsoft.EntityFrameworkCore;
using mvc_entity.Models;

namespace mvc_entity.Servico
{
    public class DbContexto : DbContext
    {
        public DbContexto(DbContextOptions<DbContexto> options) : base(options){}

        public DbSet<Aluno> Alunos {get; set;}
    }

}