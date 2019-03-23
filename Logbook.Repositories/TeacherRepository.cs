using Logbook.AppContext;
using Logbook.Entities;
using Logbook.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logbook.Repositories
{
    public class TeacherRepository : DbRepository<Teacher>, ITeacherRepository
    {
        public TeacherRepository(AppDbContext context) : base(context)
        {

        }
    }
}
