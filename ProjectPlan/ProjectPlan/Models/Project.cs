using System;

namespace ProjectPlan.Models
{
    public class Project
    {
        public int UserId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int Credits { get; set; }
    }
}