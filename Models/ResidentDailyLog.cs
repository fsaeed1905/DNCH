using System;

namespace DNCH.Models
{
    public class ResidentDailyLog
    {
        public int Id { get; set; }
        public string FullName { get; set; }

        public DateTimeKind NotesTime { get; set; }

        public string DailNotes { get; set; }

        public string StaffName { get; set; }

    }
}