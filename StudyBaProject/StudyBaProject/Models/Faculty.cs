﻿using System.ComponentModel.DataAnnotations;

namespace StudyBa.Models
{
    public class Faculty
    {
        [Key]
        public int FacultyId { get; set; }
        public string FacultyName { get; set; }

    }
}
