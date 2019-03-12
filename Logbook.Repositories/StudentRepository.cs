using Microsoft.EntityFrameworkCore;
using Logbook.Abstractions;
using Logbook.AppContext;
using Logbook.Entities;


namespace Logbook.Repositories
{
    public class StudentRepository : DbRepository<Student>, IStudentRepository
    {
        public StudentRepository(AppDbContext context) : base(context)
        {
        }
    }
}
