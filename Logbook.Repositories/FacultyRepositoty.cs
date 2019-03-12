using Microsoft.EntityFrameworkCore;
using Logbook.Abstractions;
using Logbook.AppContext;
using Logbook.Entities;


namespace Logbook.Repositories
{
    public class FacultyRepositoty : DbRepository<Faculty>, IFacultyRepository
    {
        public FacultyRepositoty(AppDbContext context) : base(context)
        {
        }
    }
}
