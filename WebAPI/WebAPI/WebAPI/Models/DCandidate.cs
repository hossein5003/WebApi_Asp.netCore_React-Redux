﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    public class DCandidate
    {
        [Key]
        public int id { get; set; }

        [Column(TypeName=("nvarchar(50)"))]
        public string fullName { get; set; }

        [Column(TypeName = ("nvarchar(50)"))]
        public string mobile { get; set; }

        [Column(TypeName = ("nvarchar(50)"))]
        public string email { get; set; }

        public int age { get; set; }

        [Column(TypeName = ("nvarchar(3)"))]
        public string bloodGroup { get; set; }

        [Column(TypeName = ("nvarchar(50)"))]
        public string address { get; set; }
    }
}
