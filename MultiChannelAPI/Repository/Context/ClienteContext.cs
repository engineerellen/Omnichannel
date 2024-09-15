using Microsoft.EntityFrameworkCore;
using MultiChannelAPI.Model;

namespace MultiChannelAPI.Repository.Context;

internal class ClienteContext : DbContext
{
    public DbSet<Cliente> Clientes { get; set; }

    public ClienteContext(DbContextOptions<ClienteContext> options) : base(options) { }
}