using Microsoft.EntityFrameworkCore;

namespace UserService.Domain
{
    public class ApplicationDbContext: DbContext
    {

       public ApplicationDbContext(DbContextOptions options)
       :base(options)
       {
           
       }



    }
}