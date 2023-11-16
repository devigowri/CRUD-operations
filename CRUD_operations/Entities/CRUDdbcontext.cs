using Microsoft.EntityFrameworkCore;
using CRUD_operations.Models;

namespace CRUD_operations.Entities

{
    public class CRUDdbcontext :DbContext
    {
        public CRUDdbcontext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Employees>Employees { get; set; }
       
    }
}
