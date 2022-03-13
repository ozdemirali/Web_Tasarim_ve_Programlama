using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentFollow.Models
{
    public class Student
    {
        [Key]
        [StringLength(11)]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool Gender { get; set; }
        public string ImagePath { get; set; }

        public byte ClassroomId { get; set; }
        public Classroom Classroom { get; set; }

    }
}