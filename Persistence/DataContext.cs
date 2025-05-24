using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        /// <summary>
        /// Представляет коллекцию пациентов в базе данных.
        /// </summary>
        public DbSet<Patient> Patients { get; set; }

        /// <summary>
        /// Конструктор для инициализации контекста базы данных с заданными параметрами.
        /// </summary>
        public DataContext(DbContextOptions options) : base(options) { } 
    }
}
