using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace timeManager3.Models
{
    public class CustomerType
    {

        public byte Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public byte Type { get; set; }


    }
}