using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace NetCore.Services.Data
{
    public class CodeFirstDbContextFactory:IDesignTimeDbContextFactory<CodeFirstDbContext>
    {
        public CodeFirstDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CodeFirstDbContext>();
            optionsBuilder.UseSqlite("");
            return new CodeFirstDbContext(optionsBuilder.Options);
        }
    }
}