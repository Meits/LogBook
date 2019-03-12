using Logbook.Abstractions;
using Logbook.Entities;

namespace MyLogbook.Repositories
{
    public interface IStudentRepository:IDbRepository<Student>
    {
    }
}
