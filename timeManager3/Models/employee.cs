using System;
using System.Collections.Generic;
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
    }
}