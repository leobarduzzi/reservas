using System;
using System.Collections.Generic;
using System.Text;
using reservas.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace reservas.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Anuncio> Anuncio { get; set; }
        public DbSet<Disponibilidade> Disponibilidade  { get; set; }
        public DbSet<FormaPagamento> FormaPagamento  { get; set; }
        public DbSet<ValorAnuncio> ValorAnuncio  { get; set; }
    }
}