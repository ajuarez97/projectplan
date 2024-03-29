﻿using System;
using System.ComponentModel.DataAnnotations;
using ProjectPlan.Core.Enums;

namespace ProjectPlan.Models
{
    public class Project
    {
        public int Id { get; set; }
        
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public DateTime AssignedDate { get; set; }

        public int TimeToStart { get; set; }

        public int Credits { get; set; }

        public StatusEnum IsActive { get; set; }
    }
}