using Logbook.Abstractions;
using Logbook.Entities;
using LogBook.ViewModels;
using System.Threading.Tasks;

namespace Logbook.Repositories
{
    public interface IStudentRepository:IDbRepository<Student>
    {
        Task<StudentModel> CreateStudent(IGroupRepository groupRepository);

    }
}
