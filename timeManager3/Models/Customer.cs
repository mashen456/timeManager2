using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace timeManager3.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public Company Company { get; set; }
        public int CompanyId { get; set; }

        public CustomerType CustomerType { get; set; }
        public byte CustomerTypeId { get; set; }
    }
}