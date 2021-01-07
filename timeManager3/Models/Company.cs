using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace timeManager3.Models
{
    public class Company
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [Required]
        [StringLength(255)]
        public string Address { get; set; }
        [Required]
        [StringLength(255)]
        public string Zip { get; set; }
        [Required]
        [StringLength(255)]
        public string Country { get; set; }

        public string OwnerId { get; set; }


    }
}