using Logbook.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Logbook.Entities
{
    [Table("marks")]
    public class Mark : DbEntity
    {
        [Column("value")]
        [StringLength(64)]
        public string Value { get; set; }

        public Guid StudentId { get; set; }

        public Student Student { get; set; }

        public Guid TeacherSubjectId { get; set; }

        public TeacherSubject TeacherSubject { get; set; }
    }
}
