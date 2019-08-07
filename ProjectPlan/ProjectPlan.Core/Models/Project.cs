﻿using System;

namespace ProjectPlan.Models
{
    public class Project
    {
        public int Id { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public DateTime AssignedDate { get; set; }

        public TimeSpan TimeToStart { get; set; }

        public int Credits { get; set; }

        public bool IsActive { get; set; }
    }
}