using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace UsingPagedList.Models
{
    public class PaginationContext:DbContext
    {
        public PaginationContext()
            : base("conexao")
        {
            
        }

        public DbSet<Fornecedor> Fornecedores { get; set; }
    }
}