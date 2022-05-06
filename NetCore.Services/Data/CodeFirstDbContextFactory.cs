using Microsoft.EntityFrameworkCore.Design;

namespace NetCore.Services.Data
{
    public class CodeFirstDbContextFactory:IDesignTimeDbContextFactory<CodeFirstDbContext>
    {
        public CodeFirstDbContext CreateDbContext(string[] args)
        {
            throw new System.NotImplementedException();
        }
    }
}