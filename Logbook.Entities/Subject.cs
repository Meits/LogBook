using Logbook.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Logbook.Entities
{
    [Table("subjects")]
    public class Subject : DbEntity
    {
        [Column("name")]
        [StringLength(64)]
        public string Title { get; set; }
    }
}
