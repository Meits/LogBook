using Microsoft.EntityFrameworkCore;
using Logbook.Abstractions;
using Logbook.AppContext;
using Logbook.Entities;


namespace MyLogbook.Repositories
{
    public class GroupRepository : DbRepository<Group>, IGroupRepository
    {
        public GroupRepository(AppDbContext context) : base(context)
        {
        }
    }
}
