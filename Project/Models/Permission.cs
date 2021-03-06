﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models
{
    [Table("Permissions")]
    public class Permission
    {
        [Index, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Key, Column("St_Id", Order = 1), ForeignKey("Student")]
        public string StudentId { get; set; }

        [Required, ForeignKey("Instructor")]
        public string InstructorId { get; set; }

        [Key, Column("Start_Date", Order = 2), Display(Name = "Start Date"), DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }

        [Column("End_Date"), Display(Name = "End Date"), DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime EndDate { get; set; }

        [StringLength(250), DataType(DataType.MultilineText)]
        public string Reason { get; set; }

        public virtual Student Student { get; set; }
        public virtual Instructor Instructor { get; set; }
    }
}