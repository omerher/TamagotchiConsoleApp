﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace TamagotchiConsoleApp.DataTransferObjects
{
    [Table("Activity")]
    public partial class ActivityDTO
    {
        public ActivityDTO()
        {
            
        }

        [Key]
        [Column("ActivityID")]
        public int ActivityId { get; set; }
        [Column("ActivityCategoryID")]
        public int? ActivityCategoryId { get; set; }
        [Required]
        [StringLength(30)]
        public string ActivityName { get; set; }
        public int ImprovementRate { get; set; }

    }
}
