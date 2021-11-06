using FIAP.Global_ImpactWeb.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FIAP.Global_ImpactWeb.Persistencia
{
    public class SolutionContext : DbContext
    {
        public DbSet<UserONG> Users { get; set; }

        public DbSet<ContaBancaria> Contas { get; set; }

        public DbSet<Endereco> Enderecos { get; set; }

        public SolutionContext(DbContextOptions op): base(op) { }
    }
}
