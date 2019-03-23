using Logbook.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LogBook.ViewModels
{
    public class StudentModel
    {

        public Guid Id { get; set; }

        [Required(ErrorMessage = "Enter First Name!")]
        [Display(Name = "First Name:")]
        [DataType(DataType.Text)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Enter Last Name!")]
        [Display(Name = "Last Name:")]
        [DataType(DataType.Text)]
        [StringLength(64)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Select a group!")]
        [Display(Name = "Select a group:")]
        public Guid GroupId { get; set; }

        public List<Group> Groups { get; set; }
        public virtual Group Group { get; set; }

        public SelectList GetSelectList()
        {
            return new SelectList(Groups, "Id", "Name");
        }
    }

  
}
