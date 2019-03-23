using Microsoft.EntityFrameworkCore;
using Logbook.Abstractions;
using Logbook.AppContext;
using Logbook.Entities;
using LogBook.ViewModels;
using System.Threading.Tasks;

namespace Logbook.Repositories
{
    public class StudentRepository : DbRepository<Student>, IStudentRepository
    {
        public StudentRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<StudentModel> CreateStudent(IGroupRepository groupRepository)
        {
            var groups = await groupRepository.ToListAsync();
            StudentModel model = new StudentModel { Groups = groups };
            return model;
        }
    }
}
