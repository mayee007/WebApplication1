using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace WebApplication1.DAL
{
    public static class SeedData 
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            /* using (var context = new BookContext(
                serviceProvider.GetRequiredService<options =>
                options.UseSqlServer(Configuration.GetConnectionString("BookDatabase")));
            {
                // Look for any movies.
                if (context.Names.Any())
                {
                    return;   // DB has been seeded
                }

            } */
        }
    } // end of class 
}
