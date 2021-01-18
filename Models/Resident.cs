using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DNCH.Models
{
    public class Resident
    {
        public int Id { get; set; }
        public string First_Name { get; set; }

        public string Last_Name { get; set; }
        public string MiddleName { get; set; }

        public int DOB { get; set; }
        public DateTime JoiningDate { get; set; }
        public DateTime LeavingDate { get; set; }
        public string Resident_Address { get; set; }


    }
}