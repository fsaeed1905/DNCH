using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DNCH.Models
{
    public class DailyLogContext :DbContext
    {

        public DbSet<ResidentDailyLog> ResidentDailyLogs { get; set; }
    }
}