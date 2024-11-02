using System.Data.Entity;
using TodoApplicationNetFramework.Models.Entidades;

namespace TodoApplicationNetFramework.DbContext.Contexts
{
    public class TodoContext : System.Data.Entity.DbContext

    {
        public TodoContext() : base("name=ConexaoBD"){}
        public DbSet<Time> Times  { get; set; }
    }
}