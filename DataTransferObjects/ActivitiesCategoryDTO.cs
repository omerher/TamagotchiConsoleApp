using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace TamagotchiConsoleApp.DataTransferObjects
{
    public partial class ActivitiesCategoryDTO
    {
        public ActivitiesCategoryDTO()
        {
            Activities = new HashSet<ActivityDTO>();
        }

        [Key]
        [Column("AcitivtyCategoryID")]
        public int AcitivtyCategoryId { get; set; }
        [Required]
        [StringLength(20)]
        public string CategoryName { get; set; }

        [InverseProperty(nameof(ActivityDTO.ActivityCategory))]
        public virtual ICollection<ActivityDTO> Activities { get; set; }
    }
}
