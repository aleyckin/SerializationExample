using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public class DataContextFactory : IDesignTimeDbContextFactory<DataContext>
    {
        /// <summary>
        /// Создает экземпляр контекста базы данных для использования в инструментах миграции и других сценариях, где требуется DbContext.
        /// </summary>
        public DataContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
            optionsBuilder.UseSqlite("Data Source=placeholder.db");

            return new DataContext(optionsBuilder.Options);
        }
    }
}
