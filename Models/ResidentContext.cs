using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DNCH.Models
{
    public class ResidentContext :DbContext
    {
        public DbSet<Resident> Residents { get; set; }
    }
}