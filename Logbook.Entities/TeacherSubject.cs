using Logbook.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logbook.Entities
{
    public class TeacherSubject : DbEntity
    {
        public Guid TeacherId { get; set; }

        public Teacher Teacher { get; set; }

        public Guid SubjectId { get; set; }

        public Subject Subject { get; set; }
    }
}
