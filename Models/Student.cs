﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Lab4.Models
{
    public class Student
    {
        public int ID
        {
            get;
            set;
        }
        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName
        {
            get;
            set;
        }
        [Required]
        [Display(Name = "Last Name")]
        public string FirstName
        {
            get;
            set;
        }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate
        {
            get;
            set;
        }
        [Required]
        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return LastName + "," + FirstName;
            }
        }
        public ICollection<CommunityMembership> Memberships
        {
            get;
            set;
        }

    }
}
