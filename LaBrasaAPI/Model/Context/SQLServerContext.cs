using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaBrasaAPI.Model.Context
{
    public class SQLServerContext : DbContext
    {
        public SQLServerContext()
        {
        }
        public SQLServerContext(DbContextOptions<SQLServerContext> options) : base(options)
        {

        }
        public DbSet<Comanda> Comandas { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Mesa> Mesas { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
    }
}