using Logbook.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Logbook.Entities
{
    [Table("departments")]
    public class Department : DbEntity
    {
        [Column("name")]
        [StringLength(64)]
        public string Title { get; set; }

        public virtual List<Teacher> Teachers { get; set; }
    }
}
