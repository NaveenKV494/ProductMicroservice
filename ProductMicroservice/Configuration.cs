using Microsoft.EntityFrameworkCore.Infrastructure;

namespace ProductMicroservice
{
    internal class Configuration
    {
        internal static Action<SqlServerDbContextOptionsBuilder>? GetConnectionString(string v)
        {
            throw new NotImplementedException();
        }
    }
}