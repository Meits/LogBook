using Logbook.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Logbook.Entities
{
    [Table("ratings")]
    public class Rating : DbEntity
    {
        [Column("rating")]
        public string Assessment { get; set; }

        [Column("created_at")]
        [DataType(DataType.Date)]
        public string CreatedAt { get; set; }

        [ForeignKey("AcademicSubjectId")]
        public Guid AcademicSubjectId { get; set; }

        public AcademicSubject AcademicSubject { get; set; }
    }
}
