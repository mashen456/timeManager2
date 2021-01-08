using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace timeManager3.Models
{
    public class employee
    {
        public int Id { get; set; }
        public Company Company { get; set; }
        public int CompanyId { get; set; }

        public string employeId { get; set; }

        [NotMapped]
        [Display(Name = "Invite Key")]
        public Guid invKey { get; set; }
    }
}