using ExoAPI.Domains;
using Microsoft.EntityFrameworkCore;

namespace ExoAPI.Contexts
{
    public class ExoApiContext : DbContext
    {
        public ExoApiContext()
        {
        }
        public ExoApiContext(DbContextOptions<ExoApiContext> options) : base(options)
        { 
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Cada provedor tem sua sintaxe para especificação
                optionsBuilder.UseSqlServer("Data Source = DESKTOP-FSU9PC5\\SQLEXPRESS; initial catalog = ExoApi; Integrated Security = True; TrustServerCertificate=True");
            }
        }
        //dbset representa as entidades que serão utilizadas nas operações de leitura, criação, atualização e deleção
        public DbSet<Projeto> Projetos { get; set; }


    }
}
