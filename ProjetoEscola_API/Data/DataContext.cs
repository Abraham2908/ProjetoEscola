
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ProjetoEscola_API.Models;

namespace ProjetoEscola_API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options)
        {
        }
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Professor> Professores { get; set; }

        //MÉTODO PARA DAR CARGA INICIAL NO BANCO:
        protected override void OnModelCreating(ModelBuilder builder) 
        {
            builder.Entity<Professor>()
                .HasData(
                    new List<Professor>(){
                        new Professor() {
                            Id = 1,
                            Nome = "Abraham"
                        },
                        new Professor() {
                            Id = 2,
                            Nome = "Marcelo"
                        },
                        new Professor() {
                            Id = 3,
                            Nome = "Rosy"
                        },
                    }
                );

                builder.Entity<Aluno>()
                .HasData(
                    new List<Aluno>(){
                        new Aluno() {
                            Id = 1,
                            Nome = "Gisele",
                            Sobrenome = "Costa",
                            DataNasc = "25/11/1991",
                            ProfessorId = 1
                        },
                        new Aluno() {
                            Id = 2,
                            Nome = "João",
                            Sobrenome = "Pedro",
                            DataNasc = "26/08/1992",
                            ProfessorId = 2
                        },
                        new Aluno() {
                            Id = 3,
                            Nome = "Pedro",
                            Sobrenome = "França",
                            DataNasc = "27/01/1987",
                            ProfessorId = 3
                        },
                    }
                );
        }
    }
}