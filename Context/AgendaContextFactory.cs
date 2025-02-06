using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace CRUD_API.Context
{
    public class AgendaContextFactory : IDesignTimeDbContextFactory<AgendaContext>
    {
        public AgendaContext CreateDbContext(string[] args)
        {
            // Obtém as configurações do appsettings.json
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            // Configura a conexão com o banco de dados
            var optionsBuilder = new DbContextOptionsBuilder<AgendaContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            optionsBuilder.UseSqlServer(connectionString); // Altere para o seu provedor, se necessário

            return new AgendaContext(optionsBuilder.Options);
        }
    }
}

