using Logbook.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Logbook.Entities
{
    
    [Table("academic_subjects")]
    public class AcademicSubject : DbEntity
    {
        [Column("title")]
        [StringLength(64)]
        public string Title { get; set; }

        [ForeignKey("teacherId")]
        public Guid TeacherId { get; set; }

        public Teacher Teacher { get; set; }

    }
}
