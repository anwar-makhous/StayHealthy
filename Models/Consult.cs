using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace StayHealthy.Models
{
    public class Consult
    {
        [Key]
        public int Id { get; set; }

        public string? subject { get; set; }
        
        public string? content { get; set; }
        
        public string? reply { get; set; }

        [ScaffoldColumn(false)]
        public bool answered { get; set; }

        [ScaffoldColumn(false)]
        public string? patientId { get; set; }

        [ScaffoldColumn(false)]
        public DateTime date { get; set; }

        public string? imageName { get; set; }

        [NotMapped]
        public IFormFile? MyProperty { get; set; }

    }
}