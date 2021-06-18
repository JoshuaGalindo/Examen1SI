using System;
using System.Collections.Generic;
using System.Text;
using Examen1SI.Models.Citasmedicas;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Examen1SI.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Cita_Medica> Citas { get; set; }
    }
}
