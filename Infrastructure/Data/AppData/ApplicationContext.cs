using Microsoft.EntityFrameworkCore;
using GS_PowerScore.Domain.Entities;

namespace GS_PowerScore.Infrastructure.Data.AppData
{
    public class ApplicationContext(DbContextOptions<ApplicationContext> options) : DbContext(options)
    {
        public DbSet<BeneficiarioEntity> Beneficiarios { get; set; }
    }
}
