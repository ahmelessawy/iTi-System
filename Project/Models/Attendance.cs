﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models
{
    [Table("Attendances")]
    public class Attendance
    {
        public Attendance()
        {
        }

        public Attendance(string Id)
        {
            Date = DateTime.Now;
            StudentId = Id;
        }

        [Key, Column(Order = 0), DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Date { set; get; }

        [Key, Column("St_Id", Order = 1), ForeignKey("Student")]
        public string StudentId { get; set; }

        [Column("Arrival"), Display(Name = "Arrival Time"), DataType(DataType.DateTime), DisplayFormat(DataFormatString = "{0:T}", ApplyFormatInEditMode = true)]
        public DateTime? ArrivalTime { set; get; }

        [Column("Leaving"), Display(Name = "Leaving Time"), DataType(DataType.DateTime), DisplayFormat(DataFormatString = "{0:T}", ApplyFormatInEditMode = true)]
        public DateTime? LeavingTime { set; get; }

        public virtual Student Student { get; set; }
    }

    public class DailyReport
    {
        [Key, Column(Order = 0), ForeignKey("Student")]
        public string StudentId { get; set; }

        [Key, Column(Order = 1), DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        public int Absences { get; set; }
        public int Degrees { get; set; }

        [Column("Arrival"), Display(Name = "Arrival Time"), DataType(DataType.DateTime), DisplayFormat(DataFormatString = "{0:T}", ApplyFormatInEditMode = true)]
        public DateTime? ArrivalTime { set; get; }

        [Column("Leaving"), Display(Name = "Leaving Time"), DataType(DataType.DateTime), DisplayFormat(DataFormatString = "{0:T}", ApplyFormatInEditMode = true)]
        public DateTime? LeavingTime { set; get; }

        public virtual Student Student { get; set; }
    }
}