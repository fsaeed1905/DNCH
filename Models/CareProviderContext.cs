using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DNCH.Models
{
    public class CareProviderContext : DbContext
    {
        public DbSet<NursingCareHome>NursingCareHomes { get; set; }


    }
}