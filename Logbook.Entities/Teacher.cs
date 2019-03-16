using Logbook.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Logbook.Entities
{
    [Table("teachers")]
    public class Teacher : DbEntity
    {
        
        [Column("firstName")]
        [StringLength(64)]
        public string FirstName { get; set; }

        [Column("lastName")]
        [StringLength(64)]
        public string LastName { get; set; }

        public List<AcademicSubject> AcademicSubjects { get; set; }

        public Guid DepartmentId { get; set; }

        public Department Department { get; set; }

    }
}
