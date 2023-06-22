using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using projeto_gamer.Models;

namespace projeto_gamer.Infra
{
    public class Context : DbContext
    {
        public Context()
        {
            
        }

        public Context(DbContextOptions<Context> options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //string de conexão com o banco
                optionsBuilder.UseSqlServer("Data Source = DESKTOP-2B634JF; Initial catalog = gamerManha; user id = sa; password = Senai@134; TrustServerCertificate = true"); //Data Source (gerenciador do banco, nome do cervidor) initial catalog (nome do banco de dados)
            }
        }

        //referencia de classes e tabelas
        public DbSet<Equipe> Equipe { get; set; }     
        public DbSet<Jogador> Jogador { get; set; }     
    }
}