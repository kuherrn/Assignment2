using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Week5.Data
{
    public class AppContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] arg)
        {
            var optBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optBuilder.UseSqlServer("Server=tcp:comp2018inclass.database.windows.net,1433;Initial Catalog=COMP2084-DB-In-Class;Persist Security Info=False;User ID=KNagayaindran;Password=Mid$hipman180051;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            return new ApplicationDbContext(optBuilder.Options);
        }
    }
}