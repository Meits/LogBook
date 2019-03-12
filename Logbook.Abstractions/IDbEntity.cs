using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Logbook.Abstractions
{
    public interface IDbEntity
    {
        [Key]
        Guid Id { get; set; }
    }
}
