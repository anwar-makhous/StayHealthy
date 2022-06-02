using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StayHealthy.Models
{
    public class Article
    {
        public int Id { get; set; }
        [Display(Name ="Title")]
        public string? title { get; set; }
        [Display(Name ="Content")]
        public string? content { get; set; }
        public DateTime date { get; set; }
        public int viewsCount { get; set; }
        public string? imageName { get; set; }
        [NotMapped]
        [Display(Name ="Upload Image")]
        public IFormFile? imageFile { get; set; }
    }
}